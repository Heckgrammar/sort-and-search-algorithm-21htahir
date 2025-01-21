using System.Diagnostics;

namespace compare_algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            menu();
        }
        static int[] CreateArray(int size, int min, int max)
        {
            Random r = new Random();
            int[] a = new int[size];
            for (int i = 0; i < a.Length; ++i)
            {
                a[i] = r.Next(min, max);
            }
            return a;
        }
        static void menu()
        {
            Console.WriteLine("Enter 1 for linear search");
            Console.WriteLine("Enter 2 for binary search");
            Console.WriteLine("enter 3 for bubble sort");
            Console.WriteLine("enter 4 for merge sort");
            Console.WriteLine("enter 9 to quit");
            int opt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the size of the array");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter minimum value for the array");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" enter the maximum value for the array");
            int max = Convert.ToInt32(Console.ReadLine());
            int[] b = CreateArray(size, min, max);
            if (opt == 1)
            {
                Console.WriteLine("Enter a value to find");
                int val = Convert.ToInt32(Console.ReadLine());
                LinearSearch(b, val);
            }
            else(opt = 2)
                    {

                    }

        }
        
        static void BubbleSort(int[] a)
        {
            int temp;
            bool swaps;
            do
            {

            }
            
        }
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
            bool found = false;
            for (int i = 0; i < a.Length; ++i)
            {

            }
        }
        static bool BinarySearch(int[] a, int numToFind)
        {
            bool found = false
                for (int i = 0; i < a.Length; i++)
                {
      
                }
        }
   
    }
}
