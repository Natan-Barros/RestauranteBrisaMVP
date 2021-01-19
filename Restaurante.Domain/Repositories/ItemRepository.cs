using Restaurante.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurante.Domain.Repositories
{
    public class ItemRepository : BaseRepository<Item>, IItemRepository
    {
        public ItemRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public List<Item> BuscaPedidos(List<int> numerosItens)
        {
            return dbSet.Where(i => numerosItens.Contains(i.Numero)).ToList();
        }
    }
}
