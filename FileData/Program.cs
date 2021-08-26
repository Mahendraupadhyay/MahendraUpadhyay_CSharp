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
            try
            {
                string[] argList1 = new string[] { "-v", "--v", "/ v", "--version" };
                string[] argList2 = new string[] { "-s", "--s", "/ s", "--size" };
                Class1 class1 = new Class1();
                string result = string.Empty;
                if (argList1.Contains(args[0]))
                {
                  result=  class1.GetVersionNumber(args[1]);
                }
                else if (argList2.Contains(args[0]))
                {
                   result = class1.GetSize(args[1]).ToString();
                }

                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }

    public class Class1
    {
        FileDetails fileDetails = new FileDetails();
        public string GetVersionNumber(string input)
        {
            string result = string.Empty;
            try
            { 
                    result = fileDetails.Version(input);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        public int GetSize(string input)
        {
            int result = 0;
            try
            {
               result = fileDetails.Size(input);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }
    }
}
