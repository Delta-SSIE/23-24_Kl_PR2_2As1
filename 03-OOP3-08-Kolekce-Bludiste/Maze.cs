using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Kolekce_02_Bludiste
{
    internal class Maze
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        private Coords _entrance;
        private TileType[,] _map;
        private MazeDisplay _display;

        public void LoadMaze(string filename)
        {
            using (StreamReader reader = new StreamReader(filename)) //načtu textový soubor
            {
                Width = int.Parse(reader.ReadLine()); //první řádek je šířka
                Height = int.Parse(reader.ReadLine()); //druhý řádek je výška

                _map = new TileType[Width, Height];

                string line;
                for (int y = 0; y < Height; y++) //projdu všechny řádky
                {
                    line = reader.ReadLine();
                    for (int x = 0; x < Width; x++) //projdu všechny sloupce
                    {
                        _map[x, y] = line[x] switch //uložím do mapy
                        {
                            '#' => TileType.Wall,
                            ' ' => TileType.Corridor,
                            'S' => TileType.Entrance,
                            'E' => TileType.Exit,
                        };
                        if (line[x] == 'S') //poznamenám si, kde je start
                            _entrance = new Coords(x, y);
                    }
                }
            }
            _display = new MazeDisplay(1, 1, Width, Height); //připravím prostor pro kreslení, odsazený o 1 čtverec
            RenderMaze();
        }

        public void RenderMaze()
        {
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    _display.RenderTile(new Coords(x, y), _map[x, y]);
                }
            }
            _display.WrapUp();
        }

        public void Solve(IVisitList visitList)
        {
            //připrav seznam bodů k projití
            //Stack<Coords> placesToVisit = new();

            //dej do seznamu start
            visitList.AddPlace(_entrance);

            //dokud na seznamu něco je
            while (visitList.Count > 0)
            {
                //vyndej první ze seznamu
                Coords here = visitList.GetNext();

                //pokud jsi v cíli, zajásej
                if (_map[here.X, here.Y] == TileType.Exit)
                {
                    //hotovo
                    return;
                }

                _map[here.X, here.Y] = TileType.Visited;


                //přidej na seznam všechny sousedy, které na něm ještě nemáš

                Coords[] neighbours = GetNeighbours(here);
                foreach(Coords neighbour in neighbours)
                {
                    visitList.AddPlace(neighbour);

                    if (_map[neighbour.X, neighbour.Y] == TileType.Corridor)
                    { 
                        _map[neighbour.X, neighbour.Y] = TileType.Listed;
                    }
                }

                Console.ReadKey();
                RenderMaze();

            }


        }

        private Coords[] GetNeighbours(Coords place)
        {
            Coords[] candidates =
            {
                new Coords(place.X - 1, place.Y),
                new Coords(place.X + 1, place.Y),
                new Coords(place.X, place.Y + 1),
                new Coords(place.X, place.Y - 1),
            };

            List<Coords> result = new();
            foreach(Coords candidate in candidates)
            {
                TileType type = _map[candidate.X, candidate.Y];
                if (type == TileType.Corridor || type == TileType.Exit)
                {
                    result.Add(candidate);
                }
            }

            return result.ToArray();
        }

    }
}
