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
    public partial class GamePlayForm : Form
    {

        private const int SQUARE_SIDE_SIZE = 60;
        private const int SELECTED_SQUARE_SIDE_SIZE = 57;
        private const int INITIAL_POSITION = 50;
        private StreamReader reader;
        PCPictureBox pictureBox;
        PCPictureBox[,] tiles;

        int numOfRows;
        int numOfCols;


        public GamePlayForm()
        {
            InitializeComponent();
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

                        GenerateMaze(tiles);

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

        }
        private void btnRight_Click(object sender, EventArgs e)
        {

        }

        private void btnUp_Click(object sender, EventArgs e)
        {

        }

        private void btnDown_Click(object sender, EventArgs e)
        {

        }



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


        private PCPictureBox LoadPictureBox(int row, int col, PictureTypeEnum tileType)
        {
            if (tileType == PictureTypeEnum.None)
            {
                return null;
            }

            pictureBox = new PCPictureBox
            {
                Size = new Size(SQUARE_SIDE_SIZE, SQUARE_SIDE_SIZE),
                //Location = new Point(row, col),
                BorderStyle = BorderStyle.FixedSingle,
                //Name = "pictureBox" + xPosition + yPosition,
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

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PCPictureBox pictureClicked = sender as PCPictureBox;

            if (pictureClicked.PictureType == PictureTypeEnum.GreenBox || pictureClicked.PictureType == PictureTypeEnum.RedBox)
            {
                GetTileFromMaze(pictureClicked.PictureRow, pictureClicked.PictureColumn);
            }
        }
        private PCPictureBox GetTileFromMaze(int row, int col)
        {
            if (tiles[row,col] == null)
            {
                return null;
            }
            return tiles[row, col];
        }
    }
}
