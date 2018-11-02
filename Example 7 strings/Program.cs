using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Strings *****\n");
            BasicStringFunctionality();
            StringConcatenation();            
            //FunWithStringBuilder();
            Console.ReadLine();
        }

        #region String basics
        static void BasicStringFunctionality()
        {
            Console.WriteLine("=> Basic String functionality:");
            string firstName = "Freddy";
            string middleName = "Jr.";
            string lastName = "Mercury";
            string fullName = string.Concat(firstName, " ", middleName, " ", lastName);
            Console.WriteLine("Value of firstName: {0}", firstName);
            Console.WriteLine("Value of fullName: {0}", fullName);
            Console.WriteLine("firstName has {0} characters.", firstName.Length);
            Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
            Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());
            Console.WriteLine("firstName contains the letter y?: {0}",
              firstName.Contains("y"));
            Console.WriteLine("New first name: {0}", firstName.Replace("dy", ""));
            Console.WriteLine();

            
        }
        #endregion

        #region Concatenation
        static void StringConcatenation()
        {
            Console.WriteLine("=> String concatenation:");
            string s1 = "Programming the ";
            string s2 = "PsychoDrill (PTP)";
            string s3 = s1 + s2;
            //s2 = "PsychoDrill (BTB)";
            Console.WriteLine(s3);
            Console.WriteLine();
        }
        #endregion
                       
        #region StringBuilder
        static void FunWithStringBuilder()
        {
            Console.WriteLine("=> Using the StringBuilder:");

            // Make a StringBuilder with an initial size of 256.
            StringBuilder sb = new StringBuilder("**** Fantastic Games ****", 256);

            sb.Append("\n");
            sb.AppendLine("Half Life");
            sb.AppendLine("Beyond Good and Evil");
            sb.AppendLine("Deus Ex 2");
            sb.AppendLine("System Shock");
            Console.WriteLine(sb.ToString());
            // This sample shows the new object was created with concat;
           // sb.Replace("2", "Invisible War");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("sb has {0} chars.", sb.Length);
            Console.WriteLine();
        }
        #endregion
    }
}
