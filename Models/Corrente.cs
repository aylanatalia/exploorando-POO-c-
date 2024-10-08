using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploPOO_C_.Models
{
    public class Corrente : Conta
    {
        //implementando o método abstrato
        public override void Creditar(decimal valorCreditado)
        {
            SaldoAtual += valorCreditado;
        }
    }
}