using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesTestAPI.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RecipesTestAPIContext(
                serviceProvider.GetRequiredService<DbContextOptions<RecipesTestAPIContext>>()))
            {
                // Look for any movies.
                if (context.RecipesItem.Count() > 0 )
                {
                    return;   // DB has been seeded
                }
                if (context.TagItem.Count() > 0)
                {
                    return;   // DB has been seeded
                }
                context.RecipesItem.AddRange(
                    new Recipes
                    {
                        Title = "Is Mayo an Instrument?",
                        Description = "This is the description part",
                        Ingredient = "This is the ingredient part teating",
                        Url = "https://i.kym-cdn.com/photos/images/original/001/371/723/be6.jpg",
                        Tag = new List<TagItem> {
                           new TagItem { Name = "Tag 1"},
                           new TagItem { Name = "Tag 2"}
                        },
                        Uploaded = "07-10-18 4:20T18:25:43.511Z",
                    }


                );
                context.SaveChanges();
            }
        }



    }
}
