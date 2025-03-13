using WebApplication1.Domains;

namespace Event.Interfaces
{
    public interface IComentarioEventoRepository
    {
        void cadastrar(ComentarioEvento novocomentarioEvento);

        void deletar (Guid id);
      

        List<ComentarioEvento>lista(Guid id);

        void atualizar (Guid id, ComentarioEvento novocomentarioEvento);

        ComentarioEvento  buscarporid (Guid idususario, Guid iddevento);
    }
}
