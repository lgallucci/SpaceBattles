namespace SpaceBattlesGame
{
    class Program
    {
        // Usage: SpaceBattles [host] [port]. The game mode is chosen on the opening screen.
        static void Main(string[] args)
        {
            new SpaceBattles().Run();
        }
    }
}
