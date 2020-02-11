using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Project Name: Play Game
 *Made by: Seth Niescier*/
namespace PlayGame
{
    public partial class VideoGame : Form
    {
        public VideoGame()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //changes the starting background colour
            this.BackColor = Color.Black;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            //when the button is clicked, it disappears 
            startButton.Hide();
            SoundPlayer beep = new SoundPlayer(Properties.Resources.beep);
            SoundPlayer start = new SoundPlayer(Properties.Resources.startBeep);

            //starts the text coutdown, waiting 1 second between texts
            beep.Play();
            countDown.Text = "Game starting in: 3";
            countDown.Refresh();
            Thread.Sleep(1000);

            beep.Play();
            countDown.Text = "Game starting in: 2";
            countDown.Refresh();
            Thread.Sleep(1000);

            beep.Play();
            countDown.Text = "Game starting in: 1";
            countDown.Refresh();
            Thread.Sleep(1000);

            //changes the text, colour scheme, and plays start sound
            start.Play();
            this.BackColor = Color.LimeGreen;
            countDown.ForeColor = Color.Black;
            countDown.BackColor = Color.LimeGreen;
            countDown.Text = "Begin!";
        }

        //extra
        private void Label1_Click(object sender, EventArgs e)
        {
            startButton.Show();

            countDown.Text = "Video Game";
        }

        private void Label1_Click_1(object sender, EventArgs e)
        {
            startButton.Hide();

            countDown.Text = "Made by Seth N";
        }
    }
}
