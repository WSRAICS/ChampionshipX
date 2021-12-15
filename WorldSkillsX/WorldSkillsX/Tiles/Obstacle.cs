using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using WorldSkillsX.Properties;

namespace WorldSkillsX.Tiles
{
    public class Obstacle
    {
        public string ObstacleType = "";
        public int Type;
        public Bitmap Image;
        public bool CanGo;
        public bool canGo(int i)
        {
            return false;
        }
    }
}
