using System;

namespace MySecondApp
{ 
class Program
{ 
static void Main(string[] args)
{
//programa de calculadora ! 
int numero1, numero2, resultado = 0;
string operacao;

Console.WriteLine("Digite o primeiro número: ");
numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a operação: ");
operacao = Console.ReadLine();

Console.WriteLine("Digite o segundo numero: ");
numero2 = int.Parse(Console.ReadLine());
//fiz um switch para englobar as principais operações !
switch(operacao)
{
case "+" :
resultado = numero1 + numero2;
break;
case "-":
resultado = numero1 - numero2;
break;
case "/":
resultado = numero1 / numero2;
break;
case "*" :
resultado = numero1 * numero2;
break;
default:
Console.WriteLine("operaçao invalida!");
break;

}
Console.WriteLine("{0} {1} {2} = {3}", numero1, operacao,numero2,resultado);
Console.ReadKey(true);
}
}
}
