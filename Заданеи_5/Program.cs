namespace Заданеи_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintLength("123");
            PrintLength(null);
        }

        static void PrintLength(string? input)
        {
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Cтрока отсутствует");
            }
            else
            {
                Console.WriteLine($"Длина строки {input.Length}");
            }
        }
    }
}
