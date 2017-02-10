using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Review_Site_Project.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }

    }
}