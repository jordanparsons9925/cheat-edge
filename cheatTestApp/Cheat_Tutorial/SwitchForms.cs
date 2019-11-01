using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheat_Tutorial
{
    class SwitchForms
    {
        static CheatStep1 step1;
        static CheatStep2 step2;

        public static void OpenStep1()
        {
            step1 = new CheatStep1();
            step1.Show();
        }
        public static void CloseStep1()
        {
            step1.Close();
        }

        public static void OpenStep2()
        {
            step2 = new CheatStep2();
            step2.Show();
        }
        public static void CloseStep2()
        {
            step2.Close();
        }
    }
}
