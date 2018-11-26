using System;

namespace Inviris.GUI.Solution
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LockPicture = new System.Windows.Forms.PictureBox();
            this.Lemail = new System.Windows.Forms.Label();
            this.Temail = new System.Windows.Forms.TextBox();
            this.Tpassword = new System.Windows.Forms.TextBox();
            this.Lpassword = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.L2 = new System.Windows.Forms.Label();
            this.L1 = new System.Windows.Forms.Label();
            this.BTlogin = new System.Windows.Forms.Button();
            this.showPassword = new System.Windows.Forms.CheckBox();
            this.LoginWrapper = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.LockPicture)).BeginInit();
            this.LoginWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // LockPicture
            // 
            this.LockPicture.Image = ((System.Drawing.Image)(resources.GetObject("LockPicture.Image")));
            this.LockPicture.Location = new System.Drawing.Point(43, 58);
            this.LockPicture.Name = "LockPicture";
            this.LockPicture.Size = new System.Drawing.Size(320, 338);
            this.LockPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LockPicture.TabIndex = 0;
            this.LockPicture.TabStop = false;
            // 
            // Lemail
            // 
            this.Lemail.AutoSize = true;
            this.Lemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lemail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lemail.Location = new System.Drawing.Point(440, 92);
            this.Lemail.Name = "Lemail";
            this.Lemail.Size = new System.Drawing.Size(97, 37);
            this.Lemail.TabIndex = 1;
            this.Lemail.Text = "Email";
            // 
            // Temail
            // 
            this.Temail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Temail.Location = new System.Drawing.Point(616, 92);
            this.Temail.Multiline = true;
            this.Temail.Name = "Temail";
            this.Temail.Size = new System.Drawing.Size(461, 37);
            this.Temail.TabIndex = 2;
            // 
            // Tpassword
            // 
            this.Tpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tpassword.Location = new System.Drawing.Point(616, 182);
            this.Tpassword.Multiline = true;
            this.Tpassword.Name = "Tpassword";
            this.Tpassword.Size = new System.Drawing.Size(461, 37);
            this.Tpassword.TabIndex = 4;
            this.Tpassword.TextChanged += new System.EventHandler(this.Tpassword_TextChanged);
            // 
            // Lpassword
            // 
            this.Lpassword.AutoSize = true;
            this.Lpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lpassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lpassword.Location = new System.Drawing.Point(440, 182);
            this.Lpassword.Name = "Lpassword";
            this.Lpassword.Size = new System.Drawing.Size(158, 37);
            this.Lpassword.TabIndex = 3;
            this.Lpassword.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(715, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 5;
            // 
            // L2
            // 
            this.L2.AutoSize = true;
            this.L2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.L2.Location = new System.Drawing.Point(590, 182);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(26, 37);
            this.L2.TabIndex = 6;
            this.L2.Text = ":";
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.L1.Location = new System.Drawing.Point(590, 92);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(26, 37);
            this.L1.TabIndex = 7;
            this.L1.Text = ":";
            // 
            // BTlogin
            // 
            this.BTlogin.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BTlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTlogin.Location = new System.Drawing.Point(961, 329);
            this.BTlogin.Name = "BTlogin";
            this.BTlogin.Size = new System.Drawing.Size(116, 67);
            this.BTlogin.TabIndex = 8;
            this.BTlogin.Text = "LOGIN";
            this.BTlogin.UseVisualStyleBackColor = false;
            this.BTlogin.Click += new System.EventHandler(this.BTlogin_Click);
            // 
            // showPassword
            // 
            this.showPassword.AutoSize = true;
            this.showPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPassword.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.showPassword.Location = new System.Drawing.Point(616, 255);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(141, 24);
            this.showPassword.TabIndex = 9;
            this.showPassword.Text = "Show Password";
            this.showPassword.UseVisualStyleBackColor = true;
            this.showPassword.CheckedChanged += new System.EventHandler(this.showPassword_CheckedChanged);
            // 
            // LoginWrapper
            // 
            this.LoginWrapper.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LoginWrapper.Controls.Add(this.Tpassword);
            this.LoginWrapper.Controls.Add(this.showPassword);
            this.LoginWrapper.Controls.Add(this.LockPicture);
            this.LoginWrapper.Controls.Add(this.BTlogin);
            this.LoginWrapper.Controls.Add(this.Lemail);
            this.LoginWrapper.Controls.Add(this.L1);
            this.LoginWrapper.Controls.Add(this.Temail);
            this.LoginWrapper.Controls.Add(this.L2);
            this.LoginWrapper.Controls.Add(this.Lpassword);
            this.LoginWrapper.Location = new System.Drawing.Point(84, 267);
            this.LoginWrapper.Name = "LoginWrapper";
            this.LoginWrapper.Size = new System.Drawing.Size(1104, 461);
            this.LoginWrapper.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.LoginWrapper);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.LockPicture)).EndInit();
            this.LoginWrapper.ResumeLayout(false);
            this.LoginWrapper.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.PictureBox LockPicture;
        private System.Windows.Forms.Label Lemail;
        private System.Windows.Forms.TextBox Temail;
        private System.Windows.Forms.TextBox Tpassword;
        private System.Windows.Forms.Label Lpassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label L2;
        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.Button BTlogin;
        private System.Windows.Forms.CheckBox showPassword;
        private System.Windows.Forms.Panel LoginWrapper;
    }
}

