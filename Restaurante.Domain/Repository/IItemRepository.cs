using Restaurante.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Shared.Repository
{
    public interface IItemRepository
    {
        List<Item> BuscaPedidos(List<int> numerosItens);
    }
}
