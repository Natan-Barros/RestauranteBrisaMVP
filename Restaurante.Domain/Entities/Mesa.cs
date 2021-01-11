using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Domain
{
    public class Mesa : Entidade
    {
        public int Numero { get; private set; }
        public bool Ativa { get; private set; }
    }
}
