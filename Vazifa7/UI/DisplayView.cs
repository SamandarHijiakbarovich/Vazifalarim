using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vazifa7.UI
{
    internal class DisplayView
    {
        KompyuterView kompyuterView;
        public DisplayView()
        {
            kompyuterView = new KompyuterView();

        }
        void Menu()
        {
            Console.WriteLine(@"1.Kompyuter
2.CPU
3.GPU
4.Disk
5.Ram
6.dasturdan chiqish ");

        }

        public void start()
        {
            Menu();
            int n = int.Parse(Console.ReadLine());

            switch(n)
            {
                case 1: kompyuterView.SetLaptop();break;
                case 2:kompyuterView.SetCPU();break;
                case 3:kompyuterView.SetGPU();break;
                case 4:kompyuterView.SetDisc();break;
                case 5:kompyuterView.SetRam();break;
                case 6:return ;

            }
            Console.ReadKey();
            
        }
    }
}
