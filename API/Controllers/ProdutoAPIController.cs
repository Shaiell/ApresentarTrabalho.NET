using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace API.Controllers
{
    [Route("api/Produto")]
    [ApiController]
    public class ProdutoAPIController : ControllerBase
    {
        private readonly ProdutoDAO pDAO;

        public ProdutoAPIController(ProdutoDAO produtoDAO)
        {
            pDAO = produtoDAO;
        }

        //  GET: /api/Produto/ListarTodos
        [HttpGet]
        [Route("ListarTodos")]
        public IActionResult ListarTodos()
        {
            return Ok(pDAO.ListarTodos());
        }
    }
}