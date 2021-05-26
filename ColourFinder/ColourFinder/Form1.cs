using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColourFinder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            val = new int[0, 0];
        }
        /// <summary>
        /// 0 = HSV
        /// 1 = RGB
        /// 2 = HEX
        /// </summary>
        public int[,] val;

        void HSV(bool a) {
            switch (a) {
                case true:
                    break;
                case false:
                    break;
            }
        }

        void RGB(bool a) {
            switch (a) {
                case true:
                    break;
                case false:
                    break;
            }
        }

        void HEX(bool a) {
            switch (a) {
                case true:
                    break;
                case false:
                    break;
            }
        }

        private void radioHSV_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioRGB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioHEX_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioHSV2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioRGB2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioHEX2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
