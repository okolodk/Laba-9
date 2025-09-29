namespace Задание_3
{
    internal class Program
    {
        public delegate void Logger(string message);
        static void Main(string[] args)
        {
            
            Logger deleg = LogToConsole;
            deleg("hello world");
            Console.ReadKey();
        }
        static void LogToConsole(string message)
        {
            Console.WriteLine(message);
        }
    }
}
