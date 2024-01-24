namespace _03_OOP2_Reseni_testu
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Test();
        }
        public static void Test()
        {
            Corridor chodba = new Corridor(12, 6); //plocha 12 m2 a úklid 6 minut
            Kitchen kuchyne = new Kitchen(16, 20); //plocha 16m2 a úklid 20 minut
            Garden zahrada = new Garden(200); // uklízí se 200 minut

            Room obyvak = new Room("Living room", 25, 20); // název, plocha, doba úklidu
            Room loznice = new Room("Bedroom", 10, 8);
            Room pracovna = new Room("Study", 15, 30);

            Space[] mistnosti = { chodba, kuchyne, pracovna, obyvak, loznice };
            ITidyable[] kUklizeni = { chodba, kuchyne, pracovna, obyvak, loznice, zahrada };


            House dum = new House(mistnosti, kUklizeni);

            Console.WriteLine(dum.TidyUpTime);
            Console.WriteLine(dum.TotalSpace);

            dum.TidyUp();
        }
    }
    interface ITidyable
    {
        string TidyUp();
        int TidyUpTime { get; }
    }
    abstract class Space : ITidyable
    {
        public double Area { get; protected set; }
        public string Name { get; }

        public int TidyUpTime { get; protected set; }

        public Space(string name, double area)
        {
            Area = area;
            Name = name;
        }
        public abstract string TidyUp();
    }

    class Room : Space
    {
        public Room(string name, double area, int tidyUpTime) : base(name, area)
        {
            TidyUpTime = tidyUpTime;
        }
        public override string TidyUp()
        {
            return $"{Name}: Vacuum cleaning, {TidyUpTime} minutes";
        }
    }

    sealed class Corridor : Room
    {
        public Corridor(double area, int tidyUpTime) : base("Corridor", area, tidyUpTime)
        {
        }
        public override string TidyUp()
        {
            return $"{Name}: Sweeping floor, {TidyUpTime} minutes";
        }
    }

    sealed class Kitchen : Room
    {
        public Kitchen(double area, int tidyUpTime) : base("Kitchen", area, tidyUpTime)
        {
        }
        public override string TidyUp()
        {
            return $"{Name}: Washing floor, {TidyUpTime} minutes";
        }
    }

    sealed class Garden : ITidyable
    {
        public int TidyUpTime { get; }
        public Garden(int tidyUpTime)
        {
            TidyUpTime = tidyUpTime;
        }
        public string TidyUp()
        {
            return $"Garden: Raking, {TidyUpTime} minutes";
        }
    }

    class House
    {
        private Space[] spaces;
        private ITidyable[] tidyables;

        //public int TidyUpTime => tidyables.Select(x => x.TidyUpTime).Sum();
        public int TidyUpTime
        {
            get
            {
                int time = 0;
                foreach (ITidyable room in tidyables)
                {
                    time = room.TidyUpTime;
                }
                return time;
            }
        }

        //public double TotalSpace => spaces.Select(x => x.Area).Sum();
        public double TotalSpace
        {
            get
            {
                double totalSpace = 0;
                foreach (Space space in spaces)
                {
                    totalSpace = space.Area;
                }
                return totalSpace;
            }
        }

        public House(Space[] spaces, ITidyable[] tidyables)
        {
            this.spaces = spaces;
            this.tidyables = tidyables;
        }

        public void TidyUp()
        {
            foreach (ITidyable room in tidyables)
            {
                Console.WriteLine(room.TidyUp());
            }
        }

    }
}
