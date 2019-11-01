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
        static CheatStep3 step3;

        //Opens the specified step
        public static void OpenStep(int step)
        {
            switch (step)
            {
                case 1:
                    OpenStep1();
                    break;
                case 2:
                    OpenStep2();
                    break;
                case 3:
                    OpenStep3();
                    break;
                default:
                    OpenStep1();
                    break;
            }
        }

        //Code for handling step 1
        public static void OpenStep1()
        {
            step1 = new CheatStep1();
            step1.Show();
        }
        public static void CloseStep1()
        {
            step1.Close();
        }

        //Code for handling step 2
        public static void OpenStep2()
        {
            step2 = new CheatStep2();
            step2.Show();
        }
        public static void CloseStep2()
        {
            step2.Close();
        }

        //Code for handling step 3
        public static void OpenStep3()
        {
            step3 = new CheatStep3();
            step3.Show();
        }
        public static void CloseStep3()
        {
            step3.Close();
        }
    }
}
