using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SentenceBuilder
{
    public partial class SentenceBuilder : Form
    {
        public SentenceBuilder()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSpokeTo_Click(object sender, EventArgs e)
        {
            sentenceDisplay.Text += buttonSpokeTo.Text;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            sentenceDisplay.Clear();
        }

        private void buttonDrove_Click(object sender, EventArgs e)
        {
            sentenceDisplay.Text += buttonDrove.Text;
            
        }

        private void upcaseA_Click(object sender, EventArgs e)
        {
            sentenceDisplay.Text += upcaseA.Text;
        }

        private void lowercaseA_Click(object sender, EventArgs e)
        {
            sentenceDisplay.Text += lowercaseA.Text;
        }

        private void buttonAn_Click(object sender, EventArgs e)
        {
            sentenceDisplay.Text += buttonAn.Text;
        }

        private void lowercaseAn_Click(object sender, EventArgs e)
        {
            sentenceDisplay.Text += lowercaseAn.Text;
        }

        private void uppercaseThe_Click(object sender, EventArgs e)
        {
            sentenceDisplay.Text += uppercaseThe.Text;
        }

        private void lowercaseThe_Click(object sender, EventArgs e)
        {
            sentenceDisplay.Text += lowercaseThe.Text;
        }

        private void buttonMan_Click(object sender, EventArgs e)
        {
            sentenceDisplay.Text += buttonMan.Text;
        }

        private void buttonWoman_Click(object sender, EventArgs e)
        {
            sentenceDisplay.Text += buttonWoman.Text;
        }

        private void buttonDog_Click(object sender, EventArgs e)
        {
            sentenceDisplay.Text += buttonDog.Text;
        }

        private void buttonCat_Click(object sender, EventArgs e)
        {
            sentenceDisplay.Text += buttonCat.Text;
        }

        private void buttonCar_Click(object sender, EventArgs e)
        {
            sentenceDisplay.Text += buttonCar.Text;
        }

        private void buttonBicyle_Click(object sender, EventArgs e)
        {
            sentenceDisplay.Text += buttonBicyle.Text;
        }

        private void buttonBeautiful_Click(object sender, EventArgs e)
        {
            sentenceDisplay.Text += buttonBeautiful.Text;
        }

        private void buttonBig_Click(object sender, EventArgs e)
        {
            sentenceDisplay.Text += buttonBig.Text;
        }

        private void buttonSmall_Click(object sender, EventArgs e)
        {
            sentenceDisplay.Text += buttonSmall.Text;
        }

        private void buttonStrange_Click(object sender, EventArgs e)
        {
            sentenceDisplay.Text += buttonStrange.Text;
        }

        private void buttonLookedAt_Click(object sender, EventArgs e)
        {
            sentenceDisplay.Text += buttonLookedAt.Text;
        }

        private void buttonRode_Click(object sender, EventArgs e)
        {
            sentenceDisplay.Text += buttonRode.Text;
        }

        private void buttonLaughedAt_Click(object sender, EventArgs e)
        {
            sentenceDisplay.Text += buttonLookedAt.Text;
        }

        private void buttonSpace_Click(object sender, EventArgs e)
        {
            sentenceDisplay.Text += " ";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonExclamation_Click(object sender, EventArgs e)
        {
            sentenceDisplay.Text += buttonExclamation.Text;
        }

        private void buttonPeriod_Click(object sender, EventArgs e)
        {
            sentenceDisplay.Text += buttonPeriod.Text;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        

        }
    }
}
