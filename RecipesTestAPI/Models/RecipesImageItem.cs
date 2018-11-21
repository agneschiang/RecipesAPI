using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesTestAPI.Models
{
    public class RecipesImageItem
    {
        public string Title { get; set; }
        public List<TagItem> Tag { get; set; }
        public IFormFile Image { get; set; }
    }
}
