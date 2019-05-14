using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consulting.Models
{
    public class ConsultingContext_Singleton
    {
        private static ConsultingContext _context;
        private static Object syncLock = new object();
        public static ConsultingContext Context()
        {
            if (_context == null)
            {
                lock (syncLock)
                {
                    if (_context == null)
                    {
                        var optionsBuilder = new DbContextOptionsBuilder<ConsultingContext>();
                        optionsBuilder.UseSqlServer(
                        @"Data Source=DESKTOP-LT88502\FATIMASQL2017;Initial Catalog=Consulting;Integrated Security=True");
                        _context = new ConsultingContext(optionsBuilder.Options);

                    }
                }
            }
            return _context;
        }
    }
}

