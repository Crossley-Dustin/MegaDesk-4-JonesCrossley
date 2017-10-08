﻿namespace MegaDesk_4_JonesCrossley
{
    partial class SearchAllQuotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchAllQuotes));
            this.CmbSurfaceSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbQuotes = new System.Windows.Forms.ListBox();
            this.BtnViewQuote = new System.Windows.Forms.Button();
            this.BtnReturnToMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmbSurfaceSelect
            // 
            this.CmbSurfaceSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbSurfaceSelect.FormattingEnabled = true;
            this.CmbSurfaceSelect.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.CmbSurfaceSelect.Location = new System.Drawing.Point(66, 92);
            this.CmbSurfaceSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbSurfaceSelect.Name = "CmbSurfaceSelect";
            this.CmbSurfaceSelect.Size = new System.Drawing.Size(550, 40);
            this.CmbSurfaceSelect.TabIndex = 0;
            this.CmbSurfaceSelect.SelectedIndexChanged += new System.EventHandler(this.CmbSurfaceSelect_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search by Surface Material";
            // 
            // lbQuotes
            // 
            this.lbQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuotes.FormattingEnabled = true;
            this.lbQuotes.ItemHeight = 32;
            this.lbQuotes.Location = new System.Drawing.Point(66, 175);
            this.lbQuotes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbQuotes.Name = "lbQuotes";
            this.lbQuotes.Size = new System.Drawing.Size(550, 292);
            this.lbQuotes.TabIndex = 3;
            // 
            // BtnViewQuote
            // 
            this.BtnViewQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnViewQuote.Location = new System.Drawing.Point(66, 509);
            this.BtnViewQuote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnViewQuote.Name = "BtnViewQuote";
            this.BtnViewQuote.Size = new System.Drawing.Size(552, 77);
            this.BtnViewQuote.TabIndex = 4;
            this.BtnViewQuote.Text = "View Selected Quote";
            this.BtnViewQuote.UseVisualStyleBackColor = true;
            this.BtnViewQuote.Click += new System.EventHandler(this.BtnViewQuote_Click);
            // 
            // BtnReturnToMainMenu
            // 
            this.BtnReturnToMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReturnToMainMenu.Location = new System.Drawing.Point(66, 608);
            this.BtnReturnToMainMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnReturnToMainMenu.Name = "BtnReturnToMainMenu";
            this.BtnReturnToMainMenu.Size = new System.Drawing.Size(552, 77);
            this.BtnReturnToMainMenu.TabIndex = 5;
            this.BtnReturnToMainMenu.Text = "Return To Main Menu";
            this.BtnReturnToMainMenu.UseVisualStyleBackColor = true;
            this.BtnReturnToMainMenu.Click += new System.EventHandler(this.BtnReturnToMainMenu_Click);
            // 
            // SearchAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 728);
            this.Controls.Add(this.BtnReturnToMainMenu);
            this.Controls.Add(this.BtnViewQuote);
            this.Controls.Add(this.lbQuotes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbSurfaceSelect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SearchAllQuotes";
            this.Text = "Search All Quotes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchAllQuotes_FormClosing);
            this.Load += new System.EventHandler(this.SearchAllQuotes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbSurfaceSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbQuotes;
        private System.Windows.Forms.Button BtnViewQuote;
        private System.Windows.Forms.Button BtnReturnToMainMenu;
    }
}