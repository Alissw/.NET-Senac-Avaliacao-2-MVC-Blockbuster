using System;
using System.Collections.Generic;
using Models;

namespace Controllers{
    class ClienteControllers
    {
        public static Cliente adicionarCliente(int idCliente, string nomeCliente, string dataNascimento, string cpf, int diasDevolucao){
            return new Cliente(idCliente, nomeCliente, dataNascimento, cpf, diasDevolucao);
        }

        public static List<Cliente> mostraClientes(){
            return Cliente.mostraClientes();
        }
    }
}