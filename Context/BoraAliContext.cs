using Microsoft.EntityFrameworkCore;

namespace BoraAli.Api.Context
{
    public class BoraAliContext : DbContext
    {
        public BoraAliContext(DbContextOptions<BoraAliContext> options) : base(options)
        {}
        
    }
}
