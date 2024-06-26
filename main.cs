/* Crie um método chamado ImprimirMensagem que receba uma string como parâmetro e imprima essa mensagem na tela. */

using System;

class Program
{
    static void Frase(string frase)
    {
        Console.Write(frase);
    }
    public static void Main(string[] args)
    {
      Console.WriteLine("Digite uma frase: ");
      string fraseMain = Console.ReadLine();
      Frase(fraseMain);
    }
}