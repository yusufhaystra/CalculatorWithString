using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;

namespace CalculatorWithUseString
{
    class Calculator
    {
        
        Sort mySortClassObject = new Sort();

        public bool NumberIsSoBig = false;
        public static bool ForDeveloper = false, Checking = false;
        public static double ClosestNumber;
        
        public string Multiplication(string Number1, string Number2)
        {
            
            #region For Short Transactions

            if (Number1 == "0" || Number2 == "0")
                return "0";
            if (Number1 == "1")
                return Number2;
            if (Number2 == "1")
                return Number1;
            if (!ForDeveloper && !NumberIsSoBig)
            {
                double Number1Double, Number2Double;
                if (double.TryParse(Number1, out Number1Double) && double.TryParse(Number2, out Number2Double)) // I Don't Want To Force Ram Memory For Short Operations 
                    return (Number1Double * Number2Double).ToString();

            }
            if (Checking)
            {
                XtraMessageBox.Show("\tThis process can't do without this algorithm. Because your number is so big.\nError: OverFlow");
                Checking = false;
                return "0";
            }
            #endregion

            #region For Negative Numbers

            bool ResultIsNegative = false;
            if (Number1.StartsWith("-") && Number2.StartsWith("-"))
            {
                Number1 = Number1.Substring(1);
                Number2 = Number2.Substring(1);
            }
            else if (Number1.StartsWith("-"))
            {
                Number1 = Number1.Substring(1);
                ResultIsNegative = true;
            }
            else if (Number2.StartsWith("-"))
            {
                Number2 = Number2.Substring(1);
                ResultIsNegative = true;
            }

            #endregion

            #region For Numbers Containing ","

            string Denominator1 = "1", Denominator2 = "1";
            if (Number1.Contains(","))
            {
                // 22,2 => 222 / 10
                int length1 = Number1.Substring(Number1.IndexOf(",") + 1).Length; // after comma
                for (int ax = 0; ax < length1; ax++)
                {
                    Denominator1 += "0";
                }
                Number1 = Number1.Replace(",", ""); // i remove ","
            }
            if (Number2.Contains(","))
            {
                // 22,2 => 222 / 10
                int length2 = Number2.Substring(Number2.IndexOf(",") + 1).Length; // after comma
                for (int ax = 0; ax < length2; ax++)
                {
                    Denominator2 += "0";
                }
                Number2 = Number2.Replace(",", ""); // i remove ","
            }

            #endregion

            #region Calculator with Use String

            int MinLength = Math.Min(Number1.Length, Number2.Length);
            int MaxLength = Math.Max(Number1.Length, Number2.Length);
            // I am saving each digit of the numbers to be multiplied separately.
            // I'm using "bytes" because what I saved is a number between 0 and 9.
            // For Example: Number1 = 13 (1 and 3), Number2 = 24 (2 and 4)
            byte[] Data1 = new byte[MaxLength];
            byte[] Data2 = new byte[MinLength];
            int Length2 = MinLength;

            #region I take the long number

            // my longest number should be "Data1", for my algorithm
            // I am saving the numbers of both numbers separately.
            if (Number2.Replace("-", "").Replace(",", "").Length > Number1.Replace("-", "").Replace(",", "").Length) // number2 is big
            {
                #region Save numbers (if number2 is big)
                for (int ax = 0; ax < Number2.Length; ax++)
                {
                    Data1[ax] = Convert.ToByte(Number2.Substring(ax, 1));
                }

                for (int ax = 0; ax < Number1.Length; ax++)
                {
                    Data2[ax] = Convert.ToByte(Number1.Substring(ax, 1));
                }
                #endregion
            }
            else if (Number2.Replace("-", "").Replace(",", "").Length == Number1.Replace("-", "").Replace(",", "").Length)
            {
                if (Number1.Contains(",") || Number2.Contains(","))
                {
                    int index1 = Number1.IndexOf(","), index2 = Number2.IndexOf(",");
                    if ((index2 > index1 && index1 != -1) || (index2 == -1 && index1 != -1)) // number2 is big
                    {
                        #region Save numbers (if number2 is big)
                        for (int ax = 0; ax < Number2.Length; ax++)
                        {
                            Data1[ax] = Convert.ToByte(Number2.Substring(ax, 1));
                        }

                        for (int ax = 0; ax < Number1.Length; ax++)
                        {
                            Data2[ax] = Convert.ToByte(Number1.Substring(ax, 1));
                        }
                        #endregion
                    }
                    else if (index1 == index2)// equal
                    {
                        string[] numberss = { Number1.Replace(",", "").Replace("-", ""), Number2.Replace(",", "").Replace("-", "") };
                        if (mySortClassObject.SortByStringLength(numberss)[1] == Number2.Replace(",", "").Replace("-", "")) // if number2 is big
                        {
                            #region Save numbers (if number2 is big)
                            for (int ax = 0; ax < Number2.Length; ax++)
                            {
                                Data1[ax] = Convert.ToByte(Number2.Substring(ax, 1));
                            }

                            for (int ax = 0; ax < Number1.Length; ax++)
                            {
                                Data2[ax] = Convert.ToByte(Number1.Substring(ax, 1));
                            }
                            #endregion
                        }
                        else
                        {
                            #region Save numbers (if data1 is big)
                            for (int ax = 0; ax < Number1.Length; ax++)
                            {
                                Data1[ax] = Convert.ToByte(Number1.Substring(ax, 1));
                            }

                            for (int ax = 0; ax < Number2.Length; ax++)
                            {
                                Data2[ax] = Convert.ToByte(Number2.Substring(ax, 1));
                            }
                            #endregion
                        }
                    }
                    else // number1 is big
                    {
                        #region Save numbers (if data1 is big)
                        for (int ax = 0; ax < Number1.Length; ax++)
                        {
                            Data1[ax] = Convert.ToByte(Number1.Substring(ax, 1));
                        }

                        for (int ax = 0; ax < Number2.Length; ax++)
                        {
                            Data2[ax] = Convert.ToByte(Number2.Substring(ax, 1));
                        }
                        #endregion
                    }

                }
                else
                {
                    string[] numberss = { Number1.Replace("-", ""), Number2.Replace("-", "") };
                    if (mySortClassObject.SortByStringLength(numberss)[1] == Number2.Replace("-", "")) // if number2 is big
                    {
                        #region Save numbers (if number2 is big)
                        for (int ax = 0; ax < Number2.Length; ax++)
                        {
                            Data1[ax] = Convert.ToByte(Number2.Substring(ax, 1));
                        }

                        for (int ax = 0; ax < Number1.Length; ax++)
                        {
                            Data2[ax] = Convert.ToByte(Number1.Substring(ax, 1));
                        }
                        #endregion
                    }
                    else // number1 is big
                    {
                        #region Save numbers (if data1 is big)
                        for (int ax = 0; ax < Number1.Length; ax++)
                        {
                            Data1[ax] = Convert.ToByte(Number1.Substring(ax, 1));
                        }

                        for (int ax = 0; ax < Number2.Length; ax++)
                        {
                            Data2[ax] = Convert.ToByte(Number2.Substring(ax, 1));
                        }
                        #endregion
                    }
                }
            }
            else // number1 is big
            {
                #region Save numbers (if data1 is big)
                for (int ax = 0; ax < Number1.Length; ax++)
                {
                    Data1[ax] = Convert.ToByte(Number1.Substring(ax, 1));
                }

                for (int ax = 0; ax < Number2.Length; ax++)
                {
                    Data2[ax] = Convert.ToByte(Number2.Substring(ax, 1));
                }
                #endregion
            }

            #endregion

            #region Manuel Multiplication

            int Number = 0;
            // Manual Multiplication occurs as follows;

            //    126  >>> These numbers must be multiplied (ID: 1)
            //x    43  >>> These numbers must be multiplied (ID: 2)
            //---------
            //    378 >>> These numbers need to be added (ID: 3)
            //+  504  >>> These numbers need to be added (ID: 4)
            //----------
            //   5418 >>> Result

            // When the numbers ID:1 and ID:2 were multiplied, the numbers ID:3 and ID:4 appeared.
            // There were 2 numbers to add because the smallest number was 2 digits.
            // So,
            // digit value of the smallest number = number of numbers to be summed.
            // To save these numbers (378 and 504),  i create string variable;
            string[] MainNumber = new string[MinLength];


            for (int bx = 0; bx < MinLength; bx++)
            {
                byte Plus = 0;
                int Length3 = MaxLength; // manual multiplication goes from right to left. I'll process the number to the left in every loop.
                for (int ax = MaxLength; ax > 0; ax--)
                {
                    Number = ((Data2[Length2 - 1] * Data1[Length3 - 1]) + Plus);
                    Length3--; // in the next loop I'll trade with a the left number
                    if (Number >= 10) // if the two numbers multiplied are greater than 10, i'll save this
                    {
                        if (Length3 == 0) // if the end of the number
                        {
                            MainNumber[bx] = Number.ToString() + MainNumber[bx];
                            Plus = 0;
                        }
                        else
                        {
                            Plus = Convert.ToByte(Number.ToString().Substring(0, 1));
                            MainNumber[bx] = Number.ToString().Substring(1) + MainNumber[bx];
                        }
                    }
                    else
                    {

                        MainNumber[bx] = Number.ToString() + MainNumber[bx];
                        Plus = 0;
                    }
                }
                Length2--;
            }

            #endregion

            #region Synchronize Numbers to the Right
            //    126  >>> These numbers must be multiplied (ID: 1)
            //x    43  >>> These numbers must be multiplied (ID: 2)
            //---------
            //    378 >>> These numbers need to be added (ID: 3)
            //+  504  >>> These numbers need to be added (ID: 4)
            //----------
            //   5418 >>> Result
            // It starts from a left of ID: 4, 3. I need to equalize right. "0" will be added to ID: 4. If there are more than 2 numbers to be collected, "00" should be added to ID: 5, "000" should be added to ID: 6 
            for (int ax = 1; ax < MainNumber.Length; ax++)
            {
                string Zero = "";
                for (int bx = 0; bx < ax; bx++)
                {
                    Zero += "0";
                }
                MainNumber[ax] += Zero;
            }

            #endregion

            #endregion

            string Result = Addition(MainNumber);

            #region For Numbers Containing (Yes, Again :)
            // For example, our numbers are 20,5 and 12,2.
            // Above, we deleted the comma from these numbers and these numbers happened the (205/10) and (122/10) 
            // And We have multiplied the Shares (so, 205 * 122 = 25010).
            // Now, We must multiply the denominators (10 * 10 = 100)
            // If the denominator result contains how many "0", we should shift the comma to left in Result
            // In our example we have two zeros. Denominator = 100, Numerator = 25010
            //  I will put a comma from the far right of the Result to the left (Result = 250,10)
            if (Denominator1 != "1" || Denominator2 != "1")
            {

                if (Denominator1 != "1" && Denominator2 != "1")
                {
                    int CommaIndex = Denominator1.Length + Denominator2.Length - 2;
                    Result = Result.Substring(0, Result.Length - CommaIndex) + "," + Result.Substring(Result.Length - CommaIndex);
                }
                else if (Denominator1 != "1")
                    Result = Result.Substring(0, Result.Length - Denominator1.Length + 1) + "," + Result.Substring(Result.Length - Denominator1.Length + 1);
                else
                    Result = Result.Substring(0, Result.Length - Denominator2.Length + 1) + "," + Result.Substring(Result.Length - Denominator2.Length + 1);

                while ((Result.EndsWith("0") && Result.Contains(",")) || Result.EndsWith(",")) // if the number after the comma ends with "0", we need to delete it. Because it's unnecessary.
                {
                    Result = Result.Substring(0, Result.Length - 1);
                }
            }

            #endregion

            if (ResultIsNegative)
                return "-" + Result;

            return mySortClassObject.DeleteTheZero(Result);
        }
        public string Division(string Number1, string Number2, bool ReturnOnlyNumbers)
        {
            #region For Short Result

            if (Number2 == "1")
                return Number1;
            if (Number2 == "0")
                return "Undefined";
            if (Number1 == "0")
                return "0";
            if (!ForDeveloper && !NumberIsSoBig)
            {
                double example0, example1;
                if (double.TryParse(Number1, out example0) && double.TryParse(Number2, out example1))
                    return (example0 / example1).ToString();
            }
            if (Checking)
            {
                XtraMessageBox.Show("\tThis process can't do without this algorithm. Because your number is so big.\nError: OverFlow");
                Checking = false;
                return "0";
            }

            #endregion

            #region For Negative Numbers

            bool ResultIsNegative = false;
            if (Number1.StartsWith("-") && Number2.StartsWith("-"))
            {
                Number1 = Number1.Substring(1);
                Number2 = Number2.Substring(1);
            }
            else if (Number1.StartsWith("-"))
            {
                Number1 = Number1.Substring(1);
                ResultIsNegative = true;
            }
            else if (Number2.StartsWith("-"))
            {
                Number2 = Number2.Substring(1);
                ResultIsNegative = true;
            }

            #endregion

            #region For Numbers Containing ","
            bool NumbersContainComma = false;
            string Denominator1 = "1", Denominator2 = "1";
            if (Number1.Contains(","))
            {
                NumbersContainComma = true;
                Number1 = mySortClassObject.DeleteTheZero(Number1);
                // 22,2 => 222 / 10
                int length1 = Number1.Substring(Number1.IndexOf(",") + 1).Length; // after comma
                for (int ax = 0; ax < length1; ax++)
                {
                    Denominator1 += "0";
                }
                Number1 = mySortClassObject.DeleteTheZero(Number1.Replace(",", ""));  // i remove "," and "0"
            }
            if (Number2.Contains(","))
            {
                NumbersContainComma = true;
                Number2 = mySortClassObject.DeleteTheZero(Number2);
                // 22,2 => 222 / 10
                int length2 = Number2.Substring(Number2.IndexOf(",") + 1).Length; // after comma
                for (int ax = 0; ax < length2; ax++)
                {
                    Denominator2 += "0";
                }
                Number2 = mySortClassObject.DeleteTheZero(Number2.Replace(",", "")); ; // i remove "," and "0"
            }

            #endregion

            #region Process Abbreviation

            while (Number1.EndsWith("0") && Number2.EndsWith("0"))
            {
                Number1 = Number1.Substring(0, Number1.Length - 1);
                Number2 = Number2.Substring(0, Number2.Length - 1);
            }
            // After this is for numbers that contain comma
            if (NumbersContainComma)
            {
                #region Abbreviation
                while (Denominator1.EndsWith("0") && Denominator2.EndsWith("0"))
                {
                    Denominator1 = Denominator1.Substring(0, Denominator1.Length - 1);
                    Denominator2 = Denominator2.Substring(0, Denominator2.Length - 1);
                }
                while (Number1.EndsWith("0") && Denominator1.EndsWith("0"))
                {
                    Number1 = Number1.Substring(0, Number1.Length - 1);
                    Denominator1 = Denominator1.Substring(0, Denominator1.Length - 1);
                }
                while (Number2.EndsWith("0") && Denominator2.EndsWith("0"))
                {
                    Number2 = Number2.Substring(0, Number2.Length - 1);
                    Denominator2 = Denominator2.Substring(0, Denominator2.Length - 1);
                }
                #endregion
                Number1 = Multiplication(Number1, Denominator2);
                Number2 = Multiplication(Number2, Denominator1);
                //return Division(data1, data2, true);
            }

            #endregion

            #region Division

            string Data1 = "", RemainingNumber = "", Chapter = "";

            #region Division Part 1

            for (int ax = 0; ax < Number1.Length; ax++)
            {
                Data1 = Number1.Substring(ax, 1);
                if (RemainingNumber != "0" && RemainingNumber != "")
                    Data1 = RemainingNumber + Data1;

                again:
                string[] Numbers = { mySortClassObject.DeleteTheZero(Data1), Number2 };
                if (mySortClassObject.SortByStringLength(Numbers)[0] == Data1) // [0] = small, [1] = the big one
                {
                    if (ax != Number1.Length - 1)
                    {
                        ax++;
                        Data1 += Number1.Substring(ax, 1);
                        if (Chapter.Length > 0)
                            Chapter += "0";
                        goto again;
                    }
                    else
                    {
                        RemainingNumber = Data1 + RemainingNumber;
                    }

                }
                else
                {
                    byte ChapterForNow = 1;
                    Numbers[0] = Subtraction(Data1, Number2);
                    while (mySortClassObject.SortByStringLength(Numbers)[1] == Numbers[0]) // the big one
                    {
                        ChapterForNow++;
                        Numbers[0] = Subtraction(Data1, Multiplication(Number2, ChapterForNow.ToString()));
                    }
                    Chapter += ChapterForNow.ToString();

                    RemainingNumber = Numbers[0];
                }


            }

            #endregion

            #region Division Part 2

            if (RemainingNumber != "0") // if RemainingNumber isn't be "0", i should carry on. In this way, i can find Result Numbers Containing ","
            {
                if (Chapter.Length == 0)
                    Chapter = "0";
                Chapter += ",";
                // Some of the division operations are in a cyclic.
                // The section (our answer) can be an infinite repetition.
                // For Example; 0,756756756756... The number "756" repeat forever.
                // With my algorithm, I find the cyclic number and i show it only once.

                List<string> OldRemainingNumbers = new List<string>();
                while (RemainingNumber != "0")
                {

                    RemainingNumber += "0";
                    string[] Numbers = { RemainingNumber, Number2 };
                    while (mySortClassObject.SortByStringLength(Numbers)[0] == RemainingNumber && RemainingNumber != Numbers[1])
                    {
                        RemainingNumber += "0";
                        Chapter += "0";
                        Numbers[0] = RemainingNumber;
                    }

                    if (OldRemainingNumbers.Contains(RemainingNumber))
                    {// If it is found in any of the previous numbers, the remaining number is cyclic.
                        if (!ReturnOnlyNumbers)
                            Chapter += "...";
                        break;
                    }
                    OldRemainingNumbers.Add(RemainingNumber);

                    byte ChapterForNow = 1;
                    Numbers[0] = Subtraction(RemainingNumber, Number2); // BURAYA BAK

                    while (mySortClassObject.SortByStringLength(Numbers)[1] == Numbers[0]) // the big one
                    {
                        ChapterForNow++;
                        Numbers[0] = Subtraction(RemainingNumber, Multiplication(Number2, ChapterForNow.ToString()));
                    }
                    Chapter += ChapterForNow.ToString();

                    RemainingNumber = Numbers[0];

                }


            }

            #endregion

            #endregion

            if (ResultIsNegative)
                return "-" + Chapter;
            return Chapter;
        }
        public string AdditionForUser(string[] DataToBeCollected)
        {
            #region For Short Result

            if (!ForDeveloper && !NumberIsSoBig)
            {
                double example0, FinallyResult = 0;
                bool ThisCanBe = true;
                foreach (string sx in DataToBeCollected)
                {
                    if (double.TryParse(sx, out example0))
                    {
                        if (double.MaxValue - example0 >= FinallyResult) // when i added "example0" and "FinallyResult", Result may be Greater than Max Value of Double. Therefore i put this query.
                            FinallyResult += example0;
                        else
                        {
                            ThisCanBe = false;
                            break;
                        }
                    }
                    else
                    {
                        ThisCanBe = false;
                        break;
                    }

                }
                if (ThisCanBe)
                {
                    return FinallyResult.ToString();
                }
                if (Checking)
                {
                    XtraMessageBox.Show("\tThis process can't do without this algorithm. Because your number is so big.\nError: OverFlow");
                    Checking = false;
                    return "0";
                }

            }
            if (NumberIsSoBig && Checking)
            { // if this user checked result of my algorithm. And this result can't be learned without this algorithm. I show you
                XtraMessageBox.Show("\tThis process can't do without this algorithm. Because your number is so big.\nError: OverFlow");
                return "0";
            }
            #endregion

            #region For Numbers Containing ","
            int MaxLengthOfDenominator = 0;
            bool HaveComma = false;
            string[] DenominatorNumbers = new string[DataToBeCollected.Length];
            for (int ax = 0; ax < DataToBeCollected.Length; ax++)
            {
                if (DataToBeCollected[ax].Contains(","))
                {
                    // 22,2 => 222 / 10
                    // for caracter length that after comma is "1", Denominator of this number is "10" 
                    // if caracter length that after comma were being "2", Denominator of this number was being "100"
                    HaveComma = true;
                    string Denominator = "1";
                    int length = DataToBeCollected[ax].Substring(DataToBeCollected[ax].IndexOf(",") + 1).Length; // After comma (",")
                    for (int bx = 0; bx < length; bx++)
                    {
                        Denominator += "0";
                    }
                    DenominatorNumbers[ax] = Denominator;
                    DataToBeCollected[ax] = DataToBeCollected[ax].Replace(",", ""); // i remove ",". 22,2 => 222 / 10
                }
                else
                    DenominatorNumbers[ax] = "1"; // 22 => 22 / 1
            }
            if (HaveComma) 
            {
                MaxLengthOfDenominator = mySortClassObject.SortByStringLength(DenominatorNumbers)[DenominatorNumbers.Length - 1].Length;
                for (int ax = 0; ax < DenominatorNumbers.Length; ax++)
                {
                    // For Example: 2,2 + 3,45 => (22 / 10) + (345 / 100) 
                    // => (22 * 10 / 10 * 10) + (345 / 100)
                    // => (220 / 100) + (345 / 100) 
                    // => (220 + 345) / 100 = Result
                    if (DenominatorNumbers[ax].Length != MaxLengthOfDenominator) 
                    {
                        string Denominator = "1";
                        int ZeroCount = MaxLengthOfDenominator - DenominatorNumbers[ax].Length;
                        for (int bx = 0; bx < ZeroCount; bx++)
                        {
                            Denominator += "0";
                        }
                        DataToBeCollected[ax] = Multiplication(DataToBeCollected[ax], Denominator);
                    }
                }
            }
            #endregion

            string Result = Addition(DataToBeCollected);

            #region For Numbers Containing "," (end)
            
            if (MaxLengthOfDenominator > 0) // if numbers contain comma
            {
                // For Example;
                // (220 / 100) + (345 / 100) 
                // => (220 + 345) / 100 So,
                // => Result / 100 = True Result
                // i should divison Result and 100 in this example
                string Denominator = "1";
                for (int ax = 1; ax < MaxLengthOfDenominator; ax++)
                {
                    Denominator += "0";
                }

                return Division(Result, Denominator, false); 
            }
            return Result;
            #endregion
        }
        string Addition(string[] DataToBeCollected)
        {// this function is used only by Multiplication
            #region Delete "-"
            // sometimes, DataToBeCollected Array can contain "-".
            // But this function can just add. If we want to subtract, we can use subtraction function.
            for (int ax = 0; ax < DataToBeCollected.Length; ax++)
            {
                DataToBeCollected[ax] = DataToBeCollected[ax].Replace("-", "");
            }
            #endregion

            #region Sorting
            // I must put the largest number at the top of the list for my algorithm
            // i could convert the list to "decimal" and learn the largest number BUT
            // When I convert to "decimal", the number shown is reduced by adding "+" or "E" signs in long numbers.
            // Also, this algorithm should work with "string". If "Decimal" is overflowed, it cannot be translated. But "string" does not overflow, because it is infinite.
            // Only, the following "SortByStringLength" code was taken as reference by AllTech (https://www.youtube.com/channel/UCBGENnRMZ3chHn_9gkcrFuA). Thanks AllTech
            DataToBeCollected = mySortClassObject.SortByStringLength(DataToBeCollected); // this process sorts from small to large
            // Therefore I'll reverse this list. In this way, it will be sorted from big to small.
            Array.Reverse(DataToBeCollected);
            #endregion

            #region Addition The Numbers
            // For example this numbers will be added;
            //  345700
            //   69140
            //+  20742
            //----------
            //  435582
            // I will add the numbers on the far right and then add the numbers on the left one in turn.

            int LengthOfMaxNumber = DataToBeCollected[0].Length; // we sorted from big to small. Maximum Number = 0 index
            byte[,] Numbers = new byte[DataToBeCollected.Length, LengthOfMaxNumber]; // I am saving the numbers of all the numbers to be added.
            // it will loop by the length of the largest number and add up the numbers
            for (int ax = 0; ax < DataToBeCollected.Length; ax++) // With this loop I save the numbers of all the numbers to be summed.
            {
                int NumberOfEntries = DataToBeCollected[ax].Length;

                for (int NumberToCut = 1; NumberToCut <= NumberOfEntries; NumberToCut++)
                {
                    Numbers[ax, DataToBeCollected[ax].Length - NumberToCut] = Convert.ToByte(DataToBeCollected[ax].Substring(DataToBeCollected[ax].Length - NumberToCut, 1));
                }
            }

            string Result = ""; // I will record the result of the addition
            byte MyNumber = 0; // I will save the result of the sum of 2 digits
            byte Plus2 = 0; // If the sum of 2 digits is greater than 10, i will save the digit.
            for (int NumberToCut = 1; NumberToCut <= LengthOfMaxNumber; NumberToCut++)
            {

                for (int ax = 0; ax < DataToBeCollected.Length; ax++) // with this loop, I add the digits of all the numbers to be summed.
                {
                    // for example; 
                    //  1|2|3 -> (123)
                    //+  |4|5 ->  (45)
                    //-------------
                    // I'm adding 5 and 3 (5 + 3 = 8). In other words, I add the numbers in the determined step with this cycle.     
                    if (NumberToCut > DataToBeCollected[ax].Length) // for example, the small number (45) does not have a hundred digits. If not, i finish the collection. The next number is no longer than this number because the sort is from big to small.
                        break;
                    MyNumber += Numbers[ax, DataToBeCollected[ax].Length - NumberToCut];
                }
                MyNumber += Plus2;

                if (MyNumber >= 10) // If the collected figures are greater than 10, there will be an event.
                {
                    if (NumberToCut == LengthOfMaxNumber) // if the leftmost digit of the largest number is reached, the result is written
                    {
                        Result = MyNumber + Result;
                    }
                    else
                    {
                        Plus2 = Convert.ToByte(MyNumber.ToString().Substring(0, 1));
                        Result = MyNumber.ToString().Substring(1) + Result;
                    }

                }
                else
                {
                    Result = MyNumber + Result;
                    Plus2 = 0;
                }
                MyNumber = 0; // i reset for next addition
            }


            #endregion

            return Result;
        }

