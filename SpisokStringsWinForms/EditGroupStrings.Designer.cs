namespace SpisokStringsWinForms
{
    partial class EditGroupStrings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox_NewGroupStrings = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_GroupName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox_NewGroupStrings);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_GroupName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 393);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Создание новой группы строк";
            // 
            // richTextBox_NewGroupStrings
            // 
            this.richTextBox_NewGroupStrings.Location = new System.Drawing.Point(20, 118);
            this.richTextBox_NewGroupStrings.Name = "richTextBox_NewGroupStrings";
            this.richTextBox_NewGroupStrings.Size = new System.Drawing.Size(547, 166);
            this.richTextBox_NewGroupStrings.TabIndex = 6;
            this.richTextBox_NewGroupStrings.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(377, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "Ok";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Добавте строки:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название группы";
            // 
            // textBox_GroupName
            // 
            this.textBox_GroupName.Location = new System.Drawing.Point(170, 37);
            this.textBox_GroupName.Name = "textBox_GroupName";
            this.textBox_GroupName.Size = new System.Drawing.Size(397, 26);
            this.textBox_GroupName.TabIndex = 1;
            // 
            // EditGroupStrings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(611, 417);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditGroupStrings";
            this.Text = "EditGroupStrings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox textBox_GroupName;
        public System.Windows.Forms.RichTextBox richTextBox_NewGroupStrings;
    }
}