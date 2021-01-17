using Restaurante.Domain.Enums;
using Restaurante.Shared.Entities;
using System;
using System.Collections.Generic;

namespace Restaurante.Domain.Entities
{
    public class Mesa : Entidade
    {
        public Mesa(int numero)
        {
            Numero = numero;
            Status = EStatus.Livre;
            Clientes = new List<Cliente>();
        }

        public int Numero { get; private set; }
        public EStatus Status { get; private set; }
        public List<Cliente> Clientes { get; private set; }

        public void ReservarMesa()
        {
            if (Status == EStatus.Ocupado)
                throw new Exception("Mesa ocupada");
            
            if (Status == EStatus.Reservado)
                throw new Exception("Mesa Reservada");
            
            Status = EStatus.Reservado;
        }

        public void OcuparMesa()
        {
            if (Status == EStatus.Ocupado)
                throw new Exception("Mesa ocupada");

            if (Status == EStatus.Reservado)
                throw new Exception("Mesa Reservada");

            Status = EStatus.Ocupado;
        }

        public void AdicionarCliente(Cliente cliente)
        {
            if(string.IsNullOrEmpty(cliente.Nome))
            {
                throw new ArgumentException("Nome deve ser preenchido");
            }
     
            Clientes.Add(cliente);
        }

    }
}
