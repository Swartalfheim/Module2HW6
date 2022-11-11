namespace HW6
{
    public class Sort : DeviceTable
    {
        public void DeviceSorting()
        {
            Console.WriteLine("\nChoose which parameter you want to sort by (enter the number that corresponds to the sort parameter)" +
                "\n1) by number\n2) by voltage\n3)energy consumption");
            string type = Console.ReadLine();
            string[,] devices = new string[10, 6];
            switch (type)
            {
                case "1":
                    devices = new string[10, 6]
                    {
                        { "1", "Microwave", "800", "12000", "Samsung", "Kitchen" },
                        { "2", "Blender", "1000", "1200", "Scarlett", "Kitchen" },
                        { "3", "Mixer", "1000", "5000", "Electrolux", "Kitchen" },
                        { "4", "Personal Computer", "850", "10000", "Vinga", "Bedroom" },
                        { "5", "Fan", "1600", "659", "Dyson", "Bath" },
                        { "6", "Heater", "40", "1700", "Sencor", "Bedroom" },
                        { "7", "Fridge", "309", "64000", "INDESIT", "Kitchen" },
                        { "8", "Television", "105", "7300", "Xiaomi", "Bedroom" },
                        { "9", "Playstation 5", "700", "4000", "Sony", "Bedroom" },
                        { "10", "Washing Machine", "810", "62000", "GORENJE", "Bath" }
                    };
                    break;
                case "2":
                    devices = new string[10, 6]
                    {
                        { "5", "Fan", "1600", "659", "Dyson", "Bath" },
                        { "2", "Blender", "1000", "1200", "Scarlett", "Kitchen" },
                        { "3", "Mixer", "1000", "5000", "Electrolux", "Kitchen" },
                        { "4", "Personal Computer", "850", "10000", "Vinga", "Bedroom" },
                        { "10", "Washing Machine", "810", "62000", "GORENJE", "Bath" },
                        { "1", "Microwave", "800", "12000", "Samsung", "Kitchen" },
                        { "9", "Playstation 5", "700", "4000", "Sony", "Bedroom" },
                        { "7", "Fridge", "309", "64000", "INDESIT", "Kitchen" },
                        { "8", "Television", "105", "7300", "Xiaomi", "Bedroom" },
                        { "6", "Heater", "40", "1700", "Sencor", "Bedroom" }
                    };
                    break;
                case "3":
                    devices = new string[10, 6]
                    {
                        { "7", "Fridge", "309", "64000", "INDESIT", "Kitchen" },
                        { "10", "Washing Machine", "810", "62000", "GORENJE", "Bath" },
                        { "1", "Microwave", "800", "12000", "Samsung", "Kitchen" },
                        { "4", "Personal Computer", "850", "10000", "Vinga", "Bedroom" },
                        { "8", "Television", "105", "7300", "Xiaomi", "Bedroom" },
                        { "3", "Mixer", "1000", "5000", "Electrolux", "Kitchen" },
                        { "9", "Playstation 5", "700", "4000", "Sony", "Bedroom" },
                        { "6", "Heater", "40", "1700", "Sencor", "Bedroom" },
                        { "2", "Blender", "1000", "1200", "Scarlett", "Kitchen" },
                        { "5", "Fan", "1600", "659", "Dyson", "Bath" }
                    };
                    break;
            }

            int height = devices.GetLength(0);
            int width = devices.GetLength(1);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(devices[i, j] + "; ");
                }

                Console.WriteLine();
            }
        }
    }
}
