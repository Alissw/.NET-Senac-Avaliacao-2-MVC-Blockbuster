using System;
using System.Collections.Generic;
using Models;

namespace Controllers{
    class LocacaosControllers
    {
        public static Locacao adicionarLocacao(int idLocacao, Cliente cliente){
            return new Locacao(idLocacao, cliente);
        }

        public static void adicionarLocacao(Locacao locacao){
            Locacao.adicionarLocacao(locacao);
        }

        public static void adicionarFilme(Locacao locacao, Filme filme){
            locacao.adicionarFilme(filme);
        }

        public static List<Locacao> mostrarLocacaos(){
           return Locacao.mostrarLocacaos();
        }        
        public static int QtdFilmeLocados(){
            return Locacao.QtdFilmeLocados();
        }        
        public static String Devolver(){
            return Locacao.Devolver();
        }

        public static float valorTotal(){
            return Locacao.valorTotal();
        }        
    }
}