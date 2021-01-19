using Restaurante.Shared.Entities;
using System;
using System.Collections.Generic;

namespace Restaurante.Domain.Entities
{
    public class Cliente : Entidade
    {


        public Cliente(string nome) 
        {
            if (string.IsNullOrEmpty(nome))
                throw new ArgumentException("Nome deve ser preenchido");
            
            Nome = nome;
        }

        public string Nome { get; private set; }
        public Pedido Pedido { get; private set; }
        public Mesa Mesa { get; private set; }


        public Pedido FazerPedido()
        {
            Pedido = new Pedido();

            return Pedido;
        }

        public void OcuparMesa(Mesa mesa)
        {
            Mesa = mesa;
        }

    }
}
