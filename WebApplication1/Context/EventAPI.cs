using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Domains;

namespace Event.Context
{
    public class EventAPI
    {
        public class EventAPI_context : DbContext

        {
            public EventAPI_context()
            {
            }
        
            public EventAPI_context(DbContextOptions<EventAPI_context> options) : base(options)
            {
            }

            public DbSet<ComentarioEvento> comentarioEvento { get; set; }
            public DbSet<Eventos> eventos { get; set; }

            public DbSet<Instituicao> instituicaos { get; set; }

            public DbSet<Presenca> presenca { get; set; }
            public DbSet<TipoEvento> tipoEvento { get; set; }
            public DbSet<TipoUsuario> tipoUsuario { get; set; }
            public DbSet<Usuario> usuario { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseSqlServer("server = DESKTOP-0L5VRFL\\SQLEXPRESS; Database = Event; User Id = sa; Pwd = Senai@134; TrustServerCertificate=true;");
                }
            }
        }
    }


}

