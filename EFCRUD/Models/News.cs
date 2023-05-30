using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCRUD.Models
{
    public class News
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Brief { get; set; }
        public string? BriefDescription { get; set; }
        public string? Photo { get; set; }
        public DateTime PublishDate { get; set; }

        [ForeignKey("Author")]
        public virtual int AuthorId { get; set; }
        [ForeignKey("Catlog")]

        public virtual int? CatalogId { get; set; }

        public virtual Author? Author { get; set; }
        public virtual Catlog? Catlog { get; set; }



    }
}
