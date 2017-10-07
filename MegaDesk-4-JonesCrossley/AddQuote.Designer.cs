namespace MegaDesk_4_JonesCrossley
{
    partial class AddQuote
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
            this.components = new System.ComponentModel.Container();
            this.btnReturnToMainMenu = new System.Windows.Forms.Button();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.tbDeskWidth = new System.Windows.Forms.TextBox();
            this.tbDeskDepth = new System.Windows.Forms.TextBox();
            this.cmbRushDays = new System.Windows.Forms.ComboBox();
            this.cmbNumDrawers = new System.Windows.Forms.ComboBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblDeskWidth = new System.Windows.Forms.Label();
            this.lblDeskDepth = new System.Windows.Forms.Label();
            this.lblNumDrawers = new System.Windows.Forms.Label();
            this.lblRushOrder = new System.Windows.Forms.Label();
            this.btnSaveQuote = new System.Windows.Forms.Button();
            this.ErrProv_DeskQuote = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSurfaceMaterial = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ErrProv_DeskQuote)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturnToMainMenu
            // 
            this.btnReturnToMainMenu.AutoSize = true;
            this.btnReturnToMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnToMainMenu.Location = new System.Drawing.Point(84, 688);
            this.btnReturnToMainMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReturnToMainMenu.Name = "btnReturnToMainMenu";
            this.btnReturnToMainMenu.Size = new System.Drawing.Size(638, 77);
            this.btnReturnToMainMenu.TabIndex = 7;
            this.btnReturnToMainMenu.Text = "Cancel and Return to Menu";
            this.btnReturnToMainMenu.UseVisualStyleBackColor = true;
            this.btnReturnToMainMenu.Click += new System.EventHandler(this.BtnReturnToMainMenu_Click);
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomerName.Location = new System.Drawing.Point(346, 38);
            this.tbCustomerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCustomerName.MaximumSize = new System.Drawing.Size(448, 50);
            this.tbCustomerName.MinimumSize = new System.Drawing.Size(373, 30);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(373, 44);
            this.tbCustomerName.TabIndex = 0;
            this.tbCustomerName.WordWrap = false;
            // 
            // tbDeskWidth
            // 
            this.tbDeskWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDeskWidth.Location = new System.Drawing.Point(346, 123);
            this.tbDeskWidth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDeskWidth.MaximumSize = new System.Drawing.Size(373, 50);
            this.tbDeskWidth.MinimumSize = new System.Drawing.Size(298, 30);
            this.tbDeskWidth.Name = "tbDeskWidth";
            this.tbDeskWidth.Size = new System.Drawing.Size(373, 44);
            this.tbDeskWidth.TabIndex = 1;
            this.tbDeskWidth.WordWrap = false;
            this.tbDeskWidth.Validating += new System.ComponentModel.CancelEventHandler(this.TbDeskWidth_Validating);
            // 
            // tbDeskDepth
            // 
            this.tbDeskDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDeskDepth.Location = new System.Drawing.Point(346, 208);
            this.tbDeskDepth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDeskDepth.MaximumSize = new System.Drawing.Size(448, 50);
            this.tbDeskDepth.MinimumSize = new System.Drawing.Size(298, 30);
            this.tbDeskDepth.Name = "tbDeskDepth";
            this.tbDeskDepth.Size = new System.Drawing.Size(373, 44);
            this.tbDeskDepth.TabIndex = 2;
            this.tbDeskDepth.WordWrap = false;
            this.tbDeskDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbDeskDepth_KeyPress);
            this.tbDeskDepth.Validating += new System.ComponentModel.CancelEventHandler(this.TbDeskDepth_Validating);
            // 
            // cmbRushDays
            // 
            this.cmbRushDays.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbRushDays.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRushDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRushDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRushDays.FormattingEnabled = true;
            this.cmbRushDays.Items.AddRange(new object[] {
            "0",
            "3",
            "5",
            "7"});
            this.cmbRushDays.Location = new System.Drawing.Point(346, 458);
            this.cmbRushDays.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbRushDays.Name = "cmbRushDays";
            this.cmbRushDays.Size = new System.Drawing.Size(373, 45);
            this.cmbRushDays.TabIndex = 5;
            // 
            // cmbNumDrawers
            // 
            this.cmbNumDrawers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbNumDrawers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbNumDrawers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNumDrawers.FormattingEnabled = true;
            this.cmbNumDrawers.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cmbNumDrawers.Location = new System.Drawing.Point(346, 292);
            this.cmbNumDrawers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbNumDrawers.MaxDropDownItems = 24;
            this.cmbNumDrawers.Name = "cmbNumDrawers";
            this.cmbNumDrawers.Size = new System.Drawing.Size(373, 45);
            this.cmbNumDrawers.TabIndex = 3;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(78, 45);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(219, 32);
            this.lblCustomerName.TabIndex = 6;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblDeskWidth
            // 
            this.lblDeskWidth.AutoSize = true;
            this.lblDeskWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeskWidth.Location = new System.Drawing.Point(78, 131);
            this.lblDeskWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeskWidth.Name = "lblDeskWidth";
            this.lblDeskWidth.Size = new System.Drawing.Size(207, 32);
            this.lblDeskWidth.TabIndex = 7;
            this.lblDeskWidth.Text = "Desk Width (in)";
            // 
            // lblDeskDepth
            // 
            this.lblDeskDepth.AutoSize = true;
            this.lblDeskDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeskDepth.Location = new System.Drawing.Point(78, 217);
            this.lblDeskDepth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeskDepth.Name = "lblDeskDepth";
            this.lblDeskDepth.Size = new System.Drawing.Size(210, 32);
            this.lblDeskDepth.TabIndex = 8;
            this.lblDeskDepth.Text = "Desk Depth (in)";
            // 
            // lblNumDrawers
            // 
            this.lblNumDrawers.AutoSize = true;
            this.lblNumDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumDrawers.Location = new System.Drawing.Point(78, 303);
            this.lblNumDrawers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumDrawers.Name = "lblNumDrawers";
            this.lblNumDrawers.Size = new System.Drawing.Size(257, 32);
            this.lblNumDrawers.TabIndex = 9;
            this.lblNumDrawers.Text = "Number of Drawers";
            // 
            // lblRushOrder
            // 
            this.lblRushOrder.AutoSize = true;
            this.lblRushOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRushOrder.Location = new System.Drawing.Point(78, 466);
            this.lblRushOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRushOrder.Name = "lblRushOrder";
            this.lblRushOrder.Size = new System.Drawing.Size(245, 32);
            this.lblRushOrder.TabIndex = 10;
            this.lblRushOrder.Text = "Rush Order (days)";
            // 
            // btnSaveQuote
            // 
            this.btnSaveQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveQuote.Location = new System.Drawing.Point(84, 582);
            this.btnSaveQuote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveQuote.Name = "btnSaveQuote";
            this.btnSaveQuote.Size = new System.Drawing.Size(638, 77);
            this.btnSaveQuote.TabIndex = 6;
            this.btnSaveQuote.Text = "Save Quote and Return to Menu";
            this.btnSaveQuote.UseVisualStyleBackColor = true;
            this.btnSaveQuote.Click += new System.EventHandler(this.BtnSaveQuote_Click);
            // 
            // ErrProv_DeskQuote
            // 
            this.ErrProv_DeskQuote.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 385);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Surface Material";
            // 
            // cmbSurfaceMaterial
            // 
            this.cmbSurfaceMaterial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSurfaceMaterial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSurfaceMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSurfaceMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSurfaceMaterial.FormattingEnabled = true;
            this.cmbSurfaceMaterial.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.cmbSurfaceMaterial.Location = new System.Drawing.Point(346, 374);
            this.cmbSurfaceMaterial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSurfaceMaterial.MaxDropDownItems = 24;
            this.cmbSurfaceMaterial.Name = "cmbSurfaceMaterial";
            this.cmbSurfaceMaterial.Size = new System.Drawing.Size(373, 45);
            this.cmbSurfaceMaterial.TabIndex = 4;
            this.cmbSurfaceMaterial.SelectedIndexChanged += new System.EventHandler(this.cmbSurfaceMaterial_SelectedIndexChanged);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 806);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSurfaceMaterial);
            this.Controls.Add(this.btnSaveQuote);
            this.Controls.Add(this.lblRushOrder);
            this.Controls.Add(this.lblNumDrawers);
            this.Controls.Add(this.lblDeskDepth);
            this.Controls.Add(this.lblDeskWidth);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.cmbNumDrawers);
            this.Controls.Add(this.cmbRushDays);
            this.Controls.Add(this.tbDeskDepth);
            this.Controls.Add(this.tbDeskWidth);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.btnReturnToMainMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddQuote_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ErrProv_DeskQuote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturnToMainMenu;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.TextBox tbDeskWidth;
        private System.Windows.Forms.TextBox tbDeskDepth;
        private System.Windows.Forms.ComboBox cmbRushDays;
        private System.Windows.Forms.ComboBox cmbNumDrawers;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblDeskWidth;
        private System.Windows.Forms.Label lblDeskDepth;
        private System.Windows.Forms.Label lblNumDrawers;
        private System.Windows.Forms.Label lblRushOrder;
        private System.Windows.Forms.Button btnSaveQuote;
        private System.Windows.Forms.ErrorProvider ErrProv_DeskQuote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSurfaceMaterial;
    }
}