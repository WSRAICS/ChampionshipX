using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using WorldSkillsX.Properties;


namespace WorldSkillsX.Tiles
{
    public class RoadSign : Obstacle
    {
        Bitmap block = Resources.Block;
        Bitmap heavy = Resources.HeavyBlock2;
        Bitmap vagon = Resources.VagonBlock;

        public RoadSign(int type)
        {
            ObstacleType = "rs";
            Type = type;
            pickImage();
        }

        private void pickImage()
        {
            if (Type == 0) Image = block;  //q
            if (Type == 1) Image = heavy;  //w
            if (Type == 2) Image = vagon;  //e
        }

        public void ChangeType(int type)
        {
            Type = type;
            pickImage();
        }

        public new bool canGo(int i)
        {
            if (Type == 0)
            {
                return false;
            }
            if (Type == 1 && i == 1)
            {
                return false;
            }
            if (Type == 2 && i == 2)
            {
                return false;
            }
            return true;
        }
    }
}
