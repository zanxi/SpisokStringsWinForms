namespace SpisokStringsWinForms
{
    partial class Form2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_DeleteIDString = new System.Windows.Forms.Button();
            this.button_AddIDString = new System.Windows.Forms.Button();
            this.button_SaveIDString = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ValueStr = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.Label();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchText = new System.Windows.Forms.TextBox();
            this.viewSpisokStrings1 = new SpisokStringsWinForms.ViewSpisokStrings();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_SearchTextGroup = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label_CheckSpisokStrings = new System.Windows.Forms.Label();
            this.comboBox_spisokStrings = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_GroupStrings = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_IDGroup = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_SearchGroup = new System.Windows.Forms.TextBox();
            this.viewSpisokStringsGroup1 = new SpisokStringsWinForms.ViewSpisokStringsGroup();
            this.button5 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1209, 607);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1201, 574);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список строк";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.searchText);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.viewSpisokStrings1);
            this.splitContainer1.Size = new System.Drawing.Size(1195, 568);
            this.splitContainer1.SplitterDistance = 398;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button_DeleteIDString);
            this.groupBox1.Controls.Add(this.button_AddIDString);
            this.groupBox1.Controls.Add(this.button_SaveIDString);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_ValueStr);
            this.groupBox1.Controls.Add(this.Id);
            this.groupBox1.Controls.Add(this.textBox_Id);
            this.groupBox1.Location = new System.Drawing.Point(29, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 333);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбрано слово из списка";
            // 
            // button_DeleteIDString
            // 
            this.button_DeleteIDString.Location = new System.Drawing.Point(16, 253);
            this.button_DeleteIDString.Name = "button_DeleteIDString";
            this.button_DeleteIDString.Size = new System.Drawing.Size(207, 33);
            this.button_DeleteIDString.TabIndex = 6;
            this.button_DeleteIDString.Text = "Удалить из БД";
            this.button_DeleteIDString.UseVisualStyleBackColor = true;
            this.button_DeleteIDString.Click += new System.EventHandler(this.button_DeleteIDString_Click);
            // 
            // button_AddIDString
            // 
            this.button_AddIDString.Location = new System.Drawing.Point(16, 210);
            this.button_AddIDString.Name = "button_AddIDString";
            this.button_AddIDString.Size = new System.Drawing.Size(207, 37);
            this.button_AddIDString.TabIndex = 5;
            this.button_AddIDString.Text = "Добавить в БД";
            this.button_AddIDString.UseVisualStyleBackColor = true;
            this.button_AddIDString.Click += new System.EventHandler(this.button_AddIDString_Click);
            // 
            // button_SaveIDString
            // 
            this.button_SaveIDString.Location = new System.Drawing.Point(16, 168);
            this.button_SaveIDString.Name = "button_SaveIDString";
            this.button_SaveIDString.Size = new System.Drawing.Size(207, 35);
            this.button_SaveIDString.TabIndex = 4;
            this.button_SaveIDString.Text = "Сохранить в БД";
            this.button_SaveIDString.UseVisualStyleBackColor = true;
            this.button_SaveIDString.Click += new System.EventHandler(this.button_SaveIDString_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Значение";
            // 
            // textBox_ValueStr
            // 
            this.textBox_ValueStr.Location = new System.Drawing.Point(16, 118);
            this.textBox_ValueStr.Name = "textBox_ValueStr";
            this.textBox_ValueStr.Size = new System.Drawing.Size(344, 26);
            this.textBox_ValueStr.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(12, 31);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(23, 20);
            this.Id.TabIndex = 1;
            this.Id.Text = "Id";
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(16, 54);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(100, 26);
            this.textBox_Id.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Строка поиска";
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(28, 163);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(361, 26);
            this.searchText.TabIndex = 4;
            this.searchText.TextChanged += new System.EventHandler(this.searchText_TextChanged);
            // 
            // viewSpisokStrings1
            // 
            this.viewSpisokStrings1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewSpisokStrings1.Location = new System.Drawing.Point(3, 3);
            this.viewSpisokStrings1.Name = "viewSpisokStrings1";
            this.viewSpisokStrings1.Size = new System.Drawing.Size(750, 562);
            this.viewSpisokStrings1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1201, 574);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Списки строк по категориям";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.textBox_SearchTextGroup);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.textBox_SearchGroup);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.viewSpisokStringsGroup1);
            this.splitContainer2.Size = new System.Drawing.Size(1195, 568);
            this.splitContainer2.SplitterDistance = 398;
            this.splitContainer2.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Поиск по строкам";
            // 
            // textBox_SearchTextGroup
            // 
            this.textBox_SearchTextGroup.Location = new System.Drawing.Point(17, 53);
            this.textBox_SearchTextGroup.Name = "textBox_SearchTextGroup";
            this.textBox_SearchTextGroup.Size = new System.Drawing.Size(366, 26);
            this.textBox_SearchTextGroup.TabIndex = 10;
            this.textBox_SearchTextGroup.TextChanged += new System.EventHandler(this.textBox_SearchTextGroup_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.label_CheckSpisokStrings);
            this.groupBox2.Controls.Add(this.comboBox_spisokStrings);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox_GroupStrings);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox_IDGroup);
            this.groupBox2.Location = new System.Drawing.Point(25, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 395);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выбрана группа и слово из списка";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(19, 346);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(238, 30);
            this.button4.TabIndex = 9;
            this.button4.Text = "Очистить таблицу";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label_CheckSpisokStrings
            // 
            this.label_CheckSpisokStrings.AutoSize = true;
            this.label_CheckSpisokStrings.Location = new System.Drawing.Point(16, 153);
            this.label_CheckSpisokStrings.Name = "label_CheckSpisokStrings";
            this.label_CheckSpisokStrings.Size = new System.Drawing.Size(51, 20);
            this.label_CheckSpisokStrings.TabIndex = 8;
            this.label_CheckSpisokStrings.Text = "label7";
            // 
            // comboBox_spisokStrings
            // 
            this.comboBox_spisokStrings.FormattingEnabled = true;
            this.comboBox_spisokStrings.Location = new System.Drawing.Point(16, 185);
            this.comboBox_spisokStrings.Name = "comboBox_spisokStrings";
            this.comboBox_spisokStrings.Size = new System.Drawing.Size(327, 28);
            this.comboBox_spisokStrings.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Удалить группу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(242, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "Добавить новую группу строк";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 221);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(242, 35);
            this.button3.TabIndex = 4;
            this.button3.Text = "Редактировать группу строк";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Строка";
            // 
            // textBox_GroupStrings
            // 
            this.textBox_GroupStrings.Location = new System.Drawing.Point(16, 118);
            this.textBox_GroupStrings.Name = "textBox_GroupStrings";
            this.textBox_GroupStrings.Size = new System.Drawing.Size(327, 26);
            this.textBox_GroupStrings.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Группа";
            // 
            // textBox_IDGroup
            // 
            this.textBox_IDGroup.Location = new System.Drawing.Point(16, 54);
            this.textBox_IDGroup.Name = "textBox_IDGroup";
            this.textBox_IDGroup.Size = new System.Drawing.Size(100, 26);
            this.textBox_IDGroup.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Строка поиска по группам";
            // 
            // textBox_SearchGroup
            // 
            this.textBox_SearchGroup.Location = new System.Drawing.Point(24, 126);
            this.textBox_SearchGroup.Name = "textBox_SearchGroup";
            this.textBox_SearchGroup.Size = new System.Drawing.Size(359, 26);
            this.textBox_SearchGroup.TabIndex = 7;
            this.textBox_SearchGroup.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // viewSpisokStringsGroup1
            // 
            this.viewSpisokStringsGroup1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewSpisokStringsGroup1.Location = new System.Drawing.Point(0, 0);
            this.viewSpisokStringsGroup1.Name = "viewSpisokStringsGroup1";
            this.viewSpisokStringsGroup1.Size = new System.Drawing.Size(793, 568);
            this.viewSpisokStringsGroup1.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(16, 294);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(207, 33);
            this.button5.TabIndex = 7;
            this.button5.Text = "Очистить таблицу";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1278, 616);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_DeleteIDString;
        private System.Windows.Forms.Button button_AddIDString;
        private System.Windows.Forms.Button button_SaveIDString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ValueStr;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchText;
        private ViewSpisokStrings viewSpisokStrings1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_GroupStrings;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_IDGroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_SearchGroup;
        private ViewSpisokStringsGroup viewSpisokStringsGroup1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_SearchTextGroup;
        private System.Windows.Forms.ComboBox comboBox_spisokStrings;
        private System.Windows.Forms.Label label_CheckSpisokStrings;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}