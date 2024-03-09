using Knapsack;
using System.Diagnostics;

namespace MSTest_Knapsack
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodIsAtleastOneElement()
        {
            int capacity = 10;
            Problem problem = new Problem();
            List<Item> items = new List<Item>();
            items.Add(new Item(7, 4, 0));
            items.Add(new Item(7, 7, 1));
            items.Add(new Item(7, 3, 2));

            problem.AddItemsManually(items);

            Result result = problem.Solve(capacity);

            Assert.IsTrue(result.listID.Count >= 1);
            Assert.IsTrue(!result.listID.Contains(7));
        }
        [TestMethod]
        public void TestMethodNoElementsInBackpack()
        {
            Problem problem = new Problem();
            int capacity = 10;
            List<Item> items = new List<Item>();
            items.Add(new Item(7, 12, 0));
            items.Add(new Item(7, 16, 1));
            items.Add(new Item(7, 11, 2));

            problem.AddItemsManually(items);


            Result result = problem.Solve(capacity);

            Assert.IsTrue(result.listID.Count == 0);
        }
        [TestMethod]
        public void TestMethodDoesSortingMatter()
        {
            Problem problem = new Problem();
            Result referenceResult = new Result();
            List<Item> items = new List<Item>();
            int capacity = 30;

            items.Add(new Item(7, 4, 0));
            items.Add(new Item(6, 7, 1));
            items.Add(new Item(3, 9, 2));
            items.Add(new Item(7, 5, 3));
            items.Add(new Item(3, 4, 4));
            items.Add(new Item(1, 8, 5));
            items.Add(new Item(9, 5, 6));

            problem.AddItemsManually(items);

            foreach (var item in items)
            {
                if (referenceResult.weightSum + item.weight <= capacity)
                {
                    referenceResult.valueSum += item.value;
                    referenceResult.weightSum += item.weight;
                    referenceResult.listID.Add(item.ID);

                    if (referenceResult.weightSum == capacity)
                    {
                        break;
                    }
                }
            }
            Result result = problem.Solve(capacity);
            Assert.IsTrue(result.valueSum > referenceResult.valueSum);
        }

        [TestMethod]
        public void TestMethodInstanceCheck()
        {
            Problem problem = new Problem(10,5);
            int capacity = 20;
            
            Result result = problem.Solve(capacity);

            Assert.IsTrue(result.valueSum == 45);
        }
    }
}