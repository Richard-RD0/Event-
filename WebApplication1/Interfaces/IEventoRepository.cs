using WebApplication1.Domains;

namespace Event.Interfaces
{
    public interface IEventoRepository
    {
        void cadastrar(TipoEvento tipoevento);
        List<Eventos> listarProximosEventos(Eventos proximosEventos);
        List<Eventos> listar();
        Eventos BuscarPorid(Guid id);
        void atualizar (Guid id, Eventos eventos);
        void deletar (Guid id);

    }
}
