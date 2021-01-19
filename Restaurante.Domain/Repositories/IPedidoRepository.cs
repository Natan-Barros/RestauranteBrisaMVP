using Restaurante.Domain.Entities;

namespace Restaurante.Domain.Repositories
{
    public interface IPedidoRepository
    {
        void Salvar(Pedido pedido);
    }
}