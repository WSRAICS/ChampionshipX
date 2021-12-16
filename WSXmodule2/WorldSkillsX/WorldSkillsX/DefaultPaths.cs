using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WorldSkillsX
{
    public static class DefaultPaths
    {
        public static Point[] getPath(Point p)
        {
            if (p.X == 1 && p.Y == 0)
            {
                return pp;
            }
            if (p.X == 11 && p.Y == 0)
            {
                return p1;
            }
            if (p.X == 0 && p.Y == 2)
            {
                return p2;
            }
            if (p.X == 0 && p.Y == 9)
            {
                return p3;
            }
            if (p.X == 0 && p.Y == 14)
            {
                return p4;
            }
            if (p.X == 0 && p.Y == 18)
            {
                return p5;
            }
            if (p.X == 5 && p.Y == 19)
            {
                return p6;
            }
            if (p.X == 16 && p.Y == 19)
            {
                return p7;
            }
            if (p.X == 19 && p.Y == 17)
            {
                return p8;
            }
            if (p.X == 19 && p.Y == 12)
            {
                return p9;
            }
            if (p.X == 19 && p.Y ==8)
            {
                return p10;
            }
            if (p.X == 19 && p.Y == 3)
            {
                return p11;
            }
            if (p.X == 15 && p.Y == 0)
            {
                return p12;
            }

            return null;
        }

        public static Point[] pp = new Point[]  // blue car at 1 0
        {
            new Point(1, 2),
            new Point(11, 2),
            new Point(11, 9),
            new Point(19, 9)
        };
        public static Point[] p1 = new Point[] // red car at 11 0
{
            new Point(11, 1),
            new Point(1, 1),
            new Point(1, 9),
            new Point(4, 9),
            new Point(4, 13),
            new Point(0, 13),
};
        public static Point[] p2 = new Point[] // red car at 0 2
{
            new Point(1, 2),
            new Point(1, 9),
            new Point(19, 9)
};
        public static Point[] p3 = new Point[] // red truck at 0 9
{
            new Point(19, 9)
};
        public static Point[] p4 = new Point[] // blue car at 0 14
{
            new Point(8, 14),
            new Point(8, 18),
            new Point(15, 18),
            new Point(15, 19)
};
        public static Point[] p5 = new Point[] // vag at 0 18
{
            new Point(2, 18),
            new Point(2, 14),
            new Point(8, 14),
            new Point(8, 18),
            new Point(19, 18)
};
        public static Point[] p6 = new Point[] // truck at 5 19
{
            new Point(5, 13),
            new Point(0, 13)
};
        public static Point[] p7 = new Point[] // red car at 16 19
{
            new Point(16, 17),
            new Point(9, 17),
            new Point(9, 13),
            new Point(5, 13),
            new Point(5, 8),
            new Point(0, 8)
};
        public static Point[] p8 = new Point[] // blue car at 19 17
{
            new Point(16, 17),
            new Point(16, 8),
            new Point(12, 8),
            new Point(12, 0)
};
        public static Point[] p9 = new Point[] // vag at 19 12
{
            new Point(16, 12),
            new Point(16, 8),
            new Point(2, 8),
            new Point(2, 0)
};
        public static Point[] p10 = new Point[] // red car at 19 8
{
            new Point(15, 8),
            new Point(15, 18),
            new Point(19, 18)
};
        public static Point[] p11 = new Point[] // truck at 19 3
{
            new Point(15, 3),
            new Point(15, 8),
            new Point(2, 8),
            new Point(2, 0),
};
        public static Point[] p12 = new Point[] // vag at 15 0
{
            new Point(15, 19)
};
    }
}
