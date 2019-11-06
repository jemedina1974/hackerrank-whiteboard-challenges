using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;


namespace HackerRank_PracticeCode
{
   
    class Solutions
    {
        static int saveThePrisoner(int n, int m, int s)
        {
            int iReturn = 0;
            int iS = s;
            int x = 0;
            int x2 = 0;
                        
            if (m < n)
            {
                for (int cm = 1; cm <= m; cm++)
                {
                    if (iS <= n)
                    {
                        iS++;
                    }
                    else
                    {
                        iS = 1;
                    }
                }
                iReturn = iS-1;
            }else
            {
                x = m - n;
                x2 = s + x - 1;
                if (x2 > n)
                {
                    x2 = x2 - n;
                }
                iReturn = x2 ;

            }
                
            

            return iReturn;

        }


        private static int findDigits(int n)
        {
            int iReturn = 0;
            int iDivisor = 0;
            int iResult = 0;

            string sNumber = Convert.ToString(n);

            for (int i=0;i< sNumber.Length; i++)
            {
                iDivisor = Convert.ToInt32(sNumber.Substring(i, 1));
                if (iDivisor > 0)
                {
                    iResult = n % iDivisor;
                    if (iResult == 0)
                    {
                        iReturn++;
                    }
                }
               
            }

            return iReturn;
        }

        static void Main(string[] args)
        {
            

            Console.WriteLine("*******************Welcome to Medinas codes *********************");
            Console.WriteLine("**************************MAIN MENU *********************");
            Console.WriteLine("1.-Save the prisoner");
            Console.WriteLine("2.-Find digits");
            Console.WriteLine("0.-Exit");
            Console.Write("Select option:");
            int iOpt = Convert.ToInt32(Console.ReadLine());

            if (iOpt != 0)
            {

                switch (iOpt)
                {
                    case 1:saveThePrisoner_EnterData();
                        break;
                    case 2:findDigits_EnterData();
                        break;

                }
                
            }else
            {
                Environment.Exit(0);
            }
           
        }

        private static void findDigits_EnterData()
        {
            TextWriter textWriter = new StreamWriter(@"C:\Temp\HackerRank_OutFiles\FindDigit_log.txt", true);
            Console.WriteLine("Your selection == Find a digit ==");

            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int result = findDigits(n);

                Console.WriteLine("Result for test #" + Convert.ToString(tItr+1) + " , Result = " + Convert.ToString(result));
                textWriter.WriteLine(result);
            }
            Console.WriteLine("Program Terminate, press any key to exit");
            Console.ReadLine();

            textWriter.Flush();
            textWriter.Close();
        }


        private static void saveThePrisoner_EnterData()
        {
            TextWriter textWriter = new StreamWriter(@"C:\Temp\HackerRank_OutFiles\SavePrisoner_log.txt", true);
            Console.WriteLine("Your selection == Save the prisoner ==");
            int t = Convert.ToInt32(Console.ReadLine());
            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] nms = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(nms[0]);

                int m = Convert.ToInt32(nms[1]);

                int s = Convert.ToInt32(nms[2]);

                int result = saveThePrisoner(n, m, s);

                Console.WriteLine("Test " + Convert.ToString(tItr+1) + " Result = " + Convert.ToString(result));
                textWriter.WriteLine(result);
            }
            Console.WriteLine("Program Terminate, press any key to exit");
            Console.ReadLine();
            textWriter.Flush();
            textWriter.Close();
        }
    }
}