        public string Subtraction(string Number1, string Number2)
        {// Result = Number1 - Number2

            #region For Short Result
            // if this process can't be made with easy, i am going to make with "String"
            if (Number1 == Number2)
                return "0";
            if (mySortClassObject.NumberIsZero(Number1))
                return "-" + Number2;
            if (mySortClassObject.NumberIsZero(Number2))
                return Number1;
            if (!ForDeveloper && !NumberIsSoBig)
            {
                double example0, example1;
                if (double.TryParse(Number1, out example0) && double.TryParse(Number2, out example1))
                    return (example0 - example1).ToString();
            }
            if (Checking)
            {
                XtraMessageBox.Show("\tThis process can't do without this algorithm. Because your number is so big.\nError: OverFlow");
                Checking = false;
                return "0";
            }

            #endregion

            #region For Numbers Containing ","
            int MaxLengthOfDenominator = 0;
            string DenominatorNumber0 = "1", DenominatorNumber1 = "1"; // number count is 2 => Number1 and Number2
            if (Number1.Contains(",")) // for example, if Number1 is 22,2 (decimal) so, if it is not integer
            {
                // 22,2 => 222 / 10 
                // for caracter length that after comma is "1", Denominator of this number is "10" 
                // if caracter length that after comma were being "2", Denominator of this number was being "100"
                string Denominator = "1";
                int length = Number1.Substring(Number1.IndexOf(",") + 1).Length; // caracter that After comma (",")
                for (int bx = 0; bx < length; bx++)
                {
                    Denominator += "0";
                }
                DenominatorNumber0 = Denominator;
                Number1 = Number1.Replace(",", ""); // i remove ",".  22,2 => 222 / 10
            }
            if (Number2.Contains(","))
            {
                // 22,2 => 222 / 10
                string Denominator = "1";
                int length = Number2.Substring(Number2.IndexOf(",") + 1).Length; // After comma (",")
                for (int bx = 0; bx < length; bx++)
                {
                    Denominator += "0";
                }
                DenominatorNumber1 = Denominator;
                Number2 = Number2.Replace(",", ""); // i remove ",". 22,2 => 222 / 10
            }

            if (DenominatorNumber0 != "1" || DenominatorNumber1 != "1") // if Denominator numbers is not be "1", comma is there. So we do process numbers with comma
            {
                if (DenominatorNumber0.Length > DenominatorNumber1.Length)
                    MaxLengthOfDenominator = DenominatorNumber0.Length;
                else if (DenominatorNumber1.Length > DenominatorNumber0.Length)
                    MaxLengthOfDenominator = DenominatorNumber1.Length;
                else // 2 numbers is equal. Therefore it does not matter
                    MaxLengthOfDenominator = DenominatorNumber0.Length;
                if (DenominatorNumber0.Length != MaxLengthOfDenominator)
                {
                    string Denominator = "1";
                    int ZeroCount = MaxLengthOfDenominator - DenominatorNumber0.Length;
                    for (int bx = 0; bx < ZeroCount; bx++)
                    {
                        Denominator += "0";
                    }
                    Number1 = Multiplication(Number1, Denominator);
                }
                if (DenominatorNumber1.Length != MaxLengthOfDenominator)
                {
                    string Denominator = "1";
                    int ZeroCount = MaxLengthOfDenominator - DenominatorNumber1.Length;
                    for (int bx = 0; bx < ZeroCount; bx++)
                    {
                        Denominator += "0";
                    }
                    Number2 = Multiplication(Number2, Denominator);
                }
            }

            #endregion

            #region Sorting
            bool ResultIsNegative = false;
            // Number1 should be the biggest one for my algorithm
            if (Number2.Replace("-", "").Replace(",", "").Length > Number1.Replace("-", "").Replace(",", "").Length)
            {
                string Next = Number1;
                Number1 = Number2;
                Number2 = Next;
                ResultIsNegative = true;
                // 3 - 4 = -(4 - 3)
            }
            else if (Number2.Length == Number1.Length)
            {
                if (Number1.Contains(",") || Number2.Contains(","))
                {
                    int index1 = Number1.IndexOf(","), index2 = Number2.IndexOf(",");
                    if ((index2 > index1 && index1 != -1) || (index2 == -1 && index1 != -1)) // number2 is big
                    {
                        string Next = Number1;
                        Number1 = Number2;
                        Number2 = Next;
                        ResultIsNegative = true;
                    }
                    else if (index1 == index2)// equal
                    {
                        string[] numberss = { Number1.Replace(",", "").Replace("-", ""), Number2.Replace(",", "").Replace("-", "") };
                        if (mySortClassObject.SortByStringLength(numberss)[1] == Number2.Replace(",", "").Replace("-", "")) // if number2 is big
                        {
                            string Next = Number1;
                            Number1 = Number2;
                            Number2 = Next;
                            ResultIsNegative = true;
                        }
                    }
                    
                }
                else
                {
                    string[] numberss = { Number1.Replace("-", ""), Number2.Replace("-", "") };
                    if (mySortClassObject.SortByStringLength(numberss)[1] == Number2.Replace("-", "")) // if number2 is big
                    {
                        string Next = Number1;
                        Number1 = Number2;
                        Number2 = Next;
                        ResultIsNegative = true;
                    }
                }
               
            }

            #endregion

            #region Negative Numbers Control

            if (Number2.StartsWith("-") && Number1.StartsWith("-"))
            {
                // for example; -3 - (-2) = -3 + 2
                Number1 = Number1.Substring(1);
                ResultIsNegative = true; // -3 + 2 = -(3 - 2), therefore i will put "-" in the end like that;
                // 3 - 2 = 1 ---> -1
            }
            else if (Number1.StartsWith("-"))
            {
                // for example; -3 - 2 = -(3 + 2) so, i add 3 and 2. Then i will put "-" to result
                string[] Numbers = { Number1, Number2 };
                return "-" + Addition(Numbers);
            }
            else if (Number2.StartsWith("-"))
            {
                // for example; 3 - (-2) => 3 + 2 
                string[] Numbers = { Number1, Number2 };
                return Addition(Numbers);
            }

            #endregion

            // string Result = Addition(DataToBeCollected);
            #region Subtraction Process

            //  987654321 (43211)
            //- 123456789
            //------------- 
            //      97532
            string Result = "";
            sbyte Data;
            for (int ax = 1; ax <= Number1.Length; ax++)
            {
                if (Number2.Length >= ax)
                {
                    // 44500000
                    // 10000008
                    //-_________
                    //        2

                    Data = Convert.ToSByte(Convert.ToByte(Number1.Substring(Number1.Length - ax, 1)) - Convert.ToByte(Number2.Substring(Number2.Length - ax, 1)));
                    if (Data < 0)
                    {
                        Data += 10;
                        Result = Data.ToString() + Result;
                        int NewNumber = ax + 1;
                        while (Number1.Substring(Number1.Length - NewNumber, 1) == "0")
                        {
                            NewNumber++;
                        }
                        //  987654311 (43211)
                        //- 123456789
                        //------------- 
                        //      97532

                        // 44500000
                        // 10000008
                        //-_________
                        //        
                        string NewData = Number1.Substring(0, Number1.Length - NewNumber) + Convert.ToByte(Convert.ToByte(Number1.Substring(Number1.Length - NewNumber, 1)) - 1).ToString();
                        if (NewNumber > ax + 1)
                        {
                            // i should change "0" to "9". For example;
                            //1000 > 100(0) - (2) > 099(10) - (2) > 0998 
                            //   2
                            //-____
                            //0998 , in this example, i changed "ten digits" and "hundered digits". 
                            int ZeroCount = (NewNumber - ax - 1);
                            for (int cx = 0; cx < ZeroCount; cx++)
                            {
                                NewData += "9";
                            }
                            NewData += Number1.Substring(Number1.Length - NewNumber + 1 + ZeroCount);

                        }
                        else
                            NewData += Number1.Substring(Number1.Length - NewNumber + 1);
                        Number1 = NewData;
                    }
                    else
                    {
                        Result = Data.ToString() + Result;
                    }
                }
                else
                {
                    Result = Number1.Substring(Number1.Length - ax, 1) + Result;
                }
            }
            #endregion

            // Result may be "0052" or "024" and such like ...
            // So, in left of result, it may contains "0" 
            // therefore i should delete in left of result
            string FinalResult = mySortClassObject.DeleteTheZero(Result); // 55 / 10 > -55 / 10
            if (ResultIsNegative)
                FinalResult = "-" + FinalResult;

            #region For Numbers Containing "," (end)

            if (MaxLengthOfDenominator > 0) // if number1 or number2 contain comma
            {
                // For Example;
                // (345 / 100) - (220 / 100) 
                // => (345 - 220) / 100 So,
                // => Result / 100 = True Result
                // i should divison Result and 100 in this example
                string Denominator = "1";
                for (int ax = 1; ax < MaxLengthOfDenominator; ax++)
                {
                    Denominator += "0";
                }

                return Division(FinalResult, Denominator, false);
            }
            #endregion
            return FinalResult;  


        }
        public string LearnFactorial(string textdata)
        {
            #region Learn Factorial
            NumberIsSoBig = false;
            string Result = "1";
            double DataThatWasTaken;
            if (textdata == "1" || textdata == "0")
            {
                return "1";
            }
            else if (!double.TryParse(textdata, out DataThatWasTaken))
            {
               
                // if data that was taken is number but it is bigger than "Double.MaxValue", i still have to learn result of this number factorial
                if (Checking)
                {
                    XtraMessageBox.Show("\tThis process can't do without this algorithm. Because your number is so big.\nError: OverFlow");
                    Checking = false;
                    return "0";
                }
                double ThisClosestNumber = 1D;
                NumberIsSoBig = true;
                // if data that was taken is bigger than "Double.MaxValue", 
                // I will do like that (with use my string functions);
                // for example my data is 15, i use loop;
                // (15 - 1) * (15 - 2) * (15 - 3) * ... * (15 - 13) = IT'S MY RESULT
                for (string data = Subtraction(textdata, "1"); data != "1"; data = Subtraction(data, "1"))
                {
                    ClosestNumber = ThisClosestNumber;
                    Result = Multiplication(data, Result);
                    ThisClosestNumber++;
                }
                // and this loop finished, i should multiplication RESULT and 15 like that;
                // 15 * RESULT
                return Multiplication(textdata, Result);

            }
            else
            {
                if (DataThatWasTaken < 171 && !ForDeveloper) // "171 factorial" result number is infinity for "Double".
                {
                    double Result_Double = 1D;
                    for (double ax = 2; ax <= DataThatWasTaken; ax++)
                    {
                        Result_Double *= ax;
                    }
                    Result = Result_Double.ToString();
                  
                }
                else 
                {
                    if (Checking)
                    {
                        XtraMessageBox.Show("\tThis process can't do without this algorithm. Because your number is so big.\nError: OverFlow");
                        Checking = false;
                        return "0";
                    }
                    NumberIsSoBig = true;
                    for (double ax = 2; ax <= DataThatWasTaken; ax++)
                    {
                        Result = Multiplication(ax.ToString(), Result);
                        ClosestNumber = ax;
                    }
                }
        
                return Result; 
            }

            #endregion
        }

    }

}
