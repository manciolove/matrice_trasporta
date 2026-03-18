namespace matrice_trasporta
{
    internal class Program
    {
        static void Stampa (int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write($"[{m[i,j]}]");
                }
                Console.WriteLine();
            }
        }
        
        static int[,] Trasporta (int[,] m, int[,] M)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    M[j, i] = m[i, j];
                }
            }
            return M;
        }
        static void Main(string[] args)
        {
            int[,] m = { { 1, 2, 3 },{ 4, 5, 6 },{ 7, 8, 9 } };
            int[,] M = new int[3, 3];
            Stampa(m);
            Console.WriteLine("---------");
            Stampa(Trasporta(m, M));

        }
    }
}
