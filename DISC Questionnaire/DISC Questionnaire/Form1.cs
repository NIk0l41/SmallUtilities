using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISC_Questionnaire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DiscCalculator pog = new DiscCalculator();
            int[] a = { 5, 14, 2, 3 };
            a = pog.g1(a);
            label1.Text = "";
            for (int i = 0; i < a.Length; i++) {
                if (i == a.Length - 1)
                {
                    label1.Text += a[i].ToString();
                }
                else
                {
                    label1.Text += a[i] + ", ";
                }
            }
        }
    }
}
