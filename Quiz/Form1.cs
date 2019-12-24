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
        int andend1, andend2;


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

            Sum.Value = 0;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
