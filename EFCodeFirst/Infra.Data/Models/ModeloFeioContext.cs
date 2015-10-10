using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Infra.Data.Models.Mapping;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Infra.Data.Models
{
    public partial class ModeloFeioContext : DbContext
    {
        static ModeloFeioContext()
        {
            Database.SetInitializer<ModeloFeioContext>(null);
        }

        public ModeloFeioContext()
            : base("Name=ModeloFeioContext")
        {
        }

        //public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new EnderecoMap());
            modelBuilder.Configurations.Add(new PessoaMap());

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>().Configure(x => x.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(x => x.HasMaxLength(100));

           // modelBuilder.Properties().Where(x => x.ReflectedType.Name == x.Name + "Id").Configure(x => x.IsKey());
            modelBuilder.Properties().Where(x => x.Name == x.ReflectedType.Name + "Id").Configure(x => x.IsKey());
        }
    }
}
