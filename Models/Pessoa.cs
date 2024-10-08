using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploPOO_C_.Models
{
    public class Pessoa
    {
        //esse é um exemplo de abstração, onde só pegamos as informações importantes para nossa finalidade
        //isso é uma classe, ou seja, uma representação de objeto da vida real, que é uma pessoa com nome e idade e ela irá se apresentar com esses dados 
        public string Nome { get; set; }
        public int Idade { get; set; }

        //esswe virtual representa que esse método pode ser subscrito
        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}