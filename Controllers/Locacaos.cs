using System;
using Models;

namespace Controllers{
    class Locacaos
    {
        public static void adicionarLocacao(int idLocacao, Cliente cliente){
            new Locacao(idLocacao, cliente);
        }
        public static void dadosLocacao(){
            Locacao.dadosLocacao();
        }

        public static void addFilme(Filme filme){
            Locacao.addFilme(filme);
        }

        public static void mostrarFilme(){
            Locacao.mostrarFilme();
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