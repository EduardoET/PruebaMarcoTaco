using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Endidades
{
    public class Inventory
    {
        public int inventoryId { get; set; }
        public int film_Id { get; set; }
        public int store_Id { get; set; }
        public string last_update { get; set; }

        //Relacion con film 
        public Film film { get; set; }
    }
}
