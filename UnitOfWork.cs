using Randomizer.Models;
using Randomizer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomizer
{
    public class UnitOfWork
    {
        private readonly AppDBContext _context;

        public UnitOfWork()
        {
            _context = new AppDBContext();
        }

        public IThingsRepo? ThingsRepo { 
            get
            {
                return new ThingsRepo(_context);
            }
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
