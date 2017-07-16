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


        public enum ChatOption
        {
            Invalid,
            A,
            B,
            C
        }

        
       

        static void Main(string[] args)
        {
           EffectTrust();
           TrustResult();


            System.Console.ReadKey();
        }


        private static void EffectTrust()
        {
            System.Console.WriteLine ("1. Option A");
            System.Console.WriteLine("2. Option B");
            System.Console.WriteLine("3. Option C");

            string choice = System.Console.ReadLine();
            ChatOption choiceCheck = ValidChoice(choice);

            if (choiceCheck == ChatOption.Invalid)
            {
                // Do nothing
            }
            else if (choiceCheck == ChatOption.A)
            {
            System.Console.WriteLine ("did it work?");
            trustA = trustA + 1;
            }
            else if (choiceCheck == ChatOption.B)
            {
            System.Console.WriteLine ("Other option");
            paranoiaA = paranoiaA + 2;

            }
            else if (choiceCheck == ChatOption.C)
            {
            System.Console.WriteLine ("poor choice");
            trustA = trustA - 1;
            }

        }

        private static ChatOption ValidChoice(string choice)
        {
            if (choice == "A")
            {
                return ChatOption.A;
            }
            else if (choice == "B")
            {
                return ChatOption.B;
            }
            else if (choice == "C")
            {
                return ChatOption.C;
            }
            else
            {
                return ChatOption.Invalid;
            }
        }

        private static void TrustResult()
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
