using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Something_basic
{
    class Program
    {

    public static int trustA = 5;
    public static int paranoiaA = 5;
    public static int suspiciousA = 5;

    static string choice = "D";

        
       

        static void Main(string[] args)
        {
           effectTrust();
           trustResult();


            System.Console.ReadKey();
        }


        private static void effectTrust()
        {
            System.Console.WriteLine ("1. Option A");
            System.Console.WriteLine("2. Option B");
            System.Console.WriteLine("3. Option C");

            choice = System.Console.ReadLine();

            if ((choice == "A"))
            {
            System.Console.WriteLine ("did it work?");
            trustA = trustA + 1;
            }

            if ((choice == "B"))
            {
            System.Console.WriteLine ("Other option");
            paranoiaA = paranoiaA + 2;

            }

            else
            {
            System.Console.WriteLine ("poor choice");
            trustA = trustA - 1;
            }

        }
        private static void trustResult()
        {
            Convert.ToString(trustA);
            Convert.ToString(paranoiaA);

            System.Console.WriteLine ("trust A is now;");
            System.Console.WriteLine(trustA);
            System.Console.WriteLine ("paranoia A is now");
            System.Console.WriteLine (paranoiaA);
        }
    }
}
