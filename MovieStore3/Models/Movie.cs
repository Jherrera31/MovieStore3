using MovieStore3.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieStore3.Models
{
    public class Movie : BaseEntity

    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
    }
}