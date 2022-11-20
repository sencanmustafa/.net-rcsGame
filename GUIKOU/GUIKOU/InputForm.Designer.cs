namespace GUIKOU
{
    partial class InputForm
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
            this.combo0 = new System.Windows.Forms.ComboBox();
            this.combo1 = new System.Windows.Forms.ComboBox();
            this.combo2 = new System.Windows.Forms.ComboBox();
            this.combo3 = new System.Windows.Forms.ComboBox();
            this.combo4 = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combo0
            // 
            this.combo0.FormattingEnabled = true;
            this.combo0.Items.AddRange(new object[] {
            "Tas",
            "Kagit",
            "Makas"});
            this.combo0.Location = new System.Drawing.Point(67, 75);
            this.combo0.Name = "combo0";
            this.combo0.Size = new System.Drawing.Size(121, 23);
            this.combo0.TabIndex = 0;
            // 
            // combo1
            // 
            this.combo1.FormattingEnabled = true;
            this.combo1.Items.AddRange(new object[] {
            "Tas",
            "Kagit",
            "Makas"});
            this.combo1.Location = new System.Drawing.Point(263, 75);
            this.combo1.Name = "combo1";
            this.combo1.Size = new System.Drawing.Size(121, 23);
            this.combo1.TabIndex = 1;
            // 
            // combo2
            // 
            this.combo2.FormattingEnabled = true;
            this.combo2.Items.AddRange(new object[] {
            "Tas",
            "Kagit",
            "Makas"});
            this.combo2.Location = new System.Drawing.Point(463, 75);
            this.combo2.Name = "combo2";
            this.combo2.Size = new System.Drawing.Size(121, 23);
            this.combo2.TabIndex = 2;
            // 
            // combo3
            // 
            this.combo3.FormattingEnabled = true;
            this.combo3.Items.AddRange(new object[] {
            "Tas",
            "Kagit",
            "Makas"});
            this.combo3.Location = new System.Drawing.Point(657, 75);
            this.combo3.Name = "combo3";
            this.combo3.Size = new System.Drawing.Size(121, 23);
            this.combo3.TabIndex = 3;
            // 
            // combo4
            // 
            this.combo4.FormattingEnabled = true;
            this.combo4.Items.AddRange(new object[] {
            "Tas",
            "Kagit",
            "Makas"});
            this.combo4.Location = new System.Drawing.Point(831, 75);
            this.combo4.Name = "combo4";
            this.combo4.Size = new System.Drawing.Size(121, 23);
            this.combo4.TabIndex = 4;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(411, 234);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(127, 51);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 467);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.combo4);
            this.Controls.Add(this.combo3);
            this.Controls.Add(this.combo2);
            this.Controls.Add(this.combo1);
            this.Controls.Add(this.combo0);
            this.Name = "InputForm";
            this.Text = "InputForm";
            this.Load += new System.EventHandler(this.InputForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox combo0;
        private ComboBox combo1;
        private ComboBox combo2;
        private ComboBox combo3;
        private ComboBox combo4;
        private Button saveButton;
    }
}