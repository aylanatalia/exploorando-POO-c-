using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploPOO_C_.Models
{
    //classe selada, não pode ser herdada, caso eu coloque a palavra sealed no método, esse método também não pode ser herdado
    public sealed class Professor : Pessoa
    {
        //construtor por heraça
        public Professor(string nome) : base(nome)
        {
            
        }

        public decimal Salario { get; set; }

        //sobscrevendo um método
        public override void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome}, tenho {Idade}, e sou professor com salario de {Salario} reais");
        }
    }
}