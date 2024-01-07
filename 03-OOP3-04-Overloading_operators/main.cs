using System;

class Program
{
    public static void Main(string[] args)
    {
        bool[,] boolArray =
        {
            { true , false, true  },
            { false, true , true  },
            { true , false, false },
        };
        Map map = new Map(boolArray); //mapa vytvořená z předlohového pole

        map.Display();

        Vector2D point = new Vector2D(0, 1);
        Vector2D step = new Vector2D(1, 0);

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Step {i+1}");
            map[point] = !map[point];
            // point = point + step;
            point += step;
            map.Display();
        }
    }
}