using System;
using System.Collections.Generic;

namespace NumbersToWords
{
    public class Numbers
    {
        private int _numbers;
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
            {"1", "dime-ee"},
            {"2", "dub"},
            {"3", "tretee"},
            {"4", "foty"},
            {"5", "fitty"},
            {"6", "sitty"},
            {"7", "senty"},
            {"8", "eightdizzle"},
            {"9", "numpty"},

        };

        public Numbers(int numb)
        {
            _numbers = numb;
        }
        public int GetNum()
        {
            return _numbers;
        }

        public string NumToWords(int num)
        {
            string words = "";
            int intNum = num;
            string strNum = num.ToString();
            char[] arr = strNum.ToCharArray();
            if (intNum == 0)
            {
                return Units[strNum];
            }
            if ((intNum / 1000000) > 0)
            {
                words += NumToWords(intNum / 1000000) + " milli ";
                intNum %= 1000000;

            }
            if ((intNum / 1000) > 0)
            {
                words += NumToWords(intNum / 1000) + " thou ";
                intNum %= 1000;

            }
            if ((intNum / 100) > 0)
            {
                words += NumToWords(intNum / 100) + " hunnid ";
                intNum %= 100;
            }

            if (intNum > 0)
            {
                if (words != " ")
                {
                    words += "and ";
                }
                if (intNum < 20)
                {
                    words += Units[intNum.ToString()];
                }
                else
                {
     
                    words += Tens[(intNum/10).ToString()];
                    if ((intNum % 10) > 0)
                    {
                        words += "-" + Units[(intNum % 10).ToString()];
                    }
                }
            }
            return words;
        }
    }
}