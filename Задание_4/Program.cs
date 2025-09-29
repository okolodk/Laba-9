namespace Задание_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thermometer thermometer = new Thermometer();

            thermometer.TemperatureTooHigh += OnTemperatureTooHigh;

            thermometer.Measure(25);
            thermometer.Measure(105);
            Console.ReadKey();
        }
        static void OnTemperatureTooHigh(string message)
        {
            Console.WriteLine(message);
        }
    }
    

}
