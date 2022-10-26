using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithm
{
    class Program
    {
        //Array to be searched
        int[] arr = new int[20];
        //Number of elements in the Array
        int n;
        //Get the number of elements to store in the Array
        int i;

        public void input()
        {
            while (true)
            {
                Console.Write("Enter the number of the elements in the array:");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20))
                    break;
                else
                    Console.WriteLine("\nArray should have minimum 1 and maximum 20 elements. \n");
            }
            //Accept array elements
            Console.WriteLine("");
            Console.WriteLine("______________________");
            Console.WriteLine(" Enter Array Elements ");
            Console.WriteLine("______________________");
            for (i = 0; i < n; i++)
            {
                Console.Write("<"+(i+1)+">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }
        public void BinarySearch()
        {
            char ch;
            do
            {
                // accept the number to be serached
                Console.Write
                    ("\nEnter elements want you to search :");
                int item = Convert.ToInt32(Console.ReadLine());

                // Apply binary serach
                int lowerbound = 0;
                int upperbound = n - 1;

                //obtain the index of the middle elements
                int mid = (lowerbound + upperbound) / 2;
                int ctr = 1;

                //loop to serach for the elements in the array
                while ((item != arr[mid]) && (lowerbound <= upperbound))
                {
                    if (item > arr[mid])
                        lowerbound = mid + 1;
                    else
                        upperbound = mid - 1;

                    mid = (lowerbound + upperbound) / 2;
                    ctr++;
                }
                if (item == arr[mid])
                    Console.WriteLine("\n" + item.ToString() + "found at positionn" + (mid + 1).ToString());
                else
                    Console.WriteLine("\n" + item.ToString() + "not found in the array\n");
                Console.WriteLine("\nNumber of comparison :" + ctr);
                Console.Write("\nContinue Search (y/n):");
                ch = char.Parse(Console.ReadLine().ToUpper());
            } while ((ch == 'y'));
        }
        public void LinearSearch()
        {
            char ch;
            //serach for number of comparison
            int ctr;
            do
            {
                //Accept the number to be serched
                Console.WriteLine("\nEnter the element you want to serach :");
                int item = Convert.ToInt32(Console.ReadLine());

                ctr = 0;
                for (i = 0; i < n; i++)
                {
                    ctr++;
                    if (arr[i] == item)
                    {
                        Console.WriteLine
                            ("\n" + item.ToString() + " found st position " + ( i + 1).ToString());
                        break;
                    }
                }
                if (i == n)
                    Console.WriteLine("\n" + item.ToString() + " not found in the array ");
                Console.WriteLine("\n Number of comparison: " + ctr);
                Console.Write("\nContinue search (y/n):");
                ch = char.Parse(Console.ReadLine().ToUpper());
            } while ((ch == 'y'));
        }
        static void Main(string[] args)
        {
        }
    }
}
