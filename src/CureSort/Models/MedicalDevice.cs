using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CureSort.Models
{
    public class MedicalDevice
    {
        public int ID { get; set; }
        public string Barcode { get; set; }
        public int BinID { get; set; }
        public string Manufacturer { get; set; }
        public string Brand { get; set; }
        public string Description { get; set;}
        public DateTime DateAdded { get; set; }
        public DateTime LastModified { get; set; }
        public int ApplicationUserID { get; set;}

        public ApplicationUser ApplicationUser { get; set; }
        public Bin Bin { get; set; }
    }
}
