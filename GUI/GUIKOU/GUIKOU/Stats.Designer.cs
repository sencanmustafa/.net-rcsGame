namespace GUIKOU
{
    partial class Stats
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
            this.closeButton = new System.Windows.Forms.Label();
            this.dayaniklilik = new System.Windows.Forms.Label();
            this.ozellik1 = new System.Windows.Forms.Label();
            this.ozellik2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dayaniklilikData = new System.Windows.Forms.Label();
            this.ozellik1Data = new System.Windows.Forms.Label();
            this.ozellik2Data = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeButton.Font = new System.Drawing.Font("VT323", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeButton.Location = new System.Drawing.Point(422, 39);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(22, 37);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "x";
            // 
            // dayaniklilik
            // 
            this.dayaniklilik.AutoSize = true;
            this.dayaniklilik.Font = new System.Drawing.Font("VT323", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dayaniklilik.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dayaniklilik.Location = new System.Drawing.Point(12, 11);
            this.dayaniklilik.Name = "dayaniklilik";
            this.dayaniklilik.Size = new System.Drawing.Size(144, 31);
            this.dayaniklilik.TabIndex = 3;
            this.dayaniklilik.Text = "Dayanıklılık:";
            this.dayaniklilik.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.dayaniklilik.Click += new System.EventHandler(this.label1_Click);
            // 
            // ozellik1
            // 
            this.ozellik1.AutoSize = true;
            this.ozellik1.Font = new System.Drawing.Font("VT323", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ozellik1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ozellik1.Location = new System.Drawing.Point(52, 42);
            this.ozellik1.Name = "ozellik1";
            this.ozellik1.Size = new System.Drawing.Size(104, 31);
            this.ozellik1.TabIndex = 4;
            this.ozellik1.Text = "Özellik1:";
            this.ozellik1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.ozellik1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // ozellik2
            // 
            this.ozellik2.AutoSize = true;
            this.ozellik2.Font = new System.Drawing.Font("VT323", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ozellik2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ozellik2.Location = new System.Drawing.Point(52, 73);
            this.ozellik2.Name = "ozellik2";
            this.ozellik2.Size = new System.Drawing.Size(104, 31);
            this.ozellik2.TabIndex = 5;
            this.ozellik2.Text = "Özellik2:";
            this.ozellik2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("VT323", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(214, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "x";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // dayaniklilikData
            // 
            this.dayaniklilikData.AutoSize = true;
            this.dayaniklilikData.Font = new System.Drawing.Font("VT323", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dayaniklilikData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dayaniklilikData.Location = new System.Drawing.Point(162, 11);
            this.dayaniklilikData.Name = "dayaniklilikData";
            this.dayaniklilikData.Size = new System.Drawing.Size(24, 31);
            this.dayaniklilikData.TabIndex = 7;
            this.dayaniklilikData.Text = "-";
            // 
            // ozellik1Data
            // 
            this.ozellik1Data.AutoSize = true;
            this.ozellik1Data.Font = new System.Drawing.Font("VT323", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ozellik1Data.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ozellik1Data.Location = new System.Drawing.Point(162, 42);
            this.ozellik1Data.Name = "ozellik1Data";
            this.ozellik1Data.Size = new System.Drawing.Size(24, 31);
            this.ozellik1Data.TabIndex = 8;
            this.ozellik1Data.Text = "-";
            // 
            // ozellik2Data
            // 
            this.ozellik2Data.AutoSize = true;
            this.ozellik2Data.Font = new System.Drawing.Font("VT323", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ozellik2Data.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ozellik2Data.Location = new System.Drawing.Point(162, 73);
            this.ozellik2Data.Name = "ozellik2Data";
            this.ozellik2Data.Size = new System.Drawing.Size(24, 31);
            this.ozellik2Data.TabIndex = 9;
            this.ozellik2Data.Text = "-";
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(248, 123);
            this.ControlBox = false;
            this.Controls.Add(this.ozellik2Data);
            this.Controls.Add(this.ozellik1Data);
            this.Controls.Add(this.dayaniklilikData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ozellik2);
            this.Controls.Add(this.ozellik1);
            this.Controls.Add(this.dayaniklilik);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Stats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label closeButton;
        private Label dayaniklilik;
        private Label ozellik1;
        private Label ozellik2;
        private Label label1;
        private Label dayaniklilikData;
        private Label ozellik1Data;
        private Label ozellik2Data;
    }
}