using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CalculatorWithUseString
{
    
    class LearnResult
    {
        public string FactorialNumber;
        public string Process = "";
        public char Operation;
        Calculator myCalculatorObject = null;
        string Regulation(string mydata)
        {
            #region Regulation 

            if (myCalculatorObject == null)
                myCalculatorObject = new Calculator();
            myCalculatorObject.NumberIsSoBig = false;
            if (Operation == '-')
            {
                #region Regulation Subtraction
            
                int index2 = mydata.IndexOf('-');
                string NumberOne = mydata.Substring(0, index2 - 1);
                mydata = mydata.Substring(index2 + 2);
                index2 = mydata.IndexOf('-');
                if (index2 == -1) // for example data is (15 - 2), if data like that, i will subtract normal way
                {
                    return myCalculatorObject.Subtraction(NumberOne, mydata);
                }
                else
                {
                    // for example data is (15 - 4 - 3 - 5);
                    // (15 - 4 - 3 - 5) = 15 - (4 + 3 + 5)
                    // if this happening, i will add the (4, 3 and 5) number. Than, i will subtract numbers that was added out of 15.
                    List<string> Numbers2 = new List<string>();
                    while (index2 != -1)
                    {
                        Numbers2.Add(mydata.Substring(0, index2 - 1));
                        mydata = mydata.Substring(index2 + 2);
                        if (mydata == "")
                            break;
                        index2 = mydata.IndexOf('-');
                    }
                    if (mydata != "")
                        Numbers2.Add(mydata.Substring(0, index2 - 1));
                    return myCalculatorObject.Subtraction(NumberOne, myCalculatorObject.AdditionForUser(Numbers2.ToArray()));
                }
                
               

                #endregion
            }
            if (Operation == '!')
            {
                return myCalculatorObject.LearnFactorial(FactorialNumber);
            }
            #region Regulation Division & Addition & Multiplication

            // if my data have numbers more than 2, i will save the numbers
            int index = mydata.IndexOf(Operation);
            List<string> Numbers = new List<string>();
            while (index != -1)
            {
                Numbers.Add(mydata.Substring(0, index - 1));
                mydata = mydata.Substring(index + 2);
                index = mydata.IndexOf(Operation);
            }
            Numbers.Add(mydata); // the end of Numbers

            if (Operation == '+')
            {
                return myCalculatorObject.AdditionForUser(Numbers.ToArray());
            }
            else if (Operation == '/')
            {
                string ResultForNow = myCalculatorObject.Division(Numbers[0], Numbers[1], false); // it can be return "..." 
                if (Numbers.Count > 2) // (for example)  if there are so many process, in order to can't division "12" with "4,45...", i cut the "...".
                    ResultForNow = ResultForNow.Replace("...", ""); // in this way, we can division "12" with "4,45"
                for (int ax = 2; ax < Numbers.Count; ax++)
                {
                    if (ax == Numbers.Count - 1)
                        ResultForNow = myCalculatorObject.Division(ResultForNow, Numbers[ax], false);
                    else
                        ResultForNow = myCalculatorObject.Division(ResultForNow, Numbers[ax], true);
                }
                return ResultForNow;
            }
            else if (Operation == 'x')
            {
                string ResultForNow = myCalculatorObject.Multiplication(Numbers[0], Numbers[1]);
                for (int ax = 2; ax < Numbers.Count; ax++)
                {
                    ResultForNow = myCalculatorObject.Multiplication(ResultForNow, Numbers[ax]);
                }
                return ResultForNow;
            }
            else
                return "Error";


            #endregion

            #endregion
        }
        public void GetResult()
        {
            #region I learn Result
            string mydata = Process;
            Form1.Result1 = Regulation(mydata);
            Form1.ProcessHasFinished = true; // I'm reports to "Form1"
       
            #endregion
        }
    }
}
