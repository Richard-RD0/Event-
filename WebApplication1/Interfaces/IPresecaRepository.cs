using WebApplication1.Domains;

namespace Event.Interfaces
{
    public interface IPresecaRepository
    {
        void deletar (Guid id); 
        void enscrever(Presenca presenca);
        void atualizar (Guid id, Presenca novapresencaatualizada);
        List<Presenca> listar();

        Presenca BuscarPorid (Guid id); 
        List<Presenca>listarMinhas(Eventos eventos); 

    }
}
