using System;
using System.Collections.Generic;
using Models;

namespace Controllers{
    class ClienteControllers
    {
        public static void adicionarCliente(int idCliente, string nomeCliente, string dataNascimento, string cpf, int diasDevolucao){
            new Cliente(idCliente, nomeCliente, dataNascimento, cpf, diasDevolucao);
        }

        public static List<Cliente> mostraClientes(){
            return Cliente.mostraClientes();
        }
    }
}