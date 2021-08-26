using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Console.WriteLine(class1.GetVersionNumber(args));
            Console.ReadKey();
        }
    }

    public class Class1
    {
        public string GetVersionNumber(string[] input)
        {
            string result = string.Empty;
            FileDetails fileDetails = new FileDetails();
            if (input[0] == "-v")
            {
                result = fileDetails.Version(input[1]);
            }
            return result;
        }
    }
}
