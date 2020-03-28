using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyLogReader.Translaters
{
    class RusKeyValues : IKeyValues
    {
        public RusKeyValues()
        {
            string[] values = 
            { 
                "й","ц","у","к","е","н","г","ш","щ","з","х","ъ",
                "ф","ы","в","а","п","р","о","л","д","ж","э",
                "я","ч","с","м","и","т","ь","б","ю","."," ",
            };

            this.Values = values;
        }

        public string[] Values { get; set; }
    }
}
