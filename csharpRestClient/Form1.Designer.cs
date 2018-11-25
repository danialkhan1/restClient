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
            this.SuspendLayout();
            // 
            // txtRestURI
            // 
            this.txtRestURI.Location = new System.Drawing.Point(164, 59);
            this.txtRestURI.Name = "txtRestURI";
            this.txtRestURI.Size = new System.Drawing.Size(437, 22);
            this.txtRestURI.TabIndex = 0;
            // 
            // txtResponse
            // 
            this.txtResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResponse.Location = new System.Drawing.Point(164, 87);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResponse.Size = new System.Drawing.Size(603, 246);
            this.txtResponse.TabIndex = 1;
            // 
            // cmdGo
            // 
            this.cmdGo.Location = new System.Drawing.Point(621, 58);
            this.cmdGo.Name = "cmdGo";
            this.cmdGo.Size = new System.Drawing.Size(108, 23);
            this.cmdGo.TabIndex = 2;
            this.cmdGo.Text = "Go!";
            this.cmdGo.UseVisualStyleBackColor = true;
            this.cmdGo.Click += new System.EventHandler(this.cmdGo_Click);
            // 
            // requestURI
            // 
            this.requestURI.AutoSize = true;
            this.requestURI.Location = new System.Drawing.Point(35, 63);
            this.requestURI.Name = "requestURI";
            this.requestURI.Size = new System.Drawing.Size(83, 17);
            this.requestURI.TabIndex = 3;
            this.requestURI.Text = "request URI";
            this.requestURI.Click += new System.EventHandler(this.requestURI_Click);
            // 
            // response
            // 
            this.response.AutoSize = true;
            this.response.Location = new System.Drawing.Point(38, 100);
            this.response.Name = "response";
            this.response.Size = new System.Drawing.Size(67, 17);
            this.response.TabIndex = 4;
            this.response.Text = "response";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.response);
            this.Controls.Add(this.requestURI);
            this.Controls.Add(this.cmdGo);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.txtRestURI);
            this.Name = "Form1";
            this.Text = "c# REST Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRestURI;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Button cmdGo;
        private System.Windows.Forms.Label requestURI;
        private System.Windows.Forms.Label response;
    }
}

