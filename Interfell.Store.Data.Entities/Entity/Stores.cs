

#region Usings

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace Interfell.Store.Data.Entities.Entity
{
    public class Stores
    {
        [Key]
        public int IdStore { get; set; }
        [Required]
        [StringLength(maximumLength:50)]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength:100)]
        public string Address { get; set; }
    }
}
