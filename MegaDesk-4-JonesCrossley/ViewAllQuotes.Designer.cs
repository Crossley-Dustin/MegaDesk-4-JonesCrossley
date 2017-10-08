namespace MegaDesk_4_JonesCrossley
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAllQuotes));
            this.TbFileContents = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnReturnToMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbFileContents
            // 
            this.TbFileContents.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbFileContents.Location = new System.Drawing.Point(57, 125);
            this.TbFileContents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TbFileContents.Multiline = true;
            this.TbFileContents.Name = "TbFileContents";
            this.TbFileContents.ReadOnly = true;
            this.TbFileContents.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TbFileContents.Size = new System.Drawing.Size(889, 527);
            this.TbFileContents.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "All Quotes in File";
            // 
            // BtnReturnToMainMenu
            // 
            this.BtnReturnToMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReturnToMainMenu.Location = new System.Drawing.Point(57, 695);
            this.BtnReturnToMainMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnReturnToMainMenu.Name = "BtnReturnToMainMenu";
            this.BtnReturnToMainMenu.Size = new System.Drawing.Size(891, 77);
            this.BtnReturnToMainMenu.TabIndex = 0;
            this.BtnReturnToMainMenu.Text = "Return to Menu";
            this.BtnReturnToMainMenu.UseVisualStyleBackColor = true;
            this.BtnReturnToMainMenu.Click += new System.EventHandler(this.BtnReturnToMainMenu_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 822);
            this.Controls.Add(this.BtnReturnToMainMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbFileContents);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewAllQuotes";
            this.Text = "View All Quotes";
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