using MovieStore3.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieStore3.Models
{
    public class Category  : BaseEntity
    {
        public string Name { get; set; }
    }
}