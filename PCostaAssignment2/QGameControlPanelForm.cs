/*
 * PROG2370 - Assignment 2
 * Programmer: Patricia Canuto Vieira da Costa
 * Revision History:
 *      2020-10-31: UI designed, code written, debbuged
 *      2020-11-02: UI updates, code written, debbuged
 *      2020-11-03: code written, Bug fixing
 *      2020-11-04: code written, code "cleaning", Documentation comments added
 *      2020-12-02: UI updates, code written
*/

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
    /// <summary>
    /// The class responsible for making the QGame Control Panel user interface.
    /// </summary>
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
            GamePlayForm gamePlayForm = new GamePlayForm();
            gamePlayForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
