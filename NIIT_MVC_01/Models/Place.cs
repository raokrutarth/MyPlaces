using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MyPlaces.Models
{
    public class Place
    {
        public long ID { get; set; }

        [Display(Name = "Place Name"), Required]
        public string PlaceName { get; set; }

        [Display(Name = "Street Address"), Required]
        public string streetAddress { get; set; }

        [Display(Name = "Residents")]
        public string residents { get; set; }

        [Display(Name = "Frequency of visit")]
        public int visitFrequency { get; set; }

        [Display(Name = "Place Type")]
        public string placeType { get; set; }

    }
}