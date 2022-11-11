namespace HW6
{
    public class PrintInfo : DeviceTable
    {
        private Sort _sort;
        public void PrintDevice()
        {
            Console.WriteLine("The table below shows the following columns:" +
                "\nroom; title; voltage; power consumption; the weight; manufacturer; location\n");
            int height = DeviceTypes().GetLength(0);
            int width = DeviceTypes().GetLength(1);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(DeviceTypes()[i, j] + "; ");
                }

                Console.WriteLine();
            }
        }

        public void PrintSorted()
        {
            _sort = new Sort();
            _sort.DeviceSorting();
        }

        public void FinPar()
        {
            Find.FindByParameter(DeviceTypes());
        }

        public void AllInfo()
        {
            AllInfo allInfo = new AllInfo();
            allInfo.Info(DeviceTypes());
        }
    }
}
