using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploPOO_C_.Models
{
    public class Professor : Pessoa
    {
        public decimal Salario { get; set; }

        //sobscrevendo um método
        public override void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome}, tenho {Idade}, e sou professor com salario de {Salario} reais");
        }
    }
}