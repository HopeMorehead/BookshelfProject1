using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookshelfProject1.Models
{
    public class Category
    {




        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        //ICollection is a navigation property
        //Foriegn key is a collection = list =many to many
        public virtual ICollection<Book> Books { get; set; }
    }
}