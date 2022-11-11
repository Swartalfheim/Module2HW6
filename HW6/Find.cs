namespace HW6
{
    public static class Find
    {
        public static void FindByParameter(this string[,] array)
        {
            Console.WriteLine("\nEnter the name of the device to find it (required with a capital letter)\n");
            string param = Console.ReadLine();
            int height = array.GetLength(0);
            int width = array.GetLength(1);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (param == array[i, 1])
                    {
                        Console.Write(array[i, j] + "; ");
                    }
                }
            }
        }
    }
}
