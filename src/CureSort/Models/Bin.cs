using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CureSort.Models
{
    public class Bin
    {
        public int BinID { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }

        public ICollection<MedicalDevice> MedicalDevices { get; set; }
    }
}
