namespace HW6
{
    public class Starter
    {
        public void Start()
        {
            PrintInfo printInfo = new PrintInfo();
            PlugIn plugIn = new PlugIn();
            printInfo.AllInfo();
            Console.Clear();
            printInfo.PrintDevice();
            plugIn.Choice();
            plugIn.UsedPower();
            printInfo.PrintSorted();
            printInfo.FinPar();
        }
    }
}
