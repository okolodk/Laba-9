using MyClass;
using Newtonsoft.Json;
using System.Security.Cryptography.X509Certificates;
namespace ClassWork
{
    internal class Program
    {
        public delegate void MessageHandler(string text);
        public class Fruit
        {
            public string? Name { get; set; }
            public int Quantity { get; set; }
        }
        static void Main()
        {
            Fruit apple = new() { Name = "Яблоко", Quantity = 5 };
            string json = JsonConvert.SerializeObject(apple);
            Console.WriteLine("B JSON: " + json);

            var deserialized = JsonConvert.DeserializeObject<Fruit>(json);
            Console.WriteLine($"Объект: {deserialized?.Name} - {deserialized?.Quantity} шт.");

            string name = null;
            Console.WriteLine(name.Length);
            string nonNullableName = "Ария";
            string? nullableName = null;

        }

        static void Main(string[] args) 
        {
            MessageHandler handler = ShowMessage;
            handler("Привет мир");

        }
        static void ShowMessage(string message)
        {
            Console.WriteLine($"Сообщение:{message}");
        }
    }
}
