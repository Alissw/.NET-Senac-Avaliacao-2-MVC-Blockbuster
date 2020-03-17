using System;
using System.Collections.Generic;
using Controllers;
using Models;

namespace Views{
    class FilmesView
    {
        public static Filme inserirFilme(int idFilme, String nomeFilme, String dataLancamento, String sinopse, float valorLocacao, int estoque, int qtdLocado){
            return FilmesControllers.adicionarFilmes(idFilme, nomeFilme, dataLancamento, sinopse, valorLocacao, estoque, qtdLocado);
        }
        public static void mostraFilmes(){
            foreach(Filme filmes in FilmesControllers.mostrarFilmes()){
                Console.WriteLine(filmes.ToString());
            }
        }
    }
}