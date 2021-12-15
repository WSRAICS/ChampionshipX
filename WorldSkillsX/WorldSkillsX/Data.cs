using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldSkillsX.Tiles;

namespace WorldSkillsX
{
    public static class Data
    { 
        public static int mapWidth = 20;
        public static int tileWidth = 35;


        public static Tile[,] map = new Tile[mapWidth, mapWidth];

        public static void Init()
        {
            for (int y = 0; y < mapWidth; y++)
            {
                for (int x = 0; x < mapWidth; x++)
                {
                    Tile t;
                    Road r = null;
                    Obstacle o = null;
                    
                    if (smap[x, y].Contains("0")) r = new Road(0);
                    if (smap[x, y].Contains("1")) r = new Road(1);
                    if (smap[x, y].Contains("2")) r = new Road(2);
                    if (smap[x, y].Contains("3")) r = new Road(3);
                    if (smap[x, y].Contains("4")) r = new Road(4);
                    if (smap[x, y].Contains("t")) o = new TrafficLight();
                    if (smap[x, y].Contains("q")) o = new RoadSign(0);
                    if (smap[x, y].Contains("w")) o = new RoadSign(1);
                    if (smap[x, y].Contains("e")) o = new RoadSign(2);
                    if (smap[x, y].Contains("h")) o = new PedLine(0);
                    if (smap[x, y].Contains("v")) o = new PedLine(1);
                    if (smap[x, y].Contains("p")) o = new Ped();


                    t = new Tile(r, o);
                    map[y, x] = t;
                }
            }
        }

        public static string[,] smap = new string[,]
        {
            { "   ", "2t ", "0  ", "   ", "   ", "   ", "p  ", "   ", "   ", "   ", "   ", "2t ", "0  ", "   ", "   ", "2  ", "0  ", "   ", "   ", "   "},

            { "3  ", "4  ", "4  ", "3t ", "3  ", "3  ", "3v ", "3  ", "3  ", "3  ", "3e ", "4  ", "4  ", "   ", "   ", "2  ", "0  ", "   ", "   ", "   "},

            { "1 t", "4  ", "4  ", "1e ", "1  ", "1  ", "1v ", "1  ", "1  ", "1  ", "1t ", "4  ", "4  ", "   ", "   ", "2t ", "0q ", "   ", "   ", "   "},

            { "   ", "2t ", "0t ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "2  ", "0t ", "   ", "   ", "4  ", "4  ", "3t ", "3  ", "3  "},

            { "   ", "4  ", "4  ", "3t ", "3  ", "3  ", "3  ", "3  ", "4  ", "   ", "   ", "2  ", "0  ", "   ", "   ", "4  ", "4  ", "1  ", "1  ", "1  "},

            { "   ", "4  ", "4  ", "1w ", "1  ", "1  ", "1  ", "1t ", "4  ", "   ", "   ", "2h ", "0h ", "   ", "   ", "2  ", "0t ", "   ", "   ", "   "},

            { "   ", "2  ", "0t ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "2  ", "0  ", "   ", "   ", "2h ", "0h ", "p  ", "   ", "   "},

            { "   ", "2t ", "0  ", "   ", "   ", "   ", "   ", "   ", "p  ", "   ", "   ", "2t ", "0  ", "   ", "   ", "2  ", "0  ", "   ", "   ", "   "},

            { "3  ", "4  ", "4  ", "3t ", "4  ", "4  ", "3t ", "3  ", "3v ", "3  ", "3  ", "4  ", "4  ", "3t ", "3  ", "4  ", "4  ", "3t ", "3  ", "3  "},

            { "1t ", "4  ", "4  ", "1  ", "4  ", "4  ", "1  ", "1  ", "1v ", "1  ", "1t ", "4  ", "4  ", "1  ", "1t ", "4  ", "4  ", "1  ", "1  ", "1  "},

            { "   ", "   ", "   ", "   ", "2  ", "0t ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "2  ", "0t ", "   ", "   ", "   "},

            { "   ", "   ", "   ", "   ", "2  ", "0  ", "   ", "   ", "4  ", "4  ", "   ", "   ", "   ", "   ", "   ", "2  ", "0  ", "   ", "   ", "   "},

            { "   ", "   ", "   ", "   ", "2t ", "0  ", "   ", "   ", "2t ", "0t ", "   ", "4  ", "3t ", "3  ", "3e ", "4  ", "4  ", "3t ", "3  ", "3  "},

            { "3  ", "4  ", "4  ", "3  ", "4  ", "4  ", "3t ", "3  ", "4  ", "4  ", "   ", "4  ", "1  ", "1  ", "1t ", "4  ", "4  ", "1q ", "1  ", "1  "},

            { "1  ", "4  ", "4  ", "1t ", "4  ", "4  ", "1  ", "1  ", "4  ", "4  ", "   ", "   ", "   ", "   ", "   ", "2  ", "0t ", "   ", "   ", "   "},

            { "   ", "2  ", "0t ", "   ", "2q ", "0t ", "   ", "   ", "2  ", "0  ", "   ", "   ", "   ", "   ", "   ", "2  ", "0  ", "   ", "   ", "   "},

            { "   ", "2  ", "0  ", "   ", "2  ", "0  ", "   ", "   ", "2t ", "0  ", "   ", "   ", "p  ", "   ", "   ", "2t ", "0  ", "   ", "   ", "   "},

            { "3  ", "4  ", "4  ", "   ", "2h ", "0h ", "p  ", "   ", "4  ", "4  ", "3t ", "3  ", "3v ", "3  ", "3w ", "4  ", "4  ", "3t ", "3  ", "3  "},

            { "1t ", "4  ", "4  ", "   ", "2  ", "0  ", "   ", "   ", "4  ", "4  ", "1w ", "1  ", "1v ", "1  ", "1t ", "4  ", "4  ", "1  ", "1  ", "1  "},

            { "   ", "   ", "   ", "   ", "2  ", "0  ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "2  ", "0t ", "   ", "   ", "   "}


        };
    }
}
