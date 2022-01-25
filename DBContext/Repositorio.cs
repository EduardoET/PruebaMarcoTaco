using Microsoft.EntityFrameworkCore;
using Modelo.Endidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDB
{
    public class Repositorio : DbContext
    {
        //configuraciones de entidades 
        public DbSet<Film> Films { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Language> languages { get; set; }

        //configuracion de la conexion 
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data source = DESKTOP - 9D8KVK4; Integrated Security = true; Initial Catalog = Prueba1; ");
        }
    }
    
    
}   
