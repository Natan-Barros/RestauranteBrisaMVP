using Restaurante.Shared.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Domain.Commands
{
    public class CreatePedidoCommand : ICommand
    {
        public int NumeroMesa { get; set; }
        public string NomeCliente { get; set; }
        public List<int> NumeroItem { get; set; }

    }
}
