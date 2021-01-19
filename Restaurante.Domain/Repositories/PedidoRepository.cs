using Restaurante.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Restaurante.Shared.Entities;

namespace Restaurante.Domain.Repositories
{
    public class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {

        public PedidoRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public void Salvar(Pedido pedido)
        {
            dbSet.Add(pedido);
            contexto.SaveChanges();
        }
    }
}
