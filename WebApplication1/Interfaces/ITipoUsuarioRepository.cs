using WebApplication1.Domains;

namespace Event.Interfaces
{
    public interface ITipoUsuarioRepository
    {
        void atualizar(Guid id, TipoUsuario tipoUsuario);    
        void deletar (Guid id);

        void cadastrar (TipoUsuario tipoUsuario);

        List<TipoUsuario> lista();

        TipoUsuario buscarporid(Guid id);

    }
}
