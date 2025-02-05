using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o número de linhas e colunas");
        string[] linCol = Console.ReadLine().Split(" ");
        int Lines = int.Parse(linCol[0]);
        int Columns = int.Parse(linCol[1]);

        int[,] mat = new int[Lines, Columns];
        for (int i = 0; i < Lines; i++)
        {
            string[] values = Console.ReadLine().Split(" ");
            for (int j = 0; j < Columns; j++)
            {
                mat[i, j] = int.Parse(values[j]);
            }
        }

        Console.Write("Digite o número de deseja ver seus vizinhos: ");
        int NumeroVerificado = int.Parse(Console.ReadLine());

        VerificaPosições(mat, Lines, Columns, NumeroVerificado);
    }

    static void VerificaPosições(int[,] mat, int Lines, int Columns, int NumeroVerificado)
    {
        for (int i = 0; i < Lines; i++)
        {
            for (int j = 0; j < Columns; j++)
            {
                if (NumeroVerificado == mat[i, j])
                {
                    Console.WriteLine($"Posição {i},{j}: ");
                    // Verificar vizinhos (com validações de limites)
                    if (j + 1 < Columns)  // Verificar direita
                    {
                        int right = mat[i, j + 1];
                        Console.WriteLine($"Direita: {right}");
                    }
                    if (j - 1 >= 0)  // Verificar esquerda
                    {
                        int left = mat[i, j - 1];
                        Console.WriteLine($"Esquerda: {left}");
                    }
                    if (i - 1 >= 0)  // Verificar cima
                    {
                        int up = mat[i - 1, j];
                        Console.WriteLine($"Cima: {up}");
                    }
                    if (i + 1 < Lines)  // Verificar baixo
                    {
                        int down = mat[i + 1, j];
                        Console.WriteLine($"Baixo: {down}");
                    }
                }
            }
        }
    }
}


