using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCostaAssignment2
{
    public class Tile : PictureBox
    {
        private int row;
        private int col;
        private int tileType;

        public int Row { get => row; set => row = value; }
        public int Col { get => col; set => col = value; }
        public int TileType { get => tileType; set => tileType = value; }
    }
}
