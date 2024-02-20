using System.Reflection.Metadata.Ecma335;

namespace _03_OOP3_0X_voziky
{
    internal class Program
    {
        static Random random = new Random(123456);
        public static void Main(string[] args)
        {

            int cartCount = 50;
            
            int timeStart = 0;
            int timeEnd = 12 * 60;
            
            int maxCustomersPerMinute = 3;
            int minShopTime = 5;
            int maxShopTime = 45;

            Cart[] cartList = CreateCarts(cartCount);
            Stack<Cart> waitingCarts = new Stack<Cart>(cartList);
            List<Cart> activeCarts = new List<Cart>();

            Queue<int> customers = new Queue<int>();

            int time = timeStart;

            while(time < timeEnd)
            {
                //new customers
                int customerCount = random.Next(maxCustomersPerMinute + 1);
                for (int i = 0; i < customerCount; i++)
                {
                    customers.Enqueue(RandomCustomer(minShopTime, maxShopTime));
                }


                //customers take carts
                while (customers.Count > 0 && waitingCarts.Count > 0)
                {
                    int customer = customers.Dequeue();
                    Cart cart = waitingCarts.Pop();
                    
                    cart.Mileage += customer;
                    cart.AvailableAt = time + customer;

                    activeCarts.Add(cart);
                }

                //carts return to stack
                List<Cart> returnList = new List<Cart>();
                foreach(Cart cart in activeCarts)
                {
                    if (cart.AvailableAt <= time)
                        returnList.Add(cart);
                }

                foreach(Cart cart in returnList)
                {
                    activeCarts.Remove(cart);
                    waitingCarts.Push(cart);
                }

                time += 1;
            }

            foreach(Cart cart in cartList)
                Console.WriteLine($"{cart.ID}: {cart.Mileage} min");

        }

        private static int RandomCustomer(int minTime, int maxTime)
        {
            return random.Next(minTime, maxTime + 1);
        }

        private static Cart[] CreateCarts(int count)
        {
            //return new int[count].Select((x, i) => new Cart(i)).ToArray();

            Cart[] carts = new Cart[count];
            for (int i = 0; i < count; i++)
            {
                carts[i] = new Cart(i);
            }

            return carts;

        }
    }
}
