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
            testBox = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            amountTextBox = new TextBox();
            EmailTextbox = new TextBox();
            numberTextbox = new TextBox();
            kont = new GroupBox();
            button1 = new Button();
            kont.SuspendLayout();
            SuspendLayout();
            // 
            // testBox
            // 
            testBox.Location = new Point(12, 184);
            testBox.Name = "testBox";
            testBox.ReadOnly = true;
            testBox.Size = new Size(760, 132);
            testBox.TabIndex = 3;
            testBox.Text = "";
            testBox.TextChanged += testBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 26);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 4;
            label1.Text = "balans :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 67);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 5;
            label2.Text = "email :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 104);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 6;
            label3.Text = "numer konta :";
            // 
            // amountTextBox
            // 
            amountTextBox.Location = new Point(105, 18);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.ReadOnly = true;
            amountTextBox.Size = new Size(465, 23);
            amountTextBox.TabIndex = 7;
            // 
            // EmailTextbox
            // 
            EmailTextbox.Location = new Point(105, 59);
            EmailTextbox.Name = "EmailTextbox";
            EmailTextbox.ReadOnly = true;
            EmailTextbox.Size = new Size(465, 23);
            EmailTextbox.TabIndex = 8;
            // 
            // numberTextbox
            // 
            numberTextbox.Location = new Point(105, 96);
            numberTextbox.Name = "numberTextbox";
            numberTextbox.ReadOnly = true;
            numberTextbox.Size = new Size(465, 23);
            numberTextbox.TabIndex = 9;
            // 
            // kont
            // 
            kont.Controls.Add(button1);
            kont.Controls.Add(amountTextBox);
            kont.Controls.Add(numberTextbox);
            kont.Controls.Add(label1);
            kont.Controls.Add(EmailTextbox);
            kont.Controls.Add(label2);
            kont.Controls.Add(label3);
            kont.Location = new Point(12, 12);
            kont.Name = "kont";
            kont.Size = new Size(760, 166);
            kont.TabIndex = 10;
            kont.TabStop = false;
            kont.Text = "konto :";
            // 
            // button1
            // 
            button1.Location = new Point(6, 125);
            button1.Name = "button1";
            button1.Size = new Size(748, 23);
            button1.TabIndex = 10;
            button1.Text = "przelej środki";
            button1.UseVisualStyleBackColor = true;
            button1.Click += transfeerButton;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 326);
            Controls.Add(kont);
            Controls.Add(testBox);
            Name = "Form1";
            Text = "Form1";
            Load += label4_Click;
            Shown += NumerKontaLabel_Click;
            kont.ResumeLayout(false);
            kont.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private RichTextBox testBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox amountTextBox;
        private TextBox EmailTextbox;
        private TextBox numberTextbox;
        private GroupBox kont;
        private Button button1;
    }
}
