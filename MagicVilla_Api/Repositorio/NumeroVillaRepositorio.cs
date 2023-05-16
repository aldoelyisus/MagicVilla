using MagicVilla_Api.Datos;
using MagicVilla_Api.Modelos;
using MagicVilla_Api.Repositorio.IRepositorio;

namespace MagicVilla_Api.Repositorio
{
    public class NumeroVillaRepositorio : Repositorio<NumeroVilla>, INumeroVillaRepositorio
    {
        private readonly AplicationDbContext _db;

        public NumeroVillaRepositorio(AplicationDbContext db) : base(db)
        {
            _db = db;   
        }

        public async Task<NumeroVilla> Actualizar(NumeroVilla entidad)
        {
            entidad.FechaActualizacion = DateTime.Now;
            _db.NumeroVilla.Update(entidad);
            await _db.SaveChangesAsync();
            return entidad;

        }
    }
}
