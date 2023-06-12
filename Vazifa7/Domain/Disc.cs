using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vazifa7.Domain.Enums;

namespace Vazifa7.Domain
{
    internal class Disc
    {
        public string BrandName { get; set; } = null!;
        public string Name { get; set; }=null!;
        public decimal Price { get; set; }  
        public int MemorySize { get; set; }
        public EDiscOfType EDiscOfType { get; set; } = EDiscOfType.HHD;

    }
}
