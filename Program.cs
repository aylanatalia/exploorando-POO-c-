using exemploPOO_C_.Interfaces;
using exemploPOO_C_.Models;

//isso é nosso objeto do tipo pessoa, que usa a nossa classe pessoa e se apresenta
//instanciando uma pessoa
Pessoa p1 = new Pessoa("Ayla Natalia");
p1.Idade = 27;
p1.Apresentar();

//instanciando uma conta
ContaCorrente c1 = new ContaCorrente(123, 1000);
c1.ExibirSaldo();
c1.SacarValor(500);
c1.ExibirSaldo();
c1.SacarValor(1000);
c1.ExibirSaldo();

//instanciando um novo aluno
Aluno a1 = new Aluno("Ayla");
a1.Idade = 27;
a1.Nota = 10;
a1.Apresentar();

Professor pr1 = new Professor("Natalia");
pr1.Idade = 35;
pr1.Salario = 1000;
pr1.Apresentar();

//instanciando a corrente
Corrente co = new Corrente();
co.Creditar(500);
co.ExibirSaldoAtual();

//instanciando a classe computador
Computador c = new Computador();
Console.WriteLine(c.ToString());

//instanciando a calculadora, pois não da pra instanciar a interface diretamente
ICalculadora cal = new Calculadora();
Console.WriteLine(cal.Somar(10, 20));