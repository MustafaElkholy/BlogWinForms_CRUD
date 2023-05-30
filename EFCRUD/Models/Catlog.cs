using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCRUD.Models
{
    public class Catlog
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? BriefDescription { get; set; }
        public virtual List<News> News { get; set; } = new List<News>();

    }
}
