using System;
using Models;
using Controllers;

namespace Views
{
    class LocacaosViews
    {
        public static Locacao adicionarLocacao(int idLocacao, Cliente cliente)
        {
            return LocacaosControllers.adicionarLocacao(idLocacao, cliente);
        }

        public static void adidionarFilme(Locacao locacao, Filme filme){
            LocacaosControllers.adicionarFilme(locacao, filme);
        }

        public static void mostraLocacoes()
        {
            foreach (Locacao locacao in LocacaosControllers.mostrarLocacaos()){
                Console.WriteLine(locacao.ToString());
            }
        }
    }
}