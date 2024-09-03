namespace Project_Skrill_Launcher
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.StartServer_btn = new System.Windows.Forms.Button();
            this.StopServer_btn = new System.Windows.Forms.Button();
            this.StartClient_btn = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.Clientpath_Input = new System.Windows.Forms.TextBox();
            this.Serverpath_Input = new System.Windows.Forms.TextBox();
            this.StopClient_btn = new System.Windows.Forms.Button();
            this.mmoOption = new System.Windows.Forms.CheckBox();
            this.ServerpathTitle = new System.Windows.Forms.Label();
            this.ClientpathTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartServer_btn
            // 
            this.StartServer_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.StartServer_btn.FlatAppearance.BorderSize = 0;
            this.StartServer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartServer_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartServer_btn.ForeColor = System.Drawing.Color.White;
            this.StartServer_btn.Location = new System.Drawing.Point(59, 263);
            this.StartServer_btn.Name = "StartServer_btn";
            this.StartServer_btn.Size = new System.Drawing.Size(128, 46);
            this.StartServer_btn.TabIndex = 0;
            this.StartServer_btn.Text = "Start Server";
            this.StartServer_btn.UseVisualStyleBackColor = false;
            this.StartServer_btn.Click += new System.EventHandler(this.StartServer_btn_Click);
            // 
            // StopServer_btn
            // 
            this.StopServer_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.StopServer_btn.FlatAppearance.BorderSize = 0;
            this.StopServer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopServer_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopServer_btn.ForeColor = System.Drawing.Color.White;
            this.StopServer_btn.Location = new System.Drawing.Point(425, 263);
            this.StopServer_btn.Name = "StopServer_btn";
            this.StopServer_btn.Size = new System.Drawing.Size(128, 46);
            this.StopServer_btn.TabIndex = 1;
            this.StopServer_btn.Text = "Stop Server";
            this.StopServer_btn.UseVisualStyleBackColor = false;
            this.StopServer_btn.Click += new System.EventHandler(this.StopServer_btn_Click);
            // 
            // StartClient_btn
            // 
            this.StartClient_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.StartClient_btn.FlatAppearance.BorderSize = 0;
            this.StartClient_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartClient_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartClient_btn.ForeColor = System.Drawing.Color.White;
            this.StartClient_btn.Location = new System.Drawing.Point(252, 263);
            this.StartClient_btn.Name = "StartClient_btn";
            this.StartClient_btn.Size = new System.Drawing.Size(128, 46);
            this.StartClient_btn.TabIndex = 2;
            this.StartClient_btn.Text = "Start Client";
            this.StartClient_btn.UseVisualStyleBackColor = false;
            this.StartClient_btn.Click += new System.EventHandler(this.StartClient_btn_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(310, 20);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(181, 37);
            this.Title.TabIndex = 3;
            this.Title.Text = "Project Skrill";
            // 
            // Clientpath_Input
            // 
            this.Clientpath_Input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Clientpath_Input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Clientpath_Input.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clientpath_Input.ForeColor = System.Drawing.Color.White;
            this.Clientpath_Input.Location = new System.Drawing.Point(59, 404);
            this.Clientpath_Input.Name = "Clientpath_Input";
            this.Clientpath_Input.Size = new System.Drawing.Size(199, 22);
            this.Clientpath_Input.TabIndex = 6;
            this.Clientpath_Input.WordWrap = false;
            this.Clientpath_Input.TextChanged += new System.EventHandler(this.Clientpath_Input_TextChanged);
            // 
            // Serverpath_Input
            // 
            this.Serverpath_Input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Serverpath_Input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Serverpath_Input.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Serverpath_Input.ForeColor = System.Drawing.Color.White;
            this.Serverpath_Input.Location = new System.Drawing.Point(537, 404);
            this.Serverpath_Input.Name = "Serverpath_Input";
            this.Serverpath_Input.Size = new System.Drawing.Size(199, 22);
            this.Serverpath_Input.TabIndex = 7;
            this.Serverpath_Input.WordWrap = false;
            this.Serverpath_Input.TextChanged += new System.EventHandler(this.Serverpath_Input_TextChanged);
            // 
            // StopClient_btn
            // 
            this.StopClient_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.StopClient_btn.FlatAppearance.BorderSize = 0;
            this.StopClient_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopClient_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopClient_btn.ForeColor = System.Drawing.Color.White;
            this.StopClient_btn.Location = new System.Drawing.Point(608, 263);
            this.StopClient_btn.Name = "StopClient_btn";
            this.StopClient_btn.Size = new System.Drawing.Size(128, 46);
            this.StopClient_btn.TabIndex = 8;
            this.StopClient_btn.Text = "Stop Client";
            this.StopClient_btn.UseVisualStyleBackColor = false;
            this.StopClient_btn.Click += new System.EventHandler(this.StopClient_btn_Click);
            // 
            // mmoOption
            // 
            this.mmoOption.AutoSize = true;
            this.mmoOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.mmoOption.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmoOption.ForeColor = System.Drawing.Color.White;
            this.mmoOption.Location = new System.Drawing.Point(376, 403);
            this.mmoOption.Name = "mmoOption";
            this.mmoOption.Size = new System.Drawing.Size(66, 25);
            this.mmoOption.TabIndex = 9;
            this.mmoOption.Text = "mmo";
            this.mmoOption.UseVisualStyleBackColor = false;
            this.mmoOption.CheckedChanged += new System.EventHandler(this.mmoOption_CheckedChanged);
            // 
            // ServerpathTitle
            // 
            this.ServerpathTitle.AutoSize = true;
            this.ServerpathTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ServerpathTitle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ServerpathTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.ServerpathTitle.ForeColor = System.Drawing.Color.White;
            this.ServerpathTitle.Location = new System.Drawing.Point(553, 364);
            this.ServerpathTitle.Name = "ServerpathTitle";
            this.ServerpathTitle.Size = new System.Drawing.Size(166, 37);
            this.ServerpathTitle.TabIndex = 10;
            this.ServerpathTitle.Text = "Server path";
            // 
            // ClientpathTitle
            // 
            this.ClientpathTitle.AutoSize = true;
            this.ClientpathTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientpathTitle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ClientpathTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.ClientpathTitle.ForeColor = System.Drawing.Color.White;
            this.ClientpathTitle.Location = new System.Drawing.Point(79, 364);
            this.ClientpathTitle.Name = "ClientpathTitle";
            this.ClientpathTitle.Size = new System.Drawing.Size(158, 37);
            this.ClientpathTitle.TabIndex = 11;
            this.ClientpathTitle.Text = "Client path";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClientpathTitle);
            this.Controls.Add(this.ServerpathTitle);
            this.Controls.Add(this.mmoOption);
            this.Controls.Add(this.StopClient_btn);
            this.Controls.Add(this.Serverpath_Input);
            this.Controls.Add(this.Clientpath_Input);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.StartClient_btn);
            this.Controls.Add(this.StopServer_btn);
            this.Controls.Add(this.StartServer_btn);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "main";
            this.Text = "Project Skill Launcher";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartServer_btn;
        private System.Windows.Forms.Button StopServer_btn;
        private System.Windows.Forms.Button StartClient_btn;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox Clientpath_Input;
        private System.Windows.Forms.TextBox Serverpath_Input;
        private System.Windows.Forms.Button StopClient_btn;
        private System.Windows.Forms.CheckBox mmoOption;
        private System.Windows.Forms.Label ServerpathTitle;
        private System.Windows.Forms.Label ClientpathTitle;
    }
}

