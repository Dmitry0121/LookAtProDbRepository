using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("Products")]
    public class Product : BaseEntity
    {
        public String Name { get; set; }

        public virtual Category Category { get; set; }
    }
}
