using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Quiz : Form
    {
        Random randomizer = new Random();
        public int andend1, andend2,timeLeft;



        public Quiz()
        {
            InitializeComponent();
        }

        private void TimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void Quiz_Load(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {


            andend1 = randomizer.Next(51);
            andend2 = randomizer.Next(51);

            PlusLeftLabel.Text = andend1.ToString();
            PlusRightLabel.Text = andend2.ToString();

            sum.Value = 0;

            timeLeft = 30;
            timeLabel.Text = "30 Seconds";
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";
            
            
            }
            else
            {
                timer1.Stop();
                timeLabel.Text = " Time is up!";
                MessageBox.Show("You didn't finish on time!");
                sum.Value = andend1 + andend2;
            }
               
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
