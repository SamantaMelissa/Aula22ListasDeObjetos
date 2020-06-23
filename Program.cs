using System;
using System.Collections.Generic; //Para uso de listas


namespace Aula22ListaDeObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação de uma nova lista do tipo "Produto"
            List<Produto> produtos = new List<Produto>();

            // Criação de um produto através do construtor padrão
            Produto produto1 = new Produto();
            produto1.Codigo = 1;
            produto1.Nome = "SmartTV LG";
            produto1.Preco = 3999.99f;

            // Adicionar o produro criado na lista

            produtos.Add(produto1);

            //Adicionamos mais produtos utilizando o novo construtor
            produtos.Add( new Produto(2, "Geladeira Eletrolux", 6800.90f));
            produtos.Add( new Produto(3, "Microondas", 399.90f));
            produtos.Add( new Produto(4, "Hair Fraire", 459.90f));
            produtos.Add( new Produto(5, "Rádio LG", 699.90f));
            produtos.Add( new Produto(6, "Fogão", 1499.90f));
           

            //Varremos a lista com FOREACH
            foreach (Produto item in produtos)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($" {item.Nome} - R$ {item.Preco} ");
                Console.ResetColor();
            }

            //Remover item passando o objeto como argumento
            produtos.Remove(produto1);

            //Remover item pelo índice
            produtos.RemoveAt(2);

             foreach (Produto item in produtos)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($" {item.Nome} - R$ {item.Preco} ");
                Console.ResetColor();
            }

            //Usar expressão lambda para eliminar (RemoveAll) ou achar (Find) um registro

            Produto Microondas = produtos.Find( x => x.Codigo == 3);
            Console.WriteLine ("Microondas - R$"+Microondas.Preco);

            //LISTA DE CARTÃO

            List<Cartao> cartoes = new List<Cartao>();

            // Criação de um produto através do construtor padrão
            Cartao cartao1 = new Cartao();
            cartao1.Titular = "Célia Nunes";
            cartao1.numero = 4598556;
            cartao1.bandeira = "Visa";
            cartao1.cvv = 656;

            Console.WriteLine("");
            // Adicionar o produro criado na lista

            cartoes.Add(cartao1);

            //Adicionamos mais produtos utilizando o novo construtor
            cartoes.Add( new Cartao("Julia Gomes", 5878556, "MasterCard", 896));
            cartoes.Add( new Cartao("Ana Victora", 8167595, "Elo", 966));
            cartoes.Add( new Cartao("Marcos Júnior", 5955236, "Hipercard", 014));
            cartoes.Add( new Cartao("Alex Rodrigues", 895456, "American Express", 213));
            cartoes.Add( new Cartao("Mel Duarte", 3052556, "Discovery Network", 986));
           

            //Varremos a lista com FOREACH
            foreach (Cartao item in cartoes)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine($" Titular: {item.Titular} ");
                Console.WriteLine($" Numero: {item.numero} ");
                Console.WriteLine($" Bandeira: {item.bandeira} ");
                Console.ResetColor();
            }


        }
    }
}
