using MicroOrm.Dapper.Repositories.Attributes.Joins;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess
{
    [Table("Breed")]
    public class Breed
    {
        [Key]
        public int BreedId { get; set; }
        public string BreedName { get; set; }
        [LeftJoin("Cat", "BreedId", "ID")]
        public IEnumerable<Cat> Cats { get; set; }
    }
}