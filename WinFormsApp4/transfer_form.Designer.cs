namespace WinFormsApp4
{
    partial class transfer_form
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
            ilośćNumericUpDown1 = new NumericUpDown();
            TargetTextBox2 = new TextBox();
            LayerGroupBox = new GroupBox();
            button1 = new Button();
            exitTransferButton = new Button();
            przelewButton = new Button();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)ilośćNumericUpDown1).BeginInit();
            LayerGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ilośćNumericUpDown1
            // 
            ilośćNumericUpDown1.DecimalPlaces = 2;
            ilośćNumericUpDown1.Location = new Point(124, 120);
            ilośćNumericUpDown1.Name = "ilośćNumericUpDown1";
            ilośćNumericUpDown1.Size = new Size(193, 23);
            ilośćNumericUpDown1.TabIndex = 0;
            // 
            // TargetTextBox2
            // 
            TargetTextBox2.Location = new Point(124, 74);
            TargetTextBox2.Name = "TargetTextBox2";
            TargetTextBox2.Size = new Size(193, 23);
            TargetTextBox2.TabIndex = 2;
            // 
            // LayerGroupBox
            // 
            LayerGroupBox.Controls.Add(button1);
            LayerGroupBox.Controls.Add(exitTransferButton);
            LayerGroupBox.Controls.Add(przelewButton);
            LayerGroupBox.Controls.Add(label3);
            LayerGroupBox.Controls.Add(label2);
            LayerGroupBox.Controls.Add(ilośćNumericUpDown1);
            LayerGroupBox.Controls.Add(TargetTextBox2);
            LayerGroupBox.Location = new Point(12, 12);
            LayerGroupBox.Name = "LayerGroupBox";
            LayerGroupBox.Size = new Size(343, 204);
            LayerGroupBox.TabIndex = 3;
            LayerGroupBox.TabStop = false;
            LayerGroupBox.Text = "przelew :";
            // 
            // button1
            // 
            button1.Location = new Point(16, 27);
            button1.Name = "button1";
            button1.Size = new Size(301, 23);
            button1.TabIndex = 8;
            button1.Text = "historia";
            button1.UseVisualStyleBackColor = true;
            button1.Click += OpenTransferHistory;
            // 
            // exitTransferButton
            // 
            exitTransferButton.Location = new Point(171, 175);
            exitTransferButton.Name = "exitTransferButton";
            exitTransferButton.Size = new Size(166, 23);
            exitTransferButton.TabIndex = 7;
            exitTransferButton.Text = "wyjdź";
            exitTransferButton.UseVisualStyleBackColor = true;
            exitTransferButton.Click += ExitButtonPressed;
            // 
            // przelewButton
            // 
            przelewButton.Location = new Point(6, 175);
            przelewButton.Name = "przelewButton";
            przelewButton.Size = new Size(159, 23);
            przelewButton.TabIndex = 6;
            przelewButton.Text = "Wykonaj przelew";
            przelewButton.UseVisualStyleBackColor = true;
            przelewButton.Click += TransferMoneh;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 122);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 5;
            label3.Text = "Kwota :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 77);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 4;
            label2.Text = "Konto docelowe  :";
            // 
            // transfer_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 226);
            Controls.Add(LayerGroupBox);
            Name = "transfer_form";
            Text = "transfer_form";
            ((System.ComponentModel.ISupportInitialize)ilośćNumericUpDown1).EndInit();
            LayerGroupBox.ResumeLayout(false);
            LayerGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown ilośćNumericUpDown1;
        private TextBox TargetTextBox2;
        private GroupBox LayerGroupBox;
        private Button przelewButton;
        private Label label3;
        private Label label2;
        private Button exitTransferButton;
        private Button button1;
    }
}