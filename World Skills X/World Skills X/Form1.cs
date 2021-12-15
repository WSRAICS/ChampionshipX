using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace World_Skills_X
{
    public partial class Form1 : Form
    {
        int blocks = 20;
        int height, width;
        int chosenObject = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Make_panel();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (panel2.Visible)
            {
                panel2.Visible = false;
            }
            else
            {
                panel2.Visible = true;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            chosenObject = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            chosenObject = 5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            chosenObject = 1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            chosenObject = 2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            chosenObject = 3;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            chosenObject = 4;
        }

        private void btnsave(object sender, EventArgs e)
        {
            List<string> rowList = new List<string>();
            for(int i = 0; i < blocks; i++)
            {
                string text = "";
                for(int j = 0; j < blocks; j++)
                {
                    text += panel1.Controls[$"{j}_{i}"].Tag + "_";
                }
                rowList.Add(text);
            }
            File.WriteAllLines("panel.txt", rowList);
        }
        private void load()
        {
            Make_panel();
            string[] file = File.ReadAllLines("panel.txt");
            for(int i = 0; i < file.Length; i++)
            {
                string[] block = file[i].Split('_');
                for(int j = 0; j < block.Length - 1; j++)
                {
                    int croad = int.Parse(block[j].ToString().Split('/')[0]);
                    int cobject = int.Parse(block[j].ToString().Split('/')[1]);
                    PictureBox pic = panel1.Controls[$"{j}_{i}"] as PictureBox;
                    Place_object(pic, croad);
                    if(cobject > 0)
                    {
                        Place_object(pic, cobject);
                    }
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            chosenObject = 9;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            chosenObject = 10;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            chosenObject = 8;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            chosenObject = 6;
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            chosenObject = 12;
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            chosenObject = 7;
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            chosenObject = 11;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            load();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            chosenObject = 13;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            chosenObject = 14;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Car_move_one();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
