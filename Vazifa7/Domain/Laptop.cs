using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vazifa7.Domain.Enum;

namespace Vazifa7.Domain
{
    internal class Laptop
    {
        public string Name { get; set; } = null!;
        public string BrandName { get; set; }=null!;
        public decimal Price { get; set; }
        public ELaptopType Type { get; set; } = ELaptopType.Gaming;
        public CPU CPU { get; set; }
        public GPU GPU { get; set; }
        public Disc Disc { get; set; }
        public Ram Ram { get; set; }


        public Laptop()
        {
            var cpu = new CPU();
            var gpu=new GPU();
            var ram = new Ram();
            var disk = new Disc();
        }


    }
}
