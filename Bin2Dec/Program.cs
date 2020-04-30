using System;

namespace Bin2Dec
{
    class Program
    {
        static void Main(string[] args)
        {
            string binario = "";
            char aux = 's';
            int i = 0, potencia = 0;
            double soma = 0;
            while (aux == 's')
            {
                Console.Write("Insira o numero binário: ");
                binario = Console.ReadLine();
                potencia = binario.Length - 1;
                for (i = 0; i < binario.Length; i++)
                {

                    if (binario[i] == '0')
                    {
                        potencia--;
                    }
                    else if (binario[i] == '1')
                    {
                        soma += Math.Pow(2, potencia);
                        potencia--;
                    }
                    else
                    {
                        i = 1000000000;
                    }
                }
                if (i == 1000000001)
                {
                    Console.WriteLine("Número binário inválido!!");
                }
                else
                {
                    Console.WriteLine("O número binário " + binario  + " é igual ao decimal: " + soma);
                }

                aux = Convert.ToChar("a");
                soma = 0;

                while (aux != 's' && aux != 'n')
                {
                    Console.WriteLine("Deseja inserir mais um numero binário? s/n");
                    try
                    {
                        aux = Convert.ToChar(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Por favor, digite apenas um algoritmo!");
                        aux = Convert.ToChar("a");
                    }
                }

            }
            Console.WriteLine("Obrigado por utilizar o sistema.");
            Environment.Exit(0);
        }
    }
}
