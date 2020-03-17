using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Views;
using Models;

namespace _NET_Senac_Avaliacao_2_MVC_Blockbuster
{
    public class Program
    {
        public static void Main(string[] args)
        {
           Cliente cliente = Views.ClienteViews.inserirCliente(1, "Jackson", "31-03-1993","00000000", 15);
           Filme filme =  Views.FilmesView.inserirFilme(1,"Velozes e furiosos","22/06/2001", "Policial infiltrado blablablabla",15.00f,5,2);
           

           Locacao locacao = Views.LocacaosViews.adicionarLocacao(1,cliente);
           Views.LocacaosViews.adidionarFilme(locacao, filme);


           Views.LocacaosViews.mostraLocacoes();
        }
    }
}
