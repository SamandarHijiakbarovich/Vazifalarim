using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vazifa7.Domain;
using Vazifa7.Domain.Enums;

namespace Vazifa7.Service
{
    internal class KompyuterService
    {
        Laptop Laptop { get; set; }
        CPU CPU { get; set; }
        GPU GPU { get; set; }
        Disc Disc { get; set; }
        Ram Ram { get; set; }




        /// <summary>
        /// Initsializatsiya qilindi 
        /// </summary>
        public KompyuterService()
        {
            Laptop = new Laptop();
            CPU = new CPU();
            GPU = new GPU();
            Disc = new Disc();
            Ram = new Ram();
        }


        /// <summary>
        /// Bu method CPU haqidagi ma'lumotlarni qaytaradi
        /// </summary>
        /// <param name="name"></param>
        /// <param name="brandname"></param>
        /// <param name="price"></param>
        /// <param name="yadrocount"></param>
        /// <returns></returns> 
        public CPU Get_CPU(string name,string brandname,decimal price,int yadrocount)
        {
            CPU.Name = name;
            CPU.BrandName=brandname; 
            CPU.Price=price;
            CPU.YadroCount = yadrocount;
            return CPU;

        }

        /// <summary>
        /// Bu method GPU xaqida ma'lumotlarni qaytaradi
        /// </summary>
        /// <param name="name"></param>
        /// <param name="brandname"></param>
        /// <param name="price"></param>
        /// <param name="gpuOfType"></param>
        /// <returns></returns>
        public GPU Get_GPU(string name,string brandname,decimal price,E_GpuOfType gpuOfType)
        {
            GPU.Name = name;
            GPU.BrandName = brandname;
            GPU.Price = price;
            GPU.GPuOfType = gpuOfType;
            return GPU;
        }


        /// <summary>
        /// Disc xaqida malumotlarni qaytaradi
        /// </summary>
        /// <param name="name"></param>
        /// <param name="brandname"></param>
        /// <param name="price"></param>
        /// <param name="memorysize"></param>
        /// <param name="discOfType"></param>
        /// <returns></returns>
        public Disc GetDisc(string name,string brandname,decimal  price,
            int memorysize, EDiscOfType discOfType)
        {
            Disc.Name = name;
            Disc.BrandName = brandname;
            Disc.Price = price;
            Disc.EDiscOfType = discOfType;
            return Disc;

        }

        /// <summary>
        /// RAm xaqida ma'lumotlarni qaytaradi
        /// </summary>
        /// <param name="name"></param>
        /// <param name="brandname"></param>
        /// <param name="size"></param>
        /// <param name="ramoftype"></param>
        /// <param name="price"></param>
        /// <returns></returns>
        public Ram GetRam(string name,string brandname,int size,
            E_RamOfType ramoftype,
            decimal price)
        {
            Ram.Name = name;
            Ram.BrandName = brandname;
            Ram.RamSize = size;
            Ram.RamOfType = ramoftype;
            Ram.Price = price;

            return Ram;
        }


       
    }
}
