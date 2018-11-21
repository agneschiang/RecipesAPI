using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesTestAPI.Models
{
    
    public class TagItem
    {
        [Key]
        public int TagID { get; set; }
        public string Name { get; set; }

        [ForeignKey("RecipesItem")]
        public int RecipesId { get; set; }
    }
}

