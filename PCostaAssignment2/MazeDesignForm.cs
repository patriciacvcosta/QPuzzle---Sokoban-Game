using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                int numberOfRows = Convert.ToInt32(txtRows.Text);
                int numberOfColumns = Convert.ToInt32(txtColumns.Text);

                if (numberOfRows <= 0 || numberOfColumns <= 0)
                {
                    throw new Exception("Non positive input.");
                }

                GenerateMaze(xLocation, yLocation, numberOfRows, numberOfColumns);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error occurred: " + ex.Message + "\n\nPlease inform a valid number of rows and columns before generating the maze.", "Maze Design");

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
                        Name = "pictureBox" + i.ToString() + ", " + j.ToString(),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Cursor = Cursors.Hand
                        
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

        }
    }
}
