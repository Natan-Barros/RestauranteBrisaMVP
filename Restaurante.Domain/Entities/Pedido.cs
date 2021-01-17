using Restaurante.Shared.Entities;
using System;
using System.Collections.Generic;

namespace Restaurante.Domain.Entities
{
    public class Pedido : Entidade
    {
        public Pedido(Mesa mesa)
        {
            Mesa = mesa;
            Itens = new List<Item>();
        }

        public IList<Item> Itens { get; private set; }
        public Mesa Mesa { get; private set; }

        public void AdicionarItem(Item item)
        {
            if (string.IsNullOrEmpty(item.Descricao))
                throw new ArgumentException("Descricao do item deve ser preenchida");

            if (string.IsNullOrEmpty(item.Nome))
                throw new ArgumentException("Nome do item deve ser preenchida");

            if (item.Preco < 0.0m)
                throw new ArgumentException("Preco é invalido");

            Itens.Add(item);
        }

        public void AdicionarItens(List<Item> itens)
        {
            foreach (var item in itens)
            {
                AdicionarItem(item);
            }
        }

        public decimal TotalPedido()
        {
            var precoTotal = 0.0m;

            foreach (var item in Itens)
            {
                precoTotal += item.Preco;
            }

            return precoTotal;
        }


    }
}
