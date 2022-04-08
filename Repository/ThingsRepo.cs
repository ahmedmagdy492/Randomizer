using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Randomizer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomizer.Repository
{
    public class ThingsRepo : IThingsRepo
    {
        private readonly AppDBContext _context;

        public ThingsRepo(AppDBContext context)
        {
            _context = context;
        }

        public Task<List<Thing>> GetAll()
        {
            return _context.Things.ToListAsync();
        }

        public Task<Thing> GetByID(string id)
        {
            return _context.Things.FirstOrDefaultAsync(t => t.ID == id);
        }

        public void Create(Thing model)
        {
            _context?.Things?.Add(model);
        }

        public void Delete(Thing thing)
        {
            _context.Things?.Remove(thing);
        }
    }
}
