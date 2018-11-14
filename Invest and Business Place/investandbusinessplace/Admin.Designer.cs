namespace investandbusinessplace
{
    partial class Admin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSignIn = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.btnInnovatorApproval = new System.Windows.Forms.Button();
            this.btnInvesterapproval = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.panelAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnSignIn.Location = new System.Drawing.Point(387, 244);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(85, 37);
            this.btnSignIn.TabIndex = 54;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSignIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPassword.Location = new System.Drawing.Point(226, 182);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(246, 22);
            this.txtPassword.TabIndex = 53;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.BurlyWood;
            this.lblPassword.Location = new System.Drawing.Point(132, 184);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 20);
            this.lblPassword.TabIndex = 52;
            this.lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.SystemColors.Window;
            this.txtUsername.Location = new System.Drawing.Point(226, 125);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(246, 22);
            this.txtUsername.TabIndex = 51;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.BurlyWood;
            this.lblEmail.Location = new System.Drawing.Point(132, 127);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(85, 20);
            this.lblEmail.TabIndex = 50;
            this.lblEmail.Text = "UserName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.BurlyWood;
            this.label4.Location = new System.Drawing.Point(251, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 29);
            this.label4.TabIndex = 55;
            this.label4.Text = "Admin";
            // 
            // panelAdmin
            // 
            this.panelAdmin.Controls.Add(this.btnSignOut);
            this.panelAdmin.Controls.Add(this.btnInvesterapproval);
            this.panelAdmin.Controls.Add(this.btnInnovatorApproval);
            this.panelAdmin.Location = new System.Drawing.Point(48, 22);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(515, 371);
            this.panelAdmin.TabIndex = 56;
            // 
            // btnInnovatorApproval
            // 
            this.btnInnovatorApproval.Location = new System.Drawing.Point(74, 39);
            this.btnInnovatorApproval.Name = "btnInnovatorApproval";
            this.btnInnovatorApproval.Size = new System.Drawing.Size(75, 48);
            this.btnInnovatorApproval.TabIndex = 0;
            this.btnInnovatorApproval.Text = "Innovator Approval";
            this.btnInnovatorApproval.UseVisualStyleBackColor = true;
            this.btnInnovatorApproval.Click += new System.EventHandler(this.btnInnovatorApproval_Click);
            // 
            // btnInvesterapproval
            // 
            this.btnInvesterapproval.Location = new System.Drawing.Point(323, 39);
            this.btnInvesterapproval.Name = "btnInvesterapproval";
            this.btnInvesterapproval.Size = new System.Drawing.Size(75, 48);
            this.btnInvesterapproval.TabIndex = 2;
            this.btnInvesterapproval.Text = "Invester Approval";
            this.btnInvesterapproval.UseVisualStyleBackColor = true;
            this.btnInvesterapproval.Click += new System.EventHandler(this.btnInvesterapproval_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.Location = new System.Drawing.Point(208, 276);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(75, 29);
            this.btnSignOut.TabIndex = 3;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.panelAdmin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblEmail);
            this.Location = new System.Drawing.Point(200, 0);
            this.Name = "Admin";
            this.Size = new System.Drawing.Size(627, 448);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panelAdmin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnInvesterapproval;
        private System.Windows.Forms.Button btnInnovatorApproval;
    }
}
