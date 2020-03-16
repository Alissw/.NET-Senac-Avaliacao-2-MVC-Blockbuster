using System;
using System.Collections.Generic;

namespace Models
{
    class Locacao
    {
        public static int idLocacao {get; set;}
        static Cliente Cliente;
        public static DateTime dataLocacao = DateTime.Now;
        static List<Filme> filmes = new List<Filme>();
        public Locacao(int idLocacao, Cliente cliente)
        {
            Locacao.idLocacao = idLocacao;
            Cliente = cliente;
        }
        //Mostra os dados da locação
        public static void dadosLocacao()
        {

            Console.WriteLine("###Locações feitas###");
            Console.WriteLine("ID locação " + Locacao.idLocacao);
            Console.WriteLine("Data da locação: " + Locacao.dataLocacao.ToString("dd/MM/yyyy"));
            Console.WriteLine("Data da devolução: " + Devolver());
            Console.WriteLine("Dias locados: " + Cliente.diasDevolucao);
            Console.WriteLine("Quantidade de filmes locados: " + QtdFilmeLocados());
            Console.WriteLine();
            Console.WriteLine("###Filmes###");
            mostrarFilme();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Total a pagar: R$ " + valorTotal().ToString("F"));
        }
        //Adiciona um filme
        public static void addFilme(Filme filme)
        {
            filmes.Add(filme);
        }
        //Mostra dados breve do(s) filme(s) locado(s)
        public static void mostrarFilme()
        {
            System.Text.StringBuilder txt = new System.Text.StringBuilder();
            foreach (Filme filme in filmes)
            {
                Console.WriteLine(filme.nomeFilme + ", R$ " + filme.valorLocacao.ToString("F"));
            }
        }
       //Mostra quantidade de filmes locados 
        public static int QtdFilmeLocados()
        {
            return Locacao.filmes.Count;
        }
        //Calcula data de devolução
        public static String Devolver()
        {

            DateTime data = DateTime.Now;
            return data.AddDays(Cliente.diasDevolucao).ToString("dd/MM/yyyy");
        }
        //Calcula valor total do(s) filme(s) locado(s)
        public static float valorTotal()
        {
            float valorTotal = 0;
            foreach (Filme filme in filmes)
            {
                valorTotal += filme.valorLocacao;
            }
            return valorTotal;
        }
    }
}