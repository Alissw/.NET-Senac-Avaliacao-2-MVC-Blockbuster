using System;
using System.Collections.Generic;
using Controllers;
using Models;

namespace Views{
    class ClienteViews
    {
        public static void mostraClientes(){
            foreach(Cliente cliente in ClienteControllers.mostraClientes()){
                Console.WriteLine(cliente);
            }
        }
        
        public static Cliente inserirCliente(int idCliente, string nomeCliente, string dataNascimento, string cpf, int diasDevolucao){
            return ClienteControllers.adicionarCliente(idCliente, nomeCliente, dataNascimento, cpf, diasDevolucao);
        }
    }
}