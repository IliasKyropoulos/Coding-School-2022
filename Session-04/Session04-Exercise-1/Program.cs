using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session04_Exercise_1
{
    class Program
    {
        static void Main1()
        {
            Console.Write("Enter your string: ");
            string originalString = Console.ReadLine();
            string reverseString = string.Empty;

            for (int i = originalString.Length - 1; i >= 0; i--)
            {
                reverseString += originalString[i];
            }
            Console.Write($"Reverse String is : {reverseString} ");
            Console.ReadLine();
        }
        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        static void Main2()
        {
            Console.Write("Give and int: ");
            int userInt = Convert.ToInt32(Console.ReadLine());

            Console.Write("(sum/product)\nEnter your choice: ");

            if (Console.ReadLine() == "sum")
            {
                //Computing the sum of userInt
            }

            else
            {
                //Computing the product of userInt
            }
            Console.ReadLine();
            // Ήθελα να κάνω ckeck το input του user αλλά δεν μπορούσα να κάνω:
            // while (Console.ReadLine() != "sum || "product"){}
        }
        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        static void Main3()
        {
            int number, i, ctr, startingNumber, endingNumber;

            Console.Write("Start of prime number range: ");
            startingNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("End of prime number range: ");
            endingNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Your prime number range is from {0} to {1} \n", startingNumber, endingNumber);

            for (number = startingNumber; number <= endingNumber; number++)
            {
                ctr = 0;

                for (i = 2; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }

                if (ctr == 0 && number != 1)
                    Console.Write("{0} ", number);
            }
            Console.ReadLine();
        }
        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        static void Main4()
        {
            int[] Array1 = { 2, 4, 9, 12 };
            int[] Array2 = { 1, 3, 7, 10 };
            int[] Array3 = new int[16];

            for (int i = 0; i < 4; i++)
                
                for (int j = 0; j < 4; j++)
                    Array3[i * 4 + j] = Array1[i] * Array2[j];
            
            Console.WriteLine("[{0}]", string.Join(", ", Array3));
            Console.ReadLine();
        }
        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        static void Main5()
        {
            int temp;

            int[] yourArray = { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };

            for (int i = 0; i < yourArray.Length; i++)
            {
                for (int j = 1 + i; j < yourArray.Length; j++)
                {
                    if (yourArray[i] > yourArray[j])
                    {
                        temp = yourArray[i];
                        yourArray[i] = yourArray[j];
                        yourArray[j] = temp;
                    }
                }
            }

            Console.Write("Array list after sorting:");
            for (int i = 0; i < yourArray.Length; i++)
            {
                Console.Write(yourArray[i] + " ");
            }
            Console.ReadLine();
        }
            // Άσκηση 5 αλλά με input user.~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            static void Main6()
        {
            int temp;
            int[] yourArray = new int[10];

            Console.Write("Enter your 10 numbers: ");
            for (int i = yourArray.Length - 1; i >= 0; i--)
            {
                yourArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < yourArray.Length; i++)
            {
                for (int j = 1 + i; j < yourArray.Length; j++)
                {
                    if (yourArray[i] > yourArray[j])
                    {
                        temp = yourArray[i];
                        yourArray[i] = yourArray[j];
                        yourArray[j] = temp;
                    }
                }
            }

            Console.Write("Array list after sorting:");
            for (int i = 0; i < yourArray.Length; i++)
            {
                Console.Write(yourArray[i] + " ");
            }
            Console.ReadLine();

            // Ήθελα να χρησιμοποιήσω input από τον user για το πλήθος των αριθμών του array του,
            // αλλά δεν μπορούσα να κάνω:
            //
            // Console.Write("Enter the amout of numbers in your array: ");
            // int[] yourArrayLength = new int[] { Convert.ToInt32(Console.ReadLine) };
            //
            // Είχα error: cannot convert from 'method group' to 'object'
        }

    }
}
