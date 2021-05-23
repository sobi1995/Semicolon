//using Domain.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Infrastructure.EntityConfig
//{
//  public  class CategoriesConfig : IEntityTypeConfiguration<Categories>
//    {
//        public void Configure(EntityTypeBuilder<Categories> builder)
//        {
//            builder.HasMany(x => x.CategoriesParent)
//                .WithOne(x => x.Categorie)
//                .HasForeignKey(x => x.CategoriesId);

//            builder.HasMany(x => x.Post)
//             .WithOne(x => x.Categories)
//             .HasForeignKey(x => x.CategoriesId);


//        }
//    }
//}
