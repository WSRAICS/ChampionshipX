using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using WorldSkillsX.Properties;


namespace WorldSkillsX.Tiles
{
    public class Ped : Obstacle
    {
        int timerInterval = 7000;

        int crosstime = 5000;

        Bitmap imagedefault = Resources.Pedestrain;
        public Ped()
        {
            ObstacleType = "ped";
            Image = imagedefault;
        }

        public void addTime(int t)
        {
            if ((timerInterval + t) >= 6*1000)
            {
                timerInterval += t;
            }
        }

        public string getTime()
        {
            return $"{timerInterval / 1000}";
        }

    }
}
