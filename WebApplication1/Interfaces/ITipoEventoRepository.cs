using Microsoft.AspNetCore.SignalR;
using WebApplication1.Domains;

namespace Event.Interfaces
{
    public interface ITipoEventoRepository
    {

        void atualizar (Guid id, TipoEvento novotipoEvento);

        List<TipoEvento> Listar();

        void cadastrar (TipoEvento novotipoEvento);

        void deletar(Guid id, TipoEvento novotipoEvento);
        
        TipoEvento buscarporid(Guid id);
    }
}
