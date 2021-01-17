using Restaurante.Domain.Commands;
using Restaurante.Domain.Entities;
using Restaurante.Shared.Commands;
using Restaurante.Shared.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Domain.Handlers
{
    public class PedidoHandler 
    {
        private readonly IItemRepository _ItemRepository;
        private readonly IPedidoRepository _PedidoRepository;

        public PedidoHandler(IItemRepository itemRepository, IPedidoRepository pedidoRepository)
        {
            _ItemRepository = itemRepository;
            _PedidoRepository = pedidoRepository;
        }

        public ICommandResult Handle(CreatePedidoCommand command)
        {
            var mesa = new Mesa(command.NumeroMesa);
            var cliente = new Cliente(command.NomeCliente, mesa);

            var pedido = cliente.FazerPedido();

            List<Item> itens = _ItemRepository.BuscaPedidos(command.NumerosItens);

            pedido.AdicionarItens(itens);

            return new CommandResult { Mensagem = "Total pedido: " + cliente.Pedido.TotalPedido(), Sucesso = true };
        }
    }
}
