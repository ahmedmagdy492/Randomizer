using Randomizer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Randomizer.Repository
{
    public interface IThingsRepo
    {
        void Create(Thing model);
        void Delete(Thing thing);
        Task<List<Thing>> GetAll();
        Task<Thing> GetByID(string id);
    }
}