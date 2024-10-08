using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploPOO_C_.Interfaces
{
    public interface ICalculadora
    {
        // métodos sem corpo serão obrigatorios na implementação da classe
        int Somar(int num1, int num2);
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2);

        //método padrão de uma interface com corpo, não tem necessidade de implementar o método na classe
        int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}