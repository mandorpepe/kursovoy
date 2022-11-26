namespace kursovoy
{
    partial class Авторизация
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
            this.login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.loginText = new System.Windows.Forms.TextBox();
            this.passText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.SystemColors.GrayText;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.login.Location = new System.Drawing.Point(135, 345);
            this.login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(231, 69);
            this.login.TabIndex = 0;
            this.login.Text = "Вход";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.25F);
            this.label1.Location = new System.Drawing.Point(157, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Авторизация";
            // 
            // loginText
            // 
            this.loginText.Location = new System.Drawing.Point(135, 174);
            this.loginText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(229, 22);
            this.loginText.TabIndex = 2;
            // 
            // passText
            // 
            this.passText.Location = new System.Drawing.Point(135, 260);
            this.passText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passText.Name = "passText";
            this.passText.PasswordChar = '*';
            this.passText.Size = new System.Drawing.Size(229, 22);
            this.passText.TabIndex = 3;
            // 
            // Авторизация
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(487, 508);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.loginText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Авторизация";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Авторизация_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginText;
        private System.Windows.Forms.TextBox passText;
    }
}

