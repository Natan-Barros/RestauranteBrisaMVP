using Restaurante.Shared.Entities;
using System;
using System.Collections.Generic;

namespace Restaurante.Domain.Entities
{
    public class Cliente : Entidade
    {
        public Cliente(string nome, Mesa mesa) 
        {
            if (string.IsNullOrEmpty(nome))
                throw new ArgumentException("Nome deve ser preenchido");

            if (mesa.Status == Enums.EStatus.Livre)
                mesa.OcuparMesa();
            
            Nome = nome;
            Mesa = mesa;
            Mesa.AdicionarCliente(this);
        }

        public string Nome { get; private set; }
        public Pedido Pedido { get; private set; }
        public Mesa Mesa { get; private set; }


        public Pedido FazerPedido()
        {
            Pedido = new Pedido(Mesa);

            return Pedido;
        }

    }
}
