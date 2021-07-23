using Microsoft.EntityFrameworkCore;

namespace ToDo.Data
{
    public class ItemContext: DbContext
    {
        public ItemContext(DbContextOptions<ItemContext> options) : base(options){}
        public DbSet<Models.Item> Items { get; set; }
       
    }
}