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
            var rrr = this._db.Breed.FindAll<Cat>(x => x.BreedId >= 1, q => q.Cats);
            return rrr;
        }

        public int BulkInsert()
        {
            var data = new List<Breed>
            {
                 new Breed{BreedName="AGGGGGGGGG" },
                 new Breed{BreedName="GGGGGGGGGGG" },
            };

            return this._db.Breed.BulkInsert(data);
        }

        public bool Insert()
        {
            using(var trans = _db.BeginTransaction())
            {
                var data = new Breed
                {
                    BreedName = "Insert AT "+DateTime.UtcNow.ToShortDateString()
                };

                _db.Breed.Insert(data, trans);

                data = new Breed
                {
                    BreedName = "Insert2 AT " + DateTime.UtcNow.ToShortDateString()
                };

                _db.Breed.Insert(data, trans);


                trans.Commit();
            }

            return true;
        }

        public bool Update()
        {
            using (var trans = _db.BeginTransaction())
            {
                var data = new Breed
                {
                    BreedId = 24,
                    BreedName = "DDDDABCaaa"
                };
                _db.Breed.Update(data, trans);


                data = new Breed
                {
                    BreedId = 25,
                    BreedName = "ddd"
                };

                _db.Breed.Update(data, trans);

                trans.Commit();
            }

            return true;
        }
    }

    public class CatRepository : BaseRepository
    {
        public IEnumerable<Cat> Get()
        {
            return this._db.Cat.FindAll();
        }
    }
}
