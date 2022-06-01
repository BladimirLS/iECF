using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace iECF
{
    public class iECFContext : DbContext
    {
        public iECFContext()
            : base("name=iECFContext")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public DbSet<DgiiToken> DgiiTokens { get; set; }
        public DbSet<ECFEncabezado> ECFEncabezado { get; set; }
        public DbSet<ECFEncabezadoComprador> ECFEncabezadoComprador { get; set; }
        public DbSet<ECFEncabezadoEmisor> ECFEncabezadoEmisor { get; set; }
        public DbSet<ECFEncabezadoIdDoc> ECFEncabezadoIdDoc { get; set; }
        public DbSet<RecepcionResult> RecepcionResult { get; set; }

        
    }
}
