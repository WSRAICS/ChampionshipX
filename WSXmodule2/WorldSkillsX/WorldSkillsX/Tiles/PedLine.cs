using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using WorldSkillsX.Properties;

namespace WorldSkillsX.Tiles
{
    public class PedLine : Obstacle
    {
        Bitmap imageh = Resources.Zhorizontal1;
        Bitmap imagev = Resources.Zvertical;

        public PedLine(int type)
        {
            CanGo = true;
            ObstacleType = "pl";
            Type = type;
            pickImage();
        }

        private void pickImage()
        {
            if (Type == 0) Image = imageh;  //h
            if (Type == 1) Image = imagev;  //v
        }

        public new bool canGo(int i)
        {
            return CanGo;
        }
    }
}
