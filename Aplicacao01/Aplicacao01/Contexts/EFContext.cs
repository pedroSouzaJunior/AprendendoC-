using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models;
using System.Data.Entity;

namespace Aplicacao01.Contexts
{
    public class EFContext: DbContext
    {
        public EFContext(): base("Connection_String_Pedro") { }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Fabricante> Fabricantes { get; set; }
    }
}