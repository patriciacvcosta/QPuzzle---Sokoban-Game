/*
 * PROG2370 - Assignment 3
 * Programmer: Patricia Canuto Vieira da Costa
 * Revision History:
 *      2020-12-02: UI designed, code written, debbuged
 *      2020-12-02: UI updates, code written, debbuged
 *      2020-12-03: code written, Bug fixing
 *      2020-12-04: code written, code "cleaning", Documentation comments added
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCostaAssignment2
{
    /// <summary>
    /// The class responsible for making the Game Play user interface.
    /// </summary>
    public partial class GamePlayForm : Form
    {

        private const int SQUARE_SIDE_SIZE = 60;
        private const int INITIAL_POSITION = 50;
        private const int INCREMENT_POSITION = 1;
        private const int DECREMENT_POSITION = -1;

        bool isHorizontalMovement;
        private StreamReader reader;
        PCPictureBox selectedPicture;
        PCPictureBox[,] tiles;

        int numOfRows;
        int numOfCols;

        int movesCount = 0;


        public GamePlayForm()
        {
            InitializeComponent();
        }

        private void GamePlayForm_Load(object sender, EventArgs e)
        {
            txtNumberOfMoves.Enabled = false;
            txtRemainingBoxes.Enabled = false;

            ResetCounters();
            EnableButtons(false);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog openFile = new OpenFileDialog
                {
                    InitialDirectory = @"C:\",
                    Multiselect = false,
                    Title = "Open"

                };

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    string path = Path.GetFullPath(openFile.FileName);
                    using (reader = new StreamReader(path))
                    {
                        numOfRows = Convert.ToInt32(reader.ReadLine());
                        numOfCols = Convert.ToInt32(reader.ReadLine());
                        int row;
                        int col;
                        int tileType;

                        tiles = new PCPictureBox[numOfRows, numOfCols];

                        while (!reader.EndOfStream)
                        {
                            row = Convert.ToInt32(reader.ReadLine());
                            col = Convert.ToInt32(reader.ReadLine());
                            tileType = Convert.ToInt32(reader.ReadLine());

                            tiles[row, col] = LoadPictureBox(row, col, (PictureTypeEnum)tileType);

                        }

                        pnlMaze.Controls.Clear();
                        GenerateMaze(tiles);
                        ResetCounters();
                        EnableButtons(true);
                        CountBoxes(tiles);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Sorry, some error occured:\n" + ex.Message);
            }

        }
        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (IsPictureSelected())
            {
                isHorizontalMovement = true;
                CountMoves(ref movesCount);
                MoveBox(DECREMENT_POSITION);
            }

        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (IsPictureSelected())
            {
                isHorizontalMovement = true;
                CountMoves(ref movesCount);
                MoveBox(INCREMENT_POSITION);
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (IsPictureSelected())
            {
                isHorizontalMovement = false;
                CountMoves(ref movesCount);
                MoveBox(DECREMENT_POSITION);
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (IsPictureSelected())
            {
                isHorizontalMovement = false;
                CountMoves(ref movesCount);
                MoveBox(INCREMENT_POSITION);
            }

        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            PCPictureBox pictureClicked = sender as PCPictureBox;

            if (pictureClicked.PictureType == PictureTypeEnum.GreenBox || pictureClicked.PictureType == PictureTypeEnum.RedBox)
            {
                if (selectedPicture != null)
                {
                    PCPictureBox.UnselectTool(selectedPicture, SQUARE_SIDE_SIZE);
                }

                selectedPicture = pictureClicked;
                selectedPicture.Left = INITIAL_POSITION + SQUARE_SIDE_SIZE * selectedPicture.PictureColumn;
                selectedPicture.Top = INITIAL_POSITION + SQUARE_SIDE_SIZE * selectedPicture.PictureRow;

                PCPictureBox.SelectTool(selectedPicture, SQUARE_SIDE_SIZE);

            }
        }
        /// <summary>
        /// Checks if a picture is selected in the maze.
        /// </summary>
        /// <returns>True if a picture is selected, false otherwise.</returns>
        private bool IsPictureSelected()
        {
            if (selectedPicture == null)
            {
                MessageBox.Show("You need to select a Box.", "QGame");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Generates the maze
        /// </summary>
        /// <param name="tiles">The array of pictures that will be iterated through to generate the maze</param>
        private void GenerateMaze(PCPictureBox[,] tiles)
        {

            for (int i = 0; i < numOfRows; i++)
            {
                for (int j = 0; j < numOfCols; j++)
                {
                    if (tiles[i, j] != null)
                    {
                        tiles[i, j].Location = new Point(INITIAL_POSITION + j * SQUARE_SIDE_SIZE, INITIAL_POSITION + i * SQUARE_SIDE_SIZE);
                        pnlMaze.Controls.Add(tiles[i, j]);
                    }

                }
            }
        }

        /// <summary>
        /// Loads a PCPictureBox type object 
        /// </summary>
        /// <param name="row">The maze row that the PCPictureBox will be created at.</param>
        /// <param name="col">The maze column that the PCPictureBox will be created at.</param>
        /// <param name="tileType">The enum that specifies the image.</param>
        /// <returns>Null if the tileType is of type "none", or the loaded PCPictureBox otherwise.</returns>
        private PCPictureBox LoadPictureBox(int row, int col, PictureTypeEnum tileType)
        {
            if (tileType == PictureTypeEnum.None)
            {
                return null;
            }

            PCPictureBox pictureBox = new PCPictureBox
            {
                Size = new Size(SQUARE_SIDE_SIZE, SQUARE_SIDE_SIZE),
                BorderStyle = BorderStyle.FixedSingle,
                SizeMode = PictureBoxSizeMode.StretchImage,
                PictureRow = row,
                PictureColumn = col
            };

            pictureBox.Click += new EventHandler(PictureBox_Click);

            pictureBox.SetImage(tileType);

            if (tileType == PictureTypeEnum.GreenBox || tileType == PictureTypeEnum.RedBox)
            {
                pictureBox.Cursor = Cursors.Hand;
            }

            return pictureBox;
        }

        /// <summary>
        /// Gets the tile picture
        /// </summary>
        /// <param name="row">The maze row the tile is at.</param>
        /// <param name="col">The maze column the tile is at.</param>
        /// <returns>Returns null if there's no picture in the specified row and column, or the picture if it's not null.</returns>
        private PCPictureBox GetTileFromMaze(int row, int col)
        {
            if (tiles[row, col] == null)
            {
                return null;
            }
            return tiles[row, col];
        }

        /// <summary>
        /// Moves the box horizontally or vertically.
        /// </summary>
        /// <param name="displacement">The positive or negative value that displaces the picture (left/right/up/down).</param>
        private void MoveBox(int displacement)
        {
            PCPictureBox sidePicture = isHorizontalMovement
                ? GetTileFromMaze(selectedPicture.PictureRow, selectedPicture.PictureColumn + displacement)
                : GetTileFromMaze(selectedPicture.PictureRow + displacement, selectedPicture.PictureColumn);
            while (sidePicture == null)
            {
                int previousRow = selectedPicture.PictureRow;
                int previousCol = selectedPicture.PictureColumn;
                if (isHorizontalMovement)
                {
                    selectedPicture.PictureColumn += displacement;
                    Thread.Sleep(10);
                    selectedPicture.Left = INITIAL_POSITION + SQUARE_SIDE_SIZE * (selectedPicture.PictureColumn);
                    Thread.Sleep(10);
                    tiles[previousRow, previousCol] = null;
                    tiles[selectedPicture.PictureRow, selectedPicture.PictureColumn] = selectedPicture;
                    sidePicture = GetTileFromMaze(selectedPicture.PictureRow, selectedPicture.PictureColumn + displacement);
                }
                else
                {
                    selectedPicture.PictureRow += displacement;
                    Thread.Sleep(10);
                    selectedPicture.Top = INITIAL_POSITION + SQUARE_SIDE_SIZE * (selectedPicture.PictureRow);
                    Thread.Sleep(10);
                    tiles[previousRow, previousCol] = null;
                    tiles[selectedPicture.PictureRow, selectedPicture.PictureColumn] = selectedPicture;
                    sidePicture = GetTileFromMaze(selectedPicture.PictureRow + displacement, selectedPicture.PictureColumn);
                }
            }
            if (IsRemoveBox(sidePicture))
            {
                RemoveSelectedBoxFromPanel();
                CountBoxes(tiles);
            }
        }

        /// <summary>
        /// Removes the selected box from the panel.
        /// </summary>
        private void RemoveSelectedBoxFromPanel()
        {
            tiles[selectedPicture.PictureRow, selectedPicture.PictureColumn] = null;
            pnlMaze.Controls.Remove(selectedPicture);
            selectedPicture = null;
        }

        /// <summary>
        /// Checks if the picture on the side of the selected picture is a door that has the same box' color as the selected picture.
        /// </summary>
        /// <param name="sidePicture">The picture on the side (left, right, up or down) of the selected picture.</param>
        /// <returns>True if the colors are the same, false otherwise.</returns>
        private bool IsRemoveBox(PCPictureBox sidePicture)
        {
            if ((sidePicture.PictureType == PictureTypeEnum.GreenDoor && selectedPicture.PictureType == PictureTypeEnum.GreenBox)
                || sidePicture.PictureType == PictureTypeEnum.RedDoor && selectedPicture.PictureType == PictureTypeEnum.RedBox)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Counts the boxes in the current maze.
        /// </summary>
        /// <param name="tiles">The array of PCPictureBox that forms the maze being used.</param>
        private void CountBoxes(PCPictureBox[,] tiles)
        {
            int boxCount = 0;
            for (int i = 0; i < numOfRows; i++)
            {
                for (int j = 0; j < numOfCols; j++)
                {
                    if (tiles[i,j] != null && (tiles[i, j].PictureType == PictureTypeEnum.GreenBox || tiles[i, j].PictureType == PictureTypeEnum.RedBox))
                    {
                        boxCount += 1;
                    }
                }
            }

            txtRemainingBoxes.Text = boxCount.ToString();
            FinalizeGame(boxCount);
        }

        /// <summary>
        /// Counts the number of movements made by the user.
        /// </summary>
        /// <param name="movesCount">The amount of moves</param>
        private void CountMoves(ref int movesCount)
        {
            movesCount += 1;
            txtNumberOfMoves.Text = movesCount.ToString();
        }

        /// <summary>
        /// Terminates the game.
        /// </summary>
        /// <param name="boxCount">The number of boxes left in the maze.</param>
        private void FinalizeGame(int boxCount)
        {
            if (boxCount == 0)
            {
                MessageBox.Show("Congratulations!\nGame End.", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );

                pnlMaze.Controls.Clear();
                ResetCounters();
                EnableButtons(false);
            }
        }

        /// <summary>
        /// Enables the control pad buttons.
        /// </summary>
        /// <param name="buttonState">Defines if the button is enabled or not.</param>
        private void EnableButtons(bool buttonState)
        {
            btnDown.Enabled = buttonState;
            btnUp.Enabled = buttonState;
            btnLeft.Enabled = buttonState;
            btnRight.Enabled = buttonState;
        }

        /// <summary>
        /// Resets the counters to zero.
        /// </summary>
        private void ResetCounters()
        {
            movesCount = 0;
            txtNumberOfMoves.Text = "0";
            txtRemainingBoxes.Text = "0";
        }

    }
}
