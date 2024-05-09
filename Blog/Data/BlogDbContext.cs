using Blog.Models.Domain;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Blog.Data
{
    public class BlogDbContext : DbContext // heritage//
                                           //this class is  responsible for interacting with the database - Performing CRUD using EntittyFramework
    {
        public BlogDbContext(DbContextOptions options) : base(options) // constructeur //
        {
        }

        public DbSet<BlogPost> BlogPosts { get; set; }//Many to Many rs//
        public DbSet<Tag>Tags { get; set; }//Many to Many rs//
    }
}
