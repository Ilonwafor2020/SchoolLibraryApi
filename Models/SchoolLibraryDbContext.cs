using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace SchoolLibraryApi.Models
{
    
public class SchoolLibraryDbContext : IdentityDbContext<IdentityUser>
{
     public SchoolLibraryDbContext(DbContextOptions<SchoolLibraryDbContext> options) : base(options)
        {
        }
    public DbSet<Book> Books { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Publisher> Publishers { get; set; }
    public DbSet<Librarian> Librarians { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Borrowing> Borrowings { get; set; }
}

}