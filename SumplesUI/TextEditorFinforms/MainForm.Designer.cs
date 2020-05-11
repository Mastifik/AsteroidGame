namespace TextEditorFinforms
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ServiceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProgramsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTextBox = new System.Windows.Forms.TextBox();
            this.Открыть = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.ServiceMenuItem,
            this.HelpMenuItem,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(667, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateMenuItem,
            this.OpenMenuItem,
            this.SaveMenuItem,
            this.toolStripMenuItem1,
            this.ExitMenuItem});
            this.FileMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileMenuItem.Text = "Файл";
            // 
            // CreateMenuItem
            // 
            this.CreateMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CreateMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.CreateMenuItem.Name = "CreateMenuItem";
            this.CreateMenuItem.Size = new System.Drawing.Size(133, 22);
            this.CreateMenuItem.Text = "Создать";
            // 
            // OpenMenuItem
            // 
            this.OpenMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.OpenMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.OpenMenuItem.Name = "OpenMenuItem";
            this.OpenMenuItem.Size = new System.Drawing.Size(133, 22);
            this.OpenMenuItem.Text = "Открыть";
            this.OpenMenuItem.Click += new System.EventHandler(this.OpenMenuItem_Click);
            // 
            // SaveMenuItem
            // 
            this.SaveMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.SaveMenuItem.Name = "SaveMenuItem";
            this.SaveMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SaveMenuItem.Text = "Сохранить";
            this.SaveMenuItem.Click += new System.EventHandler(this.SaveMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(130, 6);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(133, 22);
            this.ExitMenuItem.Text = "Выход";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // ServiceMenuItem
            // 
            this.ServiceMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.ServiceMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsMenuItem});
            this.ServiceMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ServiceMenuItem.Name = "ServiceMenuItem";
            this.ServiceMenuItem.Size = new System.Drawing.Size(59, 20);
            this.ServiceMenuItem.Text = "Сервис";
            // 
            // SettingsMenuItem
            // 
            this.SettingsMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.SettingsMenuItem.Name = "SettingsMenuItem";
            this.SettingsMenuItem.Size = new System.Drawing.Size(134, 22);
            this.SettingsMenuItem.Text = "Настройки";
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.HelpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgramsMenuItem});
            this.HelpMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(68, 20);
            this.HelpMenuItem.Text = "Помощь";
            // 
            // ProgramsMenuItem
            // 
            this.ProgramsMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ProgramsMenuItem.Name = "ProgramsMenuItem";
            this.ProgramsMenuItem.Size = new System.Drawing.Size(149, 22);
            this.ProgramsMenuItem.Text = "О программе";
            // 
            // MainTextBox
            // 
            this.MainTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.MainTextBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.MainTextBox.Location = new System.Drawing.Point(0, 65);
            this.MainTextBox.Multiline = true;
            this.MainTextBox.Name = "MainTextBox";
            this.MainTextBox.Size = new System.Drawing.Size(667, 395);
            this.MainTextBox.TabIndex = 1;
            this.MainTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Открыть
            // 
            this.Открыть.ForeColor = System.Drawing.SystemColors.Control;
            this.Открыть.Location = new System.Drawing.Point(12, 27);
            this.Открыть.Name = "Открыть";
            this.Открыть.Size = new System.Drawing.Size(118, 32);
            this.Открыть.TabIndex = 2;
            this.Открыть.Text = "Открыть";
            this.Открыть.UseVisualStyleBackColor = true;
            this.Открыть.Click += new System.EventHandler(this.OpenMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(537, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SaveMenuItem_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            this.OpenFile.RestoreDirectory = true;
            this.OpenFile.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFile_FileOk);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem2.Text = " ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 457);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Открыть);
            this.Controls.Add(this.MainTextBox);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1080, 650);
            this.MinimumSize = new System.Drawing.Size(350, 290);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ServiceMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProgramsMenuItem;
        private System.Windows.Forms.TextBox MainTextBox;
        private System.Windows.Forms.Button Открыть;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

