using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messing_Around_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10000; i++)
            {
                await Task.Delay(1000);
                lblNumber.Text = i.ToString();
            }
        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
