using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CureSort.Models
{
    public class SearchLog
    {
        public int SearchID { get; set; }
        public string SearchString { get; set; }
        public DateTime SearchDate { get; set; }
        public int ApplicationUserID { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
    }
}
