using MathLibrary;
namespace Laba_9_Alecseev_ISP_232_ISRPO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathTools a = new MathTools();
            Console.WriteLine(a.Add(5, 10));
            Console.WriteLine(a.Multiply(5, 10));
            Console.ReadKey();
        }
    }
}
