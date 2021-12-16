using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldSkillsX.Tiles;
using System.Drawing;

namespace WorldSkillsX
{
    public static class Data
    { 
        public static int mapWidth = 20;
        public static int tileWidth = 35;


        public static Tile[,] map = new Tile[mapWidth, mapWidth];
        public static List<Point> trafficLights = new List<Point>();
        public static List<Car> defaultcars = new List<Car>();
        public static void Init()
        {
            for (int y = 0; y < mapWidth; y++)
            {
                for (int x = 0; x < mapWidth; x++)
                {
                    Tile t;
                    Road r = null;
                    Obstacle o = null;

                    string rtype = "";

                    if (smap[x, y].Contains("0")) { r = new Road(0); rtype = "0"; }
                    if (smap[x, y].Contains("1")) { r = new Road(1); rtype = "1"; }
                    if (smap[x, y].Contains("2")) { r = new Road(2); rtype = "2"; }
                    if (smap[x, y].Contains("3")) { r = new Road(3); rtype = "3"; }
                    if (smap[x, y].Contains("4")) r = new Road(4);
                    if (smap[x, y].Contains("t")) {o = new TrafficLight(); trafficLights.Add(new Point(y, x)); } 
                    if (smap[x, y].Contains("q")) o = new RoadSign(0);
                    if (smap[x, y].Contains("w")) o = new RoadSign(1);
                    if (smap[x, y].Contains("e")) o = new RoadSign(2);
                    if (smap[x, y].Contains("h")) o = new PedLine(0);
                    if (smap[x, y].Contains("v")) o = new PedLine(1);
                    if (smap[x, y].Contains("p")) o = new Ped();


                    if(smap[x, y].Contains("l"))
                    {
                        Car c = new Car(new Point(y, x), rtype, 0, 0);
                        defaultcars.Add(c);
                    }
                    if (smap[x, y].Contains("k"))
                    {
                        Car c = new Car(new Point(y, x), rtype, 0, 1);
                        defaultcars.Add(c);
                    }
                    if (smap[x, y].Contains("j"))
                    {
                        Car c = new Car(new Point(y, x), rtype, 1, 0);
                        defaultcars.Add(c);
                    }
                    if (smap[x, y].Contains("g"))
                    {
                        Car c = new Car(new Point(y, x), rtype, 2, 0);
                        defaultcars.Add(c);
                    }

                    t = new Tile(r, o);
                    map[y, x] = t;
                }
            }
        }

        //l = blue car
        //k = red car
        //j = truck
        //g = vag

        public static string[,] smap = new string[,]
        {
            { "   ", "2tl", "0  ", "   ", "   ", "   ", "p  ", "   ", "   ", "   ", "   ", "2tk", "0  ", "   ", "   ", "2g ", "0  ", "   ", "   ", "   "},

            { "3  ", "4  ", "4  ", "3t ", "3  ", "3  ", "3v ", "3  ", "3  ", "3  ", "3e ", "4  ", "4  ", "   ", "   ", "2  ", "0  ", "   ", "   ", "   "},

            { "1tk", "4  ", "4  ", "1e ", "1  ", "1  ", "1v ", "1  ", "1  ", "1  ", "1t ", "4  ", "4  ", "   ", "   ", "2t ", "0q ", "   ", "   ", "   "},

            { "   ", "2t ", "0t ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "2  ", "0t ", "   ", "   ", "4  ", "4  ", "3t ", "3  ", "3j "},

            { "   ", "4  ", "4  ", "3t ", "3  ", "3  ", "3  ", "3  ", "4  ", "   ", "   ", "2  ", "0  ", "   ", "   ", "4  ", "4  ", "1  ", "1  ", "1  "},

            { "   ", "4  ", "4  ", "1w ", "1  ", "1  ", "1  ", "1t ", "4  ", "   ", "   ", "2h ", "0h ", "   ", "   ", "2  ", "0t ", "   ", "   ", "   "},

            { "   ", "2  ", "0t ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "2  ", "0  ", "   ", "   ", "2h ", "0h ", "p  ", "   ", "   "},

            { "   ", "2t ", "0  ", "   ", "   ", "   ", "   ", "   ", "p  ", "   ", "   ", "2t ", "0  ", "   ", "   ", "2  ", "0  ", "   ", "   ", "   "},

            { "3  ", "4  ", "4  ", "3t ", "4  ", "4  ", "3t ", "3  ", "3v ", "3  ", "3  ", "4  ", "4  ", "3t ", "3  ", "4  ", "4  ", "3t ", "3  ", "3 k"},

            { "1tj", "4  ", "4  ", "1  ", "4  ", "4  ", "1  ", "1  ", "1v ", "1  ", "1t ", "4  ", "4  ", "1  ", "1t ", "4  ", "4  ", "1  ", "1  ", "1  "},

            { "   ", "   ", "   ", "   ", "2  ", "0t ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "2  ", "0t ", "   ", "   ", "   "},

            { "   ", "   ", "   ", "   ", "2  ", "0  ", "   ", "   ", "4  ", "4  ", "   ", "   ", "   ", "   ", "   ", "2  ", "0  ", "   ", "   ", "   "},

            { "   ", "   ", "   ", "   ", "2t ", "0  ", "   ", "   ", "2t ", "0t ", "   ", "4  ", "3t ", "3  ", "3e ", "4  ", "4  ", "3t ", "3  ", "3 g"},

            { "3  ", "4  ", "4  ", "3  ", "4  ", "4  ", "3t ", "3  ", "4  ", "4  ", "   ", "4  ", "1  ", "1  ", "1t ", "4  ", "4  ", "1q ", "1  ", "1  "},

            { "1l ", "4  ", "4  ", "1t ", "4  ", "4  ", "1  ", "1  ", "4  ", "4  ", "   ", "   ", "   ", "   ", "   ", "2  ", "0t ", "   ", "   ", "   "},

            { "   ", "2  ", "0t ", "   ", "2q ", "0t ", "   ", "   ", "2  ", "0  ", "   ", "   ", "   ", "   ", "   ", "2  ", "0  ", "   ", "   ", "   "},

            { "   ", "2  ", "0  ", "   ", "2  ", "0  ", "   ", "   ", "2t ", "0  ", "   ", "   ", "p  ", "   ", "   ", "2t ", "0  ", "   ", "   ", "   "},

            { "3  ", "4  ", "4  ", "   ", "2h ", "0h ", "p  ", "   ", "4  ", "4  ", "3t ", "3  ", "3v ", "3  ", "3w ", "4  ", "4  ", "3t ", "3  ", "3l "},

            { "1tg", "4  ", "4  ", "   ", "2  ", "0  ", "   ", "   ", "4  ", "4  ", "1w ", "1  ", "1v ", "1  ", "1t ", "4  ", "4  ", "1  ", "1  ", "1  "},

            { "   ", "   ", "   ", "   ", "2  ", "0j ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "2  ", "0tk", "   ", "   ", "   "}


        };
    }
}
