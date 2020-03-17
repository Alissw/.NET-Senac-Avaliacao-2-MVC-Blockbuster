using System;
using System.Collections.Generic;
using Models;
namespace Controllers{
    class FilmesControllers
    {
        public static Filme adicionarFilmes(int idFilme, String nomeFilme, String dataLancamento, String sinopse, float valorLocacao, int estoque, int qtdLocado){
            return new Filme(idFilme, nomeFilme, dataLancamento, sinopse, valorLocacao, estoque, qtdLocado);
        }

        public static List<Filme> mostrarFilmes(){
            return Filme.mostrarFilmes();
        }
    }
}