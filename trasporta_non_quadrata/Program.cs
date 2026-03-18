namespace trasporta_non_quadrata
{
    internal class Program
    {
        static void Stampa(int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write($"[{m[i, j]}]");
                }
                Console.WriteLine();
            }
        }

        static int[,] Trasporta(int[,] m, int[,] M)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    if (m.GetLength(0) == M.GetLength(1))
                    {
                        M[j, i] = m[i, j];
                    }
                }
            }
            return M;
        }
        static void Main(string[] args)
        {
            int[,] m = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            int[,] M = new int[m.GetLength(1), m.GetLength(0)];
            Stampa(m);
            Console.WriteLine("---------");
            Stampa(Trasporta(m, M));

        }
    }
}


