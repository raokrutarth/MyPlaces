using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPlaces.DatabaseContext
{
    public class PlaceDbContext : System.Data.Entity.DbContext
    {
        public PlaceDbContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<MyPlaces.Models.Place> Movies { get; set; }
    }
}