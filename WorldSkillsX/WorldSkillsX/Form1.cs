using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldSkillsX.Tiles;

namespace WorldSkillsX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int mapWidth = 20;
        int tileWidth = 35;

        Point selectedTile = new Point(-1,-1);
        bool selectionActive = false;

        string tool = "`";
        bool objIsBeingAdded = false;

        Pen selectionPen = new Pen(Brushes.Red, 3);

        private void Form1_Load(object sender, EventArgs e)
        {
            Data.Init();
            int mapWidth = Data.mapWidth;
            int tileWidth = Data.tileWidth;
        }

        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {
            selectionActive = false;
            remObjBtn.Enabled = false;
            pedSetBox.Visible = false;
            rsSetBox.Visible = false;

            Point p = e.Location;
            var tilecoords = new Point(p.X / tileWidth, p.Y / tileWidth);

            if ((tilecoords.X > 19 || tilecoords.X < 0) || (tilecoords.Y > 19 || tilecoords.Y < 0))
            {
                selectionActive = false;
                return;
            }

            toolsBox.Visible = false;

            var tile = Data.map[tilecoords.X, tilecoords.Y];


            if (tile.HasObstacle)
            {
                selectedTile = tilecoords;
                selectionActive = true;
                remObjBtn.Enabled = true;

                if (tile.Obstacle.ObstacleType == "ped")
                {
                    pedSetBox.Visible = true;
                    pedTimerLabel.Text = (Data.map[selectedTile.X, selectedTile.Y].Obstacle as Ped).getTime();
                }
                else if (tile.Obstacle.ObstacleType == "rs")
                {
                    rsSetBox.Visible = true;
                    switch (tile.Obstacle.Type)
                    {
                        case 0:
                            rsAllRadio.Checked = true;
                            break;
                        case 1:
                            rsHeavyRadio.Checked = true;
                            break;
                        case 2:
                            rsVagonRadio.Checked = true;
                            break;
                        default:
                            rsAllRadio.Checked = true;
                            break;
                    }
                }
            }
            else
            {
                /*selectionActive = false;
                remObjBtn.Enabled = false;
                pedSetBox.Visible = false;
                rsSetBox.Visible = false;*/

                #region objadd
                if (objIsBeingAdded)
                {
                    switch (tool)
                    {
                        case "tl":
                            if (tile.HasRoad)
                            {
                                switch (tile.Road.Type)
                                {
                                    case 0:
                                        if (tilecoords.Y - 1 >= 0)
                                        {
                                            var nexttile = Data.map[tilecoords.X, tilecoords.Y - 1];
                                            if (nexttile.HasRoad)
                                            {
                                                if (nexttile.Road.Type == 4)
                                                {
                                                    Data.map[tilecoords.X, tilecoords.Y].Obstacle = new TrafficLight();
                                                    Data.map[tilecoords.X, tilecoords.Y].HasObstacle = true;
                                                }
                                            }
                                        }
                                        break;
                                    case 1:
                                        if (tilecoords.X + 1 <= 19)
                                        {
                                            var nexttile = Data.map[tilecoords.X + 1, tilecoords.Y];
                                            if (nexttile.HasRoad)
                                            {
                                                if (nexttile.Road.Type == 4)
                                                {
                                                    Data.map[tilecoords.X, tilecoords.Y].Obstacle = new TrafficLight();
                                                    Data.map[tilecoords.X, tilecoords.Y].HasObstacle = true;
                                                }
                                            }
                                        }
                                        break;
                                    case 2:
                                        if (tilecoords.Y + 1 <= 19)
                                        {
                                            var nexttile = Data.map[tilecoords.X, tilecoords.Y + 1];
                                            if (nexttile.HasRoad)
                                            {
                                                if (nexttile.Road.Type == 4)
                                                {
                                                    Data.map[tilecoords.X, tilecoords.Y].Obstacle = new TrafficLight();
                                                    Data.map[tilecoords.X, tilecoords.Y].HasObstacle = true;
                                                }
                                            }
                                        }
                                        break;
                                    case 3:
                                        if (tilecoords.X - 1 >= 0)
                                        {
                                            var nexttile = Data.map[tilecoords.X - 1, tilecoords.Y];
                                            if (nexttile.HasRoad)
                                            {
                                                if (nexttile.Road.Type == 4)
                                                {
                                                    Data.map[tilecoords.X, tilecoords.Y].Obstacle = new TrafficLight();
                                                    Data.map[tilecoords.X, tilecoords.Y].HasObstacle = true;
                                                }
                                            }
                                        }
                                        break;
                                    default:
                                        break;
                                }
                            }
                            break;
                        case "ped":
                            if (!tile.HasRoad)
                            {
                                bool canplace = false;
                                Tile nexttile;

                                if (tilecoords.X + 1 <= 19)
                                {
                                    nexttile = Data.map[tilecoords.X + 1, tilecoords.Y];
                                    if (nexttile.HasObstacle && nexttile.Obstacle.ObstacleType == "pl")
                                    {
                                        canplace = true;
                                    }
                                }


                                if (tilecoords.X - 1 >= 0)
                                {
                                    nexttile = Data.map[tilecoords.X - 1, tilecoords.Y];
                                    if (nexttile.HasObstacle && nexttile.Obstacle.ObstacleType == "pl")
                                    {
                                        canplace = true;
                                    }
                                }


                                if (tilecoords.Y + 1 <= 19)
                                {
                                    nexttile = Data.map[tilecoords.X, tilecoords.Y + 1];
                                    if (nexttile.HasObstacle && nexttile.Obstacle.ObstacleType == "pl")
                                    {
                                        canplace = true;
                                    }
                                }

                                if (tilecoords.Y - 1 >= 0)
                                {
                                    nexttile = Data.map[tilecoords.X, tilecoords.Y - 1];
                                    if (nexttile.HasObstacle && nexttile.Obstacle.ObstacleType == "pl")
                                    {
                                        canplace = true;
                                    }
                                }

                                if (canplace)
                                {
                                    Data.map[tilecoords.X, tilecoords.Y].Obstacle = new Ped();
                                    Data.map[tilecoords.X, tilecoords.Y].HasObstacle = true;
                                }
                            }
                            break;
                        case "pl":
                            if (tile.HasRoad)
                            {
                                if (tile.Road.Type == 1 || tile.Road.Type == 3)
                                {
                                    Data.map[tilecoords.X, tilecoords.Y].Obstacle = new PedLine(1);
                                    Data.map[tilecoords.X, tilecoords.Y].HasObstacle = true;
                                }
                                else if (tile.Road.Type == 0 || tile.Road.Type == 2)
                                {
                                    Data.map[tilecoords.X, tilecoords.Y].Obstacle = new PedLine(0);
                                    Data.map[tilecoords.X, tilecoords.Y].HasObstacle = true;
                                }
                            }
                            break;
                        case "rs":
                            if (tile.HasRoad)
                            {
                                if (tile.Road.Type != 4)
                                {
                                    Data.map[tilecoords.X, tilecoords.Y].Obstacle = new RoadSign(0);
                                    Data.map[tilecoords.X, tilecoords.Y].HasObstacle = true;
                                }
                            }
                            break;
                    }
                }
                #endregion
            }
            objIsBeingAdded = false;

        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            Point p = e.Location;
            var p2 = new Point(p.X / tileWidth, p.Y / tileWidth);
            coordsLabel.Text = p2.ToString();
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            for (int y = 0; y < mapWidth; y++)
            {
                for (int x = 0; x < mapWidth; x++)
                {
                    var tile = Data.map[x, y];
                    if (tile.HasRoad) g.DrawImage(tile.Road.Image, getRect(x, y));
                    if (tile.HasObstacle) g.DrawImage(tile.Obstacle.Image, getRect(x, y));

                    g.DrawRectangle(Pens.Black, getRect(x, y));
                }
            }

            if (selectionActive)
            {
                g.DrawRectangle(selectionPen, getRect(selectedTile));
            }
        }

        private void RenderingTimer_Tick(object sender, EventArgs e)
        {
            canvas.Refresh();
        }


        #region helpers
        private Rectangle getRect(int x, int y)
        {
            return new Rectangle(x * tileWidth, y * tileWidth, tileWidth, tileWidth);
        }
        private Rectangle getRect(Point p)
        {
            return new Rectangle(p.X * tileWidth, p.Y * tileWidth, tileWidth, tileWidth);
        }
        #endregion

        #region mapRedactor
        private void addObjBtn_Click(object sender, EventArgs e)
        {
            toolsBox.Visible = true;
            objIsBeingAdded = true;
        }

        private void tlToolBtn_Click(object sender, EventArgs e)
        {
            tool = "tl";
        }

        private void plToolBtn_Click(object sender, EventArgs e)
        {
            tool = "pl";
        }

        private void pedToolBtn_Click(object sender, EventArgs e)
        {
            tool = "ped";
        }

        private void rsToolBtn_Click(object sender, EventArgs e)
        {
            tool = "rs";
        }

        private void remObjBtn_Click(object sender, EventArgs e)
        {
            if (selectionActive)
            {
                Data.map[selectedTile.X, selectedTile.Y].Obstacle = null;
                Data.map[selectedTile.X, selectedTile.Y].HasObstacle = false;
                selectionActive = false;
                remObjBtn.Enabled = false;
                pedSetBox.Visible = false;
                rsSetBox.Visible = false;
            }
        }

        #endregion


        #region pedSettings
        private void pedTimerPlusBtn_Click(object sender, EventArgs e)
        {
            if (Data.map[selectedTile.X, selectedTile.Y].HasObstacle && Data.map[selectedTile.X, selectedTile.Y].Obstacle.ObstacleType == "ped")
            {
                (Data.map[selectedTile.X, selectedTile.Y].Obstacle as Ped).addTime(1000);
                pedTimerLabel.Text = (Data.map[selectedTile.X, selectedTile.Y].Obstacle as Ped).getTime();
            }
        }

        private void pedTimerMinusBtn_Click(object sender, EventArgs e)
        {
            if (Data.map[selectedTile.X, selectedTile.Y].HasObstacle && Data.map[selectedTile.X, selectedTile.Y].Obstacle.ObstacleType == "ped")
            {
                (Data.map[selectedTile.X, selectedTile.Y].Obstacle as Ped).addTime(-1000);
                pedTimerLabel.Text = (Data.map[selectedTile.X, selectedTile.Y].Obstacle as Ped).getTime();
            }
        }
        #endregion

        #region rsSettings
        private void rsAllRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (rsAllRadio.Checked && Data.map[selectedTile.X, selectedTile.Y].HasObstacle && Data.map[selectedTile.X, selectedTile.Y].Obstacle.ObstacleType == "rs")
            {
                (Data.map[selectedTile.X, selectedTile.Y].Obstacle as RoadSign).ChangeType(0);
            }
        }

        private void rsVagonRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (rsVagonRadio.Checked && Data.map[selectedTile.X, selectedTile.Y].HasObstacle && Data.map[selectedTile.X, selectedTile.Y].Obstacle.ObstacleType == "rs")
            {
                (Data.map[selectedTile.X, selectedTile.Y].Obstacle as RoadSign).ChangeType(2);
            }
        }

        private void rsHeavyRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (rsHeavyRadio.Checked && Data.map[selectedTile.X, selectedTile.Y].HasObstacle && Data.map[selectedTile.X, selectedTile.Y].Obstacle.ObstacleType == "rs")
            {
                (Data.map[selectedTile.X, selectedTile.Y].Obstacle as RoadSign).ChangeType(1);
            }
        }
        #endregion
    }
}
