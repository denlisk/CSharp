namespace CSharp.Dijkstra
{
    class Dijkstra
    {
        static int[] nums = new int[] { 1, 5, 9, 2, 5, 3, 2, 9, 7, 5 };
        static void Tail()
        {
            for (int i = nums.Length - 1; i > 0; i--)
            {
                if (nums[i] > nums[i - 1])
                {
                    int numIndex = FindNumIndex(i - 1);
                    //Console.WriteLine($"Смена {nums[numIndex]} на {nums[i - 1]}");
                    Swap(ref nums[numIndex], ref nums[i - 1]);
                    TailReverse(i);
                    break;
                }
            }
        }
        static int FindNumIndex(int i)
        {
            int min = nums.Length - 1;
            for (int j = nums.Length - 2; j > i; j--)
            {
                if (nums[j] > nums[i] && nums[j] < nums[min])
                {
                    min = j;
                }
            }
            return min;
        }
        static void TailReverse(int i)
        {
            int end = nums.Length - 1;
            while (i < end)
            {
                int t = nums[i];
                nums[i] = nums[end];
                nums[end] = t;
                i++;
                end--;
            }
        }
        static void Swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }
        public static void PrintAll()
        {
            for (int i = 0; i < 5; i++)
            {
                Print();
                Tail();
            }
        }
        static void Print()
        {
            foreach (int i in nums)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
