using MagicVilla_Api.Datos;
using MagicVilla_Api.Modelos;
using MagicVilla_Api.Repositorio.IRepositorio;

namespace MagicVilla_Api.Repositorio
{
    public class VillaRepositorio : Repositorio<Villa>, IVillaRepositorio
    {
        private readonly AplicationDbContext _db;

        public VillaRepositorio(AplicationDbContext db) : base(db)
        {
            _db = db;   
        }

        public async Task<Villa> Actualizar(Villa entidad)
        {
            entidad.FechaActualizacion = DateTime.Now;
            _db.villas.Update(entidad);
            await _db.SaveChangesAsync();
            return entidad;

        }
    }
}
