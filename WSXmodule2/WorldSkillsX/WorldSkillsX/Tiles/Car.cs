using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using WorldSkillsX.Properties;

namespace WorldSkillsX.Tiles
{
    public class Car
    {
        public bool pathDone = false;

        public Point Location;
        public Point LocationTile;
        public Point Direction;

        public Point[] turns;

        public int mode = 0; // 1 - plchldr 2 - rand  

        int currentWaypoint = 0;

        public Bitmap Image;
        Bitmap imageUp = Resources.BCvertical;
        Bitmap imageDown = Resources.BCbottom;
        Bitmap imageLeft = Resources.BCleft;
        Bitmap imageRight = Resources.BCright;

        Bitmap imageUpr = Resources.Cvertical1;
        Bitmap imageDownr = Resources.Cbottom;
        Bitmap imageLeftr = Resources.Cleft;
        Bitmap imageRightr = Resources.Cright;

        Bitmap imageUpt = Resources.Truck;
        Bitmap imageDownt = Resources.TruckBottom;
        Bitmap imageLeftt = Resources.TruckLeft;
        Bitmap imageRightt = Resources.TruckRight;

        Bitmap imageUpv = Resources.Trailer;
        Bitmap imageDownv = Resources.TrailerBottom;
        Bitmap imageLeftv = Resources.TrailerLeft;
        Bitmap imageRightv = Resources.TrailerRight;

        Timer animTimer;

        public int Type; //0 car; 1 truck; 2 vagon
        public  int color; //0 blue; 1 red;


        public Car(Point lt, Point d, int t, int c)
        {
            animTimer = new Timer()
            {
                Enabled = false,
                Interval = 40
            };
            animTimer.Tick += AnimTimer_Tick;
            LocationTile = lt;
            Location = new Point(LocationTile.X * Data.tileWidth, LocationTile.Y * Data.tileWidth);
            Direction = d;
            color = c;
            Type = t;
            pickImage();
        }

        public Car(Point lt, string s, int t, int c)
        {
            animTimer = new Timer()
            {
                Enabled = false,
                Interval = 40
            };
            animTimer.Tick += AnimTimer_Tick;
            LocationTile = lt;
            Location = new Point(LocationTile.X * Data.tileWidth, LocationTile.Y * Data.tileWidth);
            Direction = DirFromRoadType(s);
            color = c;
            Type = t;
            pickImage();
        }

        int animctr = 0;
        int animmax = 6;
        int portion = 5;
        private void AnimTimer_Tick(object sender, EventArgs e)
        {
            if (animctr < animmax + 1)
            {
                if (Direction.X == 0 && Direction.Y == -1) Location = Point.Add(Location, new Size(0, -(portion)));
                else if (Direction.X == 0 && Direction.Y == 1) Location = Point.Add(Location, new Size(0, portion));
                else if (Direction.X == 1 && Direction.Y == 0) Location = Point.Add(Location, new Size(portion, 0));
                else if (Direction.X == -1 && Direction.Y == 0) Location = Point.Add(Location, new Size(-(portion), 0));
                animctr++;
            }
            else
            {
                Location = new Point(LocationTile.X * Data.tileWidth, LocationTile.Y * Data.tileWidth);
                animTimer.Enabled = false;
                animctr = 0;
            }
        }

        public void Move()
        {
            bool needToEncCtr = false;
            if (mode == 1)
            {
                if (turns == null)
                {
                    pathDone = true;
                    return;
                }
                if (turns.Contains(LocationTile))
                {
                    calcDirection();
                    needToEncCtr = true;
                }

                var nextTile = Point.Add(LocationTile, new Size(Direction.X, Direction.Y));
                if (nextTile.X > 19 || nextTile.Y > 19 || nextTile.X < 0 || nextTile.Y < 0)
                {
                    Data.map[LocationTile.X, LocationTile.Y].IsOccupied = false;
                    animTimer.Enabled = true;
                    pathDone = true;
                    return;
                }
                if (canmove(nextTile))
                {
                    if (needToEncCtr)
                    {
                        needToEncCtr = false;
                        currentWaypoint++;
                    }
                    Data.map[LocationTile.X, LocationTile.Y].IsOccupied = false;
                    Data.map[nextTile.X, nextTile.Y].IsOccupied = true;
                    LocationTile = Point.Add(LocationTile, new Size(Direction.X, Direction.Y));
                    animTimer.Enabled = true;
                }
            }
            else if(mode == 2)
            {

            }
            else
            {
                var nextTile = Point.Add(LocationTile, new Size(Direction.X, Direction.Y));
                if (canmove(nextTile))
                {
                    Data.map[LocationTile.X, LocationTile.Y].IsOccupied = false;
                    Data.map[nextTile.X, nextTile.Y].IsOccupied = true;
                    LocationTile = Point.Add(LocationTile, new Size(Direction.X, Direction.Y));
                    animTimer.Enabled = true;
                }
            }

        }

