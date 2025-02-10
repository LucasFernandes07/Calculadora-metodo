using Calculadora;
using Valor;
using Layout;

Formatacao.Cor("\nCALCULADORA METODO ", ConsoleColor.Yellow);
Formatacao.Cor("\n1-adição", ConsoleColor.Cyan);
Formatacao.Cor("2-Subtração", ConsoleColor.Cyan);
Formatacao.Cor("3-Multiplicação", ConsoleColor.Cyan);
Formatacao.Cor("4-Divisão", ConsoleColor.Cyan);
Formatacao.Cor("Qual operação você deseja?", ConsoleColor.Cyan);
if (!int.TryParse(Console.ReadLine(), out int resposta))
{
Formatacao.Cor("Insira uma resposta válida.", ConsoleColor.Yellow);
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
    Formatacao.Cor("insira a opção correta!!!!", ConsoleColor.Yellow);

    break;
}