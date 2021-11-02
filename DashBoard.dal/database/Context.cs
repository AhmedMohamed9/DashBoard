using DashBoard.dal.Entity;
using Microsoft.EntityFrameworkCore;

namespace DashBoard.dal.database
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> opt) : base(opt)
        {

        }

        public DbSet<Department> departments { get; set; }
        public DbSet<Employee> employees { get; set; }



        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //=> optionsBuilder.UseSqlServer(@"server=DESKTOP-GMJ1CHG\SQLEXPRESS;database=dashboard;integrated Security=True;");







        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Department>(dep => {
        //        dep.Property(s => s.name).IsRequired(true);
        //        dep.HasKey(w => w.id);

        //    });


        //}
    }
}
