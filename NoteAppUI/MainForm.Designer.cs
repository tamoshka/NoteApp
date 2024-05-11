namespace NoteAppUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeleteNote = new System.Windows.Forms.Button();
            this.EditNote = new System.Windows.Forms.Button();
            this.AddNote = new System.Windows.Forms.Button();
            this.ShowCategoryCombo = new System.Windows.Forms.ComboBox();
            this.NotesListBox = new System.Windows.Forms.ListBox();
            this.showCategoryLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.dateTimePickerModified = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCreated = new System.Windows.Forms.DateTimePicker();
            this.labelModified = new System.Windows.Forms.Label();
            this.labelCreated = new System.Windows.Forms.Label();
            this.labelCurentCategory = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelСategory = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DeleteNote);
            this.panel1.Controls.Add(this.EditNote);
            this.panel1.Controls.Add(this.AddNote);
            this.panel1.Controls.Add(this.ShowCategoryCombo);
            this.panel1.Controls.Add(this.NotesListBox);
            this.panel1.Controls.Add(this.showCategoryLabel);
            this.panel1.Location = new System.Drawing.Point(14, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 837);
            this.panel1.TabIndex = 0;
            // 
            // DeleteNote
            // 
            this.DeleteNote.BackgroundImage = global::NoteAppUI.Properties.Resources.DeleteContactIconContrast_512x512;
            this.DeleteNote.Location = new System.Drawing.Point(140, 766);
            this.DeleteNote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeleteNote.Name = "DeleteNote";
            this.DeleteNote.Size = new System.Drawing.Size(58, 66);
            this.DeleteNote.TabIndex = 0;
            this.DeleteNote.UseVisualStyleBackColor = true;
            this.DeleteNote.Click += new System.EventHandler(this.DeleteNote_Click);
            // 
            // EditNote
            // 
            this.EditNote.BackgroundImage = global::NoteAppUI.Properties.Resources.EditContactIconContrast_512x512;
            this.EditNote.Location = new System.Drawing.Point(70, 766);
            this.EditNote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditNote.Name = "EditNote";
            this.EditNote.Size = new System.Drawing.Size(60, 66);
            this.EditNote.TabIndex = 0;
            this.EditNote.UseVisualStyleBackColor = true;
            this.EditNote.Click += new System.EventHandler(this.EditNote_Click);
            // 
            // AddNote
            // 
            this.AddNote.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddNote.BackgroundImage")));
            this.AddNote.Location = new System.Drawing.Point(3, 765);
            this.AddNote.Name = "AddNote";
            this.AddNote.Size = new System.Drawing.Size(62, 68);
            this.AddNote.TabIndex = 0;
            this.AddNote.UseVisualStyleBackColor = true;
            this.AddNote.Click += new System.EventHandler(this.AddNote_Click);
            // 
            // ShowCategoryCombo
            // 
            this.ShowCategoryCombo.FormattingEnabled = true;
            this.ShowCategoryCombo.Location = new System.Drawing.Point(122, 9);
            this.ShowCategoryCombo.Name = "ShowCategoryCombo";
            this.ShowCategoryCombo.Size = new System.Drawing.Size(248, 28);
            this.ShowCategoryCombo.TabIndex = 0;
            this.ShowCategoryCombo.SelectedIndexChanged += new System.EventHandler(this.ShowCategoryCombo_SelectedIndexChanged);
            this.ShowCategoryCombo.TextChanged += new System.EventHandler(this.ShowCategoryCombo_TextChanged);
            // 
            // NotesListBox
            // 
            this.NotesListBox.FormattingEnabled = true;
            this.NotesListBox.ItemHeight = 20;
            this.NotesListBox.Location = new System.Drawing.Point(8, 48);
            this.NotesListBox.Name = "NotesListBox";
            this.NotesListBox.Size = new System.Drawing.Size(362, 664);
            this.NotesListBox.TabIndex = 0;
            this.NotesListBox.SelectedIndexChanged += new System.EventHandler(this.NotesListBox_SelectedIndexChanged);
            // 
            // showCategoryLabel
            // 
            this.showCategoryLabel.AutoSize = true;
            this.showCategoryLabel.Location = new System.Drawing.Point(3, 12);
            this.showCategoryLabel.Name = "showCategoryLabel";
            this.showCategoryLabel.Size = new System.Drawing.Size(113, 20);
            this.showCategoryLabel.TabIndex = 0;
            this.showCategoryLabel.Text = "ShowCategory";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.textBoxText);
            this.panel2.Controls.Add(this.dateTimePickerModified);
            this.panel2.Controls.Add(this.dateTimePickerCreated);
            this.panel2.Controls.Add(this.labelModified);
            this.panel2.Controls.Add(this.labelCreated);
            this.panel2.Controls.Add(this.labelCurentCategory);
            this.panel2.Controls.Add(this.labelName);
            this.panel2.Controls.Add(this.labelСategory);
            this.panel2.Location = new System.Drawing.Point(394, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(822, 837);
            this.panel2.TabIndex = 1;
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(26, 172);
            this.textBoxText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.ReadOnly = true;
            this.textBoxText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxText.Size = new System.Drawing.Size(766, 621);
            this.textBoxText.TabIndex = 7;
            // 
            // dateTimePickerModified
            // 
            this.dateTimePickerModified.Location = new System.Drawing.Point(476, 132);
            this.dateTimePickerModified.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerModified.Name = "dateTimePickerModified";
            this.dateTimePickerModified.Size = new System.Drawing.Size(205, 26);
            this.dateTimePickerModified.TabIndex = 6;
            this.dateTimePickerModified.ValueChanged += new System.EventHandler(this.dateTimePickerModified_ValueChanged);
            // 
            // dateTimePickerCreated
            // 
            this.dateTimePickerCreated.Location = new System.Drawing.Point(118, 132);
            this.dateTimePickerCreated.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerCreated.Name = "dateTimePickerCreated";
            this.dateTimePickerCreated.Size = new System.Drawing.Size(205, 26);
            this.dateTimePickerCreated.TabIndex = 5;
            this.dateTimePickerCreated.ValueChanged += new System.EventHandler(this.dateTimePickerCreated_ValueChanged);
            // 
            // labelModified
            // 
            this.labelModified.AutoSize = true;
            this.labelModified.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelModified.Location = new System.Drawing.Point(370, 132);
            this.labelModified.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelModified.Name = "labelModified";
            this.labelModified.Size = new System.Drawing.Size(107, 29);
            this.labelModified.TabIndex = 4;
            this.labelModified.Text = "Modified";
            // 
            // labelCreated
            // 
            this.labelCreated.AutoSize = true;
            this.labelCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCreated.Location = new System.Drawing.Point(21, 132);
            this.labelCreated.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCreated.Name = "labelCreated";
            this.labelCreated.Size = new System.Drawing.Size(111, 29);
            this.labelCreated.TabIndex = 3;
            this.labelCreated.Text = "Created: ";
            // 
            // labelCurentCategory
            // 
            this.labelCurentCategory.AutoSize = true;
            this.labelCurentCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurentCategory.Location = new System.Drawing.Point(138, 80);
            this.labelCurentCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurentCategory.Name = "labelCurentCategory";
            this.labelCurentCategory.Size = new System.Drawing.Size(134, 29);
            this.labelCurentCategory.TabIndex = 2;
            this.labelCurentCategory.Text = "Категория";
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(202, 12);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(394, 47);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Название заметки";
            // 
            // labelСategory
            // 
            this.labelСategory.AutoSize = true;
            this.labelСategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelСategory.Location = new System.Drawing.Point(21, 80);
            this.labelСategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelСategory.Name = "labelСategory";
            this.labelСategory.Size = new System.Drawing.Size(116, 29);
            this.labelСategory.TabIndex = 0;
            this.labelСategory.Text = "Category:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1233, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.exitToolStripMenuItem.Text = "Exit...";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNoteToolStripMenuItem,
            this.editNoteToolStripMenuItem,
            this.removeNoteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addNoteToolStripMenuItem
            // 
            this.addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
            this.addNoteToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.addNoteToolStripMenuItem.Text = "AddNote";
            this.addNoteToolStripMenuItem.Click += new System.EventHandler(this.AddNote_Click);
            // 
            // editNoteToolStripMenuItem
            // 
            this.editNoteToolStripMenuItem.Name = "editNoteToolStripMenuItem";
            this.editNoteToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.editNoteToolStripMenuItem.Text = "EditNote";
            this.editNoteToolStripMenuItem.Click += new System.EventHandler(this.EditNote_Click);
            // 
            // removeNoteToolStripMenuItem
            // 
            this.removeNoteToolStripMenuItem.Name = "removeNoteToolStripMenuItem";
            this.removeNoteToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.removeNoteToolStripMenuItem.Text = "RemoveNote";
            this.removeNoteToolStripMenuItem.Click += new System.EventHandler(this.DeleteNote_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(207, 34);
            this.aboutToolStripMenuItem1.Text = "About...";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 909);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Заметки";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ComboBox ShowCategoryCombo;
        private System.Windows.Forms.Label showCategoryLabel;
        private System.Windows.Forms.Button AddNote;
        private System.Windows.Forms.ListBox NotesListBox;
        private System.Windows.Forms.Button DeleteNote;
        private System.Windows.Forms.Button EditNote;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelСategory;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.DateTimePicker dateTimePickerModified;
        private System.Windows.Forms.DateTimePicker dateTimePickerCreated;
        private System.Windows.Forms.Label labelModified;
        private System.Windows.Forms.Label labelCreated;
        private System.Windows.Forms.Label labelCurentCategory;
    }
}

