using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploPOO_C_.Models
{
    //indicação de onde ele vai herdar as característica
    public class Aluno : Pessoa
    {
        //construtor por herança
        public Aluno(string nome) : base(nome)
        {
            
        }

        //a classe Aluno vai herdar propriedades da classe pessoa, pois aluno é uma pessoa 
        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome}, tenho {Idade} anos, e sou um aluno nota {Nota}");
        }
    }
}