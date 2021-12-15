using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace World_Skills_X
{
    partial class Form1 : Form
    {
        private void Make_panel()
        {
            height = panel1.Height / blocks;
            width = panel1.Width / blocks;

            for(int i = 0; i < blocks; i++)
            {
                for(int j = 0; j < blocks; j++)
                {
                    PictureBox pic = new PictureBox
                    {
                        Name = $"{i}_{j}",
                        Size = new Size(width, height),
                        Location = new Point(width * i, height * j),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        //BorderStyle = BorderStyle.FixedSingle,
                        BackColor = Color.Transparent,
                        Tag = "0/00"
                    };
                    panel1.Controls.Add(pic);
                    pic.MouseHover += Pic_MouseHover;
                    pic.MouseClick += Pic_MouseClick;
                }
            }
        }

        private void Pic_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            

            if(chosenObject < 0)
            {
                pic.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                Place_object(pic, chosenObject);
            }
        }

        private void Pic_MouseHover(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            label1.Text = $"{pic.Tag}={pic.Name}";
        }

        private void Place_object(PictureBox pic, int chosen)
        {
            int n = int.Parse(pic.Tag.ToString().Split('/')[0]);

            switch (chosen)
            {
                case 0:
                    pic.Tag = "0/00";
                    pic.Image = null;
                    pic.BackgroundImage = null;
                    break;
                case 1:
                    pic.Tag = "1/00";
                    pic.BackgroundImage = Properties.Resources.Rvertical;
                    break;
                case 2:
                    pic.Tag = "2/00";
                    pic.BackgroundImage = Properties.Resources.Rvertical;
                    pic.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    break;
                case 3:
                    pic.Tag = "3/00";
                    pic.BackgroundImage = Properties.Resources.Rvertical;
                    pic.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    break;
                case 4:
                    pic.Tag = "4/00";
                    pic.BackgroundImage = Properties.Resources.Rvertical;
                    pic.BackgroundImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    break;
                case 5:
                    pic.Tag = "5/00";
                    pic.BackgroundImage = Properties.Resources.Rcrossroads;
                    break;
                case 6:
                    if(n > 0 && n < 5)
                    {
                        Place_pic_on_top(pic, Properties.Resources.TLgreen1, "06");
                    }
                    break;
                case 7:
                    if(n > 1 && n < 5)
                    {
                        Place_pic_on_top(pic, Properties.Resources.TLred, "07");
                    }
                    break;
                case 8:
                    if(n > 0 && n < 3)
                    {
                        Place_pic_on_top(pic, Properties.Resources.Zhorizontal1, "08");
                    }
                    if(n > 2 && n < 5)
                    {
                        Place_pic_on_top(pic, Properties.Resources.Zvertical, "08");
                    }
                    break;
                case 9:
                    if(n == 0)
                    {
                        Place_pic_on_top(pic, Properties.Resources.Pedestrain, "09");
                    }
                    break;
                case 10:
                    if(n > 0)
                    {
                        Place_pic_on_top(pic, Properties.Resources.Block, "10");
                    }
                    break;
                case 11:
                    if(n > 0)
                    {
                        Place_pic_on_top(pic, Properties.Resources.VagonBlock, "11");
                    }
                    break;
                case 12:
                    if(n > 0)
                    {
                        Place_pic_on_top(pic, Properties.Resources.HeavyBlock2, "12");
                    }
                    break;
                case 13:
                    pic.Image = Properties.Resources.Trailer;
                    pic.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    break;
                case 14:
                    pic.Image = Properties.Resources.Trailer;
                    pic.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    break;
                
                    


            }

        }
        private void Place_pic_on_top(PictureBox pic, Bitmap resource, string tag)
        {
            pic.Image = resource;
            string[] s = pic.Tag.ToString().Split('/');
            pic.Tag = s[0] + "/" + tag;
        }

        int[][] pos =
        {
           new int[]{5, 19, 1}
        };


        

        private void Car_move_one()
        {
            int[] new_pos = new int[3];
            PictureBox pic = panel1.Controls[$"{pos[0]}_{pos[1]}"] as PictureBox;
            string[] tag = pic.Tag.ToString().Split('/');
            Array.Copy(pos, new_pos, pos.Length);


            

            

            PictureBox pic1 = panel1.Controls[$"{new_pos[0]}_{new_pos[1]}"] as PictureBox;
            string[] tag1 = pic1.Tag.ToString().Split('/');
            Array.Copy(pos, new_pos, pos.Length);
            if(tag1[1] != "5")
            {
                pic1.Image = pic.Image;
                pic.Image = null;
            }
            
        }
    }
}
