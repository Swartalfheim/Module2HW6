namespace HW6
{
    internal class AllInfo : IInfo
    {
        public void Info(string[,] array)
        {
            Console.WriteLine("Welcome to my home, there are various electrical appliances here");
            int height = array.GetLength(0);
            int width = array.GetLength(1);
            Console.WriteLine("I have: ");
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (j == 1)
                    {
                        Console.WriteLine(array[i, 1]);
                    }
                }
            }

            Console.Write("\nPress any key to continue");
            Console.ReadKey();
        }
    }
}
