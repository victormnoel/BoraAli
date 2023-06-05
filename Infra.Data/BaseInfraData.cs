using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoraAli.Api.Context;

namespace BoraAli.Api.Infra.Data
{
    public class BaseInfraData : IBaseInfraData
    {
        private readonly BoraAliContext _context;
        public BaseInfraData(BoraAliContext context)
        {
            _context = context;
            
        }
        public void Add<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public void Delete<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }
    }
}