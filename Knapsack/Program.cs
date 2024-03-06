namespace Knapsack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Problem problem = new Problem(10, 15);
            /*foreach(var item in problem.items)
            {
                Console.WriteLine("ID:" + item.ID + " value:" + item.value + " weight: " + item.weight + " ratio: " + item.ratio);
            }*/
            Result result = problem.Solve(20);
            for(int i = 0; i < result.listID.Count; i++)
            {
                Console.WriteLine("ID: " + result.listID[i]);
            }
            Console.WriteLine("Total value: " + result.valueSum);
            Console.WriteLine("Total weight: " + result.weightSum);
        }
    }
}
