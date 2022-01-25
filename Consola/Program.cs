using Modelo.Endidades;
using ModeloDB;
using System;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lista de peliculas 
            Film Pelicula = new Film() 
            { 
             title = "Invicto",
             description = "ACCION",
             release_year = "2009",
             language = new Language()
                {
                  Name = "Español",
                  last_update = "2014"
                },
             rental_duration = "one weekend",
             rental_rate = "25%",
             length = "1:50",
             replacement_cost = "$5",
             rating = "TODO PUBLICO",
             last_update = "2010",
             special_features = "3D",
             fulltext = "ENTRETENIMIENTO DE ACCION"
     
            };
            Film PeliculaTerror = new Film()
            {
                title = "ARO",
                description = "TERROR",
                release_year = "2010",
                language = new Language()
                {
                    Name = "Ingles",
                    last_update = "2010"
                },
                rental_duration = "one weekend",
                rental_rate = "30%",
                length = "2:50",
                replacement_cost = "$7",
                rating = "TODO PUBLICO",
                last_update = "2010",
                special_features = "3D",
                fulltext = "TERROR MAYORES DE 15 AÑOS"

            };

            Repositorio db = new Repositorio();
            db.Films.Add(Pelicula);
            db.SaveChanges();
            db.Films.Add(PeliculaTerror);
                db.SaveChanges();
        }
    }
}
