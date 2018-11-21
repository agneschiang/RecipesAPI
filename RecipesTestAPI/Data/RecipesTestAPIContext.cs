using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RecipesTestAPI.Models
{
    public class RecipesTestAPIContext : DbContext
    {
        public RecipesTestAPIContext (DbContextOptions<RecipesTestAPIContext> options)
            : base(options)
        {
        }

        public DbSet<RecipesTestAPI.Models.Recipes> RecipesItem { get; set; }
        public DbSet<RecipesTestAPI.Models.TagItem> TagItem { get; set; }



    }
}
