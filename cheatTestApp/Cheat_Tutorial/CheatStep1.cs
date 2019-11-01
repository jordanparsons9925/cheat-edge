﻿using System;
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
    public partial class CheatStep1 : Form
    {
        
        static int tutorial1 = 10;
        static bool closeApp;

        public CheatStep1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tutorial1 > 0)
                tutorial1--;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tutorial1 < 99)
                tutorial1++;
        }

        private void CheatTutorial_Load(object sender, EventArgs e)
        {
            closeApp = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblNum.Text = tutorial1.ToString();
            if (tutorial1 == 100)
                btnStep.Enabled = true;
        }

        private void btnStep_Click(object sender, EventArgs e)
        {
            closeApp = false;
            SwitchForms.OpenStep2();
            SwitchForms.CloseStep1();
        }

        private void CheatStep1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closeApp)
                Application.Exit();
        }
    }
}
