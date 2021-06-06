using Microsoft.EntityFrameworkCore;
using MyCompanyName.MyProjectName.Samples;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace MyCompanyName.MyProjectName.EntityFrameworkCore
{
    public static class MyProjectNameDbContextModelCreatingExtensions
    {
        public static void ConfigureMyProjectName(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(MyProjectNameConsts.DbTablePrefix + "YourEntities", MyProjectNameConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
            builder.Entity<Sample>(s =>
            {
                s.ToTable(MyProjectNameConsts.DbTablePrefix + "Sample", MyProjectNameConsts.DbSchema);
                s.ConfigureByConvention();

                s.Property(x => x.Name).HasMaxLength(200).IsRequired();
            });
        }
    }
}