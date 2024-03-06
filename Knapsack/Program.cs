namespace Knapsack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of items: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter seed: ");
            int seed = int.Parse(Console.ReadLine());

            Problem problem = new Problem(n, seed);
            foreach(var item in problem.items)
            {
                Console.WriteLine("ID:" + item.ID + " value:" + item.value + " weight: " + item.weight + " ratio: " + item.ratio);
            }

            Console.WriteLine("Enter capacity: ");
            int capacity = int.Parse(Console.ReadLine());

            Result result = problem.Solve(capacity);
            for(int i = 0; i < result.listID.Count; i++)
            {
                Console.WriteLine("ID: " + result.listID[i]);
            }
            Console.WriteLine("Total value: " + result.valueSum);
            Console.WriteLine("Total weight: " + result.weightSum);
        }
    }
}
