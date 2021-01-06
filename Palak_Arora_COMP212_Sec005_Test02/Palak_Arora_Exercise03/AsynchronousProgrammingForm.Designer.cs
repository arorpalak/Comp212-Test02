namespace Palak_Arora_Exercise03
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFact = new System.Windows.Forms.NumericUpDown();
            this.btnCalculateFact = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.CheckEvenOddGroupBox = new System.Windows.Forms.GroupBox();
            this.InputNumberLabel = new System.Windows.Forms.Label();
            this.InputNumberTextBox = new System.Windows.Forms.TextBox();
            this.CheckEvenOddButton = new System.Windows.Forms.Button();
            this.DisplayListOfValuesAndSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.IntegersRadioButton = new System.Windows.Forms.RadioButton();
            this.DoublesRadioButton = new System.Windows.Forms.RadioButton();
            this.CharRadioButton = new System.Windows.Forms.RadioButton();
            this.GenerateValuesButton = new System.Windows.Forms.Button();
            this.GeneratedValuesListBox = new System.Windows.Forms.ListBox();
            this.InputValueForSearchLabel = new System.Windows.Forms.Label();
            this.InputSearchValueTextBox = new System.Windows.Forms.TextBox();
            this.InputLowIndexLabel = new System.Windows.Forms.Label();
            this.InputLowIndexTextBox = new System.Windows.Forms.TextBox();
            this.InputHighIndexLabel = new System.Windows.Forms.Label();
            this.InputHighIndexTextBox = new System.Windows.Forms.TextBox();
            this.OutputOfValuesBetweenLowAndHighLabel = new System.Windows.Forms.Label();
            this.OutputValuesBetweenLowHighTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFact)).BeginInit();
            this.CheckEvenOddGroupBox.SuspendLayout();
            this.DisplayListOfValuesAndSearchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAnswer);
            this.groupBox1.Controls.Add(this.btnCalculateFact);
            this.groupBox1.Controls.Add(this.txtFact);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 297);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "(1)Calculate Factorial Asynchronously";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get Factorial Of:";
            // 
            // txtFact
            // 
            this.txtFact.Location = new System.Drawing.Point(151, 48);
            this.txtFact.Name = "txtFact";
            this.txtFact.Size = new System.Drawing.Size(139, 22);
            this.txtFact.TabIndex = 1;
            // 
            // btnCalculateFact
            // 
            this.btnCalculateFact.Location = new System.Drawing.Point(79, 95);
            this.btnCalculateFact.Name = "btnCalculateFact";
            this.btnCalculateFact.Size = new System.Drawing.Size(165, 51);
            this.btnCalculateFact.TabIndex = 2;
            this.btnCalculateFact.Text = "Calculate Factorial";
            this.btnCalculateFact.UseVisualStyleBackColor = true;
            this.btnCalculateFact.Click += new System.EventHandler(this.btnCalculateFact_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(66, 166);
            this.txtAnswer.Multiline = true;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(224, 105);
            this.txtAnswer.TabIndex = 3;
            // 
            // CheckEvenOddGroupBox
            // 
            this.CheckEvenOddGroupBox.Controls.Add(this.CheckEvenOddButton);
            this.CheckEvenOddGroupBox.Controls.Add(this.InputNumberTextBox);
            this.CheckEvenOddGroupBox.Controls.Add(this.InputNumberLabel);
            this.CheckEvenOddGroupBox.Location = new System.Drawing.Point(26, 365);
            this.CheckEvenOddGroupBox.Name = "CheckEvenOddGroupBox";
            this.CheckEvenOddGroupBox.Size = new System.Drawing.Size(347, 287);
            this.CheckEvenOddGroupBox.TabIndex = 1;
            this.CheckEvenOddGroupBox.TabStop = false;
            this.CheckEvenOddGroupBox.Text = "(2) Chech for Even/Odd";
            // 
            // InputNumberLabel
            // 
            this.InputNumberLabel.AutoSize = true;
            this.InputNumberLabel.Location = new System.Drawing.Point(21, 65);
            this.InputNumberLabel.Name = "InputNumberLabel";
            this.InputNumberLabel.Size = new System.Drawing.Size(93, 17);
            this.InputNumberLabel.TabIndex = 0;
            this.InputNumberLabel.Text = "Input Number";
            // 
            // InputNumberTextBox
            // 
            this.InputNumberTextBox.Location = new System.Drawing.Point(143, 65);
            this.InputNumberTextBox.Name = "InputNumberTextBox";
            this.InputNumberTextBox.Size = new System.Drawing.Size(147, 22);
            this.InputNumberTextBox.TabIndex = 1;
            // 
            // CheckEvenOddButton
            // 
            this.CheckEvenOddButton.Location = new System.Drawing.Point(88, 178);
            this.CheckEvenOddButton.Name = "CheckEvenOddButton";
            this.CheckEvenOddButton.Size = new System.Drawing.Size(168, 68);
            this.CheckEvenOddButton.TabIndex = 2;
            this.CheckEvenOddButton.Text = "Check for Even or Odd";
            this.CheckEvenOddButton.UseVisualStyleBackColor = true;
            this.CheckEvenOddButton.Click += new System.EventHandler(this.CheckEvenOddButton_Click);
            // 
            // DisplayListOfValuesAndSearchGroupBox
            // 
            this.DisplayListOfValuesAndSearchGroupBox.Controls.Add(this.DisplayButton);
            this.DisplayListOfValuesAndSearchGroupBox.Controls.Add(this.SearchButton);
            this.DisplayListOfValuesAndSearchGroupBox.Controls.Add(this.OutputValuesBetweenLowHighTextBox);
            this.DisplayListOfValuesAndSearchGroupBox.Controls.Add(this.OutputOfValuesBetweenLowAndHighLabel);
            this.DisplayListOfValuesAndSearchGroupBox.Controls.Add(this.InputHighIndexTextBox);
            this.DisplayListOfValuesAndSearchGroupBox.Controls.Add(this.InputHighIndexLabel);
            this.DisplayListOfValuesAndSearchGroupBox.Controls.Add(this.InputLowIndexTextBox);
            this.DisplayListOfValuesAndSearchGroupBox.Controls.Add(this.InputLowIndexLabel);
            this.DisplayListOfValuesAndSearchGroupBox.Controls.Add(this.InputSearchValueTextBox);
            this.DisplayListOfValuesAndSearchGroupBox.Controls.Add(this.InputValueForSearchLabel);
            this.DisplayListOfValuesAndSearchGroupBox.Controls.Add(this.GeneratedValuesListBox);
            this.DisplayListOfValuesAndSearchGroupBox.Controls.Add(this.GenerateValuesButton);
            this.DisplayListOfValuesAndSearchGroupBox.Controls.Add(this.CharRadioButton);
            this.DisplayListOfValuesAndSearchGroupBox.Controls.Add(this.DoublesRadioButton);
            this.DisplayListOfValuesAndSearchGroupBox.Controls.Add(this.IntegersRadioButton);
            this.DisplayListOfValuesAndSearchGroupBox.Location = new System.Drawing.Point(428, 23);
            this.DisplayListOfValuesAndSearchGroupBox.Name = "DisplayListOfValuesAndSearchGroupBox";
            this.DisplayListOfValuesAndSearchGroupBox.Size = new System.Drawing.Size(589, 629);
            this.DisplayListOfValuesAndSearchGroupBox.TabIndex = 2;
            this.DisplayListOfValuesAndSearchGroupBox.TabStop = false;
            this.DisplayListOfValuesAndSearchGroupBox.Text = "(3) Display List of Values and Search";
            // 
            // IntegersRadioButton
            // 
            this.IntegersRadioButton.AutoSize = true;
            this.IntegersRadioButton.Location = new System.Drawing.Point(31, 36);
            this.IntegersRadioButton.Name = "IntegersRadioButton";
            this.IntegersRadioButton.Size = new System.Drawing.Size(80, 21);
            this.IntegersRadioButton.TabIndex = 0;
            this.IntegersRadioButton.TabStop = true;
            this.IntegersRadioButton.Text = "Integers";
            this.IntegersRadioButton.UseVisualStyleBackColor = true;
            // 
            // DoublesRadioButton
            // 
            this.DoublesRadioButton.AutoSize = true;
            this.DoublesRadioButton.Location = new System.Drawing.Point(149, 36);
            this.DoublesRadioButton.Name = "DoublesRadioButton";
            this.DoublesRadioButton.Size = new System.Drawing.Size(81, 21);
            this.DoublesRadioButton.TabIndex = 1;
            this.DoublesRadioButton.TabStop = true;
            this.DoublesRadioButton.Text = "Doubles";
            this.DoublesRadioButton.UseVisualStyleBackColor = true;
            // 
            // CharRadioButton
            // 
            this.CharRadioButton.AutoSize = true;
            this.CharRadioButton.Location = new System.Drawing.Point(266, 36);
            this.CharRadioButton.Name = "CharRadioButton";
            this.CharRadioButton.Size = new System.Drawing.Size(59, 21);
            this.CharRadioButton.TabIndex = 2;
            this.CharRadioButton.TabStop = true;
            this.CharRadioButton.Text = "Char";
            this.CharRadioButton.UseVisualStyleBackColor = true;
            // 
            // GenerateValuesButton
            // 
            this.GenerateValuesButton.Location = new System.Drawing.Point(372, 21);
            this.GenerateValuesButton.Name = "GenerateValuesButton";
            this.GenerateValuesButton.Size = new System.Drawing.Size(121, 44);
            this.GenerateValuesButton.TabIndex = 3;
            this.GenerateValuesButton.Text = "Generate Values";
            this.GenerateValuesButton.UseVisualStyleBackColor = true;
            this.GenerateValuesButton.Click += new System.EventHandler(this.GenerateValuesButton_Click);
            // 
            // GeneratedValuesListBox
            // 
            this.GeneratedValuesListBox.FormattingEnabled = true;
            this.GeneratedValuesListBox.ItemHeight = 16;
            this.GeneratedValuesListBox.Location = new System.Drawing.Point(20, 110);
            this.GeneratedValuesListBox.Name = "GeneratedValuesListBox";
            this.GeneratedValuesListBox.Size = new System.Drawing.Size(91, 500);
            this.GeneratedValuesListBox.TabIndex = 4;
            // 
            // InputValueForSearchLabel
            // 
            this.InputValueForSearchLabel.AutoSize = true;
            this.InputValueForSearchLabel.Location = new System.Drawing.Point(117, 150);
            this.InputValueForSearchLabel.Name = "InputValueForSearchLabel";
            this.InputValueForSearchLabel.Size = new System.Drawing.Size(149, 17);
            this.InputValueForSearchLabel.TabIndex = 5;
            this.InputValueForSearchLabel.Text = "Input Value for Search";
            // 
            // InputSearchValueTextBox
            // 
            this.InputSearchValueTextBox.Location = new System.Drawing.Point(282, 147);
            this.InputSearchValueTextBox.Name = "InputSearchValueTextBox";
            this.InputSearchValueTextBox.Size = new System.Drawing.Size(149, 22);
            this.InputSearchValueTextBox.TabIndex = 6;
            // 
            // InputLowIndexLabel
            // 
            this.InputLowIndexLabel.AutoSize = true;
            this.InputLowIndexLabel.Location = new System.Drawing.Point(137, 198);
            this.InputLowIndexLabel.Name = "InputLowIndexLabel";
            this.InputLowIndexLabel.Size = new System.Drawing.Size(105, 17);
            this.InputLowIndexLabel.TabIndex = 7;
            this.InputLowIndexLabel.Text = "Input Low Index";
            // 
            // InputLowIndexTextBox
            // 
            this.InputLowIndexTextBox.Location = new System.Drawing.Point(282, 192);
            this.InputLowIndexTextBox.Name = "InputLowIndexTextBox";
            this.InputLowIndexTextBox.Size = new System.Drawing.Size(149, 22);
            this.InputLowIndexTextBox.TabIndex = 8;
            // 
            // InputHighIndexLabel
            // 
            this.InputHighIndexLabel.AutoSize = true;
            this.InputHighIndexLabel.Location = new System.Drawing.Point(137, 254);
            this.InputHighIndexLabel.Name = "InputHighIndexLabel";
            this.InputHighIndexLabel.Size = new System.Drawing.Size(109, 17);
            this.InputHighIndexLabel.TabIndex = 9;
            this.InputHighIndexLabel.Text = "Input High Index";
            // 
            // InputHighIndexTextBox
            // 
            this.InputHighIndexTextBox.Location = new System.Drawing.Point(282, 248);
            this.InputHighIndexTextBox.Name = "InputHighIndexTextBox";
            this.InputHighIndexTextBox.Size = new System.Drawing.Size(149, 22);
            this.InputHighIndexTextBox.TabIndex = 10;
            // 
            // OutputOfValuesBetweenLowAndHighLabel
            // 
            this.OutputOfValuesBetweenLowAndHighLabel.AutoSize = true;
            this.OutputOfValuesBetweenLowAndHighLabel.Location = new System.Drawing.Point(146, 351);
            this.OutputOfValuesBetweenLowAndHighLabel.Name = "OutputOfValuesBetweenLowAndHighLabel";
            this.OutputOfValuesBetweenLowAndHighLabel.Size = new System.Drawing.Size(263, 17);
            this.OutputOfValuesBetweenLowAndHighLabel.TabIndex = 11;
            this.OutputOfValuesBetweenLowAndHighLabel.Text = "Output of values between Low and High:";
            // 
            // OutputValuesBetweenLowHighTextBox
            // 
            this.OutputValuesBetweenLowHighTextBox.Location = new System.Drawing.Point(168, 401);
            this.OutputValuesBetweenLowHighTextBox.Multiline = true;
            this.OutputValuesBetweenLowHighTextBox.Name = "OutputValuesBetweenLowHighTextBox";
            this.OutputValuesBetweenLowHighTextBox.Size = new System.Drawing.Size(370, 169);
            this.OutputValuesBetweenLowHighTextBox.TabIndex = 12;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(475, 150);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(95, 45);
            this.SearchButton.TabIndex = 13;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // DisplayButton
            // 
            this.DisplayButton.Location = new System.Drawing.Point(475, 254);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(95, 43);
            this.DisplayButton.TabIndex = 14;
            this.DisplayButton.Text = "Display";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 664);
            this.Controls.Add(this.DisplayListOfValuesAndSearchGroupBox);
            this.Controls.Add(this.CheckEvenOddGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Asynchronous Programming";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFact)).EndInit();
            this.CheckEvenOddGroupBox.ResumeLayout(false);
            this.CheckEvenOddGroupBox.PerformLayout();
            this.DisplayListOfValuesAndSearchGroupBox.ResumeLayout(false);
            this.DisplayListOfValuesAndSearchGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtFact;
        private System.Windows.Forms.Button btnCalculateFact;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.GroupBox CheckEvenOddGroupBox;
        private System.Windows.Forms.Label InputNumberLabel;
        private System.Windows.Forms.TextBox InputNumberTextBox;
        private System.Windows.Forms.Button CheckEvenOddButton;
        private System.Windows.Forms.GroupBox DisplayListOfValuesAndSearchGroupBox;
        private System.Windows.Forms.RadioButton IntegersRadioButton;
        private System.Windows.Forms.RadioButton DoublesRadioButton;
        private System.Windows.Forms.RadioButton CharRadioButton;
        private System.Windows.Forms.Button GenerateValuesButton;
        private System.Windows.Forms.ListBox GeneratedValuesListBox;
        private System.Windows.Forms.Label InputValueForSearchLabel;
        private System.Windows.Forms.TextBox InputSearchValueTextBox;
        private System.Windows.Forms.Label InputLowIndexLabel;
        private System.Windows.Forms.TextBox InputLowIndexTextBox;
        private System.Windows.Forms.Label InputHighIndexLabel;
        private System.Windows.Forms.TextBox InputHighIndexTextBox;
        private System.Windows.Forms.Label OutputOfValuesBetweenLowAndHighLabel;
        private System.Windows.Forms.TextBox OutputValuesBetweenLowHighTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button DisplayButton;
    }
}

