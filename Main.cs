using DxSlotGame.Properties;
using ns1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DxSlotGame
{
    public partial class Main : Form
    {
        private int currentPosition = 0;
        private bool isSpinning = false;
        private readonly Random random = new Random();
        private int a, b, c;

        public Main()
        {
            InitializeComponent();
            BackColor = Color.Black;
            TransparencyKey = Color.Black;
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            if (!isSpinning)
            {
                currentPosition = 0;
                timer1.Start();
                isSpinning = true;
            }

            InitializeSlotMachine(10, siticonePictureBox1, siticoneGradientPanel1, 10);
            InitializeSlotMachine(10, siticonePictureBox2, siticoneGradientPanel2, 15);
            InitializeSlotMachine(10, siticonePictureBox3, siticoneGradientPanel3, 10);
            siticoneButton1.Enabled = false;
        }

        private void InitializeSlotMachine(int interval, SiticonePictureBox pictureBox, SiticoneGradientPanel panel, int point)
        {
            panel.Controls.Add(pictureBox);
            pictureBox.Location = new Point((panel.Width - pictureBox.Width) / 2, 0);

            do
            {
                a = random.Next(1, 5);
                b = random.Next(1, 5);
                c = random.Next(1, 5);
            } while (b == a || c == a || b == c);

            List<string> listes = new List<string>() { "_1", "_2", "_3", "Lucky_Seven_512_1870318983" };

            pictureBox.Image = Resources.ResourceManager.GetObject(listes[a - 1]) as Image;
            pictureBox.Image = Resources.ResourceManager.GetObject(listes[b - 1]) as Image;
            pictureBox.Image = Resources.ResourceManager.GetObject(listes[c - 1]) as Image;

            Timer timer = new Timer();
            timer.Interval = interval;
            timer.Tick += (sender, e) => Timer_Tick(pictureBox, point);
            timer.Start();
        }

        private void Timer_Tick(SiticonePictureBox pictureBox, int point)
        {
            if (currentPosition == 800)
            {
                timer1.Stop();
                isSpinning = false;

                pictureBox.Location = new Point(0, 0);
                siticoneButton1.Enabled = true;
            }
            else
            {
                MovePictureBox(pictureBox, point);
                currentPosition++;
            }
        }

        private void MovePictureBox(SiticonePictureBox pictureBox, int point)
        {
            pictureBox.Location = new Point(pictureBox.Location.X, pictureBox.Location.Y + point);
            if (pictureBox.Location.Y >= pictureBox.Height)
            {
                pictureBox.Location = new Point(pictureBox.Location.X, -pictureBox.Height);
            }
        }
    }
}
