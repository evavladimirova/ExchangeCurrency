namespace ExchangeCurrency
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            toEuroRadioButton = new RadioButton();
            toBGNRadioButton = new RadioButton();
            amountLabel = new Label();
            inputTextBox = new TextBox();
            ConvertButton = new Button();
            resultLabel = new Label();
            resultLable = new Label();
            ResetButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(239, 39);
            label1.Name = "label1";
            label1.Size = new Size(320, 45);
            label1.TabIndex = 0;
            label1.Text = "Exchange Currency";
            // 
            // toEuroRadioButton
            // 
            toEuroRadioButton.AutoSize = true;
            toEuroRadioButton.Location = new Point(164, 137);
            toEuroRadioButton.Name = "toEuroRadioButton";
            toEuroRadioButton.Size = new Size(131, 29);
            toEuroRadioButton.TabIndex = 1;
            toEuroRadioButton.TabStop = true;
            toEuroRadioButton.Text = "BGN to EUR";
            toEuroRadioButton.UseVisualStyleBackColor = true;
            toEuroRadioButton.CheckedChanged += toEuroRadioButton_CheckedChanged;
            // 
            // toBGNRadioButton
            // 
            toBGNRadioButton.AutoSize = true;
            toBGNRadioButton.Location = new Point(486, 137);
            toBGNRadioButton.Name = "toBGNRadioButton";
            toBGNRadioButton.Size = new Size(131, 29);
            toBGNRadioButton.TabIndex = 2;
            toBGNRadioButton.TabStop = true;
            toBGNRadioButton.Text = "EUR to BGN";
            toBGNRadioButton.UseVisualStyleBackColor = true;
            toBGNRadioButton.CheckedChanged += toBGNRadioButton_CheckedChanged;
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new Point(188, 230);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(123, 25);
            amountLabel.TabIndex = 3;
            amountLabel.Text = "Enter amount:";
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(327, 230);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(150, 31);
            inputTextBox.TabIndex = 4;
            inputTextBox.TextChanged += inputTextBox_TextChanged;
            // 
            // ConvertButton
            // 
            ConvertButton.Location = new Point(535, 230);
            ConvertButton.Name = "ConvertButton";
            ConvertButton.Size = new Size(112, 34);
            ConvertButton.TabIndex = 5;
            ConvertButton.Text = "Convert";
            ConvertButton.UseVisualStyleBackColor = true;
            ConvertButton.Click += ConvertButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(327, 305);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 25);
            resultLabel.TabIndex = 6;
            // 
            // resultLable
            // 
            resultLable.AutoSize = true;
            resultLable.Location = new Point(327, 305);
            resultLable.Name = "resultLable";
            resultLable.Size = new Size(164, 25);
            resultLable.TabIndex = 7;
            resultLable.Text = "Converted Amount";
            resultLable.Click += resultLable_Click;
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(322, 373);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(155, 34);
            ResetButton.TabIndex = 8;
            ResetButton.Text = "New Conversion";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ResetButton);
            Controls.Add(resultLable);
            Controls.Add(resultLabel);
            Controls.Add(ConvertButton);
            Controls.Add(inputTextBox);
            Controls.Add(amountLabel);
            Controls.Add(toBGNRadioButton);
            Controls.Add(toEuroRadioButton);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton toEuroRadioButton;
        private RadioButton toBGNRadioButton;
        private Label amountLabel;
        private TextBox inputTextBox;
        private Button ConvertButton;
        private Label resultLabel;
        private Label resultLable;
        private Button ResetButton;
    }
}
