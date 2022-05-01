namespace watch_complete_activity
{
    partial class Form
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
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToolStrop = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFill_a = new System.Windows.Forms.Button();
            this.btnDataSave = new System.Windows.Forms.Button();
            this.cmbActivity1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdDataPick2 = new System.Windows.Forms.ComboBox();
            this.cmdDataPick1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEntrySave = new System.Windows.Forms.Button();
            this.cmbActivity2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(790, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStrop,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStrip});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // selectToolStrop
            // 
            this.selectToolStrop.Name = "selectToolStrop";
            this.selectToolStrop.Size = new System.Drawing.Size(180, 22);
            this.selectToolStrop.Text = "Открыть";
            this.selectToolStrop.Click += new System.EventHandler(this.selectToolStrop_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Сохранить как..";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStrip
            // 
            this.exitToolStrip.Name = "exitToolStrip";
            this.exitToolStrip.Size = new System.Drawing.Size(180, 22);
            this.exitToolStrip.Text = "Выход";
            this.exitToolStrip.Click += new System.EventHandler(this.exitToolStrip_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "\t\t\t\t\t\t(Выберите данные телеметрии)"});
            this.listBox1.Location = new System.Drawing.Point(9, 148);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(766, 199);
            this.listBox1.TabIndex = 7;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFill_a);
            this.groupBox1.Controls.Add(this.btnDataSave);
            this.groupBox1.Controls.Add(this.cmbActivity1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmdDataPick2);
            this.groupBox1.Controls.Add(this.cmdDataPick1);
            this.groupBox1.Location = new System.Drawing.Point(9, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(380, 108);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Изменить активность за период";
            // 
            // btnFill_a
            // 
            this.btnFill_a.Enabled = false;
            this.btnFill_a.Location = new System.Drawing.Point(297, 32);
            this.btnFill_a.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFill_a.Name = "btnFill_a";
            this.btnFill_a.Size = new System.Drawing.Size(78, 51);
            this.btnFill_a.TabIndex = 13;
            this.btnFill_a.Text = "Заполнить все записи \"а\"";
            this.btnFill_a.UseVisualStyleBackColor = true;
            this.btnFill_a.Click += new System.EventHandler(this.btnFill_a_Click);
            // 
            // btnDataSave
            // 
            this.btnDataSave.Enabled = false;
            this.btnDataSave.Location = new System.Drawing.Point(202, 56);
            this.btnDataSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDataSave.Name = "btnDataSave";
            this.btnDataSave.Size = new System.Drawing.Size(91, 27);
            this.btnDataSave.TabIndex = 12;
            this.btnDataSave.Text = "Применить";
            this.btnDataSave.UseVisualStyleBackColor = true;
            this.btnDataSave.Click += new System.EventHandler(this.btnDataSave_Click);
            // 
            // cmbActivity1
            // 
            this.cmbActivity1.FormattingEnabled = true;
            this.cmbActivity1.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d",
            "e",
            "f"});
            this.cmbActivity1.Location = new System.Drawing.Point(202, 32);
            this.cmbActivity1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbActivity1.Name = "cmbActivity1";
            this.cmbActivity1.Size = new System.Drawing.Size(92, 21);
            this.cmbActivity1.TabIndex = 11;
            this.cmbActivity1.Text = "a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Активность";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Конец";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Начало";
            // 
            // cmdDataPick2
            // 
            this.cmdDataPick2.FormattingEnabled = true;
            this.cmdDataPick2.Location = new System.Drawing.Point(8, 76);
            this.cmdDataPick2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdDataPick2.Name = "cmdDataPick2";
            this.cmdDataPick2.Size = new System.Drawing.Size(174, 21);
            this.cmdDataPick2.TabIndex = 6;
            // 
            // cmdDataPick1
            // 
            this.cmdDataPick1.FormattingEnabled = true;
            this.cmdDataPick1.Location = new System.Drawing.Point(8, 32);
            this.cmdDataPick1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdDataPick1.Name = "cmdDataPick1";
            this.cmdDataPick1.Size = new System.Drawing.Size(174, 21);
            this.cmdDataPick1.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEntrySave);
            this.groupBox2.Controls.Add(this.cmbActivity2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(393, 36);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(381, 108);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Изменить выбранную запись";
            // 
            // btnEntrySave
            // 
            this.btnEntrySave.Enabled = false;
            this.btnEntrySave.Location = new System.Drawing.Point(243, 63);
            this.btnEntrySave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEntrySave.Name = "btnEntrySave";
            this.btnEntrySave.Size = new System.Drawing.Size(91, 27);
            this.btnEntrySave.TabIndex = 15;
            this.btnEntrySave.Text = "Применить";
            this.btnEntrySave.UseVisualStyleBackColor = true;
            this.btnEntrySave.Click += new System.EventHandler(this.btnEntrySave_Click);
            // 
            // cmbActivity2
            // 
            this.cmbActivity2.FormattingEnabled = true;
            this.cmbActivity2.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d",
            "e",
            "f"});
            this.cmbActivity2.Location = new System.Drawing.Point(243, 39);
            this.cmbActivity2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbActivity2.Name = "cmbActivity2";
            this.cmbActivity2.Size = new System.Drawing.Size(92, 21);
            this.cmbActivity2.TabIndex = 14;
            this.cmbActivity2.Text = "a";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Активность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Выбранная запись";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.textBox1.Location = new System.Drawing.Point(10, 32);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(219, 71);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "(Выберите данные телеметрии)";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 351);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(765, 19);
            this.progressBar1.TabIndex = 11;
            this.progressBar1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(11, 162);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(179, 20);
            this.textBox2.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 146);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Поиск";
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(194, 153);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 27);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Найти";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 375);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заполнение телеметрии";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectToolStrop;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStrip;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmdDataPick2;
        private System.Windows.Forms.ComboBox cmdDataPick1;
        private System.Windows.Forms.ComboBox cmbActivity1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDataSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEntrySave;
        private System.Windows.Forms.ComboBox cmbActivity2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFill_a;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearch;
    }
}

