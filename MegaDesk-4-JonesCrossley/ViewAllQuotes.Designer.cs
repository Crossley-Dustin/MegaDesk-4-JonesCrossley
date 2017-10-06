namespace MegaDesk_3_DustinCrossley
{
    partial class ViewAllQuotes
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
            this.TbFileContents = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnReturnToMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbFileContents
            // 
            this.TbFileContents.Enabled = false;
            this.TbFileContents.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbFileContents.Location = new System.Drawing.Point(38, 81);
            this.TbFileContents.Multiline = true;
            this.TbFileContents.Name = "TbFileContents";
            this.TbFileContents.Size = new System.Drawing.Size(594, 344);
            this.TbFileContents.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "All Quotes in File";
            // 
            // BtnReturnToMainMenu
            // 
            this.BtnReturnToMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReturnToMainMenu.Location = new System.Drawing.Point(38, 452);
            this.BtnReturnToMainMenu.Name = "BtnReturnToMainMenu";
            this.BtnReturnToMainMenu.Size = new System.Drawing.Size(594, 50);
            this.BtnReturnToMainMenu.TabIndex = 7;
            this.BtnReturnToMainMenu.Text = "Return to Menu";
            this.BtnReturnToMainMenu.UseVisualStyleBackColor = true;
            this.BtnReturnToMainMenu.Click += new System.EventHandler(this.BtnReturnToMainMenu_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 534);
            this.Controls.Add(this.BtnReturnToMainMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbFileContents);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewAllQuotes_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbFileContents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnReturnToMainMenu;
    }
}