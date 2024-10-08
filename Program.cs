using exemploPOO_C_.Models;

//isso é nosso objeto do tipo pessoa, que usa a nossa classe pessoa e se apresenta
//instanciando uma pessoa
Pessoa p1 = new Pessoa();
p1.Nome = "Ayla Natalia";
p1.Idade = 27;
p1.Apresentar();

ContaCorrente c1 = new ContaCorrente(123, 1000);
c1.ExibirSaldo();
c1.SacarValor(500);
c1.ExibirSaldo();
c1.SacarValor(1000);
c1.ExibirSaldo();