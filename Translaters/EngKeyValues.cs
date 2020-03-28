using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyLogReader.Translaters
{
    class EngKeyValues : IKeyValues
    {
        public EngKeyValues()
        {
            string[] values =
            {
                "q","w","e","r","t","y","u","i","o","p","[","]",
                "a","s","d","f","g","h","j","k","l",";","'",
                "z","x","c","v","b","n","m",",",".","?"," ",
            };

            this.Values = values;
        }

        public string[] Values { get; set; }
    }
}
