using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using WorldSkillsX.Properties;

namespace WorldSkillsX.Tiles
{
    public class Road
    {
        Bitmap imageup = Resources.Rvertical;
        Bitmap imagedown;
        Bitmap imageleft;
        Bitmap imageright;
        Bitmap imagecross = Resources.Rcrossroads;

        public int Type;
        public Bitmap Image;

        public Road(int Type)
        {
            imagedown = Resources.Rvertical;
            imagedown.RotateFlip(RotateFlipType.RotateNoneFlipX);

            imageleft = Resources.Rvertical;
            imageleft.RotateFlip(RotateFlipType.Rotate270FlipNone);

            imageright = Resources.Rvertical;
            imageright.RotateFlip(RotateFlipType.Rotate90FlipNone);

            this.Type = Type;
            PickImage();
        }

        public void PickImage()
        {
            switch (Type)
            {
                case 0:
                    Image = imageup;
                    break;
                case 1:
                    Image = imageright;
                    break;
                case 2:
                    Image = imagedown;
                    break;
                case 3:
                    Image = imageleft;
                    break;
                case 4:
                    Image = imagecross;
                    break;
            }
        }
    }
}
