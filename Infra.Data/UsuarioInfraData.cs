using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoraAli.Api.Context;
using BoraAli.Api.Models;

namespace BoraAli.Api.Infra.Data
{
    public class UsuarioInfraData : BaseInfraData
    {
        private readonly BoraAliContext _context;
        public UsuarioInfraData(BoraAliContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Usuario> GetUsuarios()
        {
            return _context.Usuario.ToList();
        }
        public Usuario GetUsuarioById(int id)
        {
            return _context.Usuario.Where(x => x.Id == id).First();
        }


    }
}