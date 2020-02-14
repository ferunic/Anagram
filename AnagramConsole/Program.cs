using System;
using System.IO;
using System.Text;

namespace AnagramConsole
{
    static class Program
    {
        static void Main(string[] args)
        {
           if (args.Length < 2)
           {
               Console.WriteLine("Trenger input and output fil feks: ./anagramconsole Anagram-ordbok.txt resultat.txt");
               return;
           }
           if (!File.Exists(args[0]))
           {
               Console.WriteLine(@"Fant ikke input file {0} ",args[0]);
               return;
           }
           var engine = new AnagramService.AnagramService(File.ReadAllLines(args[0], Encoding.GetEncoding(28591)), args[1]);
           engine.CreateAnagramFile(); 
        }
    }
}
