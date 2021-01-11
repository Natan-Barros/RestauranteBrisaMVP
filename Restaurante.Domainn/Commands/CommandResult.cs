using Restaurante.Shared.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Domain.Commands
{
    public class CommandResult : ICommandResult
    {
        public CommandResult()
        {

        }
        public CommandResult(bool sucesso, string mensagem)
        {
            Sucesso = sucesso;
            Mensagem = mensagem;
        }
        public bool Sucesso { get; set; }
        public string Mensagem { get; set; }
    }
}
