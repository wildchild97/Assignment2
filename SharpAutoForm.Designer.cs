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
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CalculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.AdditionalGroupBox = new System.Windows.Forms.GroupBox();
            this.StereoCheckBox = new System.Windows.Forms.CheckBox();
            this.InteriorCheckBox = new System.Windows.Forms.CheckBox();
            this.NavigationCheckBox = new System.Windows.Forms.CheckBox();
            this.ExteriorGroupBox = new System.Windows.Forms.GroupBox();
            this.StandardRadioButton = new System.Windows.Forms.RadioButton();
            this.PearlizedRadioButton = new System.Windows.Forms.RadioButton();
            this.CustomRadioButton = new System.Windows.Forms.RadioButton();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.AdditionalGroupBox.SuspendLayout();
            this.ExteriorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TradeTextBox
            // 
            this.TradeTextBox.Location = new System.Drawing.Point(9, 117);
            this.TradeTextBox.Name = "TradeTextBox";
            this.TradeTextBox.Size = new System.Drawing.Size(100, 20);
            this.TradeTextBox.TabIndex = 0;
            this.TradeTextBox.Text = "0";
            this.TradeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BasePriceTextBox
            // 
            this.BasePriceTextBox.Location = new System.Drawing.Point(9, 66);
            this.BasePriceTextBox.Name = "BasePriceTextBox";
            this.BasePriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.BasePriceTextBox.TabIndex = 1;
            this.BasePriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BasePriceLabel
            // 
            this.BasePriceLabel.AutoSize = true;
            this.BasePriceLabel.Location = new System.Drawing.Point(22, 40);
            this.BasePriceLabel.Name = "BasePriceLabel";
            this.BasePriceLabel.Size = new System.Drawing.Size(58, 13);
            this.BasePriceLabel.TabIndex = 2;
            this.BasePriceLabel.Text = "Base Price";
            // 
            // TradeLabel
            // 
            this.TradeLabel.AutoSize = true;
            this.TradeLabel.Location = new System.Drawing.Point(10, 95);
            this.TradeLabel.Name = "TradeLabel";
            this.TradeLabel.Size = new System.Drawing.Size(98, 13);
            this.TradeLabel.TabIndex = 3;
            this.TradeLabel.Text = "Trade-in Allowance";
            // 
            // AdditionalLabel
            // 
            this.AdditionalLabel.AutoSize = true;
            this.AdditionalLabel.Location = new System.Drawing.Point(13, 146);
            this.AdditionalLabel.Name = "AdditionalLabel";
            this.AdditionalLabel.Size = new System.Drawing.Size(92, 13);
            this.AdditionalLabel.TabIndex = 4;
            this.AdditionalLabel.Text = "Additional Options";
            // 
            // AdditionalTextBox
            // 
            this.AdditionalTextBox.Location = new System.Drawing.Point(9, 168);
            this.AdditionalTextBox.Name = "AdditionalTextBox";
            this.AdditionalTextBox.Size = new System.Drawing.Size(100, 20);
            this.AdditionalTextBox.TabIndex = 5;
            this.AdditionalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TaxTextBox
            // 
            this.TaxTextBox.Location = new System.Drawing.Point(9, 270);
            this.TaxTextBox.Name = "TaxTextBox";
            this.TaxTextBox.ReadOnly = true;
            this.TaxTextBox.Size = new System.Drawing.Size(100, 20);
            this.TaxTextBox.TabIndex = 6;
            this.TaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TaxTextBox.TextChanged += new System.EventHandler(this.TaxTextBox_TextChanged);
            // 
            // SubTotalTextBox
            // 
            this.SubTotalTextBox.Location = new System.Drawing.Point(9, 219);
            this.SubTotalTextBox.Name = "SubTotalTextBox";
            this.SubTotalTextBox.ReadOnly = true;
            this.SubTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.SubTotalTextBox.TabIndex = 7;
            this.SubTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SubTotalTextBox.TextChanged += new System.EventHandler(this.SubTotalTextBox_TextChanged);
            // 
            // AmountDueTextBox
            // 
            this.AmountDueTextBox.Location = new System.Drawing.Point(9, 372);
            this.AmountDueTextBox.Name = "AmountDueTextBox";
            this.AmountDueTextBox.ReadOnly = true;
            this.AmountDueTextBox.Size = new System.Drawing.Size(100, 20);
            this.AmountDueTextBox.TabIndex = 8;
            this.AmountDueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AmountDueTextBox.TextChanged += new System.EventHandler(this.AmountDueTextBox_TextChanged);
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(9, 321);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalTextBox.TabIndex = 9;
            this.TotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TotalTextBox.TextChanged += new System.EventHandler(this.TotalTextBox_TextChanged);
            // 
            // SubTotalLabel
            // 
            this.SubTotalLabel.AutoSize = true;
            this.SubTotalLabel.Location = new System.Drawing.Point(34, 197);
            this.SubTotalLabel.Name = "SubTotalLabel";
            this.SubTotalLabel.Size = new System.Drawing.Size(50, 13);
            this.SubTotalLabel.TabIndex = 10;
            this.SubTotalLabel.Text = "SubTotal";
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.AutoSize = true;
            this.SalesTaxLabel.Location = new System.Drawing.Point(32, 248);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(54, 13);
            this.SalesTaxLabel.TabIndex = 11;
            this.SalesTaxLabel.Text = "Sales Tax";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(44, 299);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(31, 13);
            this.TotalLabel.TabIndex = 12;
            this.TotalLabel.Text = "Total";
            // 
            // AmountDueLabel
            // 
            this.AmountDueLabel.AutoSize = true;
            this.AmountDueLabel.Location = new System.Drawing.Point(26, 350);
            this.AmountDueLabel.Name = "AmountDueLabel";
            this.AmountDueLabel.Size = new System.Drawing.Size(66, 13);
            this.AmountDueLabel.TabIndex = 13;
            this.AmountDueLabel.Text = "Amount Due";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(419, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.FileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.ExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CalculateToolStripMenuItem,
            this.ClearToolStripMenuItem,
            this.FontToolStripMenuItem,
            this.ColourToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.EditToolStripMenuItem.Text = "Edit";
            // 
            // CalculateToolStripMenuItem
            // 
            this.CalculateToolStripMenuItem.Name = "CalculateToolStripMenuItem";
            this.CalculateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CalculateToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.CalculateToolStripMenuItem.Text = "Calculate";
            // 
            // ClearToolStripMenuItem
            // 
            this.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem";
            this.ClearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.ClearToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.ClearToolStripMenuItem.Text = "Clear";
            // 
            // FontToolStripMenuItem
            // 
            this.FontToolStripMenuItem.Name = "FontToolStripMenuItem";
            this.FontToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.FontToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.FontToolStripMenuItem.Text = "Font";
            // 
            // ColourToolStripMenuItem
            // 
            this.ColourToolStripMenuItem.Name = "ColourToolStripMenuItem";
            this.ColourToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.ColourToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.ColourToolStripMenuItem.Text = "Colour";
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.AboutToolStripMenuItem.Text = "About";
            // 
            // AdditionalGroupBox
            // 
            this.AdditionalGroupBox.Controls.Add(this.NavigationCheckBox);
            this.AdditionalGroupBox.Controls.Add(this.InteriorCheckBox);
            this.AdditionalGroupBox.Controls.Add(this.StereoCheckBox);
            this.AdditionalGroupBox.Location = new System.Drawing.Point(259, 88);
            this.AdditionalGroupBox.Name = "AdditionalGroupBox";
            this.AdditionalGroupBox.Size = new System.Drawing.Size(133, 100);
            this.AdditionalGroupBox.TabIndex = 15;
            this.AdditionalGroupBox.TabStop = false;
            this.AdditionalGroupBox.Text = "Additional Items";
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
            // 
            // ExteriorGroupBox
            // 
            this.ExteriorGroupBox.Controls.Add(this.CustomRadioButton);
            this.ExteriorGroupBox.Controls.Add(this.PearlizedRadioButton);
            this.ExteriorGroupBox.Controls.Add(this.StandardRadioButton);
            this.ExteriorGroupBox.Location = new System.Drawing.Point(259, 211);
            this.ExteriorGroupBox.Name = "ExteriorGroupBox";
            this.ExteriorGroupBox.Size = new System.Drawing.Size(132, 100);
            this.ExteriorGroupBox.TabIndex = 16;
            this.ExteriorGroupBox.TabStop = false;
            this.ExteriorGroupBox.Text = "Exterior Finish";
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
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(17, 422);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 17;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(166, 422);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 18;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(315, 422);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 19;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // SharpAutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 457);
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
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SharpAutoForm";
            this.Text = "SharpAutoForm";
            this.Load += new System.EventHandler(this.SharpAutoForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.AdditionalGroupBox.ResumeLayout(false);
            this.AdditionalGroupBox.PerformLayout();
            this.ExteriorGroupBox.ResumeLayout(false);
            this.ExteriorGroupBox.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CalculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ColourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
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
    }
}

