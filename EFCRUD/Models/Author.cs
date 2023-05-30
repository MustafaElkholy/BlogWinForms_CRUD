using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCRUD.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        public string? UserName { get; set; }
        public int? Age { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        [NotMapped]
        public string? ConfirmPassword { get; set; }
        public string? Photo { get; set; }
        public virtual List<News> News { get; set; } = new List<News>();

    }
}
