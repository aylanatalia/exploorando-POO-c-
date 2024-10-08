using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace exemploPOO_C_.Models
{
    public class ContaCorrente
    {

        //ecemplo de encapsulamento
        //construtor
        public ContaCorrente(int numeroConta, decimal saldo)
        {
            NumeroConta = numeroConta;
            Saldo = saldo;
        }

        public int NumeroConta { get; set; }

        //só pode ser alterado pela classe e só é acessivel pela classe, ficando oculto para as outras classes
        private decimal Saldo;

        public void SacarValor(decimal valor)
        {
            if(Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso.");
            }else
            {
                Console.WriteLine("Saldo insulficiente");
            }
        }

        //esse método serve para conseguirmos ver o saldo em outras classes
        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo atual é {Saldo}");
        }

    }
}