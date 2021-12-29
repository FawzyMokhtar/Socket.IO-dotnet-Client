namespace SocketIOClient_NET_WFA
{
    partial class MainForm
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
            this.flpTools = new System.Windows.Forms.FlowLayoutPanel();
            this.lblServerUrl = new System.Windows.Forms.Label();
            this.txtServerUrl = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.txtLogs = new System.Windows.Forms.RichTextBox();
            this.flpTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpTools
            // 
            this.flpTools.Controls.Add(this.lblServerUrl);
            this.flpTools.Controls.Add(this.txtServerUrl);
            this.flpTools.Controls.Add(this.btnConnect);
            this.flpTools.Controls.Add(this.btnDiscount);
            this.flpTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpTools.Location = new System.Drawing.Point(0, 0);
            this.flpTools.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flpTools.Name = "flpTools";
            this.flpTools.Size = new System.Drawing.Size(1862, 55);
            this.flpTools.TabIndex = 0;
            // 
            // lblServerUrl
            // 
            this.lblServerUrl.AutoSize = true;
            this.lblServerUrl.Location = new System.Drawing.Point(3, 10);
            this.lblServerUrl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblServerUrl.Name = "lblServerUrl";
            this.lblServerUrl.Size = new System.Drawing.Size(87, 20);
            this.lblServerUrl.TabIndex = 3;
            this.lblServerUrl.Text = "Server Url :";
            // 
            // txtServerUrl
            // 
            this.txtServerUrl.Location = new System.Drawing.Point(97, 9);
            this.txtServerUrl.Margin = new System.Windows.Forms.Padding(4, 9, 4, 5);
            this.txtServerUrl.Name = "txtServerUrl";
            this.txtServerUrl.Size = new System.Drawing.Size(348, 26);
            this.txtServerUrl.TabIndex = 1;
            this.txtServerUrl.Text = "ws://localhost:3030";
            // 
            // btnConnect
            // 
            this.btnConnect.AutoSize = true;
            this.btnConnect.ForeColor = System.Drawing.Color.Green;
            this.btnConnect.Location = new System.Drawing.Point(453, 5);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(154, 35);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect to Server";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDiscount
            // 
            this.btnDiscount.AutoSize = true;
            this.btnDiscount.ForeColor = System.Drawing.Color.Red;
            this.btnDiscount.Location = new System.Drawing.Point(615, 5);
            this.btnDiscount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(173, 35);
            this.btnDiscount.TabIndex = 2;
            this.btnDiscount.Text = "Discount from Server";
            this.btnDiscount.UseVisualStyleBackColor = true;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // txtLogs
            // 
            this.txtLogs.BackColor = System.Drawing.Color.White;
            this.txtLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogs.Location = new System.Drawing.Point(0, 55);
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.ReadOnly = true;
            this.txtLogs.Size = new System.Drawing.Size(1862, 1006);
            this.txtLogs.TabIndex = 1;
            this.txtLogs.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1862, 1061);
            this.Controls.Add(this.txtLogs);
            this.Controls.Add(this.flpTools);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Socket.IO Cleint (Windows Forms App)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.flpTools.ResumeLayout(false);
            this.flpTools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpTools;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtServerUrl;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Label lblServerUrl;
        private System.Windows.Forms.RichTextBox txtLogs;
    }
}

