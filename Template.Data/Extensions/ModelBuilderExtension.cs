using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Domain.Entities;

namespace Template.Data.Extensions
{
    public static class ModelBuilderExtension
    {
        public static ModelBuilder SeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasData(
                    new User { Id = Guid.Parse("d0e6cb64-f79e-4a65-8252-d985e7a7fc8d"), Name = "User Default", Email = "userdefault@template.com" }
                    );
            return modelBuilder;
        }
        
    }
}
