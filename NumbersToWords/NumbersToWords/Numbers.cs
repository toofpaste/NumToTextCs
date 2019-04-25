using System;
using System.Collections.Generic;

namespace NumbersToWords
{
    public class Numbers
    {
        private string _numbers;
        private static Dictionary<string, string> Units = new Dictionary<string, string>()
        {
            {"0", "zip"},
            {"1", "uno"},
            {"2", "tru"},
            {"3", "tre"},
            {"4", "fo"},
            {"5", "feye"},
            {"6", "6ix"},
            {"7", "se-en"},
            {"8", "ate"},
            {"9", "nen"},
            {"10", "dime"},
            {"11", "lem"},
            {"12", "fuck twelve"},
            {"13", "thirleen"},
            {"14", "fourleen"},
            {"15", "fiteen"},
            {"16", "siteen"},
            {"17", "seteen"},
            {"18", "ehteen"},
            {"19", "niteen"},
          

        };

        private static Dictionary<string, string> Tens = new Dictionary<string, string>()
        {
            {"0", "zip"},
            {"10", "dime"},
            {"20", "dub"},
            {"30", "tre"},
            {"40", "foty"},
            {"50", "fitty"},
            {"60", "sitty"},
            {"70", "senty"},
            {"80", "eightdizzle"},
            {"90", "numpty"},

        };


        public Numbers(string numb)
        {
            _numbers = numb;
        }

        public string NumToWords(string num)
        {
            string words = "";
            int intNum = int.Parse(num);
            char[] arr = num.ToCharArray();
            if(intNum == 0)
            {
                return Units[num];
            }
            if((intNum/1000000) > 0)
            {
                words += NumToWords(intNum / 1000000) + " milli ";
                intNum %= 1000000;
                
            }
            if ((intNum / 1000) > 0)
            {
                words += NumToWords(intNum / 100000) + " rack ";
                intNum %= 1000;

            }
            if((intNum / 100)>0)
            {
                words += NumToWords(intNum / 100) + " hunnid ";
                intNum %= 100;
            }

            if(intNum > 0)
            {
                if(words != " ")
                {
                    words += "and ";
                }
                if(intNum < 20)
                {
                    words += Units[intNum];
                }
                else
                {
                    words += Tens[intNum / 10];
                    if ((intNum % 10 )> 0)
                    {
                        words += "-" + Tens[intNum % 10];
                    }
                }
            }
            return words;
        }
    }
}
