namespace GUIKOU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PlayervsAI = new System.Windows.Forms.Label();
            this.AIvsAI = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlayervsAI
            // 
            this.PlayervsAI.BackColor = System.Drawing.Color.Transparent;
            this.PlayervsAI.Location = new System.Drawing.Point(-22, -23);
            this.PlayervsAI.Name = "PlayervsAI";
            this.PlayervsAI.Size = new System.Drawing.Size(520, 784);
            this.PlayervsAI.TabIndex = 0;
            this.PlayervsAI.Click += new System.EventHandler(this.PlayervsAI_Click);
            // 
            // AIvsAI
            // 
            this.AIvsAI.BackColor = System.Drawing.Color.Transparent;
            this.AIvsAI.Location = new System.Drawing.Point(501, -35);
            this.AIvsAI.Name = "AIvsAI";
            this.AIvsAI.Size = new System.Drawing.Size(591, 789);
            this.AIvsAI.TabIndex = 1;
            this.AIvsAI.Click += new System.EventHandler(this.AIvsAI_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.AIvsAI);
            this.Controls.Add(this.PlayervsAI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KOURPS+";
            this.ResumeLayout(false);

        }

        #endregion

        private Label PlayervsAI;
        private Label AIvsAI;
    }
}