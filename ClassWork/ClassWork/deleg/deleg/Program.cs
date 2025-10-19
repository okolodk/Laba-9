using System.Threading.Channels;

namespace deleg
{
    public delegate void NumderHandler(int number);
    internal class Program
    {
        static void Double(int num) => Console.WriteLine($"Удвоено: {num * 2}");
        static void Square(int num) => Console.WriteLine($"Квадрат: {num * num}");
        static void Main(string[] args)
        {
            NumderHandler handler = Double;
            handler += Square;
            handler(5);

            Player player = new Player();
            player.OnDeath += () => Console.WriteLine("Враги празднуют победу!");
            player.OnDeath += ShowGameOver;
            player.TakeDamage(100);

        }
        static void ShowGameOver() => Console.WriteLine("GAME OVER");
    }
}
