using CaixaEletronico.Dominio.Entidades;
using System;

namespace CaixaEletronico.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando o Caixa Eletronico");

            var cliente = new Cliente();
            cliente.Nome = "Renato Nóbrega";
            cliente.DataNascimento = new DateTime(1987, 17, 12);
            cliente.Cpf = "06696560467";

            var conta = new Conta();
            conta.Agencia = "123456"
            conta.Numero = "56789";
            conta.Saldo = 50000;
            conta.Ativa = true;

            Console.ReadLine();
        }
    }
}
