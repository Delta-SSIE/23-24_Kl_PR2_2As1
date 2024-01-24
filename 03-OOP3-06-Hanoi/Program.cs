namespace _03_OOP3_06_Hanoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Puzzle puzzle = new Puzzle(5);
            puzzle.Render();

            if (!puzzle.Move(0, 2))
                Console.WriteLine("Error: " + puzzle.ErrorMessage);
            puzzle.Render();

            if (!puzzle.Move(0, 1))
                Console.WriteLine("Error: " + puzzle.ErrorMessage);
            puzzle.Render();

            if (!puzzle.Move(2, 1))
                Console.WriteLine("Error: " + puzzle.ErrorMessage); 
            puzzle.Render();

            if (!puzzle.Move(2, 0))
                Console.WriteLine("Error: " + puzzle.ErrorMessage);
            puzzle.Render();
        }
    }
}
