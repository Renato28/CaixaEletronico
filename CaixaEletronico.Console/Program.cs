using CaixaEletronico.Dominio.Entidades;
using CaixaEletronico.Dominio.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CaixaEletronico.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando o Caixa Eletronico");
            var contexto = new Contexto();
            

            //ICollection<Cliente> clientesDoBanco = new List<Cliente>();

            var cliente1 = new Cliente();
            cliente1.Nome = "Renato Nóbrega";
            cliente1.DataNascimento = new DateTime(1987, 12, 17);
            cliente1.Cpf = "06696560467";

            var conta1 = new Conta();
            conta1.Agencia = "123456";
            conta1.Numero = "56789";
            conta1.Saldo = 50000;
            conta1.Ativa = true;

            var cartao1 = new Cartao();
            cartao1.Numero = 1234;
            cartao1.Senha = "2356";

            conta1.Cartao = cartao1;

            cliente1.Contas.Add(conta1);


            var cliente2 = new Cliente();
            cliente2.Nome = "Ricardo Silva";
            cliente2.DataNascimento = new DateTime(1990, 10, 10);
            cliente2.Cpf = "05586974521";

            var conta2 = new Conta();
            conta2.Agencia = "121256";
            conta2.Numero = "56969";
            conta2.Saldo = 40000;
            conta2.Ativa = true;

            var cartao2 = new Cartao();
            cartao2.Numero = 1895;
            cartao2.Senha = "5698";

            conta2.Cartao = cartao2;

            cliente2.Contas.Add(conta2);

            //clientesDoBanco.Add(cliente1);
            //clientesDoBanco.Add(cliente2);

            contexto.Clientes.Add(cliente1);
            contexto.Clientes.Add(cliente2);
            contexto.SaveChanges();

         

            Console.WriteLine();
            Console.WriteLine("Pesquisa de Cliente por Nome. Digite o nome do cliente");
            var nomePesquisa = Console.ReadLine();

            var resultadoClientes = contexto.Clientes.Where(c => c.Nome.ToLower().Contains(nomePesquisa.ToLower())).ToList();

            foreach(var cliente in resultadoClientes)
            {

                Console.WriteLine(cliente.Nome + " / " + cliente.Cpf);
            }

            Console.ReadLine();
        }
    }
}
