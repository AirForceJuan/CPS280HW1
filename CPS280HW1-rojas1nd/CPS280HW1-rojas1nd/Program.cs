using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CPS280HW1_rojas1nd
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bigArray = new int[100000];

            Random gen = new Random();


            for (int i = 0; i < bigArray.Length; i++)
            {

                int r = gen.Next(0, 100000);

                bigArray[i] = r;
            }

            for(int p = 0;p < bigArray.Length;p++)
            {
                Console.WriteLine(bigArray[p]);
            }



            var arr = new[]
           {
                    @"  /$$$$$$   /$$$$$$  /$$$$$$$  /$$$$$$$$          /$$$$$$  /$$$$$$$  /$$$$$$$   /$$$$$$  /$$     /$$",
                    @" /$$__  $$ /$$__  $$| $$__  $$|__  $$__/|        /$$__  $$| $$__  $$| $$__  $$ /$$__  $$|  $$   /$$/",
                    @"| $$  \__/| $$  \ $$| $$  \ $$   | $$   |       | $$  \ $$| $$  \ $$| $$  \ $$| $$  \ $$ \  $$ /$$/", 
                    @"|  $$$$$$ | $$  | $$| $$$$$$$/   | $$   |       | $$$$$$$$| $$$$$$$/| $$$$$$$/| $$$$$$$$  \  $$$$/",  
                    @" \____  $$| $$  | $$| $$__  $$   | $$   |       | $$__  $$| $$__  $$| $$__  $$| $$__  $$   \  $$/",   
                    @" /$$  \ $$| $$  | $$| $$  \ $$   | $$   |       | $$  | $$| $$  \ $$| $$  \ $$| $$  | $$    | $$",    
                    @"|  $$$$$$/|  $$$$$$/| $$  | $$   | $$   |       | $$  | $$| $$  | $$| $$  | $$| $$  | $$    | $$",    
                    @" \______/  \______/ |__/  |__/   |__/   |       |__/  |__/|__/  |__/|__/  |__/|__/  |__/    |__/",             
            };

            Console.WindowWidth = 160;
            Console.WriteLine("\n\n");
            foreach(string line in arr)
                Console.WriteLine(line);
            Console.WriteLine("====================================================================================================");
            Console.WriteLine("Press Enter Twice to Sort Array");

            Console.ReadKey();

            Stopwatch sw = new Stopwatch();

            sw.Start();

            int temp = 0;

            for (int i = bigArray.Length -1;i > 0; i--)
            {
                for (int j = 0; j <= i -1; j++)
                {
                    if (bigArray[j] > bigArray[j + 1])
                    {
                        temp = bigArray[j+ 1];
                        bigArray[j + 1] = bigArray[j];
                        bigArray[j] = temp;
                    }
                    

                }

            }

            sw.Stop();

            TimeSpan elapsedTime = sw.Elapsed;

            Console.WriteLine(elapsedTime);

            Console.ReadLine();

        }


    }
}
