using MovieStore3.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MovieStore3.Models
{

    public class MoviesStoreContext : DbContext
    {
        public MoviesStoreContext()

        : base("name=MovieStore")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MoviesStoreContext, Configuration>("MovieStore"));
        }

        public virtual DbSet<Movie> Movies { get; set; }

        public virtual DbSet<Category> CategorieS { get; set; }

        public int Coount { get; set; }

      }
}