namespace Giris_Panel
{
    partial class settings
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUserArea = new System.Windows.Forms.Label();
            this.lblEmailArea = new System.Windows.Forms.Label();
            this.lblGuard = new System.Windows.Forms.Label();
            this.cbGuard = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.AllowDrop = true;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::Giris_Panel.Resource1.closed;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(313, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 33);
            this.btnClose.TabIndex = 6;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Location = new System.Drawing.Point(-1, 411);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(352, 40);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUsername.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUsername.Location = new System.Drawing.Point(12, 147);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(134, 21);
            this.lblUsername.TabIndex = 8;
            this.lblUsername.Text = "Your Username:";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmail.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEmail.Location = new System.Drawing.Point(12, 227);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(106, 21);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Your E-mail:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserArea
            // 
            this.lblUserArea.AutoSize = true;
            this.lblUserArea.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblUserArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUserArea.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserArea.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUserArea.Location = new System.Drawing.Point(177, 147);
            this.lblUserArea.Name = "lblUserArea";
            this.lblUserArea.Size = new System.Drawing.Size(56, 21);
            this.lblUserArea.TabIndex = 10;
            this.lblUserArea.Text = "[user]";
            this.lblUserArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmailArea
            // 
            this.lblEmailArea.AutoSize = true;
            this.lblEmailArea.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblEmailArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmailArea.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmailArea.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEmailArea.Location = new System.Drawing.Point(177, 227);
            this.lblEmailArea.Name = "lblEmailArea";
            this.lblEmailArea.Size = new System.Drawing.Size(72, 21);
            this.lblEmailArea.TabIndex = 11;
            this.lblEmailArea.Text = "[e-mail]";
            this.lblEmailArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGuard
            // 
            this.lblGuard.AutoSize = true;
            this.lblGuard.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblGuard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGuard.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGuard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblGuard.Location = new System.Drawing.Point(12, 367);
            this.lblGuard.Name = "lblGuard";
            this.lblGuard.Size = new System.Drawing.Size(97, 21);
            this.lblGuard.TabIndex = 12;
            this.lblGuard.Text = "Sms Guard";
            this.lblGuard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbGuard
            // 
            this.cbGuard.AutoSize = true;
            this.cbGuard.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbGuard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbGuard.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbGuard.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cbGuard.Location = new System.Drawing.Point(121, 370);
            this.cbGuard.Name = "cbGuard";
            this.cbGuard.Size = new System.Drawing.Size(12, 11);
            this.cbGuard.TabIndex = 13;
            this.cbGuard.UseVisualStyleBackColor = false;
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Giris_Panel.Resource1.settings__2_;
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.Controls.Add(this.cbGuard);
            this.Controls.Add(this.lblGuard);
            this.Controls.Add(this.lblEmailArea);
            this.Controls.Add(this.lblUserArea);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "settings";
            this.Load += new System.EventHandler(this.settings_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.settings_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.settings_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.settings_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUserArea;
        private System.Windows.Forms.Label lblEmailArea;
        private System.Windows.Forms.Label lblGuard;
        private System.Windows.Forms.CheckBox cbGuard;
    }
}