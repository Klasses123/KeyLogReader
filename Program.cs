using KeyLogReader.Translaters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KeyLogReader
{
    class Program
    {
        static void Main(string[] args)
        {
            //log directory
            string filePath = @"C:\projects\KeyLog\Logs\LoggedKeys.text";

            var translator = new Translator(new RusKeyValues());
            Console.WriteLine(translator.Translate(File.ReadAllLines(filePath)));

            translator = new Translator(new EngKeyValues());
            Console.WriteLine(translator.Translate(File.ReadAllLines(filePath)));

            Console.WriteLine(ToStringFormat(File.ReadAllLines(filePath)));
            Console.ReadKey();
        }

        static string ToStringFormat(string[] input)
        {
            string result = "";
            for(int i = 0; i < input.Length; i++)
            {
                result += input[i];
            }

            return result;
        }
    }
}
