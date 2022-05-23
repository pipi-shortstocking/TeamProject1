namespace Teamproject1
{
    partial class loginform2
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
            this.label1 = new System.Windows.Forms.Label();
            this.loginformbutton = new System.Windows.Forms.Button();
            this.idinput = new System.Windows.Forms.TextBox();
            this.pwdinput = new System.Windows.Forms.TextBox();
            this.login2button = new System.Windows.Forms.TextBox();
            this.idstroragebutton = new System.Windows.Forms.TextBox();
            this.findidbutton = new System.Windows.Forms.TextBox();
            this.findpwdbutton = new System.Windows.Forms.TextBox();
            this.loginformcopywrite = new System.Windows.Forms.Button();
            this.loginbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(95, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "로그인";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // loginformbutton
            // 
            this.loginformbutton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.loginformbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.loginformbutton.Location = new System.Drawing.Point(15, 14);
            this.loginformbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginformbutton.Name = "loginformbutton";
            this.loginformbutton.Size = new System.Drawing.Size(72, 66);
            this.loginformbutton.TabIndex = 1;
            this.loginformbutton.Text = "<";
            this.loginformbutton.UseVisualStyleBackColor = false;
            this.loginformbutton.Click += new System.EventHandler(this.loginformbutton_Click);
            // 
            // idinput
            // 
            this.idinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.idinput.Location = new System.Drawing.Point(15, 364);
            this.idinput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idinput.Name = "idinput";
            this.idinput.Size = new System.Drawing.Size(686, 32);
            this.idinput.TabIndex = 3;
            this.idinput.Text = "아이디 또는 이메일을 입력하세요.";
            // 
            // pwdinput
            // 
            this.pwdinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pwdinput.Location = new System.Drawing.Point(15, 426);
            this.pwdinput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pwdinput.Name = "pwdinput";
            this.pwdinput.Size = new System.Drawing.Size(686, 32);
            this.pwdinput.TabIndex = 4;
            this.pwdinput.Text = "비밀번호를 입력하세요.";
            // 
            // login2button
            // 
            this.login2button.BackColor = System.Drawing.SystemColors.Control;
            this.login2button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.login2button.Location = new System.Drawing.Point(196, 620);
            this.login2button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.login2button.Name = "login2button";
            this.login2button.Size = new System.Drawing.Size(95, 28);
            this.login2button.TabIndex = 5;
            this.login2button.Text = "자동로그인";
            // 
            // idstroragebutton
            // 
            this.idstroragebutton.BackColor = System.Drawing.SystemColors.Control;
            this.idstroragebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.idstroragebutton.Location = new System.Drawing.Point(440, 620);
            this.idstroragebutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idstroragebutton.Name = "idstroragebutton";
            this.idstroragebutton.Size = new System.Drawing.Size(93, 28);
            this.idstroragebutton.TabIndex = 6;
            this.idstroragebutton.Text = "아이디저장";
            // 
            // findidbutton
            // 
            this.findidbutton.BackColor = System.Drawing.SystemColors.Control;
            this.findidbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.findidbutton.Location = new System.Drawing.Point(196, 699);
            this.findidbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.findidbutton.Name = "findidbutton";
            this.findidbutton.Size = new System.Drawing.Size(89, 28);
            this.findidbutton.TabIndex = 7;
            this.findidbutton.Text = "아이디찾기";
            // 
            // findpwdbutton
            // 
            this.findpwdbutton.BackColor = System.Drawing.SystemColors.Control;
            this.findpwdbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.findpwdbutton.Location = new System.Drawing.Point(440, 699);
            this.findpwdbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.findpwdbutton.Name = "findpwdbutton";
            this.findpwdbutton.Size = new System.Drawing.Size(112, 28);
            this.findpwdbutton.TabIndex = 9;
            this.findpwdbutton.Text = "비밀번호 찾기";
            // 
            // loginformcopywrite
            // 
            this.loginformcopywrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.loginformcopywrite.Location = new System.Drawing.Point(15, 125);
            this.loginformcopywrite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginformcopywrite.Name = "loginformcopywrite";
            this.loginformcopywrite.Size = new System.Drawing.Size(299, 196);
            this.loginformcopywrite.TabIndex = 10;
            this.loginformcopywrite.Text = "나만의 데일리      착장을        완성하다";
            this.loginformcopywrite.UseVisualStyleBackColor = true;
            // 
            // loginbutton
            // 
            this.loginbutton.Location = new System.Drawing.Point(291, 500);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(155, 76);
            this.loginbutton.TabIndex = 12;
            this.loginbutton.Text = "로그인";
            this.loginbutton.UseVisualStyleBackColor = true;
            // 
            // loginform2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 803);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.loginformcopywrite);
            this.Controls.Add(this.findpwdbutton);
            this.Controls.Add(this.findidbutton);
            this.Controls.Add(this.idstroragebutton);
            this.Controls.Add(this.login2button);
            this.Controls.Add(this.pwdinput);
            this.Controls.Add(this.idinput);
            this.Controls.Add(this.loginformbutton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "loginform2";
            this.Text = "loginform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginformbutton;
        private System.Windows.Forms.TextBox idinput;
        private System.Windows.Forms.TextBox pwdinput;
        private System.Windows.Forms.TextBox login2button;
        private System.Windows.Forms.TextBox idstroragebutton;
        private System.Windows.Forms.TextBox findidbutton;
        private System.Windows.Forms.TextBox findpwdbutton;
        private System.Windows.Forms.Button loginformcopywrite;
        private System.Windows.Forms.Button loginbutton;
    }
}