using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace API.Controllers
{
    [Route("api/Categoria")]
    [ApiController]
    public class CategoriaAPIController : ControllerBase
    {
        private readonly CategoriaDAO cDAO;

        public CategoriaAPIController(CategoriaDAO categoriaDAO)
        {
            cDAO = categoriaDAO;
        }

        //  GET: /api/Categoria/ListarTodos
        [HttpGet]
        [Route("ListarTodos")]
        public IActionResult ListarTodos()
        {
            return Ok(cDAO.ListarTodos());
        }
    }
}