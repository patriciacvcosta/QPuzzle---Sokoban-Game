/*
 * Assignment 1
 * Programmer: Patricia Canuto Vieira da Costa
 * Revision History:
 *      2020-09-28: UI designed, code written, debbuged
 *      2020-09-29: Bug fixing, comments added, ajustments to meet standards
 *      2020-09-30: Documentation comments added

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
    public partial class MazeDesignForm : Form
    {
        PictureTypeEnum chosenPictureType;

        private const int SQUARE_SIDE_SIZE = 60;
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

        private void GenerateMaze(int xLocation, int yLocation, int numberOfRows, int numberOfColumns)
        {
            pnlMaze.Controls.Clear();

            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    PCPictureBox pictureBox = new PCPictureBox
                    {
                        Size = new Size(SQUARE_SIDE_SIZE, SQUARE_SIDE_SIZE),
                        Location = new Point(xLocation, yLocation),
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

                    xLocation += SQUARE_SIDE_SIZE;

                }

                yLocation += SQUARE_SIDE_SIZE;
                xLocation = INITIAL_POSITION;
            }

            pnlToolBox.Enabled = true;

        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PCPictureBox pictureClicked = sender as PCPictureBox;
            pictureClicked.SetImage(chosenPictureType);

        }

        private void pbxNone_Click(object sender, EventArgs e)
        {
            chosenPictureType = PictureTypeEnum.None;
        }

        private void pbxWall_Click(object sender, EventArgs e)
        {
            chosenPictureType = PictureTypeEnum.Wall;
        }

        private void pbxRedDoor_Click(object sender, EventArgs e)
        {
            chosenPictureType = PictureTypeEnum.RedDoor;
        }

        private void pbxGreenDoor_Click(object sender, EventArgs e)
        {
            chosenPictureType = PictureTypeEnum.GreenDoor;
        }

        private void pbxRedBox_Click(object sender, EventArgs e)
        {
            chosenPictureType = PictureTypeEnum.RedBox;
        }

        private void pbxGreenBox_Click(object sender, EventArgs e)
        {
            chosenPictureType = PictureTypeEnum.GreenBox;
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

        private void CountTools()
        {
            int wallTotal = 0;
            int doorsTotal = 0;
            int boxesTotal = 0;

            foreach (var pictureBox in pnlMaze.Controls.OfType<PCPictureBox>())
            {
                if (pictureBox.PictureType == PictureTypeEnum.Wall)
                {
                    wallTotal++;
                }
                if (pictureBox.PictureType == PictureTypeEnum.GreenDoor || pictureBox.PictureType == PictureTypeEnum.RedDoor)
                {
                    doorsTotal++;
                }
                if (pictureBox.PictureType == PictureTypeEnum.GreenBox || pictureBox.PictureType == PictureTypeEnum.RedBox)
                {
                    boxesTotal++;
                }
            }

            MessageBox.Show("File saved successfully: " +
                "\n Total number of walls: " + wallTotal +
                "\n Total number of doors: " + doorsTotal +
                "\n Total number of boxes: " + boxesTotal, "QGame");
        }

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

        private void pbxNone_MouseEnter(object sender, EventArgs e)
        {
            pbxNone.Size = new Size(57, 57);
        }

        private void pbxNone_MouseLeave(object sender, EventArgs e)
        {
            pbxNone.Size = new Size(60, 60);
        }

        private void pbxWall_MouseEnter(object sender, EventArgs e)
        {
            pbxWall.Size = new Size(57, 57);
        }

        private void pbxWall_MouseLeave(object sender, EventArgs e)
        {
            pbxWall.Size = new Size(60, 60);
        }

        private void pbxRedDoor_MouseEnter(object sender, EventArgs e)
        {
            pbxRedDoor.Size = new Size(57, 57);
        }

        private void pbxRedDoor_MouseLeave(object sender, EventArgs e)
        {
            pbxRedDoor.Size = new Size(60, 60);
        }

        private void pbxGreenDoor_MouseEnter(object sender, EventArgs e)
        {
            pbxGreenDoor.Size = new Size(57, 57);
        }

        private void pbxGreenDoor_MouseLeave(object sender, EventArgs e)
        {
            pbxGreenDoor.Size = new Size(60, 60);
        }

        private void pbxRedBox_MouseEnter(object sender, EventArgs e)
        {
            pbxRedBox.Size = new Size(57, 57);
        }

        private void pbxRedBox_MouseLeave(object sender, EventArgs e)
        {
            pbxRedBox.Size = new Size(60, 60);
        }

        private void pbxGreenBox_MouseEnter(object sender, EventArgs e)
        {
            pbxGreenBox.Size = new Size(57, 57);
        }

        private void pbxGreenBox_MouseLeave(object sender, EventArgs e)
        {
            pbxGreenBox.Size = new Size(60, 60);
        }

    }
}
