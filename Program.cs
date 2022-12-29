using System;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            /*
            // Cüt yerdə duran rəqəmlər ( kv cemi )
            int number = int.Parse(Console.ReadLine());
            int countDigit = 0;
            
            while(number > 0)
            {
                number /= 10;
                countDigit++;

            }
            Console.WriteLine(countDigit);

            int countDigitLog = (int)Math.Log10(number) + 1;
            int r, i;

            if (countDigit % 2 == 0)
                i = 0;
            else
                i = 1;

                i =  countDigitLog % 2 == 0 ? 0 : 1;

            i= countDigitLog;

            while (number != 0) 
            {
                r = number % 10;
                number /= 10;

                if (i % 2 == 0) 
                {
                    Console.WriteLine(r);
                }

                i--;
               
            }

            Console.WriteLine(countDigitLog);
            */
            #endregion end of Task 1



            #region  Task 2 
            /*
            //Rəqəmlər və sıra nömrələri ( hasil+cem)

            int number = int.Parse(Console.ReadLine());
            int count = (int)Math.Log10(number);
            int r;
            int sum = 0;
            
            while (number != 0) 
            {
                r = number % 10;
                number /= 10;
                sum += r * count;
                count--;
            }

            Console.WriteLine(sum);
            Console.WriteLine("Hello Teacher");
            */

            #endregion End of Task 2

            #region Task 3 

            // 5 reqemli eded verilib. (evvele+4 ; sona+2)
            /*
            int number = int.Parse(Console.ReadLine());

            int count = (int)Math.Log10(number) + 1;

            if ( count == 5 )
            {
                int result = (400000 + number) * 10 + 2;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Eded 5 reqemli olmalidir");
            }
            */
            #endregion end of task 3 

            #region Task 4 
            ////Rəqəmlərin yoxlanilması (muxteliflik)

            //int number = int.Parse(Console.ReadLine());
            //int r1, r2;
            //int tmp;
            //bool isDifferenceDigit = true;

            //while (number != 0) 
            //{
            //    r1 = number % 10;
            //    number /= 10;
            //    tmp = number;
            //    while (tmp != 0) 
            //    {
            //        r2 = tmp % 10;
            //        tmp /= 10;

            //        if (r1 == r2)
            //        {
            //            Console.WriteLine("Muxtelif reqemli deyil");
            //            isDifferenceDigit = false;
            //            break;

            //        }

            //        if (!isDifferenceDigit)
            //            Console.WriteLine("Muxtelif reqemlidir");


            //    }
            //}

            #endregion End of task 4

            #region Task 5
            /*
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int count = 0;

            //for (int i = Math.Min(a,b); i <= Math.Max(a,b); i++)
            //{
            //    if (Math.Sqrt(i) == (int)Math.Sqrt(i))
            //    {
            //        Console.WriteLine(i);
            //        count++;
            //    }
            //}

            //9 100

            int kvadrati;
            for (int i = (int)Math.Sqrt(a); i <= Math.Sqrt(b); i++)
            {
                kvadrati = i * i;

                if (kvadrati >= a)
                    Console.WriteLine(kvadrati);
            }

            if (true)
            {

            }
            Console.WriteLine("Count:" + count);
            */

            #endregion end of task 5
















        }
    }
}
