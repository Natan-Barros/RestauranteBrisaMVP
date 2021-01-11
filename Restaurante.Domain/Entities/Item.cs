using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Domain.Entities
{
    public class Item : Entidade
    {
        public int Descricao { get; private set; }
        public int Nome { get; set; }
        public decimal Preco { get; set; }

    }
}
