using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCostaAssignment2
{
    public class PCPictureBox : PictureBox
    {
        private PictureTypeEnum pictureType;

        private int pictureRow;
        private int pictureColumn;

        public PictureTypeEnum PictureType { get => pictureType; set => pictureType = value; }
        public int PictureRow { get => pictureRow; set => pictureRow = value; }
        public int PictureColumn { get => pictureColumn; set => pictureColumn = value; }

        public void SetImage(PictureTypeEnum pictureType)
        {
            PictureType = pictureType;
            Image = GetImage(pictureType);
        }

        private Image GetImage(PictureTypeEnum pictureType)
        {
            switch (pictureType)
            {
                case PictureTypeEnum.None:
                    return Properties.Resources.None;
                case PictureTypeEnum.Wall:
                    return Properties.Resources.Wall;
                case PictureTypeEnum.RedDoor:
                    return Properties.Resources.RedDoor;
                case PictureTypeEnum.GreenDoor:
                    return Properties.Resources.GreenDoor;
                case PictureTypeEnum.RedBox:
                    return Properties.Resources.RedBox;
                case PictureTypeEnum.GreenBox:
                    return Properties.Resources.GreenBox;
                default:
                    return Properties.Resources.None;
            }
            
        }
    }
}
