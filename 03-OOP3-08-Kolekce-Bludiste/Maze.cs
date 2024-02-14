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

    }
}
