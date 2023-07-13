using System;
using System.Threading;
namespace Thread_
{
    internal class Program
    {
        static bool _done;
        static readonly object _locker=new object();
        static void Main(string[] args)
        {

            #region 1-misol
            /* Thread t = new Thread(WriteY);
             t.Name = "writeY oqimi ";
             t.Start();

             for (int i = 0; i < 1000; i++)
                 Console.Write("X");*/
            #endregion
            #region 2-misol
            /*            Thread t2 = new Thread(Go);
                        t2.Start();
                        Console.WriteLine("t2 oqim boshlandi");
                        t2.Join();
                        Console.WriteLine("t2 oqimi tugadi");*/
            #endregion
            #region 3-misol
            /* Console.WriteLine("Oqim yarim minut tanafus oladi!");
             Thread.Sleep(TimeSpan.FromMinutes(0.5));
             Console.WriteLine("Oqim 5000 millisekundga tanafus oladi!");
             Thread.Sleep(5000);*/

            #endregion
            #region 4-misol
            /*
                        new Thread(Go2).Start(); //yangi oqimdan chaqiramiz
                        Go2();//asosiy oqimdan chaqiramiz*/
            #endregion
            #region 5-misol
            /* Thread t3 = new Thread(Go3);
                 t3.Start();
             Go3();*/

            #endregion
            #region 6-misol
            /*    Thread t4 = new Thread(Go4);
                t4.Start();*/
            #endregion

            #region 7-misol
  /*          Thread thread = new Thread(DoWork);

            thread.Start();

            for(int i=0;i<9;i++)
            {
                Console.WriteLine($"asosiy thread {0}", i);
            }
  */
            #endregion



        }

        #region DoWork
        static void DoWork()
        {
            for(int i=0;i< 9;i++)
            {
                Console.WriteLine($"qo'shimcha thread {0}", i);
               
            }
            Thread.Sleep(TimeSpan.FromSeconds(10));

        }
        #endregion
        #region WriteY
        static void WriteY()
        {
            Console.WriteLine(Thread.CurrentThread.Name+" ishni boshladi");
            for(int i=0;i<1000;i++)
            {
                Console.Write("Y");
            }
           
        }
        #endregion
        #region Go1
        static void Go()
        {
            for(int i=0; i < 1000; i++)
            {
                Console.Write("B");
            }
        }
        #endregion

        #region Go2

        static void Go2()
        {
            for(int i=0;i<5;i++)
            {
                Console.Write("?");
            }
        }
        #endregion
        #region Go3
        static void Go3()
        {
            if(!_done)
            {
                Console.WriteLine("Done");
                _done = true;
            }
        }

        #endregion
        #region Go4

        static void Go4()
        {

        }
        #endregion

    }
}