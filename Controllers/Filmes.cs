using System;
using Models;
namespace Controllers{
    class FilmesControllers
    {
        public static void adicionarFilmes(int idFilme, String nomeFilme, String dataLancamento, String sinopse, float valorLocacao, int estoque, int qtdLocado){
            new Filme(idFilme, nomeFilme, dataLancamento, sinopse, valorLocacao, estoque, qtdLocado);
        }

        public static void mostrarFilmes(){
            return Locacao.mostrarFilme();
        }
    }
}