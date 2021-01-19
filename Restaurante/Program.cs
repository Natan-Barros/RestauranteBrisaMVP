using Restaurante.Domain.Entities;
using System;

namespace Restaurante
{
    class Program
    {
        static void Main(string[] args)
        {
            var mesa = new Mesa(2);
            var natan = new Cliente("Natan");
            var marcos = new Cliente("Marcos");


            mesa.AdicionarCliente(natan);
            mesa.AdicionarCliente(marcos);


            var xBacon = new Item("cebola, carne de hamburguer, bacon e pão bolo", "X-Bacon", 15.0m, 1);
            var meruocano = new Item("cebola, carne de hamburguer, queijo, ovo, pão arabe", "Meruocano", 15.0m, 2);
            var pizza = new Item("cebola, tomate, carne do sol, queijo, catupiry", "Pizza carne de Sol", 15.0m, 3);

            var pedidoDoNatan = natan.FazerPedido();
            var pedidoDoMarcos = marcos.FazerPedido();

            pedidoDoMarcos.AdicionarItem(meruocano);
            pedidoDoNatan.AdicionarItem(xBacon);
            pedidoDoNatan.AdicionarItem(meruocano);
            pedidoDoNatan.AdicionarItem(pizza);

            foreach (var cliente in mesa.Clientes)
            {
                Console.WriteLine(cliente.Nome);
                Console.WriteLine("Itens: ");
                foreach (var item in cliente.Pedido.Itens)
                {
                    Console.WriteLine("nome: " + item.Nome);
                }

                Console.WriteLine("Total pedido: " + cliente.Pedido.TotalPedido());
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
