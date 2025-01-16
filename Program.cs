using System.Diagnostics;

namespace compare_algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[20];
            Random r = new Random();
            for (int k = 0; k < Numbers.Length; k++)
            {
                Numbers[k] = r.Next(0, 10000000);
            }
            int temp;
            bool swaps = false;
            int Count = 0;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            do
            {
                swaps = false;
                for (int j = 0; j < Numbers.Length - 1; j++)
                {
                    if (Numbers[j] > Numbers[j + 1])
                    {
                        temp = Numbers[j];
                        Numbers[j] = Numbers[j + 1];
                        Numbers[j + 1] = temp;
                        swaps = true;
                    }
                    Count++;
                }
            } while (swaps);
            sw.Stop();
            Console.WriteLine("The array is sorted");
            Console.WriteLine($"it took {Count} operations to do so");
            Console.WriteLine($"it took {sw.ElapsedMilliseconds} milliseconds to do so");
            foreach (int i in Numbers)
            {
                Console.WriteLine(i);
            }
        }
        //static int[] CreateArray(int size, Random r)
        // {

        //}
        static void menu()
        {

        }
        
        static void BubbleSort(int[] a)
        {
            
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
        //static bool LinearSearch(int[] a, int numToFind)
        //{

        //}
        //static bool BinarySearch(int[] a, int numToFind)
        //{
            
        //}
            
    }
}
