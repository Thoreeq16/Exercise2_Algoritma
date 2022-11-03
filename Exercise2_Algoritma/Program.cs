using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearTest
{
    class Program
    {
        //array to be searched
        int[] arr = new int[74];
        //number of element i n the array
        int n;
        //get the number of element to store in the array
        int i;

        public void input()
        {
            while (true)
            {
                Console.Write("enter the number of element in the array");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 74))
                    break;
                else
                    Console.WriteLine("\nArray should have minimum 1 and minimum 74 element.\n");
            }
            //accept array element
            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.WriteLine(" Enter Array Element ");
            Console.WriteLine("---------------------");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine('<' + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }

        public void LinearSearch()
        {
            char ch;
            //Search for the number of comparasion
            int ctr;
            do
            {
                //accept the number to be searched
                Console.Write("\nEnter the element you want to search:");
                int item = Convert.ToInt32((Console.ReadLine()));

                ctr = 0;
                for (i = 0; i < n; i++)
                {
                    ctr++;
                    if (arr[i] == item)
                    {
                        Console.WriteLine("\n" + item.ToString() + " found st position " + (i + 1).ToString());
                        break;
                    }
                }
                if (i == n)
                    Console.WriteLine("\n" + item.ToString() + "not found in the array");
                Console.WriteLine("\nNumber of comparasion: " + ctr);
                Console.WriteLine("\nContinue search (y/n): ");
                ch = char.Parse(Console.ReadLine().ToUpper());
            } while ((ch == 'y'));
        }

        static void Main(string[] args)
        {
            Program myList = new Program();
            int pilihanmenu;
            char ch;
            do
            {
                do
                {
                    Console.WriteLine("Menu Option");
                    Console.WriteLine("=================");
                    Console.WriteLine("1. Linear search");
                    Console.WriteLine("2. exit");
                    Console.WriteLine("Enter your choice (1,2) : ");
                    pilihanmenu = Convert.ToInt32(Console.ReadLine());
                    switch (pilihanmenu)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("................");
                            Console.WriteLine("Linear Search");
                            Console.WriteLine("................");
                            myList.input();
                            myList.LinearSearch();
                            break;
                        case 2:
                            Console.WriteLine("Exit");
                            break;
                    }
                    Console.WriteLine("\nPilih menu lagi? (y/n): ");
                    ch = char.Parse(Console.ReadLine().ToLower());
                    Console.Clear();
                } while (ch == 'y');

                //to exit from the console
                Console.WriteLine("\n\nPress return to exit. ");
                Console.ReadLine();
            } while (pilihanmenu != 0);
        }
    }
}