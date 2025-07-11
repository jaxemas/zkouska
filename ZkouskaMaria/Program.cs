using var game = new ZkouskaMaria.Game1();
game.Run();
using System;

namespace SimpleMario
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using var game = new Game1();  // vytvoření instance hry
            game.Run();                   // spuštění hry (hlavní smyčka)
        }
    }
}