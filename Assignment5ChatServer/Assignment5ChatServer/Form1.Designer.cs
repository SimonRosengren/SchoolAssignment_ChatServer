namespace Assignment5ChatServer
{
    partial class ServerForm
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
            this.messageDisplayBox = new System.Windows.Forms.TextBox();
            this.messageEnterBox = new System.Windows.Forms.TextBox();
            this.sendMessageButton = new System.Windows.Forms.Button();
            this.userListBox = new System.Windows.Forms.ListBox();
            this.kickButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messageDisplayBox
            // 
            this.messageDisplayBox.Location = new System.Drawing.Point(12, 157);
            this.messageDisplayBox.Multiline = true;
            this.messageDisplayBox.Name = "messageDisplayBox";
            this.messageDisplayBox.ReadOnly = true;
            this.messageDisplayBox.Size = new System.Drawing.Size(220, 182);
            this.messageDisplayBox.TabIndex = 0;
            // 
            // messageEnterBox
            // 
            this.messageEnterBox.Location = new System.Drawing.Point(12, 62);
            this.messageEnterBox.Name = "messageEnterBox";
            this.messageEnterBox.Size = new System.Drawing.Size(220, 20);
            this.messageEnterBox.TabIndex = 1;
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.Location = new System.Drawing.Point(12, 106);
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Size = new System.Drawing.Size(75, 23);
            this.sendMessageButton.TabIndex = 2;
            this.sendMessageButton.Text = "Send";
            this.sendMessageButton.UseVisualStyleBackColor = true;
            this.sendMessageButton.Click += new System.EventHandler(this.sendMessageButton_Click);
            // 
            // userListBox
            // 
            this.userListBox.FormattingEnabled = true;
            this.userListBox.Location = new System.Drawing.Point(238, 62);
            this.userListBox.Name = "userListBox";
            this.userListBox.Size = new System.Drawing.Size(102, 277);
            this.userListBox.TabIndex = 3;
            // 
            // kickButton
            // 
            this.kickButton.Location = new System.Drawing.Point(238, 33);
            this.kickButton.Name = "kickButton";
            this.kickButton.Size = new System.Drawing.Size(102, 23);
            this.kickButton.TabIndex = 4;
            this.kickButton.Text = "Kick";
            this.kickButton.UseVisualStyleBackColor = true;
            this.kickButton.Click += new System.EventHandler(this.kickButton_Click);
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 351);
            this.Controls.Add(this.kickButton);
            this.Controls.Add(this.userListBox);
            this.Controls.Add(this.sendMessageButton);
            this.Controls.Add(this.messageEnterBox);
            this.Controls.Add(this.messageDisplayBox);
            this.Name = "ServerForm";
            this.Text = "Chat Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox messageDisplayBox;
        private System.Windows.Forms.TextBox messageEnterBox;
        private System.Windows.Forms.Button sendMessageButton;
        private System.Windows.Forms.ListBox userListBox;
        private System.Windows.Forms.Button kickButton;
    }
}

