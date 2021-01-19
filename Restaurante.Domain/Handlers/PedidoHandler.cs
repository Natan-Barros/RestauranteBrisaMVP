using Restaurante.Domain.Commands;
using Restaurante.Domain.Entities;
using Restaurante.Domain.Repositories;
using Restaurante.Shared.Commands;
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

        public CommandResult Handle(CreatePedidoCommand command)
        {
            var cliente = new Cliente(command.NomeCliente);

            var pedido = cliente.FazerPedido();

            List<Item> itens = _ItemRepository.BuscaPedidos(command.NumerosItens);

            pedido.AdicionarItens(itens);
            _PedidoRepository.Salvar(pedido);

            return new CommandResult { Mensagem = "Total pedido: " + cliente.Pedido.TotalPedido(), Sucesso = true };
        }
    }
}