        private bool canmove(Point nextTile)
        {

            //nextTile = Point.Add(LocationTile, new Size(Direction.X, Direction.Y));
            if (Data.map[nextTile.X, nextTile.Y].HasRoad)
            {
                if (Data.map[nextTile.X, nextTile.Y].HasObstacle && !Data.map[nextTile.X, nextTile.Y].IsOccupied)
                {
                    if (Data.map[nextTile.X, nextTile.Y].Obstacle.ObstacleType == "tl")
                    {
                        if ((Data.map[nextTile.X, nextTile.Y].Obstacle as TrafficLight).mode == 2 && !(Data.map[nextTile.X, nextTile.Y].Obstacle as TrafficLight).canGo(Type))
                        {
                            (Data.map[nextTile.X, nextTile.Y].Obstacle as TrafficLight).GoGreen();
                        }
                        return (Data.map[nextTile.X, nextTile.Y].Obstacle as TrafficLight).canGo(Type);
                    }
                    if (Data.map[nextTile.X, nextTile.Y].Obstacle.ObstacleType == "ped")
                    {
                        return (Data.map[nextTile.X, nextTile.Y].Obstacle as Ped).canGo(Type);
                    }
                    if (Data.map[nextTile.X, nextTile.Y].Obstacle.ObstacleType == "rs")
                    {
                        return (Data.map[nextTile.X, nextTile.Y].Obstacle as RoadSign).canGo(Type);
                    }
                    if (Data.map[nextTile.X, nextTile.Y].Obstacle.ObstacleType == "pl")
                    {
                        return (Data.map[nextTile.X, nextTile.Y].Obstacle as PedLine).canGo(Type);
                    }
                }
                else if (!Data.map[nextTile.X, nextTile.Y].HasObstacle && !Data.map[nextTile.X, nextTile.Y].IsOccupied)
                {
                    return true;
                }
            }
            return false;
        }

        public void pickRandomTurn()
        {

        }


        public Point DirFromRoadType(string s)
        {
            Point Direction = new Point();
            if (s == "2") { Direction.X = 0; Direction.Y = 1; }
            if (s == "1") { Direction.X = 1; Direction.Y = 0; }
            if (s == "0") { Direction.X = 0; Direction.Y = -1; }
            if (s == "3") { Direction.X = -1; Direction.Y = 0; }
            return Direction;
        }

        private void calcDirection()
        {
            if (currentWaypoint >= turns.Length-1) Console.WriteLine("end");
            else
            {
                if (turns[currentWaypoint].X < turns[currentWaypoint + 1].X) Direction = new Point(1, 0);
                if (turns[currentWaypoint].X > turns[currentWaypoint + 1].X) Direction = new Point(-1, 0);
                if (turns[currentWaypoint].Y < turns[currentWaypoint + 1].Y) Direction = new Point(0, 1);
                if (turns[currentWaypoint].Y > turns[currentWaypoint + 1].Y) Direction = new Point(0, -1);
            }
            pickImage();
        }

        private void pickImage()
        {
            if (Type == 0)
            {
                if (color == 0)
                {
                    if (Direction.X == 0 && Direction.Y == -1) Image = imageUp;
                    else if (Direction.X == 0 && Direction.Y == 1) Image = imageDown;
                    else if (Direction.X == 1 && Direction.Y == 0) Image = imageRight;
                    else if (Direction.X == -1 && Direction.Y == 0) Image = imageLeft;
                }
                if (color == 1)
                {
                    if (Direction.X == 0 && Direction.Y == -1) Image = imageUpr;
                    else if (Direction.X == 0 && Direction.Y == 1) Image = imageDownr;
                    else if (Direction.X == 1 && Direction.Y == 0) Image = imageRightr;
                    else if (Direction.X == -1 && Direction.Y == 0) Image = imageLeftr;
                }
            }
            if (Type == 1)
            {
                if (Direction.X == 0 && Direction.Y == -1) Image = imageUpt;
                else if (Direction.X == 0 && Direction.Y == 1) Image = imageDownt;
                else if (Direction.X == 1 && Direction.Y == 0) Image = imageRightt;
                else if (Direction.X == -1 && Direction.Y == 0) Image = imageLeftt;
            }
            if (Type == 2)
            {
                if (Direction.X == 0 && Direction.Y == -1) Image = imageUpv;
                else if (Direction.X == 0 && Direction.Y == 1) Image = imageDownv;
                else if (Direction.X == 1 && Direction.Y == 0) Image = imageRightv;
                else if (Direction.X == -1 && Direction.Y == 0) Image = imageLeftv;
            }
        }
    }
}
