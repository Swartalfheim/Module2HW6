namespace HW6
{
    public class PlugIn : DeviceTable
    {
        private int[] _choice;

        public int[] Choice()
        {
            _choice = new int[10];
            Console.WriteLine("\nSelect which devices will be plugged into the outlet. " +
                "\nEnter the fixture numbers you want to turn on separating each number with an enter, when you are done entering the numbers enter 0\n");
            for (int i = 0; i < _choice.Length; i++)
            {
                _choice[i] = Convert.ToInt32(Console.ReadLine());
                if (_choice[i] == 0)
                {
                    break;
                }
            }

            int height = DeviceTypes().GetLength(0);
            int width = DeviceTypes().GetLength(1);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    for (int g = 0; g < _choice.Length; g++)
                    {
                        if (Convert.ToInt32(DeviceTypes()[i, 0]) == _choice[g])
                        {
                            Console.Write(DeviceTypes()[i, j] + "; ");
                            if (j == 5)
                            {
                                Console.WriteLine();
                            }
                        }
                    }
                }
            }

            return _choice;
        }

        public void UsedPower()
        {
            int power = 0;
            int height = DeviceTypes().GetLength(0);
            int width = DeviceTypes().GetLength(1);
            Console.WriteLine("\nThe amount of energy consumed by appliances:\n");
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    for (int g = 0; g < _choice.Length; g++)
                    {
                        if (Convert.ToInt32(DeviceTypes()[i, 0]) == _choice[g])
                        {
                            if (j == 3)
                            {
                                Console.Write(DeviceTypes()[i, 1] + " - " + DeviceTypes()[i, 3] + "; ");
                                power = power + Convert.ToInt32(DeviceTypes()[i, 3]);
                            }

                            if (j == 5)
                            {
                                Console.WriteLine();
                            }
                        }
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Total energy consumption - {power}");
        }
    }
}
