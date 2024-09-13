using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Stopwatch watch = new Stopwatch();
        Random random = new Random();
        int[,] captureData = new int[10, 3];
        int captureCount = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gameTimer.Interval = 1500;
            gameTimer.Start();
            watch.Start();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            int maxX = this.Size.Width - ratPictureBox.Width;
            int maxY = this.Size.Height - ratPictureBox.Height;

            int randomX = random.Next(0, maxX);
            int randomY = random.Next(0, maxY);

            ratPictureBox.Location = new Point(randomX, randomY);
        }

        private void ratPictureBox_Click(object sender, EventArgs e)
        {
            int totalX = 0, totalY = 0;
            double totalIndex = 0.0;

            int x = ratPictureBox.Location.X;
            int y = ratPictureBox.Location.Y;
            double elapsedTime = watch.ElapsedMilliseconds;
            double timeInterval = gameTimer.Interval;
            MessageBox.Show($"Congratulations! You caught the Rat. Time elapse is: {elapsedTime}");// Time since the last capture

            if (captureCount < 10)
            {
                captureData[captureCount, 0] = x; 
                captureData[captureCount, 1] = y;
                captureData[captureCount, 2] = (int)Math.Log(elapsedTime) /(int) Math.Log(gameTimer.Interval);
                captureCount++;
            }
            if (captureCount == 10)
            {
                for (int i = 0; i < 10; i++)
                {
                    totalX += captureData[i, 0];
                    totalY += captureData[i, 1];
                    totalIndex += captureData[i, 2];
                }

                int avgX = totalX / 10;
                int avgY = totalY / 10;
                double avgIndex = totalIndex / 10;

                MessageBox.Show($"Average X: {avgX}, Average Y: {avgY}, Average Index: {avgIndex}");
                gameTimer.Stop();
            }
            
            watch.Restart();
            if (gameTimer.Interval>250)
            {
                gameTimer.Interval -= 250;
            }
        }
    }
    
}
