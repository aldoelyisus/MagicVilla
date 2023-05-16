using MagicVilla_Api.Modelos;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_Api.Datos
{
    public class AplicationDbContext: DbContext
    {

        public AplicationDbContext(DbContextOptions<AplicationDbContext>options): base(options)
        {
            
        }

        public DbSet<Villa>villas { get; set; }

        public DbSet<NumeroVilla> NumeroVilla { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Nombre = "Villa real",
                    Detalle = "Detalle de la villa ",
                    ImagenUrl = "",
                    Ocupantes = 5,
                    MetrosCuadrados = 55,
                    Tarifa = 200,
                    Amenidad = "",
                    FechaCreacion = DateTime.Now,
                    FechaActualizacion = DateTime.Now,
                },
                 new Villa()
                 {
                     Id = 2,
                     Nombre = "Premium vista pscina",
                     Detalle = "Detalle de la villa ",
                     ImagenUrl = "",
                     Ocupantes = 8,
                     MetrosCuadrados = 85,
                     Tarifa = 500,
                     Amenidad = "",
                     FechaCreacion = DateTime.Now,
                     FechaActualizacion = DateTime.Now,
                 });
        }
    }
}
