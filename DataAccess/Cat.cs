using MicroOrm.Dapper.Repositories.Attributes.Joins;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess
{
    [Table("Cat")]
    public class Cat
    {
        [Key]
        public int ID { get; set; }
        public int BreedId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}