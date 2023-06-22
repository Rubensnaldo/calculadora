using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            char operacao;
            Console.Write("insira um número: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("insira outro número: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insira a oprecao que deseja realizar(*,+,-,/):");
            operacao = Convert.ToChar(Console.ReadLine());
            switch (operacao)
            {
                case '*':
                    Console.WriteLine("O resultado e: " + num1 * num2);
                    break;
                case '+':
                    Console.WriteLine("O resultado e: " + (num1 + num2));
                    break;
                case '-':
                    Console.WriteLine("O resultado e: " + (num1 - num2));
                    break;
                case '/':
                    if (num2 != 0)
                        Console.WriteLine("O resultado e: " + num1 / num2);
                    else
                        Console.WriteLine("Nao e possivel dividir por 0. ");
                    break;
                default:
                    Console.WriteLine("Operacao invalida");
                    break;

            }

        }
    }
}

