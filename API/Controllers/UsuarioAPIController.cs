using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace API.Controllers
{
    [Route("api/Usuario")]
    [ApiController]
    public class UsuarioAPIController : ControllerBase
    {
        private readonly PessoaDAO pDAO;

        public UsuarioAPIController(PessoaDAO pessoaDAO)
        {
            pDAO = pessoaDAO;
        }

        //  GET: /api/Pessoa/ListarTodos
        [HttpGet]
        [Route("ListarTodos")]
        public IActionResult ListarTodos()
        {
            return Ok(pDAO.ListarTodos());
        }

    }
}