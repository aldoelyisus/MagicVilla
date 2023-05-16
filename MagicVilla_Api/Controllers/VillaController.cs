using MagicVilla_Api.Datos;
using MagicVilla_Api.Modelos;
using MagicVilla_Api.Modelos.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaController : ControllerBase
    {
        private readonly ILogger<VillaController> _logger;
        private readonly AplicationDbContext _db;

        public VillaController(ILogger<VillaController> logger, AplicationDbContext db) 
        {
            _logger = logger;
            _db = db;
        }



        [HttpGet]
        public ActionResult< IEnumerable<VillaDTO>> GetVillas() 
        {
            _logger.LogInformation("Obtener las villas");
            return Ok(_db.villas.ToList());
        }

        [HttpGet("Id:int", Name="GetVilla")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<VillaDTO> GetVilla(int id)
        {
            if(id == 0)
            {
                _logger.LogError("Error al traer la villa con Id " + id);
                return BadRequest();
            }
            //var villa = VillaStore.villaList.FirstOrDefault(v => v.Id == id);
            var villa = _db.villas.FirstOrDefault(v => v.Id == id);
            if (villa == null)
            {
                return NotFound();
            }
            return Ok(villa);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public ActionResult<VillaDTO> CrearVilla([FromBody]VillaDTO villaDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (_db.villas.FirstOrDefault(v=>v.Nombre.ToLower() == villaDTO.Nombre.ToLower()) !=null) 
            {
                ModelState.AddModelError("NombreExiste", "La villa con ese nombre ya existe");
                return BadRequest(ModelState);
            }

            if(villaDTO == null)
            {
                return BadRequest(villaDTO);
            }
            if (villaDTO.Id>0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            /* villaDTO.Id= VillaStore.villaList.OrderByDescending(v => v.Id).FirstOrDefault().Id + 1;
             VillaStore.villaList.Add(villaDTO);*/

            Villa modelo = new()
            {
           
                Nombre = villaDTO.Nombre,
                Detalle = villaDTO.Detalle,
                ImagenUrl = villaDTO.ImagenUrl,
                Ocupantes = villaDTO.Ocupantes,
                Tarifa = villaDTO.Tarifa,
                MetrosCuadrados = villaDTO.MetrosCuadrados,
                Amenidad = villaDTO.Amenidad,
            };

            _db.villas.Add(modelo);
            _db.SaveChanges();

            return CreatedAtRoute("GetVilla", new {id = villaDTO.Id}, villaDTO);
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public IActionResult DeleteVilla(int id) 
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var villa = _db.villas.FirstOrDefault(v=>v.Id == id);
            if (villa == null)
            {
                return NotFound();  
            }
           // VillaStore.villaList.Remove(villa);
           _db.villas.Remove(villa);
            _db.SaveChanges();
            return NoContent();
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public IActionResult UpdateVilla(int id, [FromBody] VillaDTO villaDTO)
        {
            if (villaDTO==null || id!= villaDTO.Id)
            {
                return BadRequest();
            }
            /*  var villa = VillaStore.villaList.FirstOrDefault(v => v.Id == id);
              villa.Nombre = villaDTO.Nombre;
              villa.Ocupantes = villaDTO.Ocupantes;
              villa.MetrosCuadrados = villaDTO.MetrosCuadrados;*/


            Villa modelo = new()
            {
                Id = villaDTO.Id,
                Nombre = villaDTO.Nombre,
                Detalle = villaDTO.Detalle,
                ImagenUrl = villaDTO.ImagenUrl,
                Ocupantes = villaDTO.Ocupantes,
                Tarifa = villaDTO.Tarifa,
                MetrosCuadrados = villaDTO.MetrosCuadrados,
                Amenidad = villaDTO.Amenidad,
            };

            _db.villas.Update(modelo);
            _db.SaveChanges();
            return NoContent();
        }

        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public IActionResult UpdatePartialVilla(int id, JsonPatchDocument<VillaDTO> PatchDto )
        {
            if (PatchDto == null || id ==0)
            {
                return BadRequest();
            }
            //var villa = VillaStore.villaList.FirstOrDefault(v => v.Id == id);
            var villa = _db.villas.AsNoTracking().FirstOrDefault(v => v.Id == id);

            VillaDTO villaDTO = new()
            {
                Id = villa.Id,
                Nombre = villa.Nombre,
                Detalle = villa.Detalle,
                ImagenUrl = villa.ImagenUrl,
                Ocupantes = villa.Ocupantes,
                Tarifa = villa.Tarifa,
                MetrosCuadrados = villa.MetrosCuadrados,
                Amenidad = villa.Amenidad
            };

            if (villa== null) return BadRequest();
            

            PatchDto.ApplyTo(villaDTO, ModelState);

            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Villa modelo = new()
            {
                Id = villaDTO.Id,
                Nombre = villaDTO.Nombre,
                Detalle = villaDTO.Detalle,
                ImagenUrl = villaDTO.ImagenUrl,
                Ocupantes = villaDTO.Ocupantes,
                Tarifa = villaDTO.Tarifa,
                MetrosCuadrados = villaDTO.MetrosCuadrados,
                Amenidad = villaDTO.Amenidad
            };

            _db.villas.Update(modelo);
            _db.SaveChanges();
            return NoContent();


        }

    }
}
