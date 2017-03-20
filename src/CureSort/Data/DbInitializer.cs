using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CureSort.Data
{
    public class DbInitializer
    {
        public static void Initialize(CureContext context)
        {
            context.Database.EnsureCreated();

            
            context.SaveChanges();
        }
    }
}
