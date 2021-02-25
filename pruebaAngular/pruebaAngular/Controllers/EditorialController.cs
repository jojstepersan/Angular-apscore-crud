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
    public class EditorialController : ControllerBase
    {
        private readonly IEditorialService _editorialService;

        public EditorialController(IEditorialService editorialService)
        {
            _editorialService = editorialService;
        }
        [HttpPost]
        public IActionResult PostEditorial(Editorial editorial)
        {
            if (ModelState.IsValid)
            {
                _editorialService.Insert(editorial);
                return CreatedAtAction("GetEditorial", new { id = editorial.idEditorial }, editorial);
            }
            return new JsonResult(new { message = "faltan campos obligatorios" });

        }
    }
}