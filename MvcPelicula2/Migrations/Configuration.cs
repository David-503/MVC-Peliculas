namespace MvcPelicula2.Migrations
{
    using MvcPelicula2.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcPelicula2.Models.PeliculaDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MvcPelicula2.Models.PeliculaDBContext";
        }

        protected override void Seed(MvcPelicula2.Models.PeliculaDBContext context)
        {
            context.Peliculas.AddOrUpdate(i=>i.Titulo,
            new Pelicula
            {
                Titulo = "Harry Potter y las reliquias de la muerte 2",
                FechaLanzamiento = DateTime.Parse("2011-3-15"),
                Genero = "Ficción",
                Precio = 8.99M
            },
             new Pelicula
             {
                 Titulo = "Harry Potter y la pieda filosofal",
                 FechaLanzamiento = DateTime.Parse("2001-11-16"),
                 Genero = "Ficçión",
                 Precio = 10.99M
             },
             new Pelicula
             {
                 Titulo = "Salvando al soldado Ryan",
                 FechaLanzamiento = DateTime.Parse("1998-07-24"),
                 Genero = "Guerra",
                 Precio = 3.99M
             },
             new Pelicula
             {
                 Titulo = "ET",
                 FechaLanzamiento = DateTime.Parse("1982-6-11"),
                 Genero = "Fantasia",
                 Precio = 2.99M
             }
             );

        }
    }
}
