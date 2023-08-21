using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Questions
{ 
    internal class Program
    {
        // SUM OF ALL ELEMENTS OF ARRAY
        static void sum(int[] arr)
        {
            
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.Write(sum);
            Console.ReadLine();
        }
        // AVERAGE OF ALL ELEMENTS OF ARRAY
        static void sumFloat(int[] arr)
        {
            float sum = 0;
            foreach(int num in arr)
            {
                sum += num;
            }
            Console.WriteLine(sum/arr.Length);
            Console.ReadLine();
        }

        // LARGEST ELEMENT IN ARRAY
        static void Largest(int[] arr)
        {
            int large = -1;
            foreach (int num in arr)
            {
                if(num>large)
                {
                    large = num;
                }
            }
            Console.WriteLine(large);
            Console.ReadLine();
        }
        //  NUMBER OF EVEN AND ODD IN ARRAY
        static void evenOdd(int[] arr)
        {

            int even = 0, odd = 0;
            foreach(int num in arr)
            {
                if(num%2==0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            Console.Write("Even is: {0} and odd is: {1}",even,odd);
            Console.ReadLine();
        }

        // REVERSE OF AN ARRAY
        static void reverse(int[] arr)
        {

            int s = 0, e = arr.Length-1;
            while(s<e)
            {
                int t = arr[s];
                arr[s] = arr[e];
                arr[e] = t;
                s++;
                e--;
            }
           
            foreach(int  num in arr)
            {
                Console.Write(" "+num);
            }
            Console.ReadLine();
        }

        // MULTIPLY ARRAY BY A SPECIFIC FACTOR
        static void mulFac(int[] arr)
        {
            int factor = 3;
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] *= factor;
            }
            foreach (int num in arr)
            {
                Console.Write(" " + num);
            }
            Console.ReadLine();
        }
        static int search(int[] arr)
        {
            int value = 6;
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i]==value)
                {
                    return i;
                }
            }
            return -1;
        }

        // SECOND SMALLEST ELEMENT IN ARRAY
        static void secondsmall(int[] arr)
        {
            Array.Sort(arr);
            Console.WriteLine(arr[1]);
            Console.ReadLine();
        }

        //REMOVE DUPLICATES FROM ARRAY
        static void removedup(int[] arr)
        {
            int[] un = arr.Distinct().ToArray();
            foreach(int num in un)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }

        // INTERSECTION OF TWO ARRAYS
        static void CommonInBoth(int[] arr)
        {
            int[] second = { 1, 2, 3, 4, 5 };
            for (int i = 0; i<arr.Length;i++)
            {
                for(int j=0;j<second.Length;j++)
                {
                    if (second[j] == arr[i])
                    {
                        Console.Write(arr[i] + " ");
                    }
                }
            }
            Console.ReadLine();
         }
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            sum(arr);
            sumFloat(arr);
            Largest(arr);
            evenOdd(arr);
            reverse(arr);
            mulFac(arr);
            Console.WriteLine(search(arr));
            secondsmall(arr);
            removedup(arr);
            CommonInBoth(arr);
            Console.ReadLine();



        }
    }
}
