using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SailUI.Models
{
    public class SailContext_Singleton
    {
        private static SailContext _context;
        private static Object syncLock = new object();
        public static SailContext Context()
        {
            if (_context == null)
            {
                lock (syncLock)
                {
                    if (_context == null)
                    {
                        var optionsBuilder = new DbContextOptionsBuilder<SailContext>();
                        optionsBuilder.UseSqlServer(
                        @"Data Source=DESKTOP-LT88502\FATIMASQL2017;Initial Catalog=Sail;Integrated Security=True");
                        _context = new SailContext(optionsBuilder.Options);

                    }
                }
            }
            return _context;
        }
    }
}
