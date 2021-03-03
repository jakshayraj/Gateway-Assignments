using System;

namespace UnitTestAssignment2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string a = "akshayraj";
            Console.WriteLine("================================================================================");
            Console.WriteLine("Convert \"" + a + "\" into Uppercase : " + a.ConvertUpper());
            a = "AKSHAYRAJ";
            Console.WriteLine("================================================================================");
            Console.WriteLine("Convert \"" + a + "\" into Lowercase : " + a.ConvertLower());
            a = "akshayraj jadeja";
            Console.WriteLine("================================================================================");
            Console.WriteLine("Convert \"" + a + "\" into Titlecase : " + a.ConvertTitleCase());
            a = "akshayraj";
            Console.WriteLine("================================================================================");
            Console.WriteLine("Check all the character of string is lower case or not \"" + a + "\" : " + a.IsLower());
            a = "akshayraj jadeja";
            Console.WriteLine("================================================================================");
            Console.WriteLine("Convert \"" + a + "\" into Capitalize : " + a.ConvertCapitalize());
            a = "AKSHAYRAJ";
            Console.WriteLine("================================================================================");
            Console.WriteLine("Check all the character of string is upper case or not in \"" + a + "\" : " + a.IsUpper());
            a = "akshayraj jadeja";
            Console.WriteLine("================================================================================");
            Console.WriteLine("No of word in \"" + a + "\" : " + a.WordCount());
            a = "Akshayraj Jadeja";
            Console.WriteLine("================================================================================");
            Console.WriteLine("After removing last char from string \"" + a + "\" : " + a.RemoveLastCharacter());
            string num = "123A";
            Console.WriteLine("================================================================================");
            if (num.ValidNumeric() == true)
                Console.WriteLine("\"" + num + "\" is not valid numeric value");
            else
                Console.WriteLine("\"" + num + "\" is not valid numeric value");
            Console.WriteLine("================================================================================");
            if  (num.StringToNumber() == null)
                Console.WriteLine("\"" + num + "\" can not convert in numeric value");
            else
                Console.WriteLine("\"" + num + "\" numeric value is : " + num.StringToNumber());
            
        }
    }
}
