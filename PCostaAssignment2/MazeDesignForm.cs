/*
 * PROG2370 - Assignment 2
 * Programmer: Patricia Canuto Vieira da Costa
 * Revision History:
 *      2020-10-31: UI designed, code written, debbuged
 *      2020-11-02: UI updates, code written, debbuged
 *      2020-11-03: code written, Bug fixing
 *      2020-11-04: code written, code "cleaning", Documentation comments added
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCostaAssignment2
{

    /// <summary>
    /// The class responsible for making the Maze Design user interface.
    /// </summary>
    public partial class MazeDesignForm : Form
    {
        PictureTypeEnum chosenPictureType;

        private const int SQUARE_SIDE_SIZE = 60;
        private const int SELECTED_SQUARE_SIDE_SIZE = 57;
        private const int INITIAL_POSITION = 50;

        int numberOfRows;
        int numberOfColumns;

        public MazeDesignForm()
        {
            InitializeComponent();
        }

        private void MazeDesignForm_Load(object sender, EventArgs e)
        {
            pnlToolBox.Enabled = false;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int xLocation = INITIAL_POSITION;
            int yLocation = INITIAL_POSITION;

            try
            {
                numberOfRows = Convert.ToInt32(txtRows.Text);
                numberOfColumns = Convert.ToInt32(txtColumns.Text);

                if (numberOfRows <= 0 || numberOfColumns <= 0)
                {
                    throw new Exception("Non positive input.");
                }

                GenerateMaze(xLocation, yLocation, numberOfRows, numberOfColumns);                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error occurred: " + ex.Message + "\n\nPlease inform a valid number of rows and columns before generating the maze.", "QGame");

            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "";

            if (!IsMazeValid())
            {
                MessageBox.Show("For every colored box there must be a matching colored door.", "QGame");
                return;
            }
            try
            {
                SaveMazeInfo();
            }

            catch (FileNotFoundException ex)
            {
                message += message + "FileNotFoundException: " + ex.Message + Environment.NewLine;
                MessageBox.Show(message, "QGame");
            }
            catch (DirectoryNotFoundException ex)
            {
                message += message + "DirectoryNotFoundException: " + ex.Message + Environment.NewLine;
                MessageBox.Show(message, "QGame");
            }
            catch (IOException ex)
            {
                message += message + "IOException: " + ex.Message + Environment.NewLine;
                MessageBox.Show(message, "QGame");
            }
            catch (Exception ex)
            {
                message += message + "Unexpected Exception: " + ex.Message + Environment.NewLine;
                MessageBox.Show(message, "QGame");
            }

        }

        
        private void PictureBox_Click(object sender, EventArgs e)
        {
            PCPictureBox pictureClicked = sender as PCPictureBox;
            pictureClicked.SetImage(chosenPictureType);
        }

        private void pbxNone_Click(object sender, EventArgs e)
        {
            chosenPictureType = PictureTypeEnum.None;
            UnselectAllTools();
            PCPictureBox.SelectTool(pbxNone, SELECTED_SQUARE_SIDE_SIZE);
        }

        private void pbxWall_Click(object sender, EventArgs e)
        {
            chosenPictureType = PictureTypeEnum.Wall;
            UnselectAllTools();
            PCPictureBox.SelectTool(pbxWall, SELECTED_SQUARE_SIDE_SIZE);
        }

        private void pbxRedDoor_Click(object sender, EventArgs e)
        {
            chosenPictureType = PictureTypeEnum.RedDoor;
            UnselectAllTools();
            PCPictureBox.SelectTool(pbxRedDoor, SELECTED_SQUARE_SIDE_SIZE);
        }

        private void pbxGreenDoor_Click(object sender, EventArgs e)
        {
            chosenPictureType = PictureTypeEnum.GreenDoor;
            UnselectAllTools();
            PCPictureBox.SelectTool(pbxGreenDoor, SELECTED_SQUARE_SIDE_SIZE);
        }

        private void pbxRedBox_Click(object sender, EventArgs e)
        {
            chosenPictureType = PictureTypeEnum.RedBox;
            UnselectAllTools();
            PCPictureBox.SelectTool(pbxRedBox, SELECTED_SQUARE_SIDE_SIZE);
        }

        private void pbxGreenBox_Click(object sender, EventArgs e)
        {
            chosenPictureType = PictureTypeEnum.GreenBox;
            UnselectAllTools();
            PCPictureBox.SelectTool(pbxGreenBox, SELECTED_SQUARE_SIDE_SIZE);
            
        }

        /// <summary>
        /// Reverts all PictureBox selections by re-setting border and size to the default settings.
        /// </summary>
        private void UnselectAllTools()
        {
            var pictureBoxes = pnlToolBox.Controls.OfType<Panel>().SelectMany(p => p.Controls.OfType<PictureBox>());
            foreach (var pictureBox in pictureBoxes)
            {
                pictureBox.BorderStyle = BorderStyle.FixedSingle;
                pictureBox.Size = new Size(SQUARE_SIDE_SIZE, SQUARE_SIDE_SIZE);
            }
        }

        /// <summary>
        /// Generates the maze.
        /// </summary>
        /// <param name="xPosition">The distance from the left border of the panel.</param>
        /// <param name="yPosition">The distance from the upper border of the panel.</param>
        /// <param name="numberOfRows">The number of rows to be generated.</param>
        /// <param name="numberOfColumns">The number of columns to be generated.</param>
        private void GenerateMaze(int xPosition, int yPosition, int numberOfRows, int numberOfColumns)
        {
            pnlMaze.Controls.Clear();

            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    PCPictureBox pictureBox = new PCPictureBox
                    {
                        Size = new Size(SQUARE_SIDE_SIZE, SQUARE_SIDE_SIZE),
                        Location = new Point(xPosition, yPosition),
                        Image = Properties.Resources.None,
                        BorderStyle = BorderStyle.FixedSingle,
                        Name = "pictureBox" + i.ToString() + j.ToString(),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Cursor = Cursors.Hand,
                        PictureType = PictureTypeEnum.None,
                        PictureRow = i,
                        PictureColumn = j
                    };

                    pictureBox.Click += new EventHandler(PictureBox_Click);

                    pnlMaze.Controls.Add(pictureBox);

                    xPosition += SQUARE_SIDE_SIZE;
                }

                yPosition += SQUARE_SIDE_SIZE;
                xPosition = INITIAL_POSITION;
            }

            pnlToolBox.Enabled = true;

        }

        /// <summary>
        /// Saves the Maze's information (number of rows, number of columns, and, for each cell, row number, column number, and content) to a file.
        /// </summary>
        private void SaveMazeInfo()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                InitialDirectory = @"C:\",
                RestoreDirectory = true,
                FileName = "savegame1.qgame"

            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream fileStream = saveFileDialog.OpenFile();
                StreamWriter writer = new StreamWriter(fileStream);

                writer.WriteLine(numberOfRows);
                writer.WriteLine(numberOfColumns);

                foreach (var pictureBox in pnlMaze.Controls.OfType<PCPictureBox>())
                {
                    writer.WriteLine(pictureBox.PictureRow);
                    writer.WriteLine(pictureBox.PictureColumn);
                    writer.WriteLine(Convert.ToInt32(pictureBox.PictureType));

                }

                writer.Close();
                fileStream.Close();
                CountTools();

            }

        }

        /// <summary>
        /// Checks if the Maze is valid (follows the game's rules)
        /// </summary>
        /// <returns>True if the Maze if valid, false ortherwise.</returns>
        private bool IsMazeValid()
        {
            int greenDoorCount = pnlMaze.Controls.OfType<PCPictureBox>().Count(p => p.PictureType == PictureTypeEnum.GreenDoor);
            int greenBoxCount = pnlMaze.Controls.OfType<PCPictureBox>().Count(p => p.PictureType == PictureTypeEnum.GreenBox);
            int redDoorCount = pnlMaze.Controls.OfType<PCPictureBox>().Count(p => p.PictureType == PictureTypeEnum.RedDoor);
            int redBoxCount = pnlMaze.Controls.OfType<PCPictureBox>().Count(p => p.PictureType == PictureTypeEnum.RedBox);

            if (greenBoxCount > 0 && greenDoorCount <= 0)
            {
                return false;
            }
            if (redBoxCount > 0 && redDoorCount <= 0)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Counts the number of tools (number of doors, wall, and boxes) used to create the maze.
        /// </summary>
        private void CountTools()
        {
            int wallTotal = pnlMaze.Controls.OfType<PCPictureBox>().Count(p => p.PictureType == PictureTypeEnum.Wall);
            int doorsTotal = pnlMaze.Controls.OfType<PCPictureBox>().Count(p => p.PictureType == PictureTypeEnum.GreenDoor || p.PictureType == PictureTypeEnum.RedDoor);
            int boxesTotal = pnlMaze.Controls.OfType<PCPictureBox>().Count(p => p.PictureType == PictureTypeEnum.GreenBox || p.PictureType == PictureTypeEnum.RedBox);            

            MessageBox.Show("File saved successfully: " +
                "\n Total number of walls: " + wallTotal +
                "\n Total number of doors: " + doorsTotal +
                "\n Total number of boxes: " + boxesTotal, "QGame");
        }


    }
}
