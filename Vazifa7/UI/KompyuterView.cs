using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vazifa7.Domain;
using Vazifa7.Domain.Enum;
using Vazifa7.Domain.Enums;
using Vazifa7.Service;

namespace Vazifa7.UI
{
    internal class KompyuterView
    {
        KompyuterService kompyuterService { get; set; }

        public KompyuterView()
        {
            kompyuterService = new KompyuterService();
        }


        public void SetLaptop(string? name, string? brandname, decimal price,
            ELaptopType eLaptopType, CPU? cpu, GPU? gpu, Disc? disc, Ram? ram)
        {
            Console.WriteLine("laptop name the in enter");
            name = Console.ReadLine();
            Console.WriteLine("Laptop brand name the in enter");
            brandname = Console.ReadLine();
            Console.WriteLine("enter the price");
            price = decimal.Parse(Console.ReadLine());
         
            
        }

        

        /// <summary>
        /// Bu method CPU ning ma'lumotlarini qabul qiladi
        /// </summary>
        /// <param name="name"></param>
        /// <param name="brandname"></param>
        /// <param name="price"></param>
        /// <param name="yadrocount"></param>
        public void SetCPU(string? name,string? brandname,decimal price,int yadrocount)
        {
            Console.WriteLine("Enter the name of the CPU");
            name = Console.ReadLine();
            Console.WriteLine("enter the brand name");
            brandname = Console.ReadLine();
            Console.WriteLine("enter the price");
            price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("enter the number of cores");
            yadrocount = int.Parse(Console.ReadLine());


            kompyuterService.Get_CPU(name, brandname, price, yadrocount);
        }

        /// <summary>
        /// bu method GPU ning ma'lumotlarini qabul qiladi
        /// </summary>
        /// <param name="name"></param>
        /// <param name="brandname"></param>
        /// <param name="price"></param>
        /// <param name="e_GpuOfType"></param>
        public void SetGPU(string? name,
            string? brandname,decimal price,
            E_GpuOfType e_GpuOfType)
        {
            Console.WriteLine("Enter the name of the GPU");
            name=Console.ReadLine();
            Console.WriteLine("enter the brand name");
            brandname = Console.ReadLine();
            Console.WriteLine("enter the price");
            price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("GPU of type the enter");
            e_GpuOfType = E_GpuOfType.GDDR1;

            kompyuterService.Get_GPU(name, brandname, price, e_GpuOfType);

        }


        /// <summary>
        /// Discning ma'lumotlari kiritiladi bu methodga
        /// </summary>
        /// <param name="name"></param>
        /// <param name="brandname"></param>
        /// <param name="price"></param>
        /// <param name="memorysize"></param>
        /// <param name="discOfType"></param>
        public void SetDisc(string? name, string? brandname, decimal price,
            int memorysize, EDiscOfType discOfType)
        {
            Console.WriteLine("Enter the name of the Disc");
            name = Console.ReadLine();
            Console.WriteLine("enter the brand name");
            brandname = Console.ReadLine();
            Console.WriteLine("enter the price");
            price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("enter the memory size");
            memorysize = int.Parse(Console.ReadLine());
            Console.WriteLine("type the enter ");
            discOfType = EDiscOfType.SSD;

            kompyuterService.GetDisc(name, brandname, price,memorysize, discOfType);
               
               

        }


        /// <summary>
        /// Ramning ma'lumotlari kiritiladi bu methodga
        /// </summary>
        /// <param name="name"></param>
        /// <param name="brandname"></param>
        /// <param name="size"></param>
        /// <param name="ramoftype"></param>
        /// <param name="price"></param>
        public void SetRam(string? name, string? brandname, int size,
            E_RamOfType ramoftype,
            decimal price)
        {
            Console.WriteLine("Enter the name of the RAM");
            name = Console.ReadLine();
            Console.WriteLine("enter the brand name");
            brandname = Console.ReadLine();
            Console.WriteLine("enter the size");
            size = int.Parse(Console.ReadLine());
            Console.WriteLine("ram of type enter");
            ramoftype = E_RamOfType.DDR4;
            Console.WriteLine("enter the price");
            price = decimal.Parse(Console.ReadLine());

            kompyuterService.GetRam(name, brandname, size, ramoftype, price);
        }

        internal void SetCPU()
        {
            throw new NotImplementedException();
        }

        internal void SetGPU()
        {
            throw new NotImplementedException();
        }

        internal void SetLaptop()
        {
            throw new NotImplementedException();
        }

        internal void SetDisc()
        {
            throw new NotImplementedException();
        }

        internal void SetRam()
        {
            throw new NotImplementedException();
        }
    }
}
