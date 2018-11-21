﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesTestAPI.Models
{
    public class Recipes
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Ingredient { get; set; }
        public string Url { get; set; }
        public List<TagItem> Tag { get; set; }
        public string Uploaded { get; set; }

    }

    
}