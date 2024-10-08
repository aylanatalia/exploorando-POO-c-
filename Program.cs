using exemploPOO_C_.Models;

//isso é nosso objeto do tipo pessoa, que usa a nossa classe pessoa e se apresenta
//instanciando uma pessoa
Pessoa p1 = new Pessoa();
p1.Nome = "Ayla Natalia";
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
Aluno a1 = new Aluno();
a1.Nome = "Ayla";
a1.Idade = 27;
a1.Nota = 10;
a1.Apresentar();

Professor pr1 = new Professor();
pr1.Nome = "Natalia";
pr1.Idade = 35;
pr1.Salario = 1000;
pr1.Apresentar();