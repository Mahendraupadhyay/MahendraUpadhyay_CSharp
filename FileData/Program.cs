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
            FileDetails fileDetails = new FileDetails();
            if(args[0]=="-v")
            {
              Console.WriteLine(fileDetails.Version(args[1]));
                Console.ReadKey();
            }
        }
    }
}
