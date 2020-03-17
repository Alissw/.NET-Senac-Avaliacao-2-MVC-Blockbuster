using System;
using System.Collections.Generic;

namespace Models
{
    class Cliente
    {
        public int idCliente {get; set;}
        public String nomeCliente {get; set;}
        public String dataNascimento {get; set;}
        public String cpf {get; set;}
        public int diasDevolucao {get; set;}
        static List<Cliente> clientes = new List<Cliente>();

        public Cliente(int idCliente, String nomeCliente, String dataNascimento, String cpf, int diasDevolucao)
        {
            this.idCliente = idCliente;
            this.nomeCliente = nomeCliente;
            this.dataNascimento = dataNascimento;
            this.cpf = cpf;
            this.diasDevolucao = diasDevolucao;

            adicionarCliente(this);
        }

        public static void adicionarCliente(Cliente cliente){
            clientes.Add(cliente);
        }

        public static List<Cliente> mostraClientes(){
            return clientes;
        }

        public override string ToString()
        {
            return 
            ("##Dados do cliente##")
            +("ID do cliente: " + this.idCliente + "\n")
            +("Nome............: " + this.nomeCliente + "\n")
            +("Nascido em......: " + this.dataNascimento + "\n")
            +("CPF.............: " + this.cpf + "\n")
            +("-----------------------------------------------------------------\n");
            
            }
    }
}