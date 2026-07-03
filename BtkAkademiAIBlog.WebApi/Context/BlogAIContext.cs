using BtkAkademiAIBlog.WebApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace BtkAkademiAIBlog.WebApi.Context
{
    public class BlogAIContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;initial catalog=BtkAkademiAIBlogDb;integrated security=true;TrustServerCertificate=True;Encrypt=False;");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
