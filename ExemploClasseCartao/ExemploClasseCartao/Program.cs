using ExemploClasseCartao;

//Este código fiz de uma aula sobre classes

//Instanciando a nova classe Cartao.
Cartao card = new Cartao();

card.Banco = NomeBanco.Bradesco;

card.Numero = "6873982930";

card.Digito = 5;

card.Validade =DateTime.Now.AddYears(5);

card.Saldo = 5.000M;

card.Ativo = true;

card.Tipo = TipoCartao.DebitoECredito;

//Console.WriteLine(card.Tipo); Para testar.

//Instanciando a classe Serviços do Cartão
ServicosCartao servicos = new ServicosCartao(card);

servicos.Depositar(5.000M);
servicos.Retirar(1.300M);

//VerificarSaldo imprime o saldo. É colocada depois dos outros métodos.
var saldo = servicos.VerificarSaldo();//só exibe se add uma variavel para o método.
/*var montante = servicos.Depositar(2.000M);//só exibe se add uma variavel para o método.
var retirado = servicos.Retirar(1.000M);//só exibe se add uma variavel para o método.*/
Console.WriteLine(saldo);

