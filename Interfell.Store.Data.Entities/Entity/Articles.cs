
#region Usings

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace Interfell.Store.Data.Entities.Entity
{
    public class Articles
    {
        [Key]
        public int IdArticle { get; set; }

        [Required]
        [StringLength(maximumLength: 100)]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 500)]
        public string Description { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public int TotalInShelf { get; set; }

        [Required]
        public int TotalInVault { get; set; }

        [Required]
        [ForeignKey("Stores")]
        public int StoreId { get; set; }

        public virtual Stores Stores { get; set; }
    }
}
