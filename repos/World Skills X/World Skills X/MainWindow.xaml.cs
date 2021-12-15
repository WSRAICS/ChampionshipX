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
        ImageBrush tlImg = new ImageBrush();
        
        DispatcherTimer appTimer = new DispatcherTimer();
        int addWorkn, itemWorkn, i = 0, iMode = 0, count;
        double coordX, coordY, nearbyCX, nearbyCY;
        RotateTransform rot = new RotateTransform();
        Border selBrd = new Border
        {
            Width = 35,
            Height = 35,
            BorderBrush = Brushes.Black
        };
        public MainWindow()
        {
            InitializeComponent();
            tlImg.ImageSource = new BitmapImage(new Uri("pack://application:,,,/resources/TLgreen.png"));
            appTimer.Tick += AppTimerEvent;
            appTimer.Interval = TimeSpan.FromMilliseconds(100);
            appTimer.Start();
            rot.Angle = i;
            //for (int m = 0; m < 20; m++)
            //{
            //    for (int k = 0; k < 20; k++)
            //    {
            //        Rectangle empt = new Rectangle
            //        {
            //            Name = "empt_" + m + "_" + k,
            //            Width = 35,
            //            Height = 35,
            //            Stroke = Brushes.Black,
            //            StrokeThickness = 1,
            //            Tag = "Empty_" + m + "_" + k
            //        };
            //        //empt.MouseEnter += Empt_MouseEnter;
            //        Canvas.SetLeft(empt, 10 + empt.Width * m);
            //        Canvas.SetTop(empt, 10 + empt.Height * k);
            //        mCanv.Children.Add(empt);
            //    }
            //}
            //foreach(var y in mCanv.Children.OfType<Rectangle>())
            //{
            //    MouseLeftButtonDown += Item_Click;
            //}
            count = mCanv.Children.Count;
            MessageBox.Show(count.ToString());
        }

        private void Empt_MouseEnter(object sender, MouseEventArgs e)
        {
            //for (int m = 0; m < 20; m++)
            //{
            //    for (int k = 0; k < 20; k++)
            //    {
            //        foreach (var x in mCanv.Children.OfType<Rectangle>())
            //        {
            //            if ((string)x.Tag == "Empty_" + m + "_" + k)
            //            {
            //                coordX = Canvas.GetLeft(x);
            //                coordY = Canvas.GetTop(x);
            //            }
            //            else
            //            {
            //                coordX = 0;
            //                coordY = 0;
            //            }
            //        }
            //    }
            //}
        }

        private void AddTl_Click(object sender, RoutedEventArgs e)
        {
            if (itemWorkn == 1)
                mCanv.MouseLeftButtonDown += AddTl;
        }

        private void AppTimerEvent(object sender, EventArgs e)
        {
            mCanv.Focus();
            if (i >= 360 || i <= -360)
                i = 0;
            coord.Content = "X: " + coordX + "; Y: " + coordY;
            if (addWorkn == 1)
            {
                addObj.Visibility = Visibility.Hidden;
                addBrd.Visibility = addTl.Visibility = addZbr.Visibility = addPsr.Visibility = addRdb.Visibility = cX.Visibility = Visibility.Visible;
            }
            else
            {
                addObj.Visibility = Visibility.Visible;
                addBrd.Visibility = addTl.Visibility = addZbr.Visibility = addPsr.Visibility = addRdb.Visibility = cX.Visibility = Visibility.Hidden;
            }
            coordX = Mouse.GetPosition(mCanv).X;
            coordY = Mouse.GetPosition(mCanv).Y;
            //for (int m = 0; m < 20; m++)
            //{
            //    for (int k = 0; k < 20; k++)
            //    {
            //        foreach(var x in mCanv.Children.OfType<Rectangle>())
            //        {
            //            if ((string)x.Tag == "Empty_" + m + "_" + k)
            //            {
            //                coordX = Mouse.GetPosition(x).X;
            //                coordY = Mouse.GetPosition(x).Y;
            //            }
            //        }
            //    }
            //}
        }

        private void AddObj_Click(object sender, RoutedEventArgs e)
        {
            addWorkn = 1;
        }

        private async void MvFwd(object sender, RoutedEventArgs r)
        {
            await Task.Delay(100);
        }

        private void Item_Click(object sender, RoutedEventArgs r)
        {
            if(iMode == 0)
            {
                //Canvas.SetLeft(selBrd, Canvas.GetLeft());
                mCanv.Children.Add(selBrd);
                iMode = 1;
            }
            else
            {
                mCanv.Children.Remove(selBrd);
                iMode = 0;
            }
            
            
            itemWorkn = 1;
        }

        private void AddTl(object sender, RoutedEventArgs e)
        {
            if(e.OriginalSource is Rectangle)
            {
                Rectangle tl = new Rectangle
                {
                    Height = Width = 35,
                    Fill = tlImg
                };
                Canvas.SetLeft(tl, Mouse.GetPosition(mCanv).X);
                Canvas.SetTop(tl, Mouse.GetPosition(mCanv).Y);
                mCanv.Children.Add(tl);
                mCanv.MouseLeftButtonDown -= AddTl;
                itemWorkn = 0;
            }
        }            
        private void CX_Click(object sender, RoutedEventArgs e)
        {
            addWorkn = 0;
        }
    }
}
