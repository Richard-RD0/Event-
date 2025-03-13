using WebApplication1.Domains.Event.Domains;

namespace Event.Interfaces
{
    public interface IUsuarioRepository
    {
        void cadastrar (Usuario novousuario);   
       
        Usuario buscarPorid (Guid id);

        Usuario buscarPorEmailESenha (string email, string senha);
    }
}
