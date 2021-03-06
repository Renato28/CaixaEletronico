﻿using System;

namespace CaixaEletronico.Dominio.Entidades
{
    public class Conta
    {
        public int ContaId { get; set; }

        public decimal Saldo { get; set; }

        public string Numero { get; set; }

        public string Agencia { get; set; }

        public bool Ativa { get; set; }

        public Cartao Cartao { get; set; }

        public Comprovante Saque()
        {
            throw new NotImplementedException();
        }

        public Comprovante Deposito()
        {
            throw new NotImplementedException();
        }

        public Comprovante Transferencia(string agencia, string numeroConta, decimal valor)
        {
            throw new NotImplementedException();
        }

        public Comprovante PagarBoleto(string codigoBarras)
        {
            throw new NotImplementedException();
        }

        public Extrato ObterExtrato(DateTime inicio, DateTime fim)
        {
            throw new NotImplementedException();
        }
        public bool EncerrarConta()
        {
            if (Saldo >= 0)
            {
                Ativa = false;
                return true;
            }
            else
            {
                Ativa = true;
                return false;
            }
        }
    }

}

