using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Usuário determina as diretrizes de tamanho da Matriz
            Console.Write("Digite quantas linhas deseja: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Digite quantas colunas deseja: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[m, n];


            // Adicionar valores a Matriz por posição X e Y
            for (int contadorm = 0; contadorm < m; contadorm++)
            {
                Console.WriteLine("Digite separando por espaços os numeros desta linha:");
                string[] valores = Console.ReadLine().Split(" ");
                for (int contadorn = 0; contadorn < n; contadorn++)
                {
                    matriz[contadorm, contadorn] = int.Parse(valores[contadorn]);

                }
            }


            // Analisar Vizinhos na Matriz
            Console.Write("Digite o numero que deseja analisar: ");
            int numeroAnalise = int.Parse(Console.ReadLine());

            for (int contadorm = 0; contadorm < m; contadorm++)
            {
                for (int contadorn = 0; contadorn < n; contadorn++)
                {
                    if (matriz[contadorm, contadorn] == numeroAnalise)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Posição: " + contadorm + ", " + contadorn);
                        if (contadorn > 0)
                        {
                            Console.WriteLine("Esquerda: " + matriz[contadorm, contadorn - 1]);
                        }
                        if (contadorn < n - 1)
                        {
                            Console.WriteLine("Direita: " + matriz[contadorm, contadorn + 1]);
                        }
                        if (contadorm > 0)
                        {
                            Console.WriteLine("Acima: " + matriz[contadorm - 1, contadorn]);
                        }
                        if (contadorm < m - 1)
                        { 
                            Console.WriteLine("Abaixo: " + matriz[contadorm + 1, contadorn]); 
                        }
                    }

                }
            }



            // Visualizar a Matriz

            Console.WriteLine();
            Console.WriteLine("-----------------------");

            for (int contadorm = 0; contadorm < m; contadorm++)
            {

                for (int contadorn = 0; contadorn < n; contadorn++)
                {
                    Console.Write(matriz[contadorm, contadorn] + " ");

                }
                Console.WriteLine();
            }
            
            Console.WriteLine("-----------------------");
        }
    }
}
