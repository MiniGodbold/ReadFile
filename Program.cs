using System;

namespace Voting_System
{
    class open_file
    {
        static void Main(string[] args)
        {
            string readText = File.ReadAllText(@"c:\Users/owengodbold/Projects/Voting_System/Data");
            var result = readText.Replace("; ", Environment.NewLine);
            Console.WriteLine(result);
        }
    }
}
