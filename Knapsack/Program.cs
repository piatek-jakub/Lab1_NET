namespace Knapsack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Problem problem = new Problem(10, 8);
            foreach(var item in problem.items)
            {
                Console.WriteLine("value:" + item.value + " weight: " + item.weight);
            }
        }
    }
}
