namespace AutoParts.Controls
{
    partial class UserAdd
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            Name = new Label();
            FN = new Label();
            Pas = new Label();
            Phone = new Label();
            Email = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            ex = new Button();
            Ok = new Button();
            SuspendLayout();
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Location = new Point(19, 37);
            Name.Name = "Name";
            Name.Size = new Size(34, 15);
            Name.TabIndex = 0;
            Name.Text = "Имя:";
            // 
            // FN
            // 
            FN.AutoSize = true;
            FN.Location = new Point(19, 70);
            FN.Name = "FN";
            FN.Size = new Size(61, 15);
            FN.TabIndex = 1;
            FN.Text = "Фамилия:";
            // 
            // Pas
            // 
            Pas.AutoSize = true;
            Pas.Location = new Point(19, 107);
            Pas.Name = "Pas";
            Pas.Size = new Size(57, 15);
            Pas.TabIndex = 2;
            Pas.Text = "Паспорт:";
            // 
            // Phone
            // 
            Phone.AutoSize = true;
            Phone.Location = new Point(19, 149);
            Phone.Name = "Phone";
            Phone.Size = new Size(58, 15);
            Phone.TabIndex = 3;
            Phone.Text = "Телефон:";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(19, 188);
            Email.Name = "Email";
            Email.Size = new Size(44, 15);
            Email.TabIndex = 4;
            Email.Text = "Почта:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(98, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(98, 62);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(245, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(98, 99);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(245, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(98, 141);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(245, 23);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(98, 180);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(245, 23);
            textBox5.TabIndex = 9;
            // 
            // ex
            // 
            ex.Location = new Point(268, 225);
            ex.Name = "ex";
            ex.Size = new Size(75, 28);
            ex.TabIndex = 10;
            ex.Text = "Отмена";
            ex.UseVisualStyleBackColor = true;
            // 
            // Ok
            // 
            Ok.Location = new Point(173, 225);
            Ok.Name = "Ok";
            Ok.Size = new Size(75, 28);
            Ok.TabIndex = 11;
            Ok.Text = "Ок";
            Ok.UseVisualStyleBackColor = true;
            // 
            // UserAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Ok);
            Controls.Add(ex);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Email);
            Controls.Add(Phone);
            Controls.Add(Pas);
            Controls.Add(FN);
            Controls.Add(Name);
            Name = "UserAdd";
            Size = new Size(403, 276);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Name;
        private Label FN;
        private Label Pas;
        private Label Phone;
        private Label Email;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button ex;
        private Button Ok;
    }
}
