using System;
using System.Collections.Generic;
using System.Text;

namespace MiniBank
{
    internal class Conta
    {
        public string Titular;
        public decimal Saldo;

        public void Depositar(decimal valor)
        {
            Saldo = Saldo + valor;
        }

        public void Sacar(decimal valor)
        {
            Saldo = Saldo - valor;
        }
    }
}
