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
    public partial class QGameControlPanelForm : Form
    {
        public QGameControlPanelForm()
        {
            InitializeComponent();
        }

        private void btnDesign_Click(object sender, EventArgs e)
        {
            MazeDesignForm designForm = new MazeDesignForm();
            designForm.Show();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //assignment3
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
