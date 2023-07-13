using System;

namespace Async_Await
{
    internal class Program
    {
        static void Main(string[] args)
        {



           /* string s = Console.ReadLine()!;
            Console.WriteLine("Uzunligi "+StringLength(s));*/
        }
        #region  
        //Berilgan matnning uzunligini aniqlaydigan method yarating.
        //Ushbu methoddan foydalangan holda Klaviaturadan kiritilgan matnning uzunligini ekranga chiqazadigan dastur tuzing.
        //Agarda matn bo’sh bo’lsa ArgumentException throw qilinsin.
        //Message sifatida “Kiritilgan matn bo’sh bo’lmasligi kerak” degan xabar bo’lsin.
   /*     static int  StringLength(string s)
        {
            try
            {
                if (s.Length == 0) throw new ArgumentException();
                return s.Length;
            }
            catch(ArgumentException e)
            {
                Console.WriteLine("satr null  ga teng bolib qoldi");
            }
            return 0;
        }
   */
        #endregion
    }
}