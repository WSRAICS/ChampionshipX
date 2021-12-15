using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using WorldSkillsX.Properties;

namespace WorldSkillsX.Tiles
{
    public class TrafficLight : Obstacle
    {
        Bitmap imagered = Resources.TLred;
        Bitmap imagegreen = Resources.TLgreen1;
        public TrafficLight()
        {
            CanGo = true;
            Image = imagegreen;
        }

        public void Switch()
        {
            if (CanGo)
            {
                CanGo = false;
                Image = imagered;
            }
            else
            {
                CanGo = true;
                Image = imagegreen;
            }
        }

        public void GoGreen()
        {
            CanGo = true;
            Image = imagegreen;
        }

        public void GoRed()
        {
            CanGo = false;
            Image = imagered;
        }

        public new bool canGo(int i)
        {
            return CanGo;
        }
    }
}
