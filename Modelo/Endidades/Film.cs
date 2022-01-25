using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Endidades
{
    public class Film
    {
        public int filmId { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string release_year { get; set; }
        public int language_Id { get; set; }
        public string rental_duration { get; set; }
        public string rental_rate { get; set; }
        public string length { get; set; }
        public string replacement_cost { get; set; }
        public string rating { get; set; }
        public string last_update { get; set; }
        public string special_features { get; set; }
        public string fulltext { get; set; }



        //Relacion con lenguaje 
        public Language language { get; set; }
    }
}
