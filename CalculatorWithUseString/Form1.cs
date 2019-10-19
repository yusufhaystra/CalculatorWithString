using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CalculatorWithUseString;
using System.Threading;
using System.Threading.Tasks;

namespace CalculatorWithUseString
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        Keys[] AllKeys = { Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9, Keys.Oemcomma, Keys.Divide, Keys.Multiply, Keys.Subtract, Keys.Add, Keys.Enter, Keys.Back, Keys.Delete , Keys.NumPad0, Keys.NumPad1, Keys.NumPad2, Keys.NumPad3, Keys.NumPad4, Keys.NumPad5, Keys.NumPad6, Keys.NumPad7, Keys.NumPad8, Keys.NumPad9 , Keys.Enter};
        public static string Result1 = "1";
        
        public static bool ProcessHasFinished = true;
        public Stopwatch stopwatch = new Stopwatch();

        string LastProcess, LastFactorialNumber = "1";
        char LastProcessType;
        LearnResult myLearnResultObject = new LearnResult();
        Sort mySortObject = new Sort();
        Thread thread = null;
        char GetOperation()
        {
            #region Get Operation

            char[] Operations = { '+', '-', 'x', '/', '!' }; // easy process
            int index = 1;
            foreach (char sx in Operations)
            {
                index = lb_process.Text.IndexOf(sx);
                if (index != -1)
                {
                    return sx;
                }
            }
            return 'I'; // Incorrect

            #endregion
        }
        void LetsDoThis(char ProcessType, string ProcessDetail, string FactorialNumber)
        {
            #region I do the Process
            LastProcess = lb_process.Text; // after learn result with my algorithm, i save these because user maybe want to check result
            LastProcessType = ProcessType;

            myLearnResultObject.Operation = ProcessType;
            myLearnResultObject.FactorialNumber = FactorialNumber;
            myLearnResultObject.Process = ProcessDetail;
            Result1 = "1";
            ProcessHasFinished = false;
            lb_info.Text = "Processing...";
            bt_stop.Visible = true;

            thread = new Thread(new ThreadStart(myLearnResultObject.GetResult));
            thread.Priority = ThreadPriority.AboveNormal;
            thread.Start();

            #endregion

            #region i wait the Process
            Task.Run(() =>
            {
            stopwatch.Reset();
            stopwatch.Start();
                while (!ProcessHasFinished && thread != null) // i wait for finish the process. While i was waiting, i show report.
                {
                    lb_ClosestNumber.Text = Calculator.ClosestNumber.ToString();
                    lb_ElapsedTime.Text = stopwatch.Elapsed.Hours + ":" + stopwatch.Elapsed.Minutes + ":" + stopwatch.Elapsed.Seconds;
                    double sayi = (100 * Calculator.ClosestNumber / Convert.ToDouble(FactorialNumber));
                    lb_Progress.Text = "%" + sayi.ToString();
                    Task.Delay(100).Wait();
                }
                bt_stop.Visible = false;
                stopwatch.Stop();
                if (thread == null) // if user stopped it (it could not finish)
                {
                    lb_info.Text = "Stopped!";
                    lb_process.Text = "0";
                    lb_result.Text = "0";
                }
                else // if it finished with successfully
                {
                    thread = null;
                    lb_ClosestNumber.Text = lb_result.Text;
                    lb_result.Text = Result1;
                    lb_Progress.Text = "%100";
                    lb_info.Text = "Finished!";
                 //   bt_checkresult.Visible = true;
                }
    
            });
            #endregion
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }
        #region If user want to Copy the Result

        private void lb_result_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Clipboard.SetText(lb_result.Text);
                DevExpress.XtraEditors.XtraMessageBox.Show("\tRESULT WAS COPIED !\nResut Length = " + lb_result.Text.Length + "\nAll Result:\n" + lb_result.Text, "Info | Successful");
            }
        }

        #endregion
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Calculator.ForDeveloper = true;
                bt_checkresult.Visible = true;
            }
            else
            {
                Calculator.ForDeveloper = false;
                bt_checkresult.Visible = false;
            }
           
        }

        #region Calculator Buttons

        private void bt_1_Click(object sender, EventArgs e)
        {
            if (lb_result.Text == "0")
                lb_result.Text = "";
            lb_result.Text += "1";
            lb_result.Focus();
        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            if (lb_result.Text == "0")
                lb_result.Text = "";
            lb_result.Text += "2";
            lb_result.Focus();
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            if (lb_result.Text == "0")
                lb_result.Text = "";
            lb_result.Text += "3";
            lb_result.Focus();
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            if (lb_result.Text == "0")
                lb_result.Text = "";
            lb_result.Text += "4";
            lb_result.Focus();
        }

        private void bt_5_Click(object sender, EventArgs e)
        {
            if (lb_result.Text == "0")
                lb_result.Text = "";
            lb_result.Text += "5";
            lb_result.Focus();
        }

        private void bt_6_Click(object sender, EventArgs e)
        {
            if (lb_result.Text == "0")
                lb_result.Text = "";
            lb_result.Text += "6";
            lb_result.Focus();
        }

        private void bt_7_Click(object sender, EventArgs e)
        {
            if (lb_result.Text == "0")
                lb_result.Text = "";
            lb_result.Text += "7";
            lb_result.Focus();
        }

        private void bt_8_Click(object sender, EventArgs e)
        {
            if (lb_result.Text == "0")
                lb_result.Text = "";
            lb_result.Text += "8";
            lb_result.Focus();
        }

        private void bt_9_Click(object sender, EventArgs e)
        {
            if (lb_result.Text == "0")
                lb_result.Text = "";
            lb_result.Text += "9";
            lb_result.Focus();
        }

        private void bt_0_Click(object sender, EventArgs e)
        {
            if (lb_result.Text == "0")
                lb_result.Text = "";
            lb_result.Text += "0";
            lb_result.Focus();
        }

        private void bt_comma_Click(object sender, EventArgs e)
        {
            if (!lb_result.Text.Contains(","))
                lb_result.Text += ",";
            lb_result.Focus();
        }
        #endregion
        private void bt_addition_Click(object sender, EventArgs e)
        {
            char OperationName = GetOperation();
            if (!mySortObject.NumberIsZero(lb_result.Text) && (OperationName == 'I' || OperationName == '+'))
            {
                if (lb_process.Text == "0")
                    lb_process.Text = "";
                lb_process.Text += lb_result.Text + " + ";
                lb_result.Text = "0";
            }
            lb_result.Focus();

        }

        private void bt_result_Click(object sender, EventArgs e)
        {
            char OperationName = GetOperation();
            if (OperationName != 'I' && !mySortObject.NumberIsZero(lb_result.Text) && thread == null)
            {
                lb_process.Text += lb_result.Text;
                LetsDoThis(OperationName, lb_process.Text, lb_result.Text);
            }
            lb_result.Focus();
        }

        private void bt_subtraction_Click(object sender, EventArgs e)
        {
            char OperationName = GetOperation();
            if (!mySortObject.NumberIsZero(lb_result.Text) && (OperationName == 'I' || OperationName == '-'))
            {
                if (lb_process.Text == "0")
                    lb_process.Text = "";
                lb_process.Text += lb_result.Text + " - ";
                lb_result.Text = "0";
            }
            lb_result.Focus();
        }

        private void bt_multiplication_Click(object sender, EventArgs e)
        {
            char OperationName = GetOperation();
            if (!mySortObject.NumberIsZero(lb_result.Text) && (OperationName == 'I' || OperationName == 'x'))
            {
                if (lb_process.Text == "0")
                    lb_process.Text = "";
                lb_process.Text += lb_result.Text + " x ";
                lb_result.Text = "0";
            }
            lb_result.Focus();
        }

        private void bt_division_Click(object sender, EventArgs e)
        {
            char OperationName = GetOperation();
            if (!mySortObject.NumberIsZero(lb_result.Text) && (OperationName == 'I' || OperationName == '/'))
            {
                if (lb_process.Text == "0")
                    lb_process.Text = "";
                lb_process.Text += lb_result.Text + " / ";
                lb_result.Text = "0";
                
            }
            lb_result.Focus();
        }

        private void bt_factorization_Click(object sender, EventArgs e)
        {
            char OperationName = GetOperation();
            if (OperationName == 'I' && !mySortObject.NumberIsZero(lb_result.Text))
            {
                LastFactorialNumber = lb_result.Text;
                lb_process.Text = lb_result.Text + "!";
                LetsDoThis('!', lb_process.Text, lb_result.Text);
            }
            lb_result.Focus();
        }

        private void lb_result_TextChanged(object sender, EventArgs e)
        {
            if (lb_result.Text.Length >= 10 && lb_result.Text.Length < 13)
                lb_result.Font = new Font("Tahoma", 40, FontStyle.Regular);
            else if (lb_result.Text.Length < 10)
                lb_result.Font = new Font("Tahoma", 50, FontStyle.Regular);
            else if (lb_result.Text.Length >= 13 && lb_result.Text.Length < 19)
                lb_result.Font = new Font("Tahoma", 30, FontStyle.Regular);
            else if (lb_result.Text.Length >= 19 && lb_result.Text.Length < 111)
                lb_result.Font = new Font("Tahoma", 15, FontStyle.Regular);
            else if (lb_result.Text.Length >= 111)
            {
                lb_result.Font = new Font("Tahoma", 8, FontStyle.Regular);
                if (lb_result.Text.Length > 336)
                    DevExpress.XtraEditors.XtraMessageBox.Show("Result is so big. We can show 336 numbers of the result. But if you click right mouse button, you can see all the result and copy.", "Info | Information");
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            #region I print with use button
            if (AllKeys.Contains(e.KeyCode))
            {
                foreach (Keys a in AllKeys)
                {
                    if (a == e.KeyCode)
                    {
                        if (a == Keys.D1 && (e.Alt || e.Control || e.Shift))
                        {// factorial
                            bt_factorization_Click(this, null);
                        }
                        else
                        {
                            if (a.ToString().StartsWith("NumPad") || (a.ToString().StartsWith("D") && a.ToString().Length < 3))
                            {
                                string data = a.ToString().Replace("NumPad", "").Replace("D", "");
                                if (lb_result.Text == "0")
                                    lb_result.Text = "";
                                lb_result.Text += data;
                            }
                            else
                            {
                                #region If user push the Operation Button
                                switch (a)
                                {
                                    case (Keys.Add):
                                        { // BURAYA BAK
                                            bt_addition_Click(this, null);
                                            break;
                                        }
                                    case (Keys.Multiply):
                                        {
                                            bt_multiplication_Click(this, null);
                                            break;
                                        }
                                    case (Keys.Subtract):
                                        {
                                            bt_subtraction_Click(this, null);
                                            break;
                                        }
                                    case (Keys.Divide):
                                        {
                                            bt_division_Click(this, null);
                                            break;
                                        }
                                    case (Keys.Delete):
                                        {
                                            if (thread != null) // if it continues, i will stop it.
                                            {
                                                thread.Abort();
                                                thread = null;
                                            }
                                            lb_ClosestNumber.Text = "0";
                                            lb_ElapsedTime.Text = "00:00:00";
                                            lb_Progress.Text = "%0";
                                            lb_process.Text = "0";
                                            lb_result.Text = "0";
                                            break;
                                        }
                                    case (Keys.Back):
                                        {
                                            bt_back_Click(this, null);
                                            break;
                                        }
                                    case (Keys.Enter):
                                        {
                                            bt_result_Click(this, null);
                                            break;
                                        }
                                    case (Keys.Oemcomma):
                                        {
                                            bt_comma_Click(this, null);
                                            break;
                                        }
                                }
                                #endregion
                            }

                        }
                        break;
                    }
                }
            }
            #endregion
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            #region If user push to Back button

            if (lb_result.Text.Length > 1)
            {
                lb_result.Text = lb_result.Text.Substring(0, lb_result.Text.Length - 1);
                
                byte example0;
                 if (byte.TryParse(lb_process.Text.Substring(lb_process.Text.Length - 1), out example0) && lb_process.Text.Length > 1)
                    lb_process.Text = lb_process.Text.Substring(0, lb_process.Text.Length - 1);
            }
            else
            {
                lb_result.Text = "0";
                if (GetOperation() == 'I')
                    lb_process.Text = "0";
                else
                {
                    byte example0;
                    if (byte.TryParse(lb_process.Text.Substring(lb_process.Text.Length - 1), out example0))
                        lb_process.Text = lb_process.Text.Substring(0, lb_process.Text.Length - 1);

                }
            }

            #endregion
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            while (lb_result.Width < TextRenderer.MeasureText(lb_result.Text,
     new Font(lb_result.Font.FontFamily, lb_result.Font.Size, lb_result.Font.Style)).Width)
            {
                lb_result.Font = new Font(lb_result.Font.FontFamily, lb_result.Font.Size - 0.5f, lb_result.Font.Style);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thread != null) // if it continues, i will stop it.
            {
                thread.Abort();
                thread = null;
                Thread.Sleep(100); // i wait for task to finish, after task, i can close
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lb_result.Text.Length.ToString());
        }

        private void Bt_stop_Click(object sender, EventArgs e)
        {
            if (thread != null) // if it continues, i will stop it.
            {
                thread.Abort();
                thread = null;
            }
        }

        private void Bt_checkresult_Click(object sender, EventArgs e)
        {
            #region I'm checking the result

            if (lb_info.Text == "Finished!" && thread == null) // if any process was finished by user, i can check the result.
            {
                Calculator.Checking = true;
                Calculator.ForDeveloper = false;
                string ResultOfMyAlgorithm = lb_result.Text;
                LetsDoThis(LastProcessType, LastProcess, LastFactorialNumber);
                while (!ProcessHasFinished) ;
                if (Calculator.Checking) // if process was finished succesfully 
                {
                    if (lb_result.Text == ResultOfMyAlgorithm)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("\tResult Is Correct!\nAlgorithm Result: " + ResultOfMyAlgorithm + "\nCorrectResult: " + lb_result.Text);
                    }
                    else
                    {
                        Process.Start("https://www.linkedin.com/in/yusuf-%C5%9Fahin-563567a5/");
                        Thread.Sleep(250);
                        DevExpress.XtraEditors.XtraMessageBox.Show("\tResult Is Not Correct!\nPlease help us update with contact\nAlgorithm Result: " + ResultOfMyAlgorithm + "\nCorrectResult: " + lb_result.Text);
                    }
                }
                
                
                Calculator.Checking = false;
                Calculator.ForDeveloper = true;
            }

            #endregion

            lb_result.Focus();
        }
    }
}
