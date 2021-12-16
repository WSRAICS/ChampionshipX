using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace World_Skills_X
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //"pack://application:,,,/resources/img.png"
        ImageBrush tlImgG = new ImageBrush();
        ImageBrush tlImgR = new ImageBrush();
        ImageBrush roadImg = new ImageBrush();
        ImageBrush cRoadImg = new ImageBrush();
        ImageBrush zbrImgH = new ImageBrush();
        ImageBrush zbrImgV = new ImageBrush();
        ImageBrush blockImg = new ImageBrush();
        ImageBrush hBlockImg = new ImageBrush();
        ImageBrush vBlockImg = new ImageBrush();
        ImageBrush rCarImg = new ImageBrush();
        ImageBrush bCarImg = new ImageBrush();
        ImageBrush truckImg = new ImageBrush();
        ImageBrush vagonImg = new ImageBrush();
        Rectangle trafficL = new Rectangle();
        Rectangle zebra = new Rectangle();
        Rectangle block = new Rectangle();
        Rectangle hBlock = new Rectangle();
        Rectangle vBlock = new Rectangle();
        DispatcherTimer appTimer = new DispatcherTimer();
        DispatcherTimer trafficTimer = new DispatcherTimer();
        int addWorkn, tModeWorkn, itemWorkn, i = 0, iMode = 0, tlC;
        int coordX, coordY;
        ImageBrush[] bMass = new ImageBrush[3];
        string elementName;
        RotateTransform rotV = new RotateTransform();
        RotateTransform rotH = new RotateTransform();
        RotateTransform rotH2 = new RotateTransform();
        RotateTransform rotC = new RotateTransform();
        List<String> ElementList = new List<String>();
        Border selBrd = new Border
        {
            Width = 35,
            Height = 35,
            BorderBrush = Brushes.Red,
            BorderThickness = new Thickness(1,1,1,1)
        };
        public MainWindow()
        {
            InitializeComponent();
            tlImgG.ImageSource = new BitmapImage(new Uri("pack://application:,,,/resources/TLgreen.png"));
            tlImgR.ImageSource = new BitmapImage(new Uri("pack://application:,,,/resources/TLgreen.png"));
            roadImg.ImageSource = new BitmapImage(new Uri("pack://application:,,,/resources/Rvertical.png"));
            cRoadImg.ImageSource = new BitmapImage(new Uri("pack://application:,,,/resources/Rcrossroads.png"));
            zbrImgH.ImageSource = new BitmapImage(new Uri("pack://application:,,,/resources/Zhorizontal.png"));
            zbrImgV.ImageSource = new BitmapImage(new Uri("pack://application:,,,/resources/Zvertical.png"));
            blockImg.ImageSource = new BitmapImage(new Uri("pack://application:,,,/resources/block.png"));
            hBlockImg.ImageSource = new BitmapImage(new Uri("pack://application:,,,/resources/HeavyBlock2.png"));
            vBlockImg.ImageSource = new BitmapImage(new Uri("pack://application:,,,/resources/VagonBlock.png"));
            rCarImg.ImageSource = new BitmapImage(new Uri("pack://application:,,,/resources/Cvertical.png"));
            bCarImg.ImageSource = new BitmapImage(new Uri("pack://application:,,,/resources/BCvertical.png"));
            truckImg.ImageSource = new BitmapImage(new Uri("pack://application:,,,/resources/Truck.png"));
            vagonImg.ImageSource = new BitmapImage(new Uri("pack://application:,,,/resources/Trailer.png"));
            appTimer.Interval = TimeSpan.FromMilliseconds(10);
            appTimer.Tick += AppTimerEvent;
            appTimer.Start();
            trafficTimer.Interval = TimeSpan.FromSeconds(5);
            trafficTimer.Tick += TrafficWork;
            trafficTimer.Start();
            bMass[0] = blockImg;
            bMass[1] = hBlockImg;
            bMass[2] = vBlockImg;
            for (int m = 0; m < 20; m++)
            {
                for (int k = 0; k < 20; k++)
                {
                    Rectangle empt = new Rectangle
                    {
                        Width = 35,
                        Height = 35,
                        Stroke = Brushes.Black,
                        StrokeThickness = 1,
                        Tag = "Empty"
                    };
                    empt.MouseEnter += Elt_MouseEnter;
                    Canvas.SetLeft(empt, 10 + empt.Width * m);
                    Canvas.SetTop(empt, 10 + empt.Height * k);
                    empt.Name = $"emptyL{Canvas.GetLeft(empt)}L{Canvas.GetTop(empt)}L";
                    mCanv.Children.Add(empt);
                }
            }
            VertRoad(35, 0, 1);
            VertRoad(35, 105, 1);
            VertRoad(35, 210, 2);
            VertRoad(385, 0, 1);
            VertRoad(385, 105, 5);
            VertRoad(525, 0, 3);
            VertRoad(525, 175, 3);
            VertRoad(525, 350, 2);
            VertRoad(525, 490, 3);
            VertRoad(525, 665, 1);
            VertRoad(140, 350, 3);
            VertRoad(140, 525, 5);
            VertRoad(35, 525, 2);
            VertRoad(280, 420, 1);
            VertRoad(280, 525, 2);
            HorzRoad(0, 35, 1);
            HorzRoad(0, 280, 1);
            HorzRoad(0, 455, 1);
            HorzRoad(0, 595, 1);
            HorzRoad(105, 455, 1);
            HorzRoad(210, 455, 2);
            HorzRoad(350, 595, 5);
            HorzRoad(105, 280, 1);
            HorzRoad(210, 280, 5);
            HorzRoad(105, 35, 8);
            HorzRoad(105, 140, 5);
            HorzRoad(595, 105, 3);
            HorzRoad(595, 280, 3);
            HorzRoad(455, 280, 2);
            HorzRoad(595, 420, 3);
            HorzRoad(420, 420, 3);
            HorzRoad(595, 595, 3);
            CrossRoad(35, 35);
            CrossRoad(35, 140);
            CrossRoad(35, 280);
            CrossRoad(140, 280);
            CrossRoad(385, 280);
            CrossRoad(385, 35);
            CrossRoad(525, 105);
            CrossRoad(525, 280);
            CrossRoad(35, 455);
            CrossRoad(140, 455);
            CrossRoad(280, 455);
            CrossRoad(35, 595);
            CrossRoad(280, 595);
            CrossRoad(525, 420);
            CrossRoad(525, 595);
            VHalfRoad(280, 140);
            VHalfRoad(385, 420);
            HHalfRoad(280, 385);
            Traffic(35, 35*0);
            Traffic(35*0, 35*2);
            Traffic(35, 35*3);
            Traffic(35*2, 35*3);
            Traffic(35*3, 35);
            Traffic(35*10, 35*2);
            Traffic(35*11, 35*0);
            Traffic(35*3, 35*4);
            Traffic(35*7, 35*5);
            Traffic(35*2, 35*6);
            Traffic(35, 35*7);
            Traffic(35*0, 35*9);
            Traffic(35*3, 35*8);
            Traffic(35*6, 35*8);
            Traffic(35*13, 35*8);
            Traffic(35*17, 35*8);
            Traffic(35*17, 35*3);
            Traffic(35*17, 35*12);
            Traffic(35*5, 35);
            Traffic(35*4, 35*12);
            Traffic(35*3, 35*14);
            Traffic(35*6, 35*13);
            Traffic(35*5, 35*15);
            Traffic(35*2, 35*15);
            Traffic(35*0, 35*18);
            Traffic(35*8, 35*12);
            Traffic(35*9, 35*12);
            Traffic(35*8, 35*16);
        }
        void TrafficWork(object sender, EventArgs e)
        {
            tlC += 1;
            foreach(var tl in mCanv.Children.OfType<Rectangle>())
            {
                if ((string)tl.Tag == "TrafficL")
                {
                    switch (tlC % 2)
                    {
                        case 0:
                            tl.Fill = tlImgG;
                            break;
                        case 1:
                            tl.Fill = tlImgR;
                            break;
                    }
                }
            }
            if (tlC >= 3)
                tlC = 0;
        }
        void VertRoad(int x, int y, int dln)
        {
            for (int k = 0; k < dln; k++)
            {
                Rectangle road = new Rectangle
                {
                    Width = 35,
                    Height = 35,
                    Tag = "Road"
                };
                road.Fill = roadImg;
                Canvas.SetLeft(road, x + 10 + 35);
                Canvas.SetTop(road, y + 10 + (35 * k));
                road.Name = $"roadL{Canvas.GetLeft(road)}L{Canvas.GetTop(road)}L";
                road.MouseEnter += Elt_MouseEnter;
                mCanv.Children.Add(road);
            }
            for (int k = 0; k < dln; k++)
            {
                Rectangle road = new Rectangle
                {
                    Width = 35,
                    Height = 35,
                    Tag = "Road"
                };
                rotV.Angle = 180;
                rotV.CenterX = road.Width / 2;
                rotV.CenterY = road.Height / 2;
                road.RenderTransform = rotV;
                road.Fill = roadImg;
                Canvas.SetLeft(road, x + 10);
                Canvas.SetTop(road, y + 10 + (35 * k));
                road.Name = $"roadL{Canvas.GetLeft(road)}L{Canvas.GetTop(road)}L";
                road.MouseEnter += Elt_MouseEnter;
                mCanv.Children.Add(road);
            }
        }
        void HorzRoad(int x, int y, int dln)
        {
            for (int k = 0; k < dln; k++)
            {
                Rectangle road = new Rectangle
                {
                    Width = 35,
                    Height = 35,
                    Tag = "Road"
                };
                road.Fill = roadImg;
                rotH.Angle = 90;
                rotH.CenterX = road.Width / 2;
                rotH.CenterY = road.Height / 2;
                road.RenderTransform = rotH;
                Canvas.SetLeft(road, x + 10 + (35 * k));
                Canvas.SetTop(road, y + 10 + 35);
                road.Name = $"roadL{Canvas.GetLeft(road)}L{Canvas.GetTop(road)}L";
                road.MouseEnter += Elt_MouseEnter;
                mCanv.Children.Add(road);
            }
            for (int k = 0; k < dln; k++)
            {
                Rectangle road = new Rectangle
                {
                    Width = 35,
                    Height = 35,
                    Tag = "Road"
                };
                rotH2.Angle = 270;
                rotH2.CenterX = road.Width / 2;
                rotH2.CenterY = road.Height / 2;
                road.RenderTransform = rotH2;
                road.Fill = roadImg;
                Canvas.SetLeft(road, x + 10 + (35 * k));
                Canvas.SetTop(road, y + 10);
                road.Name = $"roadL{Canvas.GetLeft(road)}L{Canvas.GetTop(road)}L";
                road.MouseEnter += Elt_MouseEnter;
                mCanv.Children.Add(road);
            }
        }
        void CrossRoad(int x, int y)
        {
            for (int k = 0; k < 2; k++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Rectangle croad = new Rectangle
                    {
                        Width = 35,
                        Height = 35,
                        Tag = "crossRoad"
                    };
                    croad.Fill = cRoadImg;
                    Canvas.SetLeft(croad, x + 10 + (35 * k));
                    Canvas.SetTop(croad, y + 10 + (35 * j));
                    croad.Name = $"сroadL{Canvas.GetLeft(croad)}L{Canvas.GetTop(croad)}L";
                    croad.MouseEnter += Elt_MouseEnter;
                    mCanv.Children.Add(croad);
                }
            }
            
        }
        void VHalfRoad(int x, int y)
        {
            for (int k = 0; k < 2; k++)
            {
                Rectangle road = new Rectangle
                {
                    Width = 35,
                    Height = 35,
                    Tag = "crossRoad"
                };
                road.Fill = cRoadImg;
                Canvas.SetLeft(road, x + 10);
                Canvas.SetTop(road, y + 10 + (35 * k));
                road.Name = $"сroadL{Canvas.GetLeft(road)}L{Canvas.GetTop(road)}L";
                road.MouseEnter += Elt_MouseEnter;
                mCanv.Children.Add(road);
            }
        }
        void HHalfRoad(int x, int y)
        {
            for (int k = 0; k < 2; k++)
            {
                Rectangle road = new Rectangle
                {
                    Width = 35,
                    Height = 35,
                    Tag = "crossRoad"
                };
                road.Fill = cRoadImg;
                Canvas.SetLeft(road, x + 10 + (35 * k));
                Canvas.SetTop(road, y + 10);
                road.Name = $"сroadL{Canvas.GetLeft(road)}L{Canvas.GetTop(road)}L";
                road.MouseEnter += Elt_MouseEnter;
                mCanv.Children.Add(road);
            }
        }
        private void Elt_MouseEnter(object sender, MouseEventArgs e)
        {
            Rectangle r = sender as Rectangle;
            coord.Content = r.Name + r.Tag;
        }

        private void RmObj_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TlModeT_Click(object sender, RoutedEventArgs e)
        {
            tModeWorkn = 0;
            lbTlMode.Content = "По времени";
            
        }

        private void TlModeC_Click(object sender, RoutedEventArgs e)
        {
            tModeWorkn = 0;
            lbTlMode.Content = "По транспорту";
        }

        private void TlMode_Click(object sender, RoutedEventArgs e)
        {
            tModeWorkn = 1;
        }

        private void AddTl_Click(object sender, RoutedEventArgs e)
        {
            addWorkn = 0;
            itemWorkn = 1;
            mCanv.MouseLeftButtonDown += AddTl;
        }

        private void AppTimerEvent(object sender, EventArgs e)
        {
            mCanv.Focus();
            if (i >= 360 || i <= -360)
                i = 0;
            if (addWorkn == 1)
            {
                addObj.Visibility = rmObj.Visibility = Visibility.Hidden;
                addBrd.Visibility = addTl.Visibility = addZbr.Visibility = addPsr.Visibility = addRdb.Visibility = cX.Visibility = Visibility.Visible;
            }
            else
            {
                addObj.Visibility = rmObj.Visibility = Visibility.Visible;
                addBrd.Visibility = addTl.Visibility = addZbr.Visibility = addPsr.Visibility = addRdb.Visibility = cX.Visibility = Visibility.Hidden;
            }
            if (tModeWorkn == 1)
            {
                tlMode.Visibility = Visibility.Hidden;
                tlModeT.Visibility = tlModeC.Visibility = tlModeStd.Visibility = Visibility.Visible;
            }
            else
            {
                tlMode.Visibility = Visibility.Visible;
                tlModeT.Visibility = tlModeC.Visibility = tlModeStd.Visibility = Visibility.Hidden;
            }
            if(elementName == "block" || elementName == "hBlock" || elementName == "vBlock")
            if(setBlockC.IsChecked == true)
            {
                setBlockC.IsEnabled = true;
                setBlockH.IsEnabled = setBlockV.IsEnabled = false;
            }else if(setBlockH.IsChecked == true){
                setBlockH.IsEnabled = true;
                setBlockC.IsEnabled = setBlockV.IsEnabled = false;
            }else if(setBlockV.IsChecked == true)
            {
                setBlockV.IsEnabled = true;
                setBlockC.IsEnabled = setBlockH.IsEnabled = false;
            }
            else
            {
                setBlockC.IsEnabled = setBlockH.IsEnabled = setBlockV.IsEnabled = false;
            }
        }

        private void AddZbr_Click(object sender, RoutedEventArgs e)
        {
            addWorkn = 0;
            mCanv.MouseLeftButtonDown += AddZbr;
        }

        private void Rotator(object sender, RoutedEventArgs e)
        {
            foreach (var dx in mCanv.Children.OfType<Rectangle>())
            {
                if (dx.Name == elementName)
                {
                    if (dx.Fill == zbrImgH)
                        dx.Fill = zbrImgV;
                    else
                        dx.Fill = zbrImgH;
                }
            }
        }

        private void AddRdb_Click(object sender, RoutedEventArgs e)
        {
            //foreach (var dx in mCanv.Children.OfType<Rectangle>())
            //{
            //    if (dx.Name == elementName)
            //    {
            //        if (setBlockC.IsChecked == true)
            //            dx.Fill = blockImg;
            //        else if (setBlockH.IsChecked == true)
            //            dx.Fill = hBlockImg;
            //        else if (setBlockV.IsChecked == true)
            //            dx.Fill = vBlockImg;
            //        else
            //            dx.Fill = blockImg;
            //    }
            //}
            mCanv.MouseLeftButtonDown += Blocker;
        }
        void Blockn(int x, int y, int ind)
        {
            trafficL = new Rectangle
            {
                Width = 35,
                Height = 35,
                Tag = "TrafficL"
            };
            Canvas.SetLeft(trafficL, x + 10);
            Canvas.SetTop(trafficL, y + 10);
            trafficL.Fill = bMass[ind];
            trafficL.Name = $"trafficL{Canvas.GetLeft(trafficL)}L{Canvas.GetTop(trafficL)}L";
            trafficL.MouseEnter += Elt_MouseEnter;
            trafficL.MouseRightButtonDown += ElementSelect;
            ElementList.Add(trafficL.Name);
            mCanv.Children.Add(trafficL);
        }
        void Blocker(object sender, RoutedEventArgs blk)
        {
            coordX = Convert.ToInt32(Mouse.GetPosition(mCanv).X);
            coordY = Convert.ToInt32(Mouse.GetPosition(mCanv).Y);
            while (coordX % 35 != 0)
                coordX -= 1;
            while (coordY % 35 != 0)
                coordY -= 1;
            bool leF = false, crossNrb = false;
            foreach (var kl in mCanv.Children.OfType<Rectangle>())
            {
                if ((string)kl.Tag == "crossRoad")
                {
                    if (Canvas.GetLeft(kl) == coordX - 25 || Canvas.GetLeft(kl) == coordX + 45 || Canvas.GetTop(kl) == coordY + 45 || Canvas.GetTop(kl) == coordY - 25)
                    {
                        crossNrb = true;
                    }
                }
                if ((string)kl.Tag == "Road")
                {
                    if (Canvas.GetLeft(kl) == coordX + 10 && Canvas.GetTop(kl) == coordY + 10)
                    {
                        leF = true;
                        trafficL = new Rectangle
                        {
                            Width = 35,
                            Height = 35,
                            Tag = "TrafficL"
                        };
                        Canvas.SetLeft(trafficL, coordX + 10);
                        Canvas.SetTop(trafficL, coordY + 10);
                        trafficL.Fill = tlImgG;
                        trafficL.Name = $"trafficL{Canvas.GetLeft(trafficL)}L{Canvas.GetTop(trafficL)}L";
                        trafficL.MouseEnter += Elt_MouseEnter;
                        trafficL.MouseRightButtonDown += ElementSelect;
                        if (leF == true && crossNrb == true)
                        {
                            foreach (string le in ElementList)
                            {
                                if (le != trafficL.Name && le != zebra.Name)
                                    ElementList.Add(trafficL.Name);
                                else
                                    leF = crossNrb = false;
                            }
                        }
                    }
                }
            }
            if (leF == true && crossNrb == true)
                mCanv.Children.Add(block);
            mCanv.MouseLeftButtonDown -= Blocker;
        }
        private void AddObj_Click(object sender, RoutedEventArgs e)
        {
            addWorkn = 1;
        }

        private void MvFwd(object sender, RoutedEventArgs r)
        {
            
        }

        private void ElementSelect(object sender, RoutedEventArgs r)
        {
            Rectangle e = sender as Rectangle;
            string tag = (string)e.Tag;
            if(iMode == 0)
            {
                elementName = e.Name;
                Canvas.SetLeft(selBrd, Canvas.GetLeft(e));
                Canvas.SetTop(selBrd, Canvas.GetTop(e));
                mCanv.Children.Add(selBrd);
                switch (tag)
                {
                    case "TrafficL":
                        settingsBrd.Visibility = settingsLb.Visibility = Visibility.Visible;
                        settingsLb.Content = "Свойства объекта: TrafficL";
                        break;
                    case "Zebra":
                        settingsBrd.Visibility = zbrSet.Visibility = settingsLb.Visibility = Visibility.Visible;
                        settingsLb.Content = "Свойства объекта: Zebra";
                        break;
                    case "Block":
                        settingsBrd.Visibility = setBlockC.Visibility = setBlockH.Visibility = setBlockV.Visibility = settingsLb.Visibility = Visibility.Visible;
                        setBlockC.IsChecked = true;
                        setBlockH.IsChecked = false;
                        setBlockV.IsChecked = false;
                        settingsLb.Content = "Свойства объекта: Block";
                        break;
                    case "hBlock":
                        settingsBrd.Visibility = settingsLb.Visibility = Visibility.Visible;
                        setBlockC.IsChecked = false;
                        setBlockH.IsChecked = true;
                        setBlockV.IsChecked = false;
                        settingsLb.Content = "Свойства объекта: hBlock";
                        break;
                    case "vBlock":
                        settingsBrd.Visibility = settingsLb.Visibility = Visibility.Visible;
                        setBlockC.IsChecked = false;
                        setBlockH.IsChecked = false;
                        setBlockV.IsChecked = true;
                        settingsLb.Content = "Свойства объекта: vBlock";
                        break;
                    case "Pedestrian":
                        settingsBrd.Visibility = settingsLb.Visibility = Visibility.Visible;
                        settingsLb.Content = "Свойства объекта: Pedestrian";
                        break;
                }
                iMode = 1;
            }
            else
            {
                elementName = null;
                switch (tag)
                {
                    case "TrafficL":
                        settingsBrd.Visibility = zbrSet.Visibility = settingsLb.Visibility = Visibility.Hidden;
                        break;
                    case "Zebra":
                        settingsBrd.Visibility = zbrSet.Visibility = settingsLb.Visibility = Visibility.Hidden;
                        break;
                }
                mCanv.Children.Remove(selBrd);
                iMode = 0;
            }
            
            
            itemWorkn = 1;
        }
        void Traffic(int x, int y)
        {
            trafficL = new Rectangle
            {
                Width = 35,
                Height = 35,
                Tag = "TrafficL"
            };
            Canvas.SetLeft(trafficL, x + 10);
            Canvas.SetTop(trafficL, y + 10);
            trafficL.Fill = tlImgG;
            trafficL.Name = $"trafficL{Canvas.GetLeft(trafficL)}L{Canvas.GetTop(trafficL)}L";
            trafficL.MouseEnter += Elt_MouseEnter;
            trafficL.MouseRightButtonDown += ElementSelect;
            ElementList.Add(trafficL.Name);
            mCanv.Children.Add(trafficL);
        }
        private void AddTl(object sender, RoutedEventArgs e)
        {
            if(itemWorkn == 1)
            {
                coordX = Convert.ToInt32(Mouse.GetPosition(mCanv).X);
                coordY = Convert.ToInt32(Mouse.GetPosition(mCanv).Y);
            }
            while (coordX % 35 != 0)
                coordX -= 1;
            while (coordY % 35 != 0)
                coordY -= 1;
            bool leF = false, crossNrb = false;
            foreach (var kl in mCanv.Children.OfType<Rectangle>())
            {
                if((string)kl.Tag == "crossRoad")
                {
                    if (Canvas.GetLeft(kl) == coordX - 25 || Canvas.GetLeft(kl) == coordX + 45 || Canvas.GetTop(kl) == coordY + 45 || Canvas.GetTop(kl) == coordY - 25)
                    {
                        crossNrb = true;
                    }
                }
                if((string)kl.Tag == "Road")
                {
                    if (Canvas.GetLeft(kl) == coordX + 10 && Canvas.GetTop(kl) == coordY + 10)
                    {
                        leF = true;
                        trafficL = new Rectangle
                        {
                            Width = 35,
                            Height = 35,
                            Tag = "TrafficL"
                        };
                        Canvas.SetLeft(trafficL, coordX + 10);
                        Canvas.SetTop(trafficL, coordY + 10);
                        trafficL.Fill = tlImgG;
                        trafficL.Name = $"trafficL{Canvas.GetLeft(trafficL)}L{Canvas.GetTop(trafficL)}L";
                        trafficL.MouseEnter += Elt_MouseEnter;
                        trafficL.MouseRightButtonDown += ElementSelect;
                        if (leF == true && crossNrb == true)
                        {
                            foreach(string le in ElementList)
                            {
                                if (le != trafficL.Name && le != zebra.Name)
                                    ElementList.Add(trafficL.Name);
                                else
                                    leF = crossNrb = false;
                            }
                        }
                    }
                }
            }
            if (leF == true && crossNrb == true)
                mCanv.Children.Add(trafficL);
            itemWorkn = 0;
            mCanv.MouseLeftButtonDown -= AddTl;
        }
        private void AddZbr(object sender, RoutedEventArgs e)
        {
            coordX = Convert.ToInt32(Mouse.GetPosition(mCanv).X);
            coordY = Convert.ToInt32(Mouse.GetPosition(mCanv).Y);
            while (coordX % 35 != 0)
                coordX -= 1;
            while (coordY % 35 != 0)
                coordY -= 1;
            bool leF = false;
            foreach (var kl in mCanv.Children.OfType<Rectangle>())
            {
                if ((string)kl.Tag == "Road")
                {
                    if (Canvas.GetLeft(kl) == coordX + 10 && Canvas.GetTop(kl) == coordY + 10)
                    {
                        leF = true;
                        zebra = new Rectangle
                        {
                            Width = 35,
                            Height = 35,
                            Tag = "Zebra"
                        };
                        Canvas.SetLeft(zebra, coordX + 10);
                        Canvas.SetTop(zebra, coordY + 10);
                        zebra.Fill = zbrImgH;
                        zebra.Name = $"zebraL{Canvas.GetLeft(zebra)}L{Canvas.GetTop(zebra)}L";
                        zebra.MouseEnter += Elt_MouseEnter;
                        zebra.MouseRightButtonDown += ElementSelect;
                        if (leF == true)
                        {
                            foreach (string le in ElementList)
                            {
                                if (le != zebra.Name)
                                    ElementList.Add(zebra.Name);
                                else
                                    leF = false;
                            }
                        }
                    }
                }
            }
            if (leF == true)
                mCanv.Children.Add(zebra);
            mCanv.MouseLeftButtonDown -= AddZbr;
        }
        private void CX_Click(object sender, RoutedEventArgs e)
        {
            addWorkn = 0;
        }
    }
}
