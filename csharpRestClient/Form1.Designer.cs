namespace csharpRestClient
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
            this.txtRestURI = new System.Windows.Forms.TextBox();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.cmdGo = new System.Windows.Forms.Button();
            this.requestURI = new System.Windows.Forms.Label();
            this.response = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.technique = new System.Windows.Forms.GroupBox();
            this.authType = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoBasicAuth = new System.Windows.Forms.RadioButton();
            this.rdoNTLMAuth = new System.Windows.Forms.RadioButton();
            this.rdoRollOwn = new System.Windows.Forms.RadioButton();
            this.rdoNetCred = new System.Windows.Forms.RadioButton();
            this.technique.SuspendLayout();
            this.authType.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRestURI
            // 
            this.txtRestURI.Location = new System.Drawing.Point(123, 48);
            this.txtRestURI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRestURI.Name = "txtRestURI";
            this.txtRestURI.Size = new System.Drawing.Size(416, 20);
            this.txtRestURI.TabIndex = 0;
            // 
            // txtResponse
            // 
            this.txtResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResponse.Location = new System.Drawing.Point(123, 188);
            this.txtResponse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResponse.Size = new System.Drawing.Size(453, 129);
            this.txtResponse.TabIndex = 1;
            this.txtResponse.TextChanged += new System.EventHandler(this.txtResponse_TextChanged);
            // 
            // cmdGo
            // 
            this.cmdGo.Location = new System.Drawing.Point(543, 48);
            this.cmdGo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdGo.Name = "cmdGo";
            this.cmdGo.Size = new System.Drawing.Size(46, 19);
            this.cmdGo.TabIndex = 2;
            this.cmdGo.Text = "Go!";
            this.cmdGo.UseVisualStyleBackColor = true;
            this.cmdGo.Click += new System.EventHandler(this.cmdGo_Click);
            // 
            // requestURI
            // 
            this.requestURI.AutoSize = true;
            this.requestURI.Location = new System.Drawing.Point(26, 51);
            this.requestURI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.requestURI.Name = "requestURI";
            this.requestURI.Size = new System.Drawing.Size(64, 13);
            this.requestURI.TabIndex = 3;
            this.requestURI.Text = "request URI";
            this.requestURI.Click += new System.EventHandler(this.requestURI_Click);
            // 
            // response
            // 
            this.response.AutoSize = true;
            this.response.Location = new System.Drawing.Point(26, 191);
            this.response.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.response.Name = "response";
            this.response.Size = new System.Drawing.Size(50, 13);
            this.response.TabIndex = 4;
            this.response.Text = "response";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(390, 85);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(149, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(181, 85);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(144, 20);
            this.txtUsername.TabIndex = 6;
            // 
            // technique
            // 
            this.technique.Controls.Add(this.rdoNetCred);
            this.technique.Controls.Add(this.rdoRollOwn);
            this.technique.Location = new System.Drawing.Point(334, 125);
            this.technique.Name = "technique";
            this.technique.Size = new System.Drawing.Size(205, 58);
            this.technique.TabIndex = 7;
            this.technique.TabStop = false;
            this.technique.Text = "Technique";
            // 
            // authType
            // 
            this.authType.Controls.Add(this.rdoNTLMAuth);
            this.authType.Controls.Add(this.rdoBasicAuth);
            this.authType.Location = new System.Drawing.Point(123, 125);
            this.authType.Name = "authType";
            this.authType.Size = new System.Drawing.Size(202, 58);
            this.authType.TabIndex = 8;
            this.authType.TabStop = false;
            this.authType.Text = "Auth Type";
            this.authType.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Username";
            // 
            // rdoBasicAuth
            // 
            this.rdoBasicAuth.AutoSize = true;
            this.rdoBasicAuth.Checked = true;
            this.rdoBasicAuth.Location = new System.Drawing.Point(7, 19);
            this.rdoBasicAuth.Name = "rdoBasicAuth";
            this.rdoBasicAuth.Size = new System.Drawing.Size(122, 17);
            this.rdoBasicAuth.TabIndex = 0;
            this.rdoBasicAuth.TabStop = true;
            this.rdoBasicAuth.Text = "Basic Authentication";
            this.rdoBasicAuth.UseVisualStyleBackColor = true;
            // 
            // rdoNTLMAuth
            // 
            this.rdoNTLMAuth.AutoSize = true;
            this.rdoNTLMAuth.Location = new System.Drawing.Point(7, 35);
            this.rdoNTLMAuth.Name = "rdoNTLMAuth";
            this.rdoNTLMAuth.Size = new System.Drawing.Size(108, 17);
            this.rdoNTLMAuth.TabIndex = 1;
            this.rdoNTLMAuth.TabStop = true;
            this.rdoNTLMAuth.Text = "NTLM (Windows)";
            this.rdoNTLMAuth.UseVisualStyleBackColor = true;
            // 
            // rdoRollOwn
            // 
            this.rdoRollOwn.AutoSize = true;
            this.rdoRollOwn.Checked = true;
            this.rdoRollOwn.Location = new System.Drawing.Point(7, 19);
            this.rdoRollOwn.Name = "rdoRollOwn";
            this.rdoRollOwn.Size = new System.Drawing.Size(93, 17);
            this.rdoRollOwn.TabIndex = 0;
            this.rdoRollOwn.TabStop = true;
            this.rdoRollOwn.Text = "Roll Your Own";
            this.rdoRollOwn.UseVisualStyleBackColor = true;
            // 
            // rdoNetCred
            // 
            this.rdoNetCred.AutoSize = true;
            this.rdoNetCred.Location = new System.Drawing.Point(7, 35);
            this.rdoNetCred.Name = "rdoNetCred";
            this.rdoNetCred.Size = new System.Drawing.Size(140, 17);
            this.rdoNetCred.TabIndex = 1;
            this.rdoNetCred.TabStop = true;
            this.rdoNetCred.Text = "NetworkCredential Class";
            this.rdoNetCred.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.authType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.technique);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.response);
            this.Controls.Add(this.requestURI);
            this.Controls.Add(this.cmdGo);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.txtRestURI);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "c# REST Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.technique.ResumeLayout(false);
            this.technique.PerformLayout();
            this.authType.ResumeLayout(false);
            this.authType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRestURI;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Button cmdGo;
        private System.Windows.Forms.Label requestURI;
        private System.Windows.Forms.Label response;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.GroupBox technique;
        private System.Windows.Forms.GroupBox authType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoNetCred;
        private System.Windows.Forms.RadioButton rdoRollOwn;
        private System.Windows.Forms.RadioButton rdoNTLMAuth;
        private System.Windows.Forms.RadioButton rdoBasicAuth;
    }
}

