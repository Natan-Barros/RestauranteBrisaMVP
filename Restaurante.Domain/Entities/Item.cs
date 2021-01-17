using Restaurante.Shared.Entities;

namespace Restaurante.Domain.Entities
{
    public class Item : Entidade
    {
        public Item(string descricao, string nome, decimal preco, int numero) 
        {
            Descricao = descricao;
            Nome = nome;
            Preco = preco;
            Numero = numero;
        }

        public string Descricao { get; private set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Numero { get; private set; }

    }
}
