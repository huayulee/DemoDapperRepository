using MicroOrm.Dapper.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BreedRepository : BaseRepository
    {
        public IEnumerable<Breed> Get()
        {
            var rrr = this.DB.Breed.FindAll<Cat>(x => x.BreedId >= 1, q => q.Cats);
            return rrr;
        }
    }

    public class CatRepository : BaseRepository
    {
        public IEnumerable<Cat> Get()
        {
            return this.DB.Cat.FindAll();
        }
    }
}
