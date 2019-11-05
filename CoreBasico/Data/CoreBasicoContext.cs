using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CoreBasico.Models
{
    public class CoreBasicoContext : DbContext
    {
        public CoreBasicoContext (DbContextOptions<CoreBasicoContext> options)
            : base(options)
        {
        }

        public DbSet<CoreBasico.Models.Usuarios> Usuarios { get; set; }
    }
}
