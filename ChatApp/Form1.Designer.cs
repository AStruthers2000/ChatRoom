namespace ChatApp
{
    partial class Chatroom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chatroom));
            this.ChatroomMain = new System.Windows.Forms.Panel();
            this.ChatroomMainTextbox = new System.Windows.Forms.RichTextBox();
            this.UserInputSendButton = new System.Windows.Forms.Button();
            this.UserInputTextBox = new System.Windows.Forms.TextBox();
            this.ChatroomMainID = new System.Windows.Forms.Label();
            this.LoginScreen = new System.Windows.Forms.Panel();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.ServerPasswordTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IPAddrTextbox = new System.Windows.Forms.TextBox();
            this.ChatroomMain.SuspendLayout();
            this.LoginScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChatroomMain
            // 
            this.ChatroomMain.BackColor = System.Drawing.Color.Black;
            this.ChatroomMain.Controls.Add(this.ChatroomMainTextbox);
            this.ChatroomMain.Controls.Add(this.UserInputSendButton);
            this.ChatroomMain.Controls.Add(this.UserInputTextBox);
            this.ChatroomMain.Controls.Add(this.ChatroomMainID);
            this.ChatroomMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChatroomMain.Location = new System.Drawing.Point(0, 0);
            this.ChatroomMain.Name = "ChatroomMain";
            this.ChatroomMain.Size = new System.Drawing.Size(500, 300);
            this.ChatroomMain.TabIndex = 0;
            this.ChatroomMain.Visible = false;
            // 
            // ChatroomMainTextbox
            // 
            this.ChatroomMainTextbox.BackColor = System.Drawing.Color.Black;
            this.ChatroomMainTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChatroomMainTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ChatroomMainTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChatroomMainTextbox.ForeColor = System.Drawing.Color.White;
            this.ChatroomMainTextbox.Location = new System.Drawing.Point(0, 35);
            this.ChatroomMainTextbox.Name = "ChatroomMainTextbox";
            this.ChatroomMainTextbox.ReadOnly = true;
            this.ChatroomMainTextbox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.ChatroomMainTextbox.Size = new System.Drawing.Size(800, 390);
            this.ChatroomMainTextbox.TabIndex = 3;
            this.ChatroomMainTextbox.Text = "";
            // 
            // UserInputSendButton
            // 
            this.UserInputSendButton.BackColor = System.Drawing.Color.Black;
            this.UserInputSendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserInputSendButton.FlatAppearance.BorderSize = 0;
            this.UserInputSendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserInputSendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInputSendButton.ForeColor = System.Drawing.Color.Crimson;
            this.UserInputSendButton.Location = new System.Drawing.Point(700, 425);
            this.UserInputSendButton.Margin = new System.Windows.Forms.Padding(0);
            this.UserInputSendButton.Name = "UserInputSendButton";
            this.UserInputSendButton.Size = new System.Drawing.Size(100, 75);
            this.UserInputSendButton.TabIndex = 2;
            this.UserInputSendButton.Text = "Send";
            this.UserInputSendButton.UseVisualStyleBackColor = false;
            this.UserInputSendButton.Click += new System.EventHandler(this.UserInputSendButton_Click);
            // 
            // UserInputTextBox
            // 
            this.UserInputTextBox.BackColor = System.Drawing.Color.Black;
            this.UserInputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInputTextBox.ForeColor = System.Drawing.Color.White;
            this.UserInputTextBox.Location = new System.Drawing.Point(0, 425);
            this.UserInputTextBox.Multiline = true;
            this.UserInputTextBox.Name = "UserInputTextBox";
            this.UserInputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UserInputTextBox.Size = new System.Drawing.Size(700, 75);
            this.UserInputTextBox.TabIndex = 1;
            this.UserInputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserInputTextBox_KeyDown);
            // 
            // ChatroomMainID
            // 
            this.ChatroomMainID.AutoSize = true;
            this.ChatroomMainID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChatroomMainID.ForeColor = System.Drawing.Color.Crimson;
            this.ChatroomMainID.Location = new System.Drawing.Point(0, 0);
            this.ChatroomMainID.Name = "ChatroomMainID";
            this.ChatroomMainID.Size = new System.Drawing.Size(393, 32);
            this.ChatroomMainID.TabIndex = 0;
            this.ChatroomMainID.Text = "Welcome to the Chat Room!";
            this.ChatroomMainID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginScreen
            // 
            this.LoginScreen.BackColor = System.Drawing.Color.Black;
            this.LoginScreen.Controls.Add(this.ErrorLabel);
            this.LoginScreen.Controls.Add(this.LoginButton);
            this.LoginScreen.Controls.Add(this.label3);
            this.LoginScreen.Controls.Add(this.UsernameTextbox);
            this.LoginScreen.Controls.Add(this.ServerPasswordTextbox);
            this.LoginScreen.Controls.Add(this.label2);
            this.LoginScreen.Controls.Add(this.label1);
            this.LoginScreen.Controls.Add(this.IPAddrTextbox);
            this.LoginScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginScreen.ForeColor = System.Drawing.Color.White;
            this.LoginScreen.Location = new System.Drawing.Point(0, 0);
            this.LoginScreen.Name = "LoginScreen";
            this.LoginScreen.Size = new System.Drawing.Size(500, 300);
            this.LoginScreen.TabIndex = 1;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Location = new System.Drawing.Point(0, 283);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 17);
            this.ErrorLabel.TabIndex = 7;
            // 
            // LoginButton
            // 
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(300, 0);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(200, 300);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "Log In!";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Username for Chatroom:";
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Location = new System.Drawing.Point(0, 220);
            this.UsernameTextbox.MaxLength = 30;
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(200, 22);
            this.UsernameTextbox.TabIndex = 4;
            // 
            // ServerPasswordTextbox
            // 
            this.ServerPasswordTextbox.Location = new System.Drawing.Point(0, 145);
            this.ServerPasswordTextbox.MaxLength = 30;
            this.ServerPasswordTextbox.Name = "ServerPasswordTextbox";
            this.ServerPasswordTextbox.PasswordChar = '*';
            this.ServerPasswordTextbox.Size = new System.Drawing.Size(200, 22);
            this.ServerPasswordTextbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Login Info For Server (comma seperated):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Host IP Address:";
            // 
            // IPAddrTextbox
            // 
            this.IPAddrTextbox.Location = new System.Drawing.Point(0, 70);
            this.IPAddrTextbox.MaxLength = 30;
            this.IPAddrTextbox.Name = "IPAddrTextbox";
            this.IPAddrTextbox.Size = new System.Drawing.Size(200, 22);
            this.IPAddrTextbox.TabIndex = 0;
            // 
            // Chatroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.LoginScreen);
            this.Controls.Add(this.ChatroomMain);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Chatroom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chatroom";
            this.ChatroomMain.ResumeLayout(false);
            this.ChatroomMain.PerformLayout();
            this.LoginScreen.ResumeLayout(false);
            this.LoginScreen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ChatroomMain;
        private System.Windows.Forms.Label ChatroomMainID;
        private System.Windows.Forms.TextBox UserInputTextBox;
        private System.Windows.Forms.Button UserInputSendButton;
        private System.Windows.Forms.RichTextBox ChatroomMainTextbox;
        private System.Windows.Forms.Panel LoginScreen;
        private System.Windows.Forms.TextBox IPAddrTextbox;
        private System.Windows.Forms.TextBox ServerPasswordTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UsernameTextbox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label ErrorLabel;
    }
}

