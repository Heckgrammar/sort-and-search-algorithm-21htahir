using System.Diagnostics;

namespace compare_algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random n = new Random();
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("what size would you like your array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] ints = CreateArray(size, n);
            menu();
        }
        static int[] CreateArray(int size, Random r)
        {
            int[] numbers = new int[size];
            for (int i = 0; i < numbers.Length; ++i)
            {
                numbers[i] = r.Next(1, 10000);
            }
            return numbers;
        }
        static void menu()
        {
            Console.WriteLine("Enter 1 for linear search");
            Console.WriteLine("Enter 2 for binary search");
            Console.WriteLine("enter 3 for bubble sort");
            Console.WriteLine("enter 4 for merge sort");
            Console.WriteLine("enter 9 to quit");
            Console.WriteLine("Choose a value");
        }
        
        //static void BubbleSort(int[] a)
        //{
        //    int temp;
        //    bool swaps;
        //    do
        //    {

        //    }
            
        //}
        static void Merge(int[] a, int low, int mid, int high)
        {
            int i, j, k;
            int num1 = mid - low + 1;
            int num2 = high - mid;
            int[] L = new int[num1];
            int[] R = new int[num2];
            for (i = 0; i < num1; i++)
            {
                L[i] = a[low + i];
            }
            for (j = 0; j < num2; j++)
            {
                R[j] = a[mid + j + 1];
            }
            i = 0;
            j = 0;
            k = low;
            while (i < num1 && j < num2)
            {
                if (L[i] <= R[j])
                {
                    a[k] = L[i];
                    i++;
                }
                else
                {
                    a[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < num1)
            {
                a[k] = L[i];
                i++;
                k++;
            }
            while (j < num2)
            {
                a[k] = R[j];
                j++; k++;
            }
        }
        static void MergeSortRecursive(int[] a, int low, int high)
        {
            if (low < high)
            {
                int mid = (low + high) / 2;
                MergeSortRecursive(a, low, mid);
                MergeSortRecursive(a, mid + 1, high);
                Merge(a, low, mid, high);
            }
        }
        static bool LinearSearch(int[] a, int numToFind)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == numToFind)
                {
                    return  true;
                    Console.WriteLine($"your number was found at index {i}");
                }
            }
            return false;
        }
        //static bool BinarySearch(int[] a, int numToFind)
        //{
        //    bool found = false
        //    int ub = a.Length - 1;

        //        {
      
        //        }
        //}
   
    }
}
