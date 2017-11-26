using MicroOrm.Dapper.Repositories.Attributes;
using MicroOrm.Dapper.Repositories.Attributes.Joins;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess
{
    [Table("Breed")]
    public class Breed
    {
        [Key, Identity]
        public int BreedId { get; set; }

        [MaxLength(20)]
        public string BreedName { get; set; }

        [UpdatedAt]
        public DateTime? ModifiedOn { get; set; }

        [InnerJoin("Cat", "BreedId", "ID")]
        public IEnumerable<Cat> Cats { get; set; }
    }
}