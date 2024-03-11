using Knapsack;
using System.Diagnostics;

namespace MSTest_Knapsack
{
    [TestClass]
    public class UnitTestKnapsack
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
            Assert.IsFalse(result.listID.Contains(7));
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
            Debug.WriteLine(result);
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

        [TestMethod]
        public void TestMethodItemsValidity()
        {
            Problem problem = new Problem();
            int capacity = 20;
            List<Item> items = new List<Item>();
            items.Add(new Item(-7, 6, 0));
            items.Add(new Item(7, 6, 1));
            items.Add(new Item(7, -6, 2));
            items.Add(new Item(-7, -6, 3));
            items.Add(new Item(0, 7, 4));
            items.Add(new Item(7, 0, 5));

            problem.AddItemsManually(items);


            Result result = problem.Solve(capacity);
            Debug.WriteLine(problem);
            Assert.IsTrue(result.valueSum == 7);
            Assert.IsTrue(result.weightSum == 6);
            Assert.IsFalse(result.listID.Contains(0));
            Assert.IsFalse(result.listID.Contains(2));
            Assert.IsFalse(result.listID.Contains(3));
            Assert.IsFalse(result.listID.Contains(4));
            Assert.IsFalse(result.listID.Contains(5));
        }
        [TestMethod]
        public void TestMethodFirstElementHighestRatio()
        {
            float highestRatio = 0.0f;
            int capacity = 10;
            Problem problem = new Problem();
            List<Item> items = new List<Item>();
            items.Add(new Item(7, 4, 0));
            items.Add(new Item(6, 7, 1));
            items.Add(new Item(9, 3, 2));
            items.Add(new Item(7, 5, 3));
            items.Add(new Item(10, 1, 4));

            problem.AddItemsManually(items);

            Result result = problem.Solve(capacity);
            for(int i = 0; i < problem.items.Count; i++)
            {
                if(problem.items[i].ratio > highestRatio)
                {
                    highestRatio = problem.items[i].ratio;
                }
            }

            Assert.IsTrue(highestRatio == problem.items[0].ratio);
        }
        [TestMethod]
        public void TestMethodNumberOfItems()
        {
            Problem problem = new Problem();
            int capacity = 30;
            List<Item> items = new List<Item>();
            items.Add(new Item(7, 4, 0));
            items.Add(new Item(6, 7, 1));
            items.Add(new Item(3, 9, 2));
            items.Add(new Item(7, 5, 3));
            items.Add(new Item(3, 4, 4));
            items.Add(new Item(1, 8, 5));
            items.Add(new Item(9, 5, 6));

            problem.AddItemsManually(items);


            Result result = problem.Solve(capacity);

            Assert.IsTrue(result.listID.Count == 5);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Invalid capacity")]
        public void TestMethodCapacityException()
        {
            Problem problem = new Problem();
            int capacity = -5;
            List<Item> items = new List<Item>();
            items.Add(new Item(7, 4, 0));
            items.Add(new Item(6, 7, 1));
            items.Add(new Item(3, 9, 2));

            problem.AddItemsManually(items);


            Result result = problem.Solve(capacity);
        }
    }
}