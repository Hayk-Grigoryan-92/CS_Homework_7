using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //////////////////////////// Exercices 7 ///////////////////////////////////////////////
            /*
            //Ex: 1․ Write a C# Sharp program to display the cube of an integer up to given number.
                Test Data :
                Input number of terms : 5
                Expected Output :
                Number is : 1 and cube of the 1 is :1
                Number is : 2 and cube of the 2 is :8
                Number is : 3 and cube of the 3 is :27
                Number is : 4 and cube of the 4 is :64
                Number is : 5 and cube of the 5 is :125
             */
            /*
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(Math.Pow(i, 3));
            }
            */
            // ----------------------------------------------------------------

            /*
             Ex: 2․Write a program in C# Sharp to display the n terms of even natural number and their sum.
                    Test Data :
                    Input number of terms : 5
                    Expected Output :
                    The even numbers are :2 4 6 8 10
                    The Sum of even Natural Number upto 5 terms : 30
             */
            /*
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 2; i <= num * 2; i+=2) 
            {
                Console.WriteLine(i);
                sum += i;
               
            }
            Console.WriteLine(sum);
            */
            //------------------------------------------------------------------

            /*
             Ex: 3. Write a program in C# Sharp to print Triangle.

                1
                01 
                010
                1010 
                10101
             */
            /*
            int num = int.Parse(Console.ReadLine());
            int x = 0;

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(x);
                    x = 1 - x;
                }
                Console.WriteLine();
            }
            */
            //---------------------------------------------------------------------------

            /*
             EX: 4. Write a program in C# Sharp to display the pattern like a this.

                 *******
                  *****
                   ***
                    * 
            */
            /*
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = num - i; k > 0; k--)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
            */
            //-----------------------------------------------------------------------------
            /*
             5. Write a program in C# Sharp to display the pattern like a diamond.

                    * 
                   *** 
                  *****
                 *******
                *********
                 *******
                  *****
                   ***
                    *
             */
            /*
            int num = int.Parse(Console.ReadLine());
            int i = 0;
            bool flag = true;
            
            if (flag) 
            {
                for (i = 0; i <  num; i++)
                {
                    for (int k = num - i - 1; k > 0; k--)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write(" *");
                    }
                    Console.WriteLine();
                    if(i == num-1)
                    {
                        flag = false;
                    }
                }
               
            }
            if (!flag) 
            {
                for (i = 0; i < num; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = num - i; k > 0; k--)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
            }
            */
            //-----------------------------------------------------------------------------------------
            /*
             6. Write a program in C# Sharp to convert a decimal number into binary without using an array.
                Test Data :
                Enter a number to convert : 25
                Expected Output :
                The Binary of 25 is 11001.
             */
            /*
            int number = int.Parse(Console.ReadLine());
            string result = "";
            while (number != 0)
            {
                int x = number % 2;
                number = number / 2;
                result += x;
            }
            for (int i = result.Length - 1; i >= 0; i--)
            {
                Console.Write(result[i]);
            }
           */
            //--------------------------------------------------------------------------
            /*
             7․ Գրել ծրագիր, որը console ից կստանա 10 հատ թիվ և կտպի այդ թվերից ամենափոքրը։
             */
            /*
            int result = int.Parse(Console.ReadLine());

            for (int i = 0; i < 9; i++) 
            {
                int number = int.Parse(Console.ReadLine());

               
                if (number < result)
                {
                    result = number;
                }
            }
        
            Console.WriteLine($"Result : {result}");
            */
            //----------------------------------------------------------------------------

            ///////////////////////////// Exercices 8  /////////////////////////////////////////
            /*
             1. Գրել ծրագիր, որը console ից կստանա n բնական թիվ և * ներով կտպի n - ը n - ի վրա քառակուսի։

                Օրինակ ՝ 
                Մուտք 5
                Ելք
                * * * * *
                *       *  
                *       *
                *       *
                * * * * *
             */
            /*
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++) 
            {
                for (int j = 0; j < number; j++) {
                    if (i == 0 || i == number-1 || j == 0 || j == number-1)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            */
            //------------------------------------------------------------------------

            /*
             2. Write a program in C# Sharp to display the first 10 natural numbers.
                Expected Output :
                1 2 3 4 5 6 7 8 9 10
             */
            /*
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            */

            //-----------------------------------------------------------------------------

            /*
             3. Write a C# Sharp program to find the sum of the first 10 natural numbers.
                Expected Output :
                The first 10 natural number is :
                1 2 3 4 5 6 7 8 9 10
                The Sum is : 55
             */
            /*
            int sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
            */
            //--------------------------------------------------------------------------------

            /*
             4. Գրել ծրագիր, որը կհաշվի 1-100 միջակայքում բոլոր կենտ թվերի թվաբանական միջինը։
             */
            /*
            int sum = 0;
            int result = 0;

            for (int i = 1; i <= 100; i++)
            {
                if(i % 2 == 1)
                {
                    sum += i;
                }
                result = sum / 50;
            }
            Console.WriteLine(result);
            */
            //-------------------------------------------------------------------------------------

            /*
             5. Գրել ծրագիր, որը 10 անգամ console ից կստանա թիվ և կտպի թիվը կենտ է թե զույգ։
             */
            /*
            for (int i = 1; i < 10; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if(num%2 == 0)
                {
                    Console.WriteLine("Even number");
                }
                else
                {
                    Console.WriteLine("Odd number");
                }
            }
            */
            //-------------------------------------------------------------------------

           // 6.Գրել ծրագիր, որը console ից կստանա n բնական թիվ և n անգամ կտպի պատահական թիվ։
           /*
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) 
            {
                Random rnd = new Random();
                int newRnd = rnd.Next(0,101);
                Console.WriteLine(newRnd);
            }
            */


        }

    }
}




