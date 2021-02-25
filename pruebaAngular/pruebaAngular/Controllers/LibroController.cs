using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pruebaAngular.Model;
using pruebaAngular.Repository;

namespace pruebaAngular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibroController : ControllerBase
    {
        private readonly ILibroService _libroService;

        public LibroController(ILogger<LibroController> logger,
            ILibroService libroService)
        {
            _libroService = libroService;
        }


        [HttpGet]        
        public IActionResult GetLibros(string titulo,string autor,int anho,string editorial,string genero)
        {
            try
            {                
                return new JsonResult( _libroService.GetLibros(autor, titulo, anho,editorial,genero) );
            }
            catch (Exception e)
            {
                return new JsonResult(new { message = "Error al leer libros" });
            }
        }
        [HttpPost]
        public IActionResult PostLibro(Libro libro)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _libroService.Insert(libro);
                    return CreatedAtAction("GetLibro", new { id = libro.idLibro }, libro);
                }
                return new JsonResult(new { message = "faltan campos obligatoriosd" });
            }
            catch (Exception e)
            {
                string message = "";
                if(e.InnerException==null)
                {
                    message = e.Message;
                }
                else if (e.InnerException.Message.Contains("FK_EDI"))
                {
                    message = "La editorial no está registrada";
                }
                else if (e.InnerException.Message.Contains("FK_AUT"))
                {
                    message = "El autor no está registrado";
                }
                return new JsonResult(new { message= message });
            }
            

        }

    }
}