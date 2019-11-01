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
        static float tutorial3 = 1.27f;
        static byte red = 127;
        static byte blue = 126;

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Cursor.Position.X - this.Location.X - 8 >= lblRed.Location.X
                && Cursor.Position.X - this.Location.X - 8 < lblRed.Location.X + lblRed.Size.Width
                && Cursor.Position.Y - this.Location.Y - 32 >= lblRed.Location.Y
                && Cursor.Position.Y - this.Location.Y - 32< lblRed.Location.Y + lblRed.Size.Height)
                lblRed_MouseHover();

            if (Cursor.Position.X - this.Location.X - 8 >= lblBlue.Location.X
                && Cursor.Position.X - this.Location.X - 8< lblBlue.Location.X + lblBlue.Size.Width
                && Cursor.Position.Y - this.Location.Y - 32>= lblBlue.Location.Y
                && Cursor.Position.Y - this.Location.Y - 32< lblBlue.Location.Y + lblBlue.Size.Height)
                lblBlue_MouseHover();

                red = (byte) (tutorial3 * 100f);
            blue = (byte) (255 - red);

            this.BackColor = Color.FromArgb(red, 0, blue);
        }

        private void lblRed_MouseHover()
        {
            if (tutorial3 < 2.55f)
                tutorial3 += .01f;
        }

        private void lblBlue_MouseHover()
        {
            if (tutorial3 > 0f)
                tutorial3 -= .01f;
        }
    }
}
