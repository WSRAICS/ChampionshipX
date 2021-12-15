using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSkillsX.Tiles
{
    public class Tile
    {
        public Road Road;
        public Obstacle Obstacle;

        public bool HasRoad;
        public bool HasObstacle;

        public Tile(Road road, Obstacle obstacle)
        {
            if (road != null)
            {
                Road = road;
                HasRoad = true;
            }
            else
            {
                Road = null;
                HasRoad = false;
            }

            if (obstacle != null)
            {
                Obstacle = obstacle;
                HasObstacle = true;
            }
            else
            {
                Obstacle = null;
                HasObstacle = false;
            }
            
        }
    }
}
