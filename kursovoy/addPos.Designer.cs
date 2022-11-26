namespace kursovoy
{
    partial class addPos
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
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dutyText = new System.Windows.Forms.TextBox();
            this.requirText = new System.Windows.Forms.TextBox();
            this.payText = new System.Windows.Forms.TextBox();
            this.posText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(35, 341);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 87);
            this.button2.TabIndex = 24;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label5.Location = new System.Drawing.Point(29, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 32);
            this.label5.TabIndex = 23;
            this.label5.Text = "Требования";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label4.Location = new System.Drawing.Point(322, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 32);
            this.label4.TabIndex = 22;
            this.label4.Text = "Обязанности";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label3.Location = new System.Drawing.Point(345, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 32);
            this.label3.TabIndex = 21;
            this.label3.Text = "Зарплата";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 32);
            this.label1.TabIndex = 19;
            this.label1.Text = "Название должности";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(626, 341);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 87);
            this.button1.TabIndex = 18;
            this.button1.Text = "Зарегистрировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dutyText
            // 
            this.dutyText.Location = new System.Drawing.Point(328, 208);
            this.dutyText.Margin = new System.Windows.Forms.Padding(4);
            this.dutyText.Multiline = true;
            this.dutyText.Name = "dutyText";
            this.dutyText.Size = new System.Drawing.Size(221, 100);
            this.dutyText.TabIndex = 16;
            // 
            // requirText
            // 
            this.requirText.Location = new System.Drawing.Point(35, 208);
            this.requirText.Margin = new System.Windows.Forms.Padding(4);
            this.requirText.Multiline = true;
            this.requirText.Name = "requirText";
            this.requirText.Size = new System.Drawing.Size(229, 100);
            this.requirText.TabIndex = 15;
            // 
            // payText
            // 
            this.payText.Location = new System.Drawing.Point(354, 93);
            this.payText.Margin = new System.Windows.Forms.Padding(4);
            this.payText.Name = "payText";
            this.payText.Size = new System.Drawing.Size(132, 22);
            this.payText.TabIndex = 14;
            // 
            // posText
            // 
            this.posText.Location = new System.Drawing.Point(35, 93);
            this.posText.Margin = new System.Windows.Forms.Padding(4);
            this.posText.Name = "posText";
            this.posText.Size = new System.Drawing.Size(132, 22);
            this.posText.TabIndex = 13;
            // 
            // addPos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dutyText);
            this.Controls.Add(this.requirText);
            this.Controls.Add(this.payText);
            this.Controls.Add(this.posText);
            this.Name = "addPos";
            this.Text = "addPos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox dutyText;
        private System.Windows.Forms.TextBox requirText;
        private System.Windows.Forms.TextBox payText;
        private System.Windows.Forms.TextBox posText;
    }
}