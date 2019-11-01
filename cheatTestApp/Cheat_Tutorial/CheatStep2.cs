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
    public partial class CheatStep2 : Form
    {

        static int tutorial2;
        static bool closeApp;
        Random rnd = new Random();

        public CheatStep2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tutorial2 != 101)
                tutorial2--;
            else
                tutorial2 -= 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tutorial2 != 99)
                tutorial2++;
            else
                tutorial2 += 2;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tutorial2 == 100) {
                lblCheck.ForeColor = Color.Green;
                lblCheck.Text = "✓";
            }
            else
            {
                lblCheck.ForeColor = Color.Red;
                lblCheck.Text = "X";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            closeApp = false;
            SwitchForms.OpenStep1();
            SwitchForms.CloseStep2();
        }

        private void CheatStep2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closeApp)
                Application.Exit();

        }

        private void CheatStep2_Load(object sender, EventArgs e)
        {
            closeApp = true;
            tutorial2 = rnd.Next(-1000, 1000);

        }
    }
}
