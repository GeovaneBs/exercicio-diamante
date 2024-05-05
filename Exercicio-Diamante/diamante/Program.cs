using System;

class Program
{
    static void Main(string[] args)
    {
        int numero;
        do
        {
            Console.Clear();
            Console.Write("Informe um número Impar: ");
            numero = Convert.ToInt32(Console.ReadLine());

        } while (numero % 2 == 0);

        int meio = numero / 2;
        int espaco = meio;

        for (int i = 0; i <= meio; i++)
        {
            for (int j = 0; j < espaco; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < (numero - (2 * espaco)); j++)
            {
                Console.Write("x");
            }
            Console.WriteLine();
            espaco--;
        }

        espaco = 1;
        for (int i = meio - 1; i >= 0; i--)
        {
            for (int j = 0; j < espaco; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < (numero - (2 * espaco)); j++)
            {
                Console.Write("x");
            }
            Console.WriteLine();
            espaco++;
        }
    }
}
