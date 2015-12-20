using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kubel.WebApi.Models
{
    public class CD
    {
        public int ID { get; set; }
        public string Artist { get; set; }
        public string Title { get; set; }
        public string Country { get; set; }
        public string Label { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
    }
}