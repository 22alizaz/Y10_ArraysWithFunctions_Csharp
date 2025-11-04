namespace Y10_ArraysWithFunctions_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] oneDnames = { "stacy", "keisha", "tory", "lola", "jackie", "daisy", "becky", "shakespeare", "archibald", "pibble" };
            names(oneDnames);
            int[] oneDnum = { 1, 2, 3, 4, 5, 6, 7, 8 };
            integers(oneDnum);
            string[,] twoDnames = {{ "stacy", "keisha", "tory" }, { "lola", "jackie", "daisy" }, { "shakespeare", "archibald", "pibble" } };
            list(twoDnames);
            int[,] twoDnum = { { 1, 2, 3, 4 }, { 5,6,7,8 }, { 9, 10, 11, 12 } };
            listnum(twoDnum);
        }

        static void names(string[] name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
        }

        static void integers(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }

        static void list(string[,] threenames)
        {
            for (int i = 0; i < threenames.GetLength(0); i++)
            {
                for (int j = 0; j < threenames.GetLength(1); j++)
                {
                    Console.Write(threenames[i, j] + ", ");
                }
                Console.WriteLine();
            }
        }

        static void listnum(int[,] nums)
        {
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    Console.Write(nums[i, j] + ", ");
                }
            }
        }
    }
}