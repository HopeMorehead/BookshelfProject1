using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookshelfProject1.Models
{
    public class Book
    {
        //Private fields are created
        //when your are building a model in c# you will always want an ID
        //The ID is the key identification
        //giving each object an identifier
        //ForeignKey how to establish relationship with another class or table
        //[key] key is only relevant to whats underneath it.
        //Primary key
        //The keys that are gernerated for users is a string primary key doesn't have to be an int
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }

        //ForeignKey
        [ForeignKey("Category")]
        public int CategoryID { get; set; }
                       //object name + object name again = navigation property
                       //nav prop=allows to connect classes
        public virtual Category category { get; set; }



    }
}