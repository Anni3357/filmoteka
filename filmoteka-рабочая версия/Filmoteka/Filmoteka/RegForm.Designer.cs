
namespace Filmoteka
{
    partial class RegForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Registratebutton = new System.Windows.Forms.Button();
            this.Логин = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.Passbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(775, 620);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Registratebutton);
            this.panel1.Controls.Add(this.Логин);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LoginBox);
            this.panel1.Controls.Add(this.PasswordBox);
            this.panel1.Controls.Add(this.Passbutton);
            this.panel1.Location = new System.Drawing.Point(121, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 457);
            this.panel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(112, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Придумайте пароль";
            // 
            // Registratebutton
            // 
            this.Registratebutton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.Registratebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.Registratebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MintCream;
            this.Registratebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registratebutton.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registratebutton.ForeColor = System.Drawing.Color.Teal;
            this.Registratebutton.Location = new System.Drawing.Point(118, 357);
            this.Registratebutton.Name = "Registratebutton";
            this.Registratebutton.Size = new System.Drawing.Size(295, 42);
            this.Registratebutton.TabIndex = 6;
            this.Registratebutton.Text = "Назад";
            this.Registratebutton.UseVisualStyleBackColor = true;
            this.Registratebutton.Click += new System.EventHandler(this.Registratebutton_Click);
            // 
            // Логин
            // 
            this.Логин.AutoSize = true;
            this.Логин.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Логин.ForeColor = System.Drawing.Color.Teal;
            this.Логин.Location = new System.Drawing.Point(112, 100);
            this.Логин.Name = "Логин";
            this.Логин.Size = new System.Drawing.Size(276, 33);
            this.Логин.TabIndex = 3;
            this.Логин.Text = "Придумайте логин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(94, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            // 
            // LoginBox
            // 
            this.LoginBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginBox.Location = new System.Drawing.Point(118, 135);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(295, 38);
            this.LoginBox.TabIndex = 1;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordBox.Location = new System.Drawing.Point(118, 228);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(295, 38);
            this.PasswordBox.TabIndex = 2;
            // 
            // Passbutton
            // 
            this.Passbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Passbutton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.Passbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.Passbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MintCream;
            this.Passbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Passbutton.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Passbutton.ForeColor = System.Drawing.Color.Teal;
            this.Passbutton.Location = new System.Drawing.Point(118, 307);
            this.Passbutton.Name = "Passbutton";
            this.Passbutton.Size = new System.Drawing.Size(295, 44);
            this.Passbutton.TabIndex = 5;
            this.Passbutton.Text = "Войти";
            this.Passbutton.UseVisualStyleBackColor = false;
            this.Passbutton.Click += new System.EventHandler(this.Passbutton_Click);
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 620);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Registratebutton;
        private System.Windows.Forms.Label Логин;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button Passbutton;
    }
}