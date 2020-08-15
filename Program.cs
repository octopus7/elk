using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace athena_cflog_timestamp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0) 
            {
                Console.WriteLine("csv 필요!");
                return;
            }

            string inputPath = args[0];

            Console.WriteLine(inputPath);

            var reader =  File.OpenText(inputPath);

            string dir = Path.GetDirectoryName(inputPath);
            string filename = Path.GetFileName(inputPath);

            string newFilePath = dir + "\\timestamp_" + filename;

            Console.WriteLine(newFilePath);

            var writer = new StreamWriter(newFilePath);

            {
                string line = reader.ReadLine();
                string output = line.ReplaceFirst("\",\"", "");
                writer.WriteLine(output);
            }


            //for (int i=0;i<10; i++)
            while(!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string output = line.ReplaceFirst("\",\"", "T");
                string output2 = output.ReplaceFirst("\",\"", "Z\",\"");
                writer.WriteLine(output2);
            }
            writer.Close();
            reader.Close();            
        }

        // https://stackoverflow.com/questions/8809354/replace-first-occurrence-of-pattern-in-a-string

    }

    public static class StringExtensionMethods
    {
        public static string ReplaceFirst(this string text, string search, string replace)
        {
            int pos = text.IndexOf(search);
            if (pos < 0)
            {
                return text;
            }
            return text.Substring(0, pos) + replace + text.Substring(pos + search.Length);
        }
    }
}
