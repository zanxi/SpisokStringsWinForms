namespace SpisokStringsWinForms
{
    partial class AutorizationDBServer
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_passwordDB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_loginDB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_NameDB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_IPSQLServer = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(26, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 94);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Подключение";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(131, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Выйти из программы";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "подключиться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_passwordDB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_loginDB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_NameDB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_IPSQLServer);
            this.groupBox1.Location = new System.Drawing.Point(26, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 228);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Учетная запись для авторизации на сервере";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "пароль пользователя";
            // 
            // textBox_passwordDB
            // 
            this.textBox_passwordDB.Location = new System.Drawing.Point(334, 175);
            this.textBox_passwordDB.Name = "textBox_passwordDB";
            this.textBox_passwordDB.Size = new System.Drawing.Size(243, 26);
            this.textBox_passwordDB.TabIndex = 6;
            this.textBox_passwordDB.Text = "000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "логин пользователя";
            // 
            // textBox_loginDB
            // 
            this.textBox_loginDB.Location = new System.Drawing.Point(334, 128);
            this.textBox_loginDB.Name = "textBox_loginDB";
            this.textBox_loginDB.Size = new System.Drawing.Size(243, 26);
            this.textBox_loginDB.TabIndex = 4;
            this.textBox_loginDB.Text = "sa_";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя базы данных";
            // 
            // textBox_NameDB
            // 
            this.textBox_NameDB.Location = new System.Drawing.Point(333, 85);
            this.textBox_NameDB.Name = "textBox_NameDB";
            this.textBox_NameDB.Size = new System.Drawing.Size(243, 26);
            this.textBox_NameDB.TabIndex = 2;
            this.textBox_NameDB.Text = "DBtest";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сетевой адресс Sql Server сервера";
            // 
            // textBox_IPSQLServer
            // 
            this.textBox_IPSQLServer.Location = new System.Drawing.Point(333, 33);
            this.textBox_IPSQLServer.Name = "textBox_IPSQLServer";
            this.textBox_IPSQLServer.Size = new System.Drawing.Size(243, 26);
            this.textBox_IPSQLServer.TabIndex = 0;
            this.textBox_IPSQLServer.Text = "127.0.0.1";
            // 
            // AutorizationDBServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(644, 377);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AutorizationDBServer";
            this.Text = "AutorizationDBServer";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox_passwordDB;
        public System.Windows.Forms.TextBox textBox_loginDB;
        public System.Windows.Forms.TextBox textBox_NameDB;
        public System.Windows.Forms.TextBox textBox_IPSQLServer;
    }
}