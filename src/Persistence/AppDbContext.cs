using Microsoft.EntityFrameworkCore;

namespace Vuture.Persistence
{
    public class ContactDbContext : DbContext
    {
        public ContactDbContext(DbContextOptions<ContactDbContext> opt) : base(opt)
        {
        }

        public DbSet<Contact> Contacts { get; set; } = null!;
    }
}