using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploPOO_C_.Models
{
    // é uma classe abstrata, não pode ser instaciada so herdada

    public abstract class Conta
    {
        //protegida contra alteraações externas, exceto as classes filhas 
        protected decimal SaldoAtual { get; set; }  
        
        //metodo abstrato, a classe que herdar a classe conta, devera obrigatoriamente a implementar esse método
        public abstract void Creditar(decimal valorCreditado);

        public void ExibirSaldoAtual()
        { 
            Console.WriteLine($"O seu saldo atual é {SaldoAtual} reais");
        }
    }
}