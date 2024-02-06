namespace _03_OOP3_07_Salesmen_tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Salesman boss = MakeTree();
            //PrintSalesRecursive(boss, "Alice", "Williams");

            //Salesman search = FindSalesmanRecursive(boss, "Alice", "Williams");
            //Salesman search = FindSalesmanQueue(boss, "Alice", "Williams");
            //Salesman search = FindSalesmanStack(boss, "Alice", "Williams");

            //if (search != null)
            //    Console.WriteLine(search.Sales);
            //else
            //    Console.WriteLine("Not found");

            Salesman will = FindSalesmanQueue(boss, "William", "Brown");
            int total = GetTotalSales(will);
            Console.WriteLine($"{will.Name} {will.Surname} - sales: {will.Sales}, total sales (Stack): {total}");

            total = GetTotalSalesRecursive(will);
            Console.WriteLine($"{will.Name} {will.Surname} - sales: {will.Sales}, total sales (Recursive): {total}");

            Console.WriteLine();

            Salesman benny = FindSalesmanQueue(boss, "Benny", "MacSweeney");
            total = GetTotalSalesRecursive(benny);
            Console.WriteLine($"{benny.Name} {benny.Surname} - sales: {benny.Sales}, total sales (Recursive): {total}");


            Console.WriteLine();
            DisplaySalesmenTree(boss);
        }
        static void DisplaySalesmenTree(Salesman node, string indent = "")
        {
            Console.WriteLine($"{indent}{node.Name} {node.Surname} - Sales: {node.Sales}");

            foreach (var subordinate in node.Subordinates)
            {
                DisplaySalesmenTree(subordinate, indent + "    ");
            }
        }
        static void PrintSalesRecursive(Salesman root, string name, string surname)
        {
            //Console.WriteLine($"Now: {root.Name} {root.Surname}");

            //není náhodou tohle právě ten prvek?
            if (root.Name == name && root.Surname == surname)
                Console.WriteLine($"{root.Name} {root.Surname} : {root.Sales}");

            //zkusím najít hledanou osobu v podřízených
            foreach (Salesman s in root.Subordinates)
            {
                PrintSalesRecursive(s, name, surname);
            }
        }

        static Salesman FindSalesmanRecursive(Salesman root, string name, string surname)
        {
            //není náhodou tohle právě ten prvek?
            if (root.Name == name && root.Surname == surname)
                return root;

            //zkusím najít hledanou osobu v podřízených
            foreach (Salesman s in root.Subordinates)
            {
                Salesman found = FindSalesmanRecursive(s, name, surname);
                if (found != null)
                    return found;
            }

            return null;
        }

        static Salesman FindSalesmanQueue(Salesman root, string name, string surname)
        {
            //připrav seznam, kam si budeš ukládat lidi k procházení
            Queue<Salesman> toBeVisited = new Queue<Salesman>();

            //dej tam kořenový prvek
            toBeVisited.Enqueue(root);

            //dokud v seznamu někdo je,
            while(toBeVisited.Count > 0) 
            {
                Salesman salesman = toBeVisited.Dequeue();
                //Console.WriteLine($"Now: {salesman.Name} {salesman.Surname}");

                // zjisti, jestli to není hledaná osoba
                if (salesman.Name == name && salesman.Surname == surname)
                    return salesman;

                //přidej na seznam všechny podřízené
                foreach (Salesman s in salesman.Subordinates)
                    toBeVisited.Enqueue(s);
            }
            
            //nenašel jsi? vrať null
            return null;
        }


        static Salesman FindSalesmanStack(Salesman root, string name, string surname)
        {
            //připrav seznam, kam si budeš ukládat lidi k procházení
            Stack<Salesman> toBeVisited = new Stack<Salesman>();

            //dej tam kořenový prvek
            toBeVisited.Push(root);

            //dokud v seznamu někdo je,
            while (toBeVisited.Count > 0)
            {
                Salesman salesman = toBeVisited.Pop();
                Console.WriteLine($"Now: {salesman.Name} {salesman.Surname}");

                // zjisti, jestli to není hledaná osoba
                if (salesman.Name == name && salesman.Surname == surname)
                    return salesman;

                //přidej na seznam všechny podřízené
                foreach (Salesman s in salesman.Subordinates)
                    toBeVisited.Push(s);
            }

            //nenašel jsi? vrať null
            return null;
        }

        static int GetTotalSales(Salesman salesman)
        {
            //na seznam uzlů k prohledání si napiš kořenový prvek
            Stack<Salesman> listToSearch = new Stack<Salesman>();
            listToSearch.Push(salesman);
            int totalSales = 0;

            //dokud na seznamu někdo je,
            while (listToSearch.Count > 0)
            {
                //vyjmi ho
                Salesman current = listToSearch.Pop();
                //Console.WriteLine($"Current: {current.Name} {current.Surname}"); //jen dump, abych viděl, kudy prohledávám

                //přidej jeho  prodeje
                totalSales += current.Sales;

                //přidej na seznam všechny jeho podřízené
                foreach (Salesman sub in current.Subordinates)
                {
                    listToSearch.Push(sub);
                }
            }

            //když ho nenajdeš a seznam už je prázdný, vrať null
            return totalSales;
        }

        static int GetTotalSalesRecursive(Salesman salesman)
        {
            //vezmi moje prodeje
            int totalSales = salesman.Sales;

            //přičti všechny prodeje všech podřízených
            foreach (Salesman sub in salesman.Subordinates)
            {
                totalSales += GetTotalSalesRecursive(sub);
            }

            //součet vrať
            return totalSales;
        }

        static Salesman MakeTree()
        {
            Salesman person1 = new Salesman("Weaver", "Frank", 0);
            Salesman person2 = new Salesman("Brown", "William", 40854);
            person1.AddSubordinate(person2);
            Salesman person3 = new Salesman("Jones", "Olivia", 30426);
            person2.AddSubordinate(person3);
            Salesman person4 = new Salesman("Smith", "Albert", 29862);
            person3.AddSubordinate(person4);
            Salesman person5 = new Salesman("Williams", "Alice", 24698);
            person3.AddSubordinate(person5);
            Salesman person6 = new Salesman("MacSweeney", "Benny", 31767);
            person3.AddSubordinate(person6);
            Salesman person10 = new Salesman("O'Hara", "Benny", 25592);
            person1.AddSubordinate(person10);
            Salesman person11 = new Salesman("Smith", "Tina", 36131);
            person1.AddSubordinate(person11);
            Salesman person12 = new Salesman("Brown", "Mia", 32593);
            person1.AddSubordinate(person12);
            Salesman person13 = new Salesman("Martinez", "Albert", 5470);
            person12.AddSubordinate(person13);
            Salesman person14 = new Salesman("Jackson", "Emma", 23718);
            person13.AddSubordinate(person14);

            return person1;
        }

        static Salesman MakeLargeTree()
        {
            Salesman person1 = new Salesman("Weaver", "Frank", 0);
            Salesman person2 = new Salesman("Brown", "William", 40854);
            person1.AddSubordinate(person2);
            Salesman person3 = new Salesman("Jones", "Olivia", 30426);
            person2.AddSubordinate(person3);
            Salesman person4 = new Salesman("Smith", "Albert", 29862);
            person3.AddSubordinate(person4);
            Salesman person5 = new Salesman("Williams", "Alice", 24698);
            person3.AddSubordinate(person5);
            Salesman person6 = new Salesman("MacSweeney", "Benny", 31767);
            person3.AddSubordinate(person6);
            Salesman person7 = new Salesman("Miller", "Michael", 21044);
            person3.AddSubordinate(person7);
            Salesman person8 = new Salesman("Williams", "Susan", 28830);
            person3.AddSubordinate(person8);
            Salesman person9 = new Salesman("Black", "William", 47406);
            person3.AddSubordinate(person9);
            Salesman person10 = new Salesman("O'Hara", "Benny", 25592);
            person1.AddSubordinate(person10);
            Salesman person11 = new Salesman("Smith", "Tina", 36131);
            person1.AddSubordinate(person11);
            Salesman person12 = new Salesman("Brown", "Mia", 32593);
            person1.AddSubordinate(person12);
            Salesman person13 = new Salesman("Martinez", "Albert", 5470);
            person12.AddSubordinate(person13);
            Salesman person14 = new Salesman("Jackson", "Emma", 23718);
            person13.AddSubordinate(person14);
            Salesman person15 = new Salesman("MacSweeney", "Albert", 9712);
            person14.AddSubordinate(person15);
            Salesman person16 = new Salesman("Black", "Jenny", 20505);
            person14.AddSubordinate(person16);
            Salesman person17 = new Salesman("Miller", "William", 9973);
            person14.AddSubordinate(person17);
            Salesman person18 = new Salesman("Black", "Alice", 20198);
            person14.AddSubordinate(person18);
            Salesman person19 = new Salesman("Jackson", "Mia", 38202);
            person14.AddSubordinate(person19);
            Salesman person20 = new Salesman("Black", "Sophia", 42917);
            person13.AddSubordinate(person20);
            Salesman person21 = new Salesman("Davis", "William", 43218);
            person20.AddSubordinate(person21);
            Salesman person22 = new Salesman("Black", "Emma", 35195);
            person21.AddSubordinate(person22);
            Salesman person23 = new Salesman("Black", "Albert", 14633);
            person21.AddSubordinate(person23);
            Salesman person24 = new Salesman("Jackson", "Anthony", 29290);
            person21.AddSubordinate(person24);
            Salesman person25 = new Salesman("Davis", "Albert", 22427);
            person21.AddSubordinate(person25);
            Salesman person26 = new Salesman("Johnson", "Mia", 37254);
            person20.AddSubordinate(person26);
            Salesman person27 = new Salesman("Miller", "Albert", 44671);
            person26.AddSubordinate(person27);
            Salesman person28 = new Salesman("Williams", "William", 42081);
            person26.AddSubordinate(person28);
            Salesman person29 = new Salesman("White", "Olivia", 20914);
            person26.AddSubordinate(person29);
            Salesman person30 = new Salesman("Jackson", "Bob", 17578);
            person20.AddSubordinate(person30);
            Salesman person31 = new Salesman("O'Hara", "William", 36847);
            person20.AddSubordinate(person31);
            Salesman person32 = new Salesman("Miller", "Tina", 26722);
            person31.AddSubordinate(person32);
            Salesman person33 = new Salesman("O'Hara", "Jenny", 48025);
            person31.AddSubordinate(person33);
            Salesman person34 = new Salesman("Garcia", "Benny", 26752);
            person31.AddSubordinate(person34);
            Salesman person35 = new Salesman("Brown", "Albert", 9059);
            person20.AddSubordinate(person35);
            Salesman person36 = new Salesman("Brown", "John", 21475);
            person13.AddSubordinate(person36);
            Salesman person37 = new Salesman("White", "Sophia", 29089);
            person36.AddSubordinate(person37);
            Salesman person38 = new Salesman("Johnson", "William", 30364);
            person36.AddSubordinate(person38);
            Salesman person39 = new Salesman("Black", "Benny", 26432);
            person36.AddSubordinate(person39);
            Salesman person40 = new Salesman("Miller", "Emma", 14607);
            person36.AddSubordinate(person40);
            Salesman person41 = new Salesman("Garcia", "Olivia", 34262);
            person36.AddSubordinate(person41);
            Salesman person42 = new Salesman("Brown", "Jane", 49735);
            person13.AddSubordinate(person42);
            Salesman person43 = new Salesman("Williams", "Anthony", 35578);
            person42.AddSubordinate(person43);
            Salesman person44 = new Salesman("Brown", "Michael", 33284);
            person42.AddSubordinate(person44);
            Salesman person45 = new Salesman("Miller", "Susan", 13048);
            person42.AddSubordinate(person45);
            Salesman person46 = new Salesman("O'Hara", "Anthony", 32506);
            person42.AddSubordinate(person46);
            Salesman person47 = new Salesman("Johnson", "Albert", 49350);
            person42.AddSubordinate(person47);
            Salesman person48 = new Salesman("Rodriguez", "Michael", 35233);
            person42.AddSubordinate(person48);
            Salesman person49 = new Salesman("Smith", "Anthony", 35958);
            person12.AddSubordinate(person49);
            Salesman person50 = new Salesman("Jackson", "Michael", 34731);
            person49.AddSubordinate(person50);
            Salesman person51 = new Salesman("Johnson", "Benny", 38533);
            person50.AddSubordinate(person51);
            Salesman person52 = new Salesman("Jones", "Anthony", 22302);
            person51.AddSubordinate(person52);
            Salesman person53 = new Salesman("Miller", "David", 9535);
            person51.AddSubordinate(person53);
            Salesman person54 = new Salesman("Grace", "Albert", 44845);
            person51.AddSubordinate(person54);
            Salesman person55 = new Salesman("Newman", "John", 33483);
            person51.AddSubordinate(person55);
            Salesman person56 = new Salesman("Rodriguez", "Anthony", 10698);
            person51.AddSubordinate(person56);
            Salesman person57 = new Salesman("O'Hara", "David", 15880);
            person50.AddSubordinate(person57);
            Salesman person58 = new Salesman("Johnson", "Emma", 41403);
            person57.AddSubordinate(person58);
            Salesman person59 = new Salesman("White", "Mia", 5676);
            person57.AddSubordinate(person59);
            Salesman person60 = new Salesman("Miller", "Anthony", 6257);
            person57.AddSubordinate(person60);
            Salesman person61 = new Salesman("Rodriguez", "Jenny", 43472);
            person57.AddSubordinate(person61);
            Salesman person62 = new Salesman("Garcia", "Mia", 15038);
            person57.AddSubordinate(person62);
            Salesman person63 = new Salesman("Black", "Mia", 34570);
            person57.AddSubordinate(person63);
            Salesman person64 = new Salesman("Grace", "Jenny", 36091);
            person50.AddSubordinate(person64);
            Salesman person65 = new Salesman("Rodriguez", "Susan", 5462);
            person50.AddSubordinate(person65);
            Salesman person66 = new Salesman("Brown", "Olivia", 29351);
            person50.AddSubordinate(person66);
            Salesman person67 = new Salesman("Smith", "William", 19339);
            person50.AddSubordinate(person67);
            Salesman person68 = new Salesman("MacSweeney", "Jenny", 5906);
            person49.AddSubordinate(person68);
            Salesman person69 = new Salesman("Davis", "Michael", 40988);
            person68.AddSubordinate(person69);
            Salesman person70 = new Salesman("Miller", "Bob", 32138);
            person68.AddSubordinate(person70);
            Salesman person71 = new Salesman("Black", "Tina", 10634);
            person68.AddSubordinate(person71);
            Salesman person72 = new Salesman("Jones", "Jenny", 46441);
            person68.AddSubordinate(person72);
            Salesman person73 = new Salesman("Brown", "Susan", 41225);
            person68.AddSubordinate(person73);
            Salesman person74 = new Salesman("Newman", "William", 10990);
            person68.AddSubordinate(person74);
            Salesman person75 = new Salesman("Jackson", "Tina", 39889);
            person49.AddSubordinate(person75);
            Salesman person76 = new Salesman("Grace", "Emma", 48591);
            person75.AddSubordinate(person76);
            Salesman person77 = new Salesman("O'Hara", "Michael", 19147);
            person75.AddSubordinate(person77);
            Salesman person78 = new Salesman("Jones", "Mia", 18934);
            person12.AddSubordinate(person78);
            Salesman person79 = new Salesman("Miller", "John", 7714);
            person78.AddSubordinate(person79);
            Salesman person80 = new Salesman("Williams", "John", 35584);
            person78.AddSubordinate(person80);
            Salesman person81 = new Salesman("White", "Emma", 26212);
            person78.AddSubordinate(person81);
            Salesman person82 = new Salesman("MacSweeney", "John", 44650);
            person81.AddSubordinate(person82);
            Salesman person83 = new Salesman("Davis", "Olivia", 5113);
            person81.AddSubordinate(person83);
            Salesman person84 = new Salesman("Jackson", "David", 16353);
            person12.AddSubordinate(person84);
            Salesman person85 = new Salesman("Smith", "David", 39192);
            person84.AddSubordinate(person85);
            Salesman person86 = new Salesman("Newman", "Anthony", 48876);
            person85.AddSubordinate(person86);
            Salesman person87 = new Salesman("MacSweeney", "Jane", 12018);
            person86.AddSubordinate(person87);
            Salesman person88 = new Salesman("White", "William", 27512);
            person86.AddSubordinate(person88);
            Salesman person89 = new Salesman("Garcia", "Sophia", 10229);
            person86.AddSubordinate(person89);
            Salesman person90 = new Salesman("Garcia", "William", 13520);
            person86.AddSubordinate(person90);
            Salesman person91 = new Salesman("Black", "Jane", 21097);
            person86.AddSubordinate(person91);
            Salesman person92 = new Salesman("Jones", "Emma", 40088);
            person85.AddSubordinate(person92);
            Salesman person93 = new Salesman("Jones", "Jane", 16605);
            person12.AddSubordinate(person93);
            Salesman person94 = new Salesman("Rodriguez", "William", 48847);
            person93.AddSubordinate(person94);
            Salesman person95 = new Salesman("Grace", "Bob", 17910);
            person93.AddSubordinate(person95);
            Salesman person96 = new Salesman("Jones", "John", 38002);
            person93.AddSubordinate(person96);
            Salesman person97 = new Salesman("O'Hara", "Bob", 38839);
            person93.AddSubordinate(person97);
            Salesman person98 = new Salesman("Davis", "Mia", 41718);
            person93.AddSubordinate(person98);
            Salesman person99 = new Salesman("Miller", "Jenny", 24925);
            person12.AddSubordinate(person99);
            Salesman person100 = new Salesman("Rodriguez", "Mia", 45611);
            person99.AddSubordinate(person100);
            Salesman person101 = new Salesman("Rodriguez", "Emma", 44828);
            person100.AddSubordinate(person101);
            Salesman person102 = new Salesman("White", "Bob", 28901);
            person100.AddSubordinate(person102);
            Salesman person103 = new Salesman("Jones", "William", 23912);
            person102.AddSubordinate(person103);
            Salesman person104 = new Salesman("White", "Jane", 35510);
            person100.AddSubordinate(person104);
            Salesman person105 = new Salesman("White", "Albert", 5479);
            person100.AddSubordinate(person105);
            Salesman person106 = new Salesman("Grace", "Jane", 43686);
            person100.AddSubordinate(person106);
            Salesman person107 = new Salesman("Newman", "Bob", 39498);
            person100.AddSubordinate(person107);
            Salesman person108 = new Salesman("Jones", "Michael", 18893);
            person107.AddSubordinate(person108);
            Salesman person109 = new Salesman("Grace", "Michael", 19402);
            person107.AddSubordinate(person109);
            Salesman person110 = new Salesman("Jackson", "Susan", 11445);
            person107.AddSubordinate(person110);
            Salesman person111 = new Salesman("MacSweeney", "Tina", 27480);
            person1.AddSubordinate(person111);
            Salesman person112 = new Salesman("Jones", "Susan", 39357);
            person111.AddSubordinate(person112);
            Salesman person113 = new Salesman("Williams", "Mia", 11979);
            person111.AddSubordinate(person113);
            Salesman person114 = new Salesman("MacSweeney", "Susan", 18884);
            person113.AddSubordinate(person114);
            Salesman person115 = new Salesman("Rodriguez", "Tina", 14209);
            person114.AddSubordinate(person115);
            Salesman person116 = new Salesman("Jackson", "Benny", 21009);
            person113.AddSubordinate(person116);
            Salesman person117 = new Salesman("Williams", "Albert", 9269);
            person113.AddSubordinate(person117);
            Salesman person118 = new Salesman("Johnson", "Susan", 26055);
            person111.AddSubordinate(person118);
            Salesman person119 = new Salesman("Brown", "Jenny", 45960);
            person111.AddSubordinate(person119);
            Salesman person120 = new Salesman("Martinez", "Tina", 35260);
            person111.AddSubordinate(person120);
            Salesman person121 = new Salesman("Martinez", "Mia", 12016);
            person120.AddSubordinate(person121);
            Salesman person122 = new Salesman("Davis", "Emma", 31811);
            person121.AddSubordinate(person122);
            Salesman person123 = new Salesman("Davis", "David", 42678);
            person120.AddSubordinate(person123);
            Salesman person124 = new Salesman("Brown", "David", 43187);
            person120.AddSubordinate(person124);
            Salesman person125 = new Salesman("Martinez", "Michael", 45578);
            person124.AddSubordinate(person125);
            Salesman person126 = new Salesman("White", "Tina", 12209);
            person124.AddSubordinate(person126);
            return person1;
        }
    }
}
