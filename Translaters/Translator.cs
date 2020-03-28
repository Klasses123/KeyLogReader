using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyLogReader.Translaters
{
    class Translator
    {
        private readonly KeyValue[] keyValues;
        private readonly string[] keys =
        {
            "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "OemOpenBrackets", "Oem6",
            "A", "S", "D", "F", "G", "H", "J", "K", "L", "Oem1", "Oem7",
            "Z", "X", "C", "V", "B", "N", "M", "Oemcomma", "OemPeriod", "OemQuestion", "Space"
        };

        public Translator(IKeyValues language)
        {
            keyValues = new KeyValue[keys.Length];
            for(int i = 0; i < language.Values.Length; i++)
            {
                keyValues[i] = new KeyValue { Key = keys[i], Value = language.Values[i] };
            }
        }
        public string Translate(string[] log)
        {
            string result = "";
            for(int i = 0; i < log.Length; i++)
            {
                if(keys.Contains(log[i]))
                {
                    result += keyValues.Where(x => x.Key == log[i]).FirstOrDefault().Value;
                }
            }

            return result;
        }
    }
}
