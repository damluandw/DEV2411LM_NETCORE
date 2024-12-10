namespace Lab2._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int k = 10; k >= 0; k--)
                {
                    if (i != k)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(i%10);
                        for (int j = 1; j < i; j++)
                        {
                            int show = i + j;
                            show %= 10;
                            Console.Write(show);
                        }
                        for (int j = i - 2; j >= 0; j--)
                        {
                            int show = i + j;
                            show %= 10;
                            Console.Write(show);
                        }

                    }

                }
                Console.WriteLine();
            }
        }
    }
}
