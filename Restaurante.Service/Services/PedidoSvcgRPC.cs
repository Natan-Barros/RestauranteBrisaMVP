using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using Restaurante.Domain.Commands;
using Restaurante.Domain.Handlers;

namespace Restaurante.Service.Services
{
    public class PedidoSvcgRPC : PedidoSvc.PedidoSvcBase
    {
        private readonly ILogger<PedidoSvcgRPC> _logger;
        private readonly PedidoHandler _pedidoHandler;

        public PedidoSvcgRPC(PedidoHandler pedidoHandler)
        {
            _pedidoHandler = pedidoHandler;
        }

        public override Task<PedidoResponse> FazerPedido(PedidoRequest request, ServerCallContext context)
        {
            var pedidoCommand = new CreatePedidoCommand
            {
                NomeCliente = request.NomeCliente,
                NumeroMesa = request.NumeroMesa,
                NumerosItens = request.NumerosItens.ToList()
            };

            var response = _pedidoHandler.Handle(pedidoCommand);

            return Task.FromResult(new PedidoResponse
            {
                Mensagem = response.Mensagem,
                Sucesso = response.Sucesso
            });
        }
    }
}
