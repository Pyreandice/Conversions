namespace Conversions_Homework_9_GraysonBeam
{
    partial class MainForm
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
            this.DataEntryTextBox = new System.Windows.Forms.TextBox();
            this.DataEntryTextBoxLabel = new System.Windows.Forms.Label();
            this.ConversionComboBox = new System.Windows.Forms.ComboBox();
            this.ConversionComboBoxLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.AddEditButton = new System.Windows.Forms.Button();
            this.OutputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // DataEntryTextBox
            // 
            this.DataEntryTextBox.Location = new System.Drawing.Point(210, 75);
            this.DataEntryTextBox.Name = "DataEntryTextBox";
            this.DataEntryTextBox.Size = new System.Drawing.Size(100, 20);
            this.DataEntryTextBox.TabIndex = 0;
            // 
            // DataEntryTextBoxLabel
            // 
            this.DataEntryTextBoxLabel.AutoSize = true;
            this.DataEntryTextBoxLabel.Location = new System.Drawing.Point(72, 78);
            this.DataEntryTextBoxLabel.Name = "DataEntryTextBoxLabel";
            this.DataEntryTextBoxLabel.Size = new System.Drawing.Size(124, 13);
            this.DataEntryTextBoxLabel.TabIndex = 1;
            this.DataEntryTextBoxLabel.Text = "Enter Number to Convert";
            // 
            // ConversionComboBox
            // 
            this.ConversionComboBox.FormattingEnabled = true;
            this.ConversionComboBox.Location = new System.Drawing.Point(210, 127);
            this.ConversionComboBox.Name = "ConversionComboBox";
            this.ConversionComboBox.Size = new System.Drawing.Size(100, 21);
            this.ConversionComboBox.TabIndex = 2;
            // 
            // ConversionComboBoxLabel
            // 
            this.ConversionComboBoxLabel.AutoSize = true;
            this.ConversionComboBoxLabel.Location = new System.Drawing.Point(103, 130);
            this.ConversionComboBoxLabel.Name = "ConversionComboBoxLabel";
            this.ConversionComboBoxLabel.Size = new System.Drawing.Size(93, 13);
            this.ConversionComboBoxLabel.TabIndex = 3;
            this.ConversionComboBoxLabel.Text = "Select Conversion";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(210, 184);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 4;
            this.CalculateButton.Text = "Convert";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // AddEditButton
            // 
            this.AddEditButton.Location = new System.Drawing.Point(75, 184);
            this.AddEditButton.Name = "AddEditButton";
            this.AddEditButton.Size = new System.Drawing.Size(75, 23);
            this.AddEditButton.TabIndex = 5;
            this.AddEditButton.Text = "Add / Edit";
            this.AddEditButton.UseVisualStyleBackColor = true;
            this.AddEditButton.Click += new System.EventHandler(this.AddEditButton_Click);
            // 
            // OutputRichTextBox
            // 
            this.OutputRichTextBox.Location = new System.Drawing.Point(75, 257);
            this.OutputRichTextBox.Name = "OutputRichTextBox";
            this.OutputRichTextBox.Size = new System.Drawing.Size(235, 129);
            this.OutputRichTextBox.TabIndex = 6;
            this.OutputRichTextBox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 424);
            this.Controls.Add(this.OutputRichTextBox);
            this.Controls.Add(this.AddEditButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.ConversionComboBoxLabel);
            this.Controls.Add(this.ConversionComboBox);
            this.Controls.Add(this.DataEntryTextBoxLabel);
            this.Controls.Add(this.DataEntryTextBox);
            this.Name = "MainForm";
            this.Text = "Unit Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DataEntryTextBox;
        private System.Windows.Forms.Label DataEntryTextBoxLabel;
        private System.Windows.Forms.ComboBox ConversionComboBox;
        private System.Windows.Forms.Label ConversionComboBoxLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button AddEditButton;
        private System.Windows.Forms.RichTextBox OutputRichTextBox;
    }
}

