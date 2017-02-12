using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_Review_Site_Project.Models
{
    public class Review
    {
        
        [Key]
        public int ID { get; set; } //Our key is set as ID
        public string Name { get; set; }
        public DateTime PublishDate { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }


        [ForeignKey("Category")] // calls ID for categoryID
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}