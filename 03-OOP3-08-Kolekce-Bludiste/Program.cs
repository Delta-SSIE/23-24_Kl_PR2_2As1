namespace _03_Kolekce_02_Bludiste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Maze maze = new Maze();
            maze.LoadMaze("emptymaze.txt");
            //maze.LoadMaze("micromaze.txt");
            //maze.Solve(new StackVisitList());
            //maze.Solve(new QueueVisitList());
            maze.Solve(new RandomVisitList());
 
        }
    }
}
