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
        private readonly Image imgNone = Properties.Resources.None;
        private readonly Image imgWall = Properties.Resources.Wall;
        private readonly Image imgRedDoor = Properties.Resources.RedDoor;
        private readonly Image imgGreenDoor = Properties.Resources.GreenDoor;
        private readonly Image imgRedBox = Properties.Resources.RedBox;
        private readonly Image imgGreenBox = Properties.Resources.GreenBox;

        Image chosenTool;
        bool isPictureChosen = false;
        bool isMazeGenerated = false;


        public MazeDesignForm()
        {
            InitializeComponent();
        }


        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int xLocation = 50;
            int yLocation = 50;
            int numberOfRows = Convert.ToInt32(txtRows.Text);
            int numberOfColumns = Convert.ToInt32(txtColumns.Text);

            GenerateMaze(ref xLocation, ref yLocation, numberOfRows, numberOfColumns);
            
        }

        private void GenerateMaze(ref int xLocation, ref int yLocation, int numberOfRows, int numberOfColumns)
        {
            pnlMaze.Controls.Clear();

            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    PictureBox pictureBox = new PictureBox
                    {
                        Size = new Size(60, 60),
                        Location = new Point(xLocation, yLocation),
                        Image = imgNone,
                        BorderStyle = BorderStyle.FixedSingle,
                        Name = "pictureBox" + j.ToString() + ", " + i.ToString(),
                        SizeMode = PictureBoxSizeMode.StretchImage
                        
                    };

                    pictureBox.Click += new EventHandler(this.pictureBox_Click);

                    pnlMaze.Controls.Add(pictureBox);

                    yLocation += 60;
                }

                xLocation += 60;
                yLocation = 50;
            }
            isMazeGenerated = true;
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            //PictureBox pictureClicked = sender as PictureBox;
            //MessageBox.Show(pictureClicked.Name + "clicked");

            if (isMazeGenerated == true && isPictureChosen == true)
            {
                PictureBox pictureClicked = sender as PictureBox;
                pictureClicked.Image = chosenTool;
            }

        }

        private void pbxNone_Click(object sender, EventArgs e)
        {
            chosenTool = Properties.Resources.None;
            isPictureChosen = true;
        }
        private void pnlMaze_Click(object sender, EventArgs e)
        {
            Point point = Control.MousePosition;
            
            //if(isMazeGenerated == true && isPictureChosen == true)
            //{
            //    PictureBox pictureClicked = sender as PictureBox;
            //    MessageBox.Show(pictureClicked.Name + "clicked");
            //}

        }

        private void pbxWall_Click(object sender, EventArgs e)
        {
            chosenTool = Properties.Resources.Wall;
            isPictureChosen = true;
        }

        private void pbxRedDoor_Click(object sender, EventArgs e)
        {
            chosenTool = Properties.Resources.RedDoor;
            isPictureChosen = true;
        }

        private void pbxGreenDoor_Click(object sender, EventArgs e)
        {
            chosenTool = Properties.Resources.GreenDoor;
            isPictureChosen = true;
        }

        private void pbxRedBox_Click(object sender, EventArgs e)
        {
            chosenTool = Properties.Resources.RedBox;
            isPictureChosen = true;
        }

        private void pbxGreenBox_Click(object sender, EventArgs e)
        {
            chosenTool = Properties.Resources.GreenBox;
            isPictureChosen = true;
        }
    }
}
