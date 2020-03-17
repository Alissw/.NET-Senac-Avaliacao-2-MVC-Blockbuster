using System;
using System.Collections.Generic;
using Models;

namespace Models
{
    class Locacao
    {
        public static int idLocacao {get; set;}
        static Cliente Cliente;
        public static DateTime dataLocacao = DateTime.Now;

        public List<Filme> filmes = new List<Filme>();
        static List<Locacao> locacaos = new List<Locacao>();
        public Locacao(int idLocacao, Cliente cliente)
        {
            Locacao.idLocacao = idLocacao;
            Cliente = cliente;
            adicionarLocacao(this);
            
        }

        public void adicionarFilme(Filme filme){
            filmes.Add(filme);
        }
        
        //Mostra os dados da locação
        public override string ToString()
        {

            return
             ("###Locações feitas###" + "\n")
            +("ID locação: ")
            + (Locacao.idLocacao + "\n")
            +("Data da locação: ")
            + (Locacao.dataLocacao.ToString("dd/MM/yyyy")+ "\n")
            +("Data da devolução: ")
            + (Devolver())
            +("Dias locados: " )
            + (Cliente.diasDevolucao + "\n")
            +("Quantidade de filmes locados: ")
            + (QtdFilmeLocados() + "\n")
            +("###Filmes###" + "\n")
            +(filmes.ForEach( filmes =>  filmes))
            +( "\n")
           +("-------------------------------------------------")
           +("Total a pagar: R$ ")
           + (valorTotal().ToString("F"));
        }
        //Adiciona um filme
        public static void adicionarLocacao(Locacao locacao)
        {
            locacaos.Add(locacao);
        }
        //Mostra dados breve do(s) filme(s) locado(s)
        public static List<Locacao> mostrarLocacaos()
        {
            return locacaos;
            
        }
       //Mostra quantidade de filmes locados 
        public static int QtdFilmeLocados()
        {
            return Filme.mostrarFilmes().Count;
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
            foreach (Filme filme in Filme.mostrarFilmes())
            {
                valorTotal += filme.valorLocacao;
            }
            return valorTotal;
        }
    }
}