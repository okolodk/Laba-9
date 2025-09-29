using HtmlAgilityPack;

namespace Задание_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load("https://example.com");

            // Ищем заголовок
            HtmlNode titleNode = doc.DocumentNode.SelectSingleNode("//title");

            if (titleNode != null)
            {
                Console.WriteLine($"Заголовок: {titleNode.InnerText}");
            }
            else
            {
                Console.WriteLine("Заголовок не найден!");
            }
            Console.ReadKey();
        }
    }
}
