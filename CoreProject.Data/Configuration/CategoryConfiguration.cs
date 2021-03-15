using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using CoreProject.Core.Models;

namespace CoreProject.Data.Configurations
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);//x.Id 'yi primarykey olarak al diyorum

            builder.Property(x => x.Id).UseIdentityColumn();// id'yi IdentityColumn olarak al demis oldum

            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);

            builder.ToTable("Categories");//tablonun ismini veriyorum
            //builder.ToTable("Categories","");//esktra semada verebiliriz
        }
    }
}