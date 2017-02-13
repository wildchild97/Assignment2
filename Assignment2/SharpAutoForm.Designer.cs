namespace Assignment2
{
    partial class SharpAutoForm
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
            this.TradeTextBox = new System.Windows.Forms.TextBox();
            this.BasePriceTextBox = new System.Windows.Forms.TextBox();
            this.BasePriceLabel = new System.Windows.Forms.Label();
            this.TradeLabel = new System.Windows.Forms.Label();
            this.AdditionalLabel = new System.Windows.Forms.Label();
            this.AdditionalTextBox = new System.Windows.Forms.TextBox();
            this.TaxTextBox = new System.Windows.Forms.TextBox();
            this.SubTotalTextBox = new System.Windows.Forms.TextBox();
            this.AmountDueTextBox = new System.Windows.Forms.TextBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.SubTotalLabel = new System.Windows.Forms.Label();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.AmountDueLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AdditionalGroupBox = new System.Windows.Forms.GroupBox();
            this.NavigationCheckBox = new System.Windows.Forms.CheckBox();
            this.InteriorCheckBox = new System.Windows.Forms.CheckBox();
            this.StereoCheckBox = new System.Windows.Forms.CheckBox();
            this.ExteriorGroupBox = new System.Windows.Forms.GroupBox();
            this.CustomRadioButton = new System.Windows.Forms.RadioButton();
            this.PearlizedRadioButton = new System.Windows.Forms.RadioButton();
            this.StandardRadioButton = new System.Windows.Forms.RadioButton();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.AdditionalGroupBox.SuspendLayout();
            this.ExteriorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // TradeTextBox
            // 
            this.TradeTextBox.Location = new System.Drawing.Point(114, 318);
            this.TradeTextBox.Name = "TradeTextBox";
            this.TradeTextBox.ShortcutsEnabled = false;
            this.TradeTextBox.Size = new System.Drawing.Size(100, 20);
            this.TradeTextBox.TabIndex = 1;
            this.TradeTextBox.Text = "0";
            this.TradeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TradeTextBox.MouseCaptureChanged += new System.EventHandler(this.TradeTextBox_MouseCaptureChanged);
            // 
            // BasePriceTextBox
            // 
            this.BasePriceTextBox.Location = new System.Drawing.Point(114, 40);
            this.BasePriceTextBox.Name = "BasePriceTextBox";
            this.BasePriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.BasePriceTextBox.TabIndex = 0;
            this.BasePriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BasePriceTextBox.MouseCaptureChanged += new System.EventHandler(this.BasePriceTextBox_TextChanged);
            // 
            // BasePriceLabel
            // 
            this.BasePriceLabel.AutoSize = true;
            this.BasePriceLabel.Location = new System.Drawing.Point(12, 43);
            this.BasePriceLabel.Name = "BasePriceLabel";
            this.BasePriceLabel.Size = new System.Drawing.Size(61, 13);
            this.BasePriceLabel.TabIndex = 2;
            this.BasePriceLabel.Text = "Base Price:";
            // 
            // TradeLabel
            // 
            this.TradeLabel.AutoSize = true;
            this.TradeLabel.Location = new System.Drawing.Point(12, 321);
            this.TradeLabel.Name = "TradeLabel";
            this.TradeLabel.Size = new System.Drawing.Size(101, 13);
            this.TradeLabel.TabIndex = 3;
            this.TradeLabel.Text = "Trade-in Allowance:";
            // 
            // AdditionalLabel
            // 
            this.AdditionalLabel.AutoSize = true;
            this.AdditionalLabel.Location = new System.Drawing.Point(12, 196);
            this.AdditionalLabel.Name = "AdditionalLabel";
            this.AdditionalLabel.Size = new System.Drawing.Size(95, 13);
            this.AdditionalLabel.TabIndex = 4;
            this.AdditionalLabel.Text = "Additional Options:";
            // 
            // AdditionalTextBox
            // 
            this.AdditionalTextBox.Location = new System.Drawing.Point(114, 193);
            this.AdditionalTextBox.Name = "AdditionalTextBox";
            this.AdditionalTextBox.ReadOnly = true;
            this.AdditionalTextBox.Size = new System.Drawing.Size(100, 20);
            this.AdditionalTextBox.TabIndex = 5;
            this.AdditionalTextBox.Text = "1000";
            this.AdditionalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TaxTextBox
            // 
            this.TaxTextBox.Location = new System.Drawing.Point(114, 252);
            this.TaxTextBox.Name = "TaxTextBox";
            this.TaxTextBox.ReadOnly = true;
            this.TaxTextBox.Size = new System.Drawing.Size(100, 20);
            this.TaxTextBox.TabIndex = 6;
            this.TaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SubTotalTextBox
            // 
            this.SubTotalTextBox.Location = new System.Drawing.Point(114, 222);
            this.SubTotalTextBox.Name = "SubTotalTextBox";
            this.SubTotalTextBox.ReadOnly = true;
            this.SubTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.SubTotalTextBox.TabIndex = 7;
            this.SubTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AmountDueTextBox
            // 
            this.AmountDueTextBox.Location = new System.Drawing.Point(114, 353);
            this.AmountDueTextBox.Name = "AmountDueTextBox";
            this.AmountDueTextBox.ReadOnly = true;
            this.AmountDueTextBox.Size = new System.Drawing.Size(100, 20);
            this.AmountDueTextBox.TabIndex = 8;
            this.AmountDueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(114, 285);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalTextBox.TabIndex = 9;
            this.TotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SubTotalLabel
            // 
            this.SubTotalLabel.AutoSize = true;
            this.SubTotalLabel.Location = new System.Drawing.Point(12, 225);
            this.SubTotalLabel.Name = "SubTotalLabel";
            this.SubTotalLabel.Size = new System.Drawing.Size(53, 13);
            this.SubTotalLabel.TabIndex = 10;
            this.SubTotalLabel.Text = "SubTotal:";
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.AutoSize = true;
            this.SalesTaxLabel.Location = new System.Drawing.Point(12, 255);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(57, 13);
            this.SalesTaxLabel.TabIndex = 11;
            this.SalesTaxLabel.Text = "Sales Tax:";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(12, 288);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(34, 13);
            this.TotalLabel.TabIndex = 12;
            this.TotalLabel.Text = "Total:";
            // 
            // AmountDueLabel
            // 
            this.AmountDueLabel.AutoSize = true;
            this.AmountDueLabel.Location = new System.Drawing.Point(16, 356);
            this.AmountDueLabel.Name = "AmountDueLabel";
            this.AmountDueLabel.Size = new System.Drawing.Size(69, 13);
            this.AmountDueLabel.TabIndex = 13;
            this.AmountDueLabel.Text = "Amount Due:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.editToolStripMenuItem1,
            this.helpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(348, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "&File";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(126, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.exitToolStripMenuItem1.Text = "E&xit";
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.toolStripSeparator3,
            this.fontToolStripMenuItem,
            this.colourToolStripMenuItem});
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem1.Text = "&Edit";
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.calculateToolStripMenuItem.Text = "&Calculate";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.clearToolStripMenuItem.Text = "C&lear";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(158, 6);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.fontToolStripMenuItem.Text = "&Font";
            // 
            // colourToolStripMenuItem
            // 
            this.colourToolStripMenuItem.Name = "colourToolStripMenuItem";
            this.colourToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.colourToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.colourToolStripMenuItem.Text = "C&olour";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem1});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem1.Text = "&Help";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(155, 6);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.aboutToolStripMenuItem1.Text = "&About...";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // AdditionalGroupBox
            // 
            this.AdditionalGroupBox.Controls.Add(this.NavigationCheckBox);
            this.AdditionalGroupBox.Controls.Add(this.InteriorCheckBox);
            this.AdditionalGroupBox.Controls.Add(this.StereoCheckBox);
            this.AdditionalGroupBox.Location = new System.Drawing.Point(166, 70);
            this.AdditionalGroupBox.Name = "AdditionalGroupBox";
            this.AdditionalGroupBox.Size = new System.Drawing.Size(133, 100);
            this.AdditionalGroupBox.TabIndex = 15;
            this.AdditionalGroupBox.TabStop = false;
            this.AdditionalGroupBox.Text = "Additional Items";
            // 
            // NavigationCheckBox
            // 
            this.NavigationCheckBox.AutoCheck = false;
            this.NavigationCheckBox.AutoSize = true;
            this.NavigationCheckBox.Location = new System.Drawing.Point(7, 76);
            this.NavigationCheckBox.Name = "NavigationCheckBox";
            this.NavigationCheckBox.Size = new System.Drawing.Size(125, 17);
            this.NavigationCheckBox.TabIndex = 2;
            this.NavigationCheckBox.Text = "Computer Navigation";
            this.NavigationCheckBox.UseVisualStyleBackColor = true;
            this.NavigationCheckBox.CheckedChanged += new System.EventHandler(this._navigationCheckBox_CheckedChanged);
            // 
            // InteriorCheckBox
            // 
            this.InteriorCheckBox.AutoCheck = false;
            this.InteriorCheckBox.AutoSize = true;
            this.InteriorCheckBox.Location = new System.Drawing.Point(7, 53);
            this.InteriorCheckBox.Name = "InteriorCheckBox";
            this.InteriorCheckBox.Size = new System.Drawing.Size(97, 17);
            this.InteriorCheckBox.TabIndex = 1;
            this.InteriorCheckBox.Text = "Leather Interior";
            this.InteriorCheckBox.UseVisualStyleBackColor = true;
            this.InteriorCheckBox.CheckedChanged += new System.EventHandler(this._interiorCheckBox_CheckedChanged);
            // 
            // StereoCheckBox
            // 
            this.StereoCheckBox.AutoCheck = false;
            this.StereoCheckBox.AutoSize = true;
            this.StereoCheckBox.Location = new System.Drawing.Point(7, 29);
            this.StereoCheckBox.Name = "StereoCheckBox";
            this.StereoCheckBox.Size = new System.Drawing.Size(94, 17);
            this.StereoCheckBox.TabIndex = 0;
            this.StereoCheckBox.Text = "Stereo System";
            this.StereoCheckBox.UseVisualStyleBackColor = true;
            this.StereoCheckBox.CheckedChanged += new System.EventHandler(this._stereoCheckBox_CheckedChanged);
            // 
            // ExteriorGroupBox
            // 
            this.ExteriorGroupBox.Controls.Add(this.CustomRadioButton);
            this.ExteriorGroupBox.Controls.Add(this.PearlizedRadioButton);
            this.ExteriorGroupBox.Controls.Add(this.StandardRadioButton);
            this.ExteriorGroupBox.Location = new System.Drawing.Point(12, 70);
            this.ExteriorGroupBox.Name = "ExteriorGroupBox";
            this.ExteriorGroupBox.Size = new System.Drawing.Size(132, 100);
            this.ExteriorGroupBox.TabIndex = 16;
            this.ExteriorGroupBox.TabStop = false;
            this.ExteriorGroupBox.Text = "Exterior Finish";
            // 
            // CustomRadioButton
            // 
            this.CustomRadioButton.AutoSize = true;
            this.CustomRadioButton.Location = new System.Drawing.Point(7, 77);
            this.CustomRadioButton.Name = "CustomRadioButton";
            this.CustomRadioButton.Size = new System.Drawing.Size(104, 17);
            this.CustomRadioButton.TabIndex = 2;
            this.CustomRadioButton.Text = "Custom Detailing";
            this.CustomRadioButton.UseVisualStyleBackColor = true;
            this.CustomRadioButton.CheckedChanged += new System.EventHandler(this._sharpAutoRadioButton_CheckedChanged);
            // 
            // PearlizedRadioButton
            // 
            this.PearlizedRadioButton.AutoSize = true;
            this.PearlizedRadioButton.Location = new System.Drawing.Point(6, 54);
            this.PearlizedRadioButton.Name = "PearlizedRadioButton";
            this.PearlizedRadioButton.Size = new System.Drawing.Size(68, 17);
            this.PearlizedRadioButton.TabIndex = 1;
            this.PearlizedRadioButton.Text = "Pearlized";
            this.PearlizedRadioButton.UseVisualStyleBackColor = true;
            this.PearlizedRadioButton.CheckedChanged += new System.EventHandler(this._sharpAutoRadioButton_CheckedChanged);
            // 
            // StandardRadioButton
            // 
            this.StandardRadioButton.AutoSize = true;
            this.StandardRadioButton.Checked = true;
            this.StandardRadioButton.Location = new System.Drawing.Point(6, 31);
            this.StandardRadioButton.Name = "StandardRadioButton";
            this.StandardRadioButton.Size = new System.Drawing.Size(68, 17);
            this.StandardRadioButton.TabIndex = 0;
            this.StandardRadioButton.TabStop = true;
            this.StandardRadioButton.Text = "Standard";
            this.StandardRadioButton.UseVisualStyleBackColor = true;
            this.StandardRadioButton.CheckedChanged += new System.EventHandler(this._sharpAutoRadioButton_CheckedChanged);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(15, 403);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 17;
            this.CalculateButton.Text = "&Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(135, 403);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 18;
            this.ClearButton.Text = "C&lear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(255, 403);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 19;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SharpAutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 440);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.ExteriorGroupBox);
            this.Controls.Add(this.AdditionalGroupBox);
            this.Controls.Add(this.AmountDueLabel);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.SalesTaxLabel);
            this.Controls.Add(this.SubTotalLabel);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.AmountDueTextBox);
            this.Controls.Add(this.SubTotalTextBox);
            this.Controls.Add(this.TaxTextBox);
            this.Controls.Add(this.AdditionalTextBox);
            this.Controls.Add(this.AdditionalLabel);
            this.Controls.Add(this.TradeLabel);
            this.Controls.Add(this.BasePriceLabel);
            this.Controls.Add(this.BasePriceTextBox);
            this.Controls.Add(this.TradeTextBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SharpAutoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SharpAutoForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.AdditionalGroupBox.ResumeLayout(false);
            this.AdditionalGroupBox.PerformLayout();
            this.ExteriorGroupBox.ResumeLayout(false);
            this.ExteriorGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TradeTextBox;
        private System.Windows.Forms.TextBox BasePriceTextBox;
        private System.Windows.Forms.Label BasePriceLabel;
        private System.Windows.Forms.Label TradeLabel;
        private System.Windows.Forms.Label AdditionalLabel;
        private System.Windows.Forms.TextBox AdditionalTextBox;
        private System.Windows.Forms.TextBox TaxTextBox;
        private System.Windows.Forms.TextBox SubTotalTextBox;
        private System.Windows.Forms.TextBox AmountDueTextBox;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Label SubTotalLabel;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label AmountDueLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.GroupBox AdditionalGroupBox;
        private System.Windows.Forms.CheckBox NavigationCheckBox;
        private System.Windows.Forms.CheckBox InteriorCheckBox;
        private System.Windows.Forms.CheckBox StereoCheckBox;
        private System.Windows.Forms.GroupBox ExteriorGroupBox;
        private System.Windows.Forms.RadioButton CustomRadioButton;
        private System.Windows.Forms.RadioButton PearlizedRadioButton;
        private System.Windows.Forms.RadioButton StandardRadioButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.FontDialog SharpAutoFontDialog;
    }
}

