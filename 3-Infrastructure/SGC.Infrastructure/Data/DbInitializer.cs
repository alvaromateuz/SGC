using SGC.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGC.Infrastructure.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ClienteContext context)
        {

            if (context.Clientes.Any())
                return;

            var clientes = new Cliente[]
            {
                new Cliente
                {
                    Nome = "Alvaro",
                    CPF = "11122233302"
                },
                new Cliente
                {
                    Nome = "Mateus",
                    CPF = "11122233303"
                },
                new Cliente
                {
                    Nome = "Jesus",
                    CPF = "11122233304"
                }
            };
            context.AddRange(clientes);

            var contatos = new Contato[]
            {
                new Contato
                {
                    Nome = "Contato 1",
                    Telefone = "12312300",
                    Email = "asdasd@asdsad.com",
                    Cliente = clientes[0]
                },
                new Contato
                {
                    Nome = "Contato 2",
                    Telefone = "44444444",
                    Email = "wwwww@asdsad.com",
                    Cliente = clientes[1]
                },
                new Contato
                {
                    Nome = "Contato 3",
                    Telefone = "66666545",
                    Email = "oooooo@asdsad.com",
                    Cliente = clientes[2]
                }
                
            };
            context.AddRange(contatos);


            context.SaveChanges();

        }
    }
}
