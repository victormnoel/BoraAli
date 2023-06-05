using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoraAli.Api.Infra.Data;
using Microsoft.AspNetCore.Mvc;

namespace BoraAli.Api.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioInfraData _usuarioInfra;
        public UsuarioController(UsuarioInfraData usuarioInfra)
        {
            _usuarioInfra = usuarioInfra;

        }

        [HttpGet("Usuarios")]
        public IActionResult GetUsuarios()
        {
            var usuarios = _usuarioInfra.GetUsuarios();
            return usuarios.Any() ? Ok(usuarios) : BadRequest("Usuario nao encontrado");
        }

        [HttpGet("Usuario/{id]")]
        public IActionResult GetUsuarioById(int id)
        {
            var usuario = _usuarioInfra.GetUsuarioById(id);
            return usuario != null ? Ok(usuario) : BadRequest("Usuario nao encontrado");
        }
    }
}