using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vazifa7.Domain.Enums;

namespace Vazifa7.Domain
{
    internal class Ram
    {
        public string Name { get; set; } = null!;
        public string BrandName { get; set; } = null!;
        public int RamSize { get; set; }
        public E_RamOfType RamOfType { get;set; }
        public decimal Price { get; set; }

    }
}
