using System;
using System.Collections.Generic;
using Controllers;
using Models;

namespace Views{
    class ClienteViews
    {
        public static void mostraClientes(){
            foreach(Cliente cliente in ClienteControllers.mostraClientes()){
                Console.WriteLine(ClienteControllers.mostraClientes());
            }
        }
    }
}