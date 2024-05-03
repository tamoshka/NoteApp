namespace NoteAppUI
{
    partial class AddEditNoteForm
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CreatedLabel = new System.Windows.Forms.Label();
            this.LastUpdatedLabel = new System.Windows.Forms.Label();
            this.TextLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePickerCreated = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerModified = new System.Windows.Forms.DateTimePicker();
            this.TextTextBox = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(5, 15);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(52, 18);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name:";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryLabel.Location = new System.Drawing.Point(3, 50);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(72, 18);
            this.CategoryLabel.TabIndex = 1;
            this.CategoryLabel.Text = "Category:";
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.AutoSize = true;
            this.CreatedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreatedLabel.Location = new System.Drawing.Point(5, 82);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(64, 18);
            this.CreatedLabel.TabIndex = 2;
            this.CreatedLabel.Text = "Created:";
            // 
            // LastUpdatedLabel
            // 
            this.LastUpdatedLabel.AutoSize = true;
            this.LastUpdatedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastUpdatedLabel.Location = new System.Drawing.Point(262, 83);
            this.LastUpdatedLabel.Name = "LastUpdatedLabel";
            this.LastUpdatedLabel.Size = new System.Drawing.Size(68, 18);
            this.LastUpdatedLabel.TabIndex = 3;
            this.LastUpdatedLabel.Text = "Modified:";
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextLabel.Location = new System.Drawing.Point(5, 117);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(40, 18);
            this.TextLabel.TabIndex = 4;
            this.TextLabel.Text = "Text:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(81, 15);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(256, 20);
            this.NameTextBox.TabIndex = 5;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(81, 51);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(148, 21);
            this.CategoryComboBox.TabIndex = 6;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // dateTimePickerCreated
            // 
            this.dateTimePickerCreated.Location = new System.Drawing.Point(81, 83);
            this.dateTimePickerCreated.Name = "dateTimePickerCreated";
            this.dateTimePickerCreated.Size = new System.Drawing.Size(148, 20);
            this.dateTimePickerCreated.TabIndex = 7;
            this.dateTimePickerCreated.ValueChanged += new System.EventHandler(this.dateTimePickerCreated_ValueChanged);
            // 
            // dateTimePickerModified
            // 
            this.dateTimePickerModified.Location = new System.Drawing.Point(336, 83);
            this.dateTimePickerModified.Name = "dateTimePickerModified";
            this.dateTimePickerModified.Size = new System.Drawing.Size(148, 20);
            this.dateTimePickerModified.TabIndex = 8;
            this.dateTimePickerModified.ValueChanged += new System.EventHandler(this.dateTimePickerModified_ValueChanged);
            // 
            // TextTextBox
            // 
            this.TextTextBox.Location = new System.Drawing.Point(3, 138);
            this.TextTextBox.Name = "TextTextBox";
            this.TextTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextTextBox.Size = new System.Drawing.Size(542, 20);
            this.TextTextBox.TabIndex = 9;
            this.TextTextBox.TextChanged += new System.EventHandler(this.TextTextBox_TextChanged);
            // 
            // OKButton
            // 
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OKButton.Location = new System.Drawing.Point(470, 395);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(72, 43);
            this.OKButton.TabIndex = 10;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TextTextBox);
            this.panel1.Controls.Add(this.TextLabel);
            this.panel1.Controls.Add(this.NameTextBox);
            this.panel1.Controls.Add(this.CategoryComboBox);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Controls.Add(this.CategoryLabel);
            this.panel1.Controls.Add(this.dateTimePickerModified);
            this.panel1.Controls.Add(this.dateTimePickerCreated);
            this.panel1.Controls.Add(this.CreatedLabel);
            this.panel1.Controls.Add(this.LastUpdatedLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 377);
            this.panel1.TabIndex = 11;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(37, 395);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(72, 43);
            this.CancelButton.TabIndex = 12;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddEditNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 450);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.OKButton);
            this.Name = "AddEditNoteForm";
            this.Text = "Add/Edit Note";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label CreatedLabel;
        private System.Windows.Forms.Label LastUpdatedLabel;
        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePickerCreated;
        private System.Windows.Forms.DateTimePicker dateTimePickerModified;
        private System.Windows.Forms.TextBox TextTextBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CancelButton;
    }
}