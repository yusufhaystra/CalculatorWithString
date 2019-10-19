using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalculatorWithUseString
{
    class Sort
    {
        
        public string[] SortByStringLength(params string[] values)
        {

            string[] result = new string[values.Length];

            Array.Copy(values, result, values.Length);
            

            Array.Sort(result, new LegthComparer());

            return result;
        }
        public string AddPoint(string data)
        {
            int index = data.IndexOf(","); // i won't add the point to contains "," numbers
            if (index != -1)
            {
                data = data.Substring(0, index);
            }
            // 1 234 567 890
            string newdata = "";
            byte will_next = Convert.ToByte(data.Length % 3);
            byte number = 0;
            foreach (char cx in data)
            {
                if (number == will_next)
                {
                    newdata += cx;
                }
                else
                {
                    number++;
                }

            }
            return "";
        }

        public string DeleteTheZero(string Data)
        {
            #region Delete "0"

            // Result may be "0052" or "024" and such like ...
            // So, in left of result, it may contains "0" 
            // If this be, i will fix this
            bool ResultIsNegative = false;
            if (Data.StartsWith("-"))
            {
                ResultIsNegative = true;
                Data = Data.Replace("-", "");
            }
            if (Data.Contains(","))
            {
                string Data0 = Data.Substring(0, Data.IndexOf(","));
                string Data1 = Data.Substring(Data.IndexOf(",") + 1);

                #region Delete "0"
                int index0 = Data0.IndexOf("0");
                while (index0 == 0)
                {
                    Data0 = Data0.Substring(1);
                    index0 = Data0.IndexOf("0");
                }
                if (Data0 == "")
                    Data0 += "0";
                #endregion

                #region Delete "0"
                int index1 = Data1.LastIndexOf("0");
                while (index1 == Data1.Length - 1 && index1 != -1)
                {
                    Data1 = Data1.Substring(0, Data1.Length - 1);
                    index1 = Data1.LastIndexOf("0");
                }
                #endregion

                Data = Data0 + "," + Data1;

            }
            if (!Data.Contains(","))
            {
                #region Delete "0"
                int index = Data.IndexOf("0");
                while (index == 0)
                {
                    Data = Data.Substring(1);
                    index = Data.IndexOf("0");
                }
                #endregion
            }

            #endregion

            if (ResultIsNegative)
                Data = "-" + Data;
            return Data;
        }
        
        public bool NumberIsZero(string data)
        {
            string[] NumbersExceptZero = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            foreach (string sx in NumbersExceptZero)
            {
                if (data.Contains(sx))
                {
                    return false; // no, number is not zero
                }
            }
            return true;
        }
    }
    class LegthComparer : IComparer<string>
    {
        public int Compare(string data1, string data2)
        {
            //return s1.Length - s2.Length;
            int result = data1.Length - data2.Length;

            if (result == 0) // if strings have same length
            {
            
                result = data1.CompareTo(data2); // compare alphabetically
            }

            return result;
        }
    }
}
