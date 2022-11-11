namespace HW6
{
    public class DeviceTable : Devices
    {
        private string[,] _devices;
        public override string[,] DeviceTypes()
        {
            _devices = new string[10, 6]
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
            return _devices;
        }
    }
}
