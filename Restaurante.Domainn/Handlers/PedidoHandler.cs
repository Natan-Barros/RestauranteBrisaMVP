using Restaurante.Domain.Commands;
using Restaurante.Domain.Entities;
using Restaurante.Shared.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Domain.Handlers
{
    public class PedidoHandler 
    {
        public ICommandResult Handle(CreatePedidoCommand command)
        {
            var mesa = new Mesa(command.NumeroMesa);
            var cliente = new Cliente(command.NomeCliente, mesa);

            var pedido = cliente.FazerPedido();

            var xBacon = new Item("cebola, carne de hamburguer, bacon e pão bolo", "X-Bacon", 15.0m, 1);
            pedido.AdicionarItem(xBacon);

            return new CommandResult { Mensagem = "Total pedido: " + cliente.Pedido.TotalPedido(), Sucesso = true };
        }
    }
}
