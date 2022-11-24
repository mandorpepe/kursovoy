namespace kursovoy
{
    partial class addUser
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
            this.fioText = new System.Windows.Forms.TextBox();
            this.ageText = new System.Windows.Forms.TextBox();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.passportText = new System.Windows.Forms.TextBox();
            this.regloginText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.loginText = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fioText
            // 
            this.fioText.Location = new System.Drawing.Point(65, 71);
            this.fioText.Name = "fioText";
            this.fioText.Size = new System.Drawing.Size(100, 20);
            this.fioText.TabIndex = 0;
            // 
            // ageText
            // 
            this.ageText.Location = new System.Drawing.Point(197, 71);
            this.ageText.Name = "ageText";
            this.ageText.Size = new System.Drawing.Size(100, 20);
            this.ageText.TabIndex = 1;
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(320, 71);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(100, 20);
            this.phoneText.TabIndex = 2;
            // 
            // passportText
            // 
            this.passportText.Location = new System.Drawing.Point(65, 158);
            this.passportText.Name = "passportText";
            this.passportText.Size = new System.Drawing.Size(100, 20);
            this.passportText.TabIndex = 3;
            // 
            // regloginText
            // 
            this.regloginText.Location = new System.Drawing.Point(197, 158);
            this.regloginText.Name = "regloginText";
            this.regloginText.Size = new System.Drawing.Size(100, 20);
            this.regloginText.TabIndex = 4;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(321, 158);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(100, 20);
            this.passwordText.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Администратор",
            "Менеджер",
            "Работник"});
            this.comboBox1.Location = new System.Drawing.Point(501, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(482, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "Зарегестрировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(60, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label2.Location = new System.Drawing.Point(192, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Возраст";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label3.Location = new System.Drawing.Point(316, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Телефон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label4.Location = new System.Drawing.Point(60, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Паспорт";
            // 
            // loginText
            // 
            this.loginText.AutoSize = true;
            this.loginText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.loginText.Location = new System.Drawing.Point(192, 108);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(72, 26);
            this.loginText.TabIndex = 12;
            this.loginText.Text = "Логин";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label6.Location = new System.Drawing.Point(316, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "Пароль";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label5.Location = new System.Drawing.Point(496, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Должность";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(65, 245);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 27);
            this.button2.TabIndex = 15;
            this.button2.Text = "Вернуться";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 326);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.loginText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.regloginText);
            this.Controls.Add(this.passportText);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.ageText);
            this.Controls.Add(this.fioText);
            this.Name = "addUser";
            this.Text = "addUser";
            this.Load += new System.EventHandler(this.addUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fioText;
        private System.Windows.Forms.TextBox ageText;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.TextBox passportText;
        private System.Windows.Forms.TextBox regloginText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label loginText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
    }
}