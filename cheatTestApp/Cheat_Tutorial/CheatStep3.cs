using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cheat_Tutorial
{
    public partial class CheatStep3 : Form
    {
        static bool closeApp;
        static string tutorial3 = "SAMPLE TEXT";

        public CheatStep3()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            closeApp = false;
            SwitchForms.OpenStep2();
            SwitchForms.CloseStep3();
        }

        private void CheatStep3_Load(object sender, EventArgs e)
        {
            closeApp = true;
        }

        private void CheatStep3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closeApp)
                Application.Exit();
        }

        private void btnStr1_Click(object sender, EventArgs e)
        {
            tutorial3 = "According to all known laws of aviation, there is " +
                        "no way a bee should be able to fly. Its wings are " +
                        "too small to get its fat little body off the ground.";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblOutput.Text = tutorial3;
        }

        private void btnStr2_Click(object sender, EventArgs e)
        {
            tutorial3 = "The FitnessGram Pacer Test is a multistage aerobic " +
                        "capacity test that progressively gets more difficult " +
                        "as it continues. The 20 meter pacer test will begin " +
                        "in 30 seconds.";
        }

        private void btnStr3_Click(object sender, EventArgs e)
        {
            tutorial3 = "Lorem ipsum dolor sit amet, consectetur adipiscing " +
                        "elit, sed do eiusmod tempor incididunt ut labore " +
                        "et dolore magna aliqua..";
        }
    }
}
