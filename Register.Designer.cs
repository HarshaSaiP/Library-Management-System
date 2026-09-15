namespace WindowsFormsApp1
{
    partial class Register
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
            this.FullNameTxt = new System.Windows.Forms.TextBox();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.PhnNumberTxt = new System.Windows.Forms.TextBox();
            this.PassTxt = new System.Windows.Forms.TextBox();
            this.ConfirmPassTxt = new System.Windows.Forms.TextBox();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.fullNamelabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PhnNumberLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.ConfirmPassLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FullNameTxt
            // 
            this.FullNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FullNameTxt.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(46)))), ((int)(((byte)(31)))));
            this.FullNameTxt.Location = new System.Drawing.Point(251, 95);
            this.FullNameTxt.MaxLength = 100;
            this.FullNameTxt.Name = "FullNameTxt";
            this.FullNameTxt.Size = new System.Drawing.Size(289, 40);
            this.FullNameTxt.TabIndex = 0;
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernameTxt.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(46)))), ((int)(((byte)(31)))));
            this.UsernameTxt.Location = new System.Drawing.Point(251, 198);
            this.UsernameTxt.MaxLength = 15;
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(289, 40);
            this.UsernameTxt.TabIndex = 1;
            // 
            // PhnNumberTxt
            // 
            this.PhnNumberTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhnNumberTxt.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhnNumberTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(46)))), ((int)(((byte)(31)))));
            this.PhnNumberTxt.Location = new System.Drawing.Point(251, 301);
            this.PhnNumberTxt.MaxLength = 10;
            this.PhnNumberTxt.Name = "PhnNumberTxt";
            this.PhnNumberTxt.Size = new System.Drawing.Size(289, 40);
            this.PhnNumberTxt.TabIndex = 2;
            // 
            // PassTxt
            // 
            this.PassTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassTxt.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(46)))), ((int)(((byte)(31)))));
            this.PassTxt.Location = new System.Drawing.Point(251, 404);
            this.PassTxt.MaxLength = 15;
            this.PassTxt.Name = "PassTxt";
            this.PassTxt.Size = new System.Drawing.Size(289, 40);
            this.PassTxt.TabIndex = 3;
            // 
            // ConfirmPassTxt
            // 
            this.ConfirmPassTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConfirmPassTxt.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(46)))), ((int)(((byte)(31)))));
            this.ConfirmPassTxt.Location = new System.Drawing.Point(251, 507);
            this.ConfirmPassTxt.MaxLength = 15;
            this.ConfirmPassTxt.Name = "ConfirmPassTxt";
            this.ConfirmPassTxt.Size = new System.Drawing.Size(289, 40);
            this.ConfirmPassTxt.TabIndex = 4;
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(63)))), ((int)(((byte)(42)))));
            this.RegisterBtn.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBtn.ForeColor = System.Drawing.Color.White;
            this.RegisterBtn.Location = new System.Drawing.Point(437, 596);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(220, 55);
            this.RegisterBtn.TabIndex = 5;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = false;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(63)))), ((int)(((byte)(42)))));
            this.ResetBtn.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.ForeColor = System.Drawing.Color.White;
            this.ResetBtn.Location = new System.Drawing.Point(77, 596);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(220, 55);
            this.ResetBtn.TabIndex = 6;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // fullNamelabel
            // 
            this.fullNamelabel.AutoSize = true;
            this.fullNamelabel.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNamelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(46)))), ((int)(((byte)(31)))));
            this.fullNamelabel.Location = new System.Drawing.Point(136, 46);
            this.fullNamelabel.Name = "fullNamelabel";
            this.fullNamelabel.Size = new System.Drawing.Size(145, 32);
            this.fullNamelabel.TabIndex = 7;
            this.fullNamelabel.Text = "Full Name :";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(46)))), ((int)(((byte)(31)))));
            this.UsernameLabel.Location = new System.Drawing.Point(136, 149);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(142, 32);
            this.UsernameLabel.TabIndex = 8;
            this.UsernameLabel.Text = "Username :";
            this.UsernameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // PhnNumberLabel
            // 
            this.PhnNumberLabel.AutoSize = true;
            this.PhnNumberLabel.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhnNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(46)))), ((int)(((byte)(31)))));
            this.PhnNumberLabel.Location = new System.Drawing.Point(136, 252);
            this.PhnNumberLabel.Name = "PhnNumberLabel";
            this.PhnNumberLabel.Size = new System.Drawing.Size(202, 32);
            this.PhnNumberLabel.TabIndex = 9;
            this.PhnNumberLabel.Text = "Mobile Number :";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(46)))), ((int)(((byte)(31)))));
            this.PasswordLabel.Location = new System.Drawing.Point(136, 355);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(134, 32);
            this.PasswordLabel.TabIndex = 10;
            this.PasswordLabel.Text = "Password :";
            // 
            // ConfirmPassLabel
            // 
            this.ConfirmPassLabel.AutoSize = true;
            this.ConfirmPassLabel.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(46)))), ((int)(((byte)(31)))));
            this.ConfirmPassLabel.Location = new System.Drawing.Point(136, 458);
            this.ConfirmPassLabel.Name = "ConfirmPassLabel";
            this.ConfirmPassLabel.Size = new System.Drawing.Size(229, 32);
            this.ConfirmPassLabel.TabIndex = 11;
            this.ConfirmPassLabel.Text = "Confirm Password :";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(750, 701);
            this.Controls.Add(this.ConfirmPassLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PhnNumberLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.fullNamelabel);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.ConfirmPassTxt);
            this.Controls.Add(this.PassTxt);
            this.Controls.Add(this.PhnNumberTxt);
            this.Controls.Add(this.UsernameTxt);
            this.Controls.Add(this.FullNameTxt);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FullNameTxt;
        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.TextBox PhnNumberTxt;
        private System.Windows.Forms.TextBox PassTxt;
        private System.Windows.Forms.TextBox ConfirmPassTxt;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Label fullNamelabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PhnNumberLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label ConfirmPassLabel;
    }
}