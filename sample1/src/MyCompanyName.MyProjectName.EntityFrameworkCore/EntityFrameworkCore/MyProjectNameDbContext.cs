using Microsoft.EntityFrameworkCore;
using MyCompanyName.MyProjectName.Samples;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace MyCompanyName.MyProjectName.EntityFrameworkCore
{
    /* This is your actual DbContext used on runtime.
     * It includes only your entities.
     * It does not include entities of the used modules, because each module has already
     * its own DbContext class. If you want to share some database tables with the used modules,
     * just create a structure like done for AppUser.
     *
     * Don't use this DbContext for database migrations since it does not contain tables of the
     * used modules (as explained above). See MyProjectNameMigrationsDbContext for migrations.
     */
    [ConnectionStringName("Default")]
    public class MyProjectNameDbContext : AbpDbContext<MyProjectNameDbContext>
    {

        /* Add DbSet properties for your Aggregate Roots / Entities here.
         * Also map them inside MyProjectNameDbContextModelCreatingExtensions.ConfigureMyProjectName
         */
        public DbSet<Sample> Samples { get; set; }

        public MyProjectNameDbContext(DbContextOptions<MyProjectNameDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Configure your own tables/entities inside the ConfigureMyProjectName method */

            builder.ConfigureMyProjectName();
        }
    }
}
