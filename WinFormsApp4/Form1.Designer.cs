namespace WinFormsApp4
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
            NumerKontaLabel = new Label();
            AcountTextBox = new TextBox();
            TestButton = new Button();
            testBox = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // NumerKontaLabel
            // 
            NumerKontaLabel.AutoSize = true;
            NumerKontaLabel.Location = new Point(12, 53);
            NumerKontaLabel.Name = "NumerKontaLabel";
            NumerKontaLabel.Size = new Size(83, 15);
            NumerKontaLabel.TabIndex = 0;
            NumerKontaLabel.Text = "Numer konta :";
            NumerKontaLabel.Click += NumerKontaLabel_Click;
            // 
            // AcountTextBox
            // 
            AcountTextBox.Location = new Point(112, 49);
            AcountTextBox.Name = "AcountTextBox";
            AcountTextBox.Size = new Size(100, 23);
            AcountTextBox.TabIndex = 1;
            // 
            // TestButton
            // 
            TestButton.Location = new Point(218, 49);
            TestButton.Name = "TestButton";
            TestButton.Size = new Size(116, 23);
            TestButton.TabIndex = 2;
            TestButton.Text = "sprawdz";
            TestButton.UseVisualStyleBackColor = true;
            TestButton.Click += NumerKontaLabel_Click;
            // 
            // testBox
            // 
            testBox.Location = new Point(68, 410);
            testBox.Name = "testBox";
            testBox.ReadOnly = true;
            testBox.Size = new Size(662, 132);
            testBox.TabIndex = 3;
            testBox.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 113);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 152);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 5;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 189);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 6;
            label3.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 554);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(testBox);
            Controls.Add(TestButton);
            Controls.Add(AcountTextBox);
            Controls.Add(NumerKontaLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NumerKontaLabel;
        private TextBox AcountTextBox;
        private Button TestButton;
        private RichTextBox testBox;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
