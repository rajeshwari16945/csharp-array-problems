using CSharp.Arrays;

class Program
{
    static void Main(string[] args)
    {

        /* ReverseOfArray.GetReverse();*/

        /*SumOfNNumbers processor = new SumOfNNumbers();
        processor.Run();*/

        /*NoOfRepetitiveNumbersInArray obj = new NoOfRepetitiveNumbersInArray();
        obj.GetNoOfEachELements();*/

        /* JumpGameWithArray jumpGame = new JumpGameWithArray();
         jumpGame.CanJump();*/

        /*ProductOfArrayExceptSelf productOfArrayExceptSelf = new ProductOfArrayExceptSelf();
        productOfArrayExceptSelf.getTheProductOfArrayExceptSelf();*/

        /*LongestSubArray longestSubArray = new LongestSubArray();
        longestSubArray.getLongestSubArray();*/

        /*DynamicArray dynamicArray = new DynamicArray();
        dynamicArray.Menu();*/

        //var nums = new List<int> { 1, 2, 3 };
        //var result = SubsetGenerator.GenerateSubsets(nums);
        //foreach (var subset in result)
        //{
        //    Console.WriteLine("[" + string.Join(", ", subset) + "]");
        //}

        /*var sol = new PermuteUnique();
        sol.GetPermuteUnique(new int[] { 1, 1, 2 });*/

        StackImplementationWithArray stack = new StackImplementationWithArray();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.Push(40);
        stack.Peek();
        stack.Pop();
        stack.Peek();
    }
}
