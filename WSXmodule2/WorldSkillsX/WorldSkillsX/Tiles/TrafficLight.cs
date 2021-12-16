using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using WorldSkillsX.Properties;
using System.Windows.Forms;

namespace WorldSkillsX.Tiles
{
    public class TrafficLight : Obstacle
    {
        Bitmap imagered = Resources.TLred;
        Bitmap imagegreen = Resources.TLgreen1;

        Timer switchTimer;
        Timer autoModeTimer;
        int defaultSwitchTime = 5 * 1000;
        int autoSwitchTime = (int)(0.2 * 1000);

        public int mode = -1; // 0 manual, 1 timer, 2 auto

        public TrafficLight()
        {
            switchTimer = new Timer()
            {
                Interval = defaultSwitchTime,
                Enabled = false,
            };
            autoModeTimer = new Timer()
            {
                Interval = autoSwitchTime,
                Enabled = false,
            };
            switchTimer.Tick += SwitchTimer_Tick;
            autoModeTimer.Tick += AutoModeTimer_Tick;
            ObstacleType = "tl";
            CanGo = true;
            Image = imagegreen;
        }

        private void AutoModeTimer_Tick(object sender, EventArgs e)
        {
            GoRed();
            autoModeTimer.Enabled = false;
        }

        public void setMode(int m)
        {
            if (m < 3 && m >= 0)
            {
                switch (m)
                {
                    case 0:
                        switchTimer.Enabled = false;
                        mode = m;
                        break;
                    case 1:
                        if (mode == 0) break;
                        switchTimer.Enabled = true;
                        mode = m;
                        break;
                    case 2:
                        if (mode == 0) break;
                        switchTimer.Enabled = false;
                        mode = m;
                            break;
                    default:
                        break;
                }
            }
        }

        public void automationBoiiiiii(int m)
        {
            Console.WriteLine(m);
            Console.WriteLine(m >= 0 && m < 3);
            if (m >= 0 && m < 3)
            {
                mode = m;
                if (m == 1) switchTimer.Enabled = true;
                if (m == 2) switchTimer.Enabled = false;
                Console.WriteLine(mode);
            }
        }

        private void SwitchTimer_Tick(object sender, EventArgs e)
        {
            Switch();
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
            if (mode == 2)
            {
                autoModeTimer.Enabled = true;
            }
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
