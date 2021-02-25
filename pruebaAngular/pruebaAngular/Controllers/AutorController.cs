using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pruebaAngular.Model;
using pruebaAngular.Repository;

namespace pruebaAngular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private readonly IAutorService _autorService;

        public AutorController(IAutorService autorService)
        {
            _autorService = autorService;
        }
        [HttpPost]
        public IActionResult PostAutor(Autor autor)
        {
            if (ModelState.IsValid)
            {
                _autorService.Insert(autor);
                return CreatedAtAction("GetAutor", new { id = autor.idAutor }, autor);
            }
            return new JsonResult( new { message = "faltan campos obligatorios" });
            
        }

    }
}