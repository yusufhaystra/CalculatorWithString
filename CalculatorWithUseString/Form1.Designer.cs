namespace CalculatorWithUseString
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.bt_1 = new System.Windows.Forms.Button();
            this.bt_3 = new System.Windows.Forms.Button();
            this.bt_2 = new System.Windows.Forms.Button();
            this.bt_5 = new System.Windows.Forms.Button();
            this.bt_6 = new System.Windows.Forms.Button();
            this.bt_4 = new System.Windows.Forms.Button();
            this.bt_0 = new System.Windows.Forms.Button();
            this.bt_result = new System.Windows.Forms.Button();
            this.bt_comma = new System.Windows.Forms.Button();
            this.bt_8 = new System.Windows.Forms.Button();
            this.bt_9 = new System.Windows.Forms.Button();
            this.bt_7 = new System.Windows.Forms.Button();
            this.bt_addition = new System.Windows.Forms.Button();
            this.bt_subtraction = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_division = new System.Windows.Forms.Button();
            this.bt_multiplication = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_back = new System.Windows.Forms.Button();
            this.bt_factorization = new System.Windows.Forms.Button();
            this.lb_result = new System.Windows.Forms.Label();
            this.lb_IClosestNumber = new System.Windows.Forms.Label();
            this.lb_IElapsedTime = new System.Windows.Forms.Label();
            this.lb_ElapsedTime = new System.Windows.Forms.Label();
            this.lb_Progress = new System.Windows.Forms.Label();
            this.lb_IProgress = new System.Windows.Forms.Label();
            this.lb_ClosestNumber = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_info = new System.Windows.Forms.Label();
            this.bt_stop = new System.Windows.Forms.Button();
            this.lb_process = new System.Windows.Forms.Label();
            this.bt_checkresult = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(305, 2);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(178, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.Text = "Only Use String (For Developer)";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(2, 2);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(198, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Use as Fast as Possible (Suggested)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // bt_1
            // 
            this.bt_1.FlatAppearance.BorderSize = 0;
            this.bt_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.bt_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_1.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_1.ForeColor = System.Drawing.Color.Black;
            this.bt_1.Location = new System.Drawing.Point(32, 298);
            this.bt_1.Name = "bt_1";
            this.bt_1.Size = new System.Drawing.Size(132, 78);
            this.bt_1.TabIndex = 5;
            this.bt_1.TabStop = false;
            this.bt_1.Text = "1";
            this.bt_1.UseVisualStyleBackColor = true;
            this.bt_1.Click += new System.EventHandler(this.bt_1_Click);
            // 
            // bt_3
            // 
            this.bt_3.FlatAppearance.BorderSize = 0;
            this.bt_3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.bt_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_3.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_3.ForeColor = System.Drawing.Color.Black;
            this.bt_3.Location = new System.Drawing.Point(296, 298);
            this.bt_3.Name = "bt_3";
            this.bt_3.Size = new System.Drawing.Size(132, 78);
            this.bt_3.TabIndex = 6;
            this.bt_3.TabStop = false;
            this.bt_3.Text = "3";
            this.bt_3.UseVisualStyleBackColor = true;
            this.bt_3.Click += new System.EventHandler(this.bt_3_Click);
            // 
            // bt_2
            // 
            this.bt_2.FlatAppearance.BorderSize = 0;
            this.bt_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.bt_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_2.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_2.ForeColor = System.Drawing.Color.Black;
            this.bt_2.Location = new System.Drawing.Point(164, 298);
            this.bt_2.Name = "bt_2";
            this.bt_2.Size = new System.Drawing.Size(132, 78);
            this.bt_2.TabIndex = 8;
            this.bt_2.TabStop = false;
            this.bt_2.Text = "2";
            this.bt_2.UseVisualStyleBackColor = true;
            this.bt_2.Click += new System.EventHandler(this.bt_2_Click);
            // 
            // bt_5
            // 
            this.bt_5.FlatAppearance.BorderSize = 0;
            this.bt_5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.bt_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_5.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_5.ForeColor = System.Drawing.Color.Black;
            this.bt_5.Location = new System.Drawing.Point(164, 383);
            this.bt_5.Name = "bt_5";
            this.bt_5.Size = new System.Drawing.Size(132, 78);
            this.bt_5.TabIndex = 11;
            this.bt_5.TabStop = false;
            this.bt_5.Text = "5";
            this.bt_5.UseVisualStyleBackColor = true;
            this.bt_5.Click += new System.EventHandler(this.bt_5_Click);
            // 
            // bt_6
            // 
            this.bt_6.FlatAppearance.BorderSize = 0;
            this.bt_6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.bt_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_6.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_6.ForeColor = System.Drawing.Color.Black;
            this.bt_6.Location = new System.Drawing.Point(296, 383);
            this.bt_6.Name = "bt_6";
            this.bt_6.Size = new System.Drawing.Size(132, 78);
            this.bt_6.TabIndex = 10;
            this.bt_6.TabStop = false;
            this.bt_6.Text = "6";
            this.bt_6.UseVisualStyleBackColor = true;
            this.bt_6.Click += new System.EventHandler(this.bt_6_Click);
            // 
            // bt_4
            // 
            this.bt_4.FlatAppearance.BorderSize = 0;
            this.bt_4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.bt_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_4.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_4.ForeColor = System.Drawing.Color.Black;
            this.bt_4.Location = new System.Drawing.Point(32, 383);
            this.bt_4.Name = "bt_4";
            this.bt_4.Size = new System.Drawing.Size(132, 78);
            this.bt_4.TabIndex = 9;
            this.bt_4.TabStop = false;
            this.bt_4.Text = "4";
            this.bt_4.UseVisualStyleBackColor = true;
            this.bt_4.Click += new System.EventHandler(this.bt_4_Click);
            // 
            // bt_0
            // 
            this.bt_0.FlatAppearance.BorderSize = 0;
            this.bt_0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.bt_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_0.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_0.ForeColor = System.Drawing.Color.Black;
            this.bt_0.Location = new System.Drawing.Point(164, 553);
            this.bt_0.Name = "bt_0";
            this.bt_0.Size = new System.Drawing.Size(132, 78);
            this.bt_0.TabIndex = 17;
            this.bt_0.TabStop = false;
            this.bt_0.Text = "0";
            this.bt_0.UseVisualStyleBackColor = true;
            this.bt_0.Click += new System.EventHandler(this.bt_0_Click);
            // 
            // bt_result
            // 
            this.bt_result.FlatAppearance.BorderSize = 0;
            this.bt_result.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.bt_result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_result.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_result.ForeColor = System.Drawing.Color.Black;
            this.bt_result.Location = new System.Drawing.Point(296, 553);
            this.bt_result.Name = "bt_result";
            this.bt_result.Size = new System.Drawing.Size(132, 78);
            this.bt_result.TabIndex = 16;
            this.bt_result.Text = "=";
            this.bt_result.UseVisualStyleBackColor = true;
            this.bt_result.Click += new System.EventHandler(this.bt_result_Click);
            // 
            // bt_comma
            // 
            this.bt_comma.FlatAppearance.BorderSize = 0;
            this.bt_comma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_comma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_comma.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_comma.ForeColor = System.Drawing.Color.Black;
            this.bt_comma.Location = new System.Drawing.Point(32, 553);
            this.bt_comma.Name = "bt_comma";
            this.bt_comma.Size = new System.Drawing.Size(132, 78);
            this.bt_comma.TabIndex = 15;
            this.bt_comma.TabStop = false;
            this.bt_comma.Text = ",";
            this.bt_comma.UseVisualStyleBackColor = true;
            this.bt_comma.Click += new System.EventHandler(this.bt_comma_Click);
            // 
            // bt_8
            // 
            this.bt_8.FlatAppearance.BorderSize = 0;
            this.bt_8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.bt_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_8.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_8.ForeColor = System.Drawing.Color.Black;
            this.bt_8.Location = new System.Drawing.Point(164, 468);
            this.bt_8.Name = "bt_8";
            this.bt_8.Size = new System.Drawing.Size(132, 78);
            this.bt_8.TabIndex = 14;
            this.bt_8.TabStop = false;
            this.bt_8.Text = "8";
            this.bt_8.UseVisualStyleBackColor = true;
            this.bt_8.Click += new System.EventHandler(this.bt_8_Click);
            // 
            // bt_9
            // 
            this.bt_9.FlatAppearance.BorderSize = 0;
            this.bt_9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.bt_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_9.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_9.ForeColor = System.Drawing.Color.Black;
            this.bt_9.Location = new System.Drawing.Point(296, 468);
            this.bt_9.Name = "bt_9";
            this.bt_9.Size = new System.Drawing.Size(132, 78);
            this.bt_9.TabIndex = 13;
            this.bt_9.TabStop = false;
            this.bt_9.Text = "9";
            this.bt_9.UseVisualStyleBackColor = true;
            this.bt_9.Click += new System.EventHandler(this.bt_9_Click);
            // 
            // bt_7
            // 
            this.bt_7.FlatAppearance.BorderSize = 0;
            this.bt_7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.bt_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_7.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_7.ForeColor = System.Drawing.Color.Black;
            this.bt_7.Location = new System.Drawing.Point(32, 468);
            this.bt_7.Name = "bt_7";
            this.bt_7.Size = new System.Drawing.Size(132, 78);
            this.bt_7.TabIndex = 12;
            this.bt_7.TabStop = false;
            this.bt_7.Text = "7";
            this.bt_7.UseVisualStyleBackColor = true;
            this.bt_7.Click += new System.EventHandler(this.bt_7_Click);
            // 
            // bt_addition
            // 
            this.bt_addition.FlatAppearance.BorderSize = 0;
            this.bt_addition.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.bt_addition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_addition.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_addition.ForeColor = System.Drawing.Color.Black;
            this.bt_addition.Location = new System.Drawing.Point(6, 14);
            this.bt_addition.Name = "bt_addition";
            this.bt_addition.Size = new System.Drawing.Size(60, 78);
            this.bt_addition.TabIndex = 21;
            this.bt_addition.TabStop = false;
            this.bt_addition.Text = "+";
            this.bt_addition.UseVisualStyleBackColor = true;
            this.bt_addition.Click += new System.EventHandler(this.bt_addition_Click);
            // 
            // bt_subtraction
            // 
            this.bt_subtraction.FlatAppearance.BorderSize = 0;
            this.bt_subtraction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.bt_subtraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_subtraction.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_subtraction.ForeColor = System.Drawing.Color.Black;
            this.bt_subtraction.Location = new System.Drawing.Point(64, 14);
            this.bt_subtraction.Name = "bt_subtraction";
            this.bt_subtraction.Size = new System.Drawing.Size(60, 78);
            this.bt_subtraction.TabIndex = 28;
            this.bt_subtraction.TabStop = false;
            this.bt_subtraction.Text = "-";
            this.bt_subtraction.UseVisualStyleBackColor = true;
            this.bt_subtraction.Click += new System.EventHandler(this.bt_subtraction_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_subtraction);
            this.groupBox1.Controls.Add(this.bt_addition);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(33, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 98);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_division);
            this.groupBox2.Controls.Add(this.bt_multiplication);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(165, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 98);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            // 
            // bt_division
            // 
            this.bt_division.FlatAppearance.BorderSize = 0;
            this.bt_division.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.bt_division.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_division.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_division.ForeColor = System.Drawing.Color.Black;
            this.bt_division.Location = new System.Drawing.Point(64, 14);
            this.bt_division.Name = "bt_division";
            this.bt_division.Size = new System.Drawing.Size(60, 78);
            this.bt_division.TabIndex = 28;
            this.bt_division.TabStop = false;
            this.bt_division.Text = "/";
            this.bt_division.UseVisualStyleBackColor = true;
            this.bt_division.Click += new System.EventHandler(this.bt_division_Click);
            // 
            // bt_multiplication
            // 
            this.bt_multiplication.FlatAppearance.BorderSize = 0;
            this.bt_multiplication.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.bt_multiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_multiplication.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_multiplication.ForeColor = System.Drawing.Color.Black;
            this.bt_multiplication.Location = new System.Drawing.Point(6, 14);
            this.bt_multiplication.Name = "bt_multiplication";
            this.bt_multiplication.Size = new System.Drawing.Size(60, 78);
            this.bt_multiplication.TabIndex = 21;
            this.bt_multiplication.TabStop = false;
            this.bt_multiplication.Text = "x";
            this.bt_multiplication.UseVisualStyleBackColor = true;
            this.bt_multiplication.Click += new System.EventHandler(this.bt_multiplication_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_back);
            this.groupBox3.Controls.Add(this.bt_factorization);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(297, 194);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(130, 98);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            // 
            // bt_back
            // 
            this.bt_back.FlatAppearance.BorderSize = 0;
            this.bt_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.bt_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_back.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_back.ForeColor = System.Drawing.Color.Black;
            this.bt_back.Location = new System.Drawing.Point(64, 14);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(60, 78);
            this.bt_back.TabIndex = 28;
            this.bt_back.TabStop = false;
            this.bt_back.Text = "<";
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // bt_factorization
            // 
            this.bt_factorization.FlatAppearance.BorderSize = 0;
            this.bt_factorization.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.bt_factorization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_factorization.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_factorization.ForeColor = System.Drawing.Color.Black;
            this.bt_factorization.Location = new System.Drawing.Point(6, 14);
            this.bt_factorization.Name = "bt_factorization";
            this.bt_factorization.Size = new System.Drawing.Size(60, 78);
            this.bt_factorization.TabIndex = 21;
            this.bt_factorization.TabStop = false;
            this.bt_factorization.Text = "x!";
            this.bt_factorization.UseVisualStyleBackColor = true;
            this.bt_factorization.Click += new System.EventHandler(this.bt_factorization_Click);
            // 
            // lb_result
            // 
            this.lb_result.Font = new System.Drawing.Font("Tahoma", 50F);
            this.lb_result.ForeColor = System.Drawing.Color.Black;
            this.lb_result.Location = new System.Drawing.Point(33, 52);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(415, 77);
            this.lb_result.TabIndex = 36;
            this.lb_result.Text = "0";
            this.lb_result.TextChanged += new System.EventHandler(this.lb_result_TextChanged);
            this.lb_result.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lb_result_MouseClick);
            // 
            // lb_IClosestNumber
            // 
            this.lb_IClosestNumber.AutoSize = true;
            this.lb_IClosestNumber.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lb_IClosestNumber.Location = new System.Drawing.Point(0, 19);
            this.lb_IClosestNumber.Name = "lb_IClosestNumber";
            this.lb_IClosestNumber.Size = new System.Drawing.Size(127, 19);
            this.lb_IClosestNumber.TabIndex = 37;
            this.lb_IClosestNumber.Text = "Closest Number:";
            // 
            // lb_IElapsedTime
            // 
            this.lb_IElapsedTime.AutoSize = true;
            this.lb_IElapsedTime.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lb_IElapsedTime.Location = new System.Drawing.Point(0, 44);
            this.lb_IElapsedTime.Name = "lb_IElapsedTime";
            this.lb_IElapsedTime.Size = new System.Drawing.Size(110, 19);
            this.lb_IElapsedTime.TabIndex = 38;
            this.lb_IElapsedTime.Text = "Elapsed Time:";
            // 
            // lb_ElapsedTime
            // 
            this.lb_ElapsedTime.AutoSize = true;
            this.lb_ElapsedTime.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lb_ElapsedTime.Location = new System.Drawing.Point(132, 44);
            this.lb_ElapsedTime.Name = "lb_ElapsedTime";
            this.lb_ElapsedTime.Size = new System.Drawing.Size(75, 19);
            this.lb_ElapsedTime.TabIndex = 39;
            this.lb_ElapsedTime.Text = "00:00:00";
            // 
            // lb_Progress
            // 
            this.lb_Progress.AutoSize = true;
            this.lb_Progress.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lb_Progress.Location = new System.Drawing.Point(324, 44);
            this.lb_Progress.Name = "lb_Progress";
            this.lb_Progress.Size = new System.Drawing.Size(52, 19);
            this.lb_Progress.TabIndex = 41;
            this.lb_Progress.Text = "%000";
            // 
            // lb_IProgress
            // 
            this.lb_IProgress.AutoSize = true;
            this.lb_IProgress.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lb_IProgress.Location = new System.Drawing.Point(242, 44);
            this.lb_IProgress.Name = "lb_IProgress";
            this.lb_IProgress.Size = new System.Drawing.Size(76, 19);
            this.lb_IProgress.TabIndex = 40;
            this.lb_IProgress.Text = "Progress:";
            // 
            // lb_ClosestNumber
            // 
            this.lb_ClosestNumber.AutoSize = true;
            this.lb_ClosestNumber.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lb_ClosestNumber.Location = new System.Drawing.Point(132, 19);
            this.lb_ClosestNumber.Name = "lb_ClosestNumber";
            this.lb_ClosestNumber.Size = new System.Drawing.Size(13, 19);
            this.lb_ClosestNumber.TabIndex = 42;
            this.lb_ClosestNumber.Text = "!";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_info);
            this.panel1.Controls.Add(this.bt_stop);
            this.panel1.Controls.Add(this.lb_IClosestNumber);
            this.panel1.Controls.Add(this.lb_ClosestNumber);
            this.panel1.Controls.Add(this.lb_IElapsedTime);
            this.panel1.Controls.Add(this.lb_Progress);
            this.panel1.Controls.Add(this.lb_ElapsedTime);
            this.panel1.Controls.Add(this.lb_IProgress);
            this.panel1.Location = new System.Drawing.Point(33, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 72);
            this.panel1.TabIndex = 43;
            // 
            // lb_info
            // 
            this.lb_info.AutoSize = true;
            this.lb_info.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lb_info.Location = new System.Drawing.Point(163, 2);
            this.lb_info.Name = "lb_info";
            this.lb_info.Size = new System.Drawing.Size(0, 14);
            this.lb_info.TabIndex = 44;
            // 
            // bt_stop
            // 
            this.bt_stop.BackColor = System.Drawing.Color.Silver;
            this.bt_stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_stop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt_stop.FlatAppearance.BorderSize = 0;
            this.bt_stop.Location = new System.Drawing.Point(342, 15);
            this.bt_stop.Name = "bt_stop";
            this.bt_stop.Size = new System.Drawing.Size(52, 23);
            this.bt_stop.TabIndex = 43;
            this.bt_stop.TabStop = false;
            this.bt_stop.Text = "Stop";
            this.bt_stop.UseVisualStyleBackColor = false;
            this.bt_stop.Visible = false;
            this.bt_stop.Click += new System.EventHandler(this.Bt_stop_Click);
            // 
            // lb_process
            // 
            this.lb_process.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lb_process.ForeColor = System.Drawing.Color.DimGray;
            this.lb_process.Location = new System.Drawing.Point(32, 19);
            this.lb_process.Name = "lb_process";
            this.lb_process.Size = new System.Drawing.Size(416, 33);
            this.lb_process.TabIndex = 44;
            this.lb_process.Text = "0";
            // 
            // bt_checkresult
            // 
            this.bt_checkresult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_checkresult.Location = new System.Drawing.Point(199, -1);
            this.bt_checkresult.Name = "bt_checkresult";
            this.bt_checkresult.Size = new System.Drawing.Size(103, 23);
            this.bt_checkresult.TabIndex = 46;
            this.bt_checkresult.TabStop = false;
            this.bt_checkresult.Text = " Check The Result";
            this.bt_checkresult.UseVisualStyleBackColor = true;
            this.bt_checkresult.Visible = false;
            this.bt_checkresult.Click += new System.EventHandler(this.Bt_checkresult_Click);
            // 
            // Form1
            // 
            this.Appearance.BackColor = System.Drawing.Color.Silver;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 637);
            this.Controls.Add(this.bt_checkresult);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.lb_process);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_0);
            this.Controls.Add(this.bt_result);
            this.Controls.Add(this.bt_comma);
            this.Controls.Add(this.bt_8);
            this.Controls.Add(this.bt_9);
            this.Controls.Add(this.bt_7);
            this.Controls.Add(this.bt_5);
            this.Controls.Add(this.bt_6);
            this.Controls.Add(this.bt_4);
            this.Controls.Add(this.bt_2);
            this.Controls.Add(this.bt_3);
            this.Controls.Add(this.bt_1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.InactiveGlowColor = System.Drawing.Color.White;
            this.KeyPreview = true;
            this.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.True;
            this.Margin = new System.Windows.Forms.Padding(18, 19, 18, 19);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator With Use String";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button bt_1;
        private System.Windows.Forms.Button bt_3;
        private System.Windows.Forms.Button bt_2;
        private System.Windows.Forms.Button bt_5;
        private System.Windows.Forms.Button bt_6;
        private System.Windows.Forms.Button bt_4;
        private System.Windows.Forms.Button bt_0;
        private System.Windows.Forms.Button bt_result;
        private System.Windows.Forms.Button bt_comma;
        private System.Windows.Forms.Button bt_8;
        private System.Windows.Forms.Button bt_9;
        private System.Windows.Forms.Button bt_7;
        private System.Windows.Forms.Button bt_addition;
        private System.Windows.Forms.Button bt_subtraction;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_division;
        private System.Windows.Forms.Button bt_multiplication;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_back;
        private System.Windows.Forms.Button bt_factorization;
        private System.Windows.Forms.Label lb_result;
        private System.Windows.Forms.Label lb_IClosestNumber;
        private System.Windows.Forms.Label lb_IElapsedTime;
        private System.Windows.Forms.Label lb_ElapsedTime;
        private System.Windows.Forms.Label lb_Progress;
        private System.Windows.Forms.Label lb_IProgress;
        private System.Windows.Forms.Label lb_ClosestNumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_process;
        private System.Windows.Forms.Button bt_stop;
        private System.Windows.Forms.Label lb_info;
        private System.Windows.Forms.Button bt_checkresult;
    }
}

