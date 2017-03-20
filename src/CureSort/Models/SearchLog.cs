using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CureSort.Models
{
    public class SearchLog
    {
        [Key]
        public int SearchID { get; set; }

        public string SearchString { get; set; }
        public DateTime SearchDate { get; set; }
        public int ApplicationUserID { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
    }
}
