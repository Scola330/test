namespace WinFormsApp4
{
    partial class login
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
            tableLayoutPanel1 = new TableLayoutPanel();
            HasloRichTextBox2 = new RichTextBox();
            EmailRichTextBox1 = new RichTextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            WyjdzButton = new Button();
            LoginButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(HasloRichTextBox2, 0, 1);
            tableLayoutPanel1.Controls.Add(EmailRichTextBox1, 0, 0);
            tableLayoutPanel1.Location = new Point(476, 65);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(242, 224);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // HasloRichTextBox2
            // 
            HasloRichTextBox2.Location = new Point(3, 115);
            HasloRichTextBox2.Name = "HasloRichTextBox2";
            HasloRichTextBox2.Size = new Size(236, 106);
            HasloRichTextBox2.TabIndex = 1;
            HasloRichTextBox2.Text = "Mh26l5aGfC=^";
            // 
            // EmailRichTextBox1
            // 
            EmailRichTextBox1.Location = new Point(3, 3);
            EmailRichTextBox1.Name = "EmailRichTextBox1";
            EmailRichTextBox1.Size = new Size(236, 106);
            EmailRichTextBox1.TabIndex = 0;
            EmailRichTextBox1.Text = "Skibid1@gmail.com";
            EmailRichTextBox1.TextChanged += EmailRichTextBox1_TextChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 351F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(WyjdzButton, 1, 0);
            tableLayoutPanel2.Controls.Add(LoginButton, 0, 0);
            tableLayoutPanel2.Location = new Point(12, 295);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(706, 106);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // WyjdzButton
            // 
            WyjdzButton.Font = new Font("Segoe UI", 12F);
            WyjdzButton.Location = new Point(358, 3);
            WyjdzButton.Name = "WyjdzButton";
            WyjdzButton.Size = new Size(345, 100);
            WyjdzButton.TabIndex = 1;
            WyjdzButton.Text = "Wyjdź";
            WyjdzButton.UseVisualStyleBackColor = true;
            WyjdzButton.Click += WyjdzButtonPressed;
            // 
            // LoginButton
            // 
            LoginButton.Font = new Font("Segoe UI", 12F);
            LoginButton.Location = new Point(3, 3);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(349, 100);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "Zaloguj";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButtonPressed;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(306, 9);
            label1.Name = "label1";
            label1.Size = new Size(148, 37);
            label1.TabIndex = 2;
            label1.Text = "Logowanie";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(376, 112);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 3;
            label2.Text = "E-mail :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(376, 229);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 4;
            label3.Text = "Hasło :";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 410);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "login";
            Text = "Form2";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private RichTextBox HasloRichTextBox2;
        private RichTextBox EmailRichTextBox1;
        private Button WyjdzButton;
        private Button LoginButton;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}