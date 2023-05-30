using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCRUD.Models
{
    internal class BlogDbContext : DbContext
    {
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Catlog> Catlogs { get; set; }
        public virtual DbSet<News>  News { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string ConneectionString = "Data Source=.;Initial Catalog=Blog;Integrated Security=True;TrustServerCertificate=True";
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(ConneectionString);

        }

    }
}
