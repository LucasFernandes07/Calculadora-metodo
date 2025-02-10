using Calculadora;
using Valor;
using Layout;

Formatacao.Cor("\nC A L C U L A D O R A ", ConsoleColor.Blue);
Console.WriteLine("\n1-adição");
Console.WriteLine("2-Subtração");
Console.WriteLine("3-Multiplicação");
Console.WriteLine("4-Divisão");
Console.WriteLine("Qual operação você deseja?  ");
if (!int.TryParse(Console.ReadLine(), out int resposta))
{
Formatacao.Cor("Insira uma resposta válida.", ConsoleColor.Red);
}
switch (resposta)
{
  case 1:
    Operacoes.RealizarAdicao(
    Obtervalor.ObterValores(),
    Obtervalor.ObterValores());

    break;

  case 2:

    Operacoes.RealizarSubtracao(
    Obtervalor.ObterValores(),
    Obtervalor.ObterValores());
    break;

  case 3:

    Operacoes.RealizarMultiplicacao(
    Obtervalor.ObterValores(),
    Obtervalor.ObterValores());
    break;

  case 4:

    Operacoes.RealizarDivisao(
    Obtervalor.ObterValores(),
    Obtervalor.ObterValores());
    break;

  default:
    Formatacao.Cor("insira a opção correta!!!!", ConsoleColor.Red);

    break;
}