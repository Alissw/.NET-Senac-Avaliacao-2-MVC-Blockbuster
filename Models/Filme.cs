using System;
using System.Collections.Generic;

namespace Models
{
    class Filme
    {
       public int idFilme {get; set;}
       public String nomeFilme {get; set;}
       public String dataLancamento {get; set;}
       public String sinopse {get; set;}
       public float valorLocacao {get; set;}
       public int estoque {get; set;}
       public int qtdLocado {get; set;}

       static List<Filme> filmes = new List<Filme>();

        public Filme(int idFilme, String nomeFilme, String dataLancamento, String sinopse, float valorLocacao, int estoque, int qtdLocado)
        {
            this.idFilme = idFilme;
            this.nomeFilme = nomeFilme;
            this.dataLancamento = dataLancamento;
            this.sinopse = sinopse;
            this.valorLocacao = valorLocacao;
            this.estoque = estoque;
            this.qtdLocado = 0;
            adicionarFilme(this);
        }

        public static void adicionarFilme(Filme filme){
            filmes.Add(filme);
        }

        public static List<Filme> mostrarFilmes(){
            return filmes;
        }

        public override string ToString(){
            return
            ("##DADOS DO FILME##")
            +("Id filme: " + idFilme)
            +("Nome filme: " + nomeFilme)
            +("Data lancamento: ")
            +("Valor locação: " + valorLocacao);
        }
    }
}