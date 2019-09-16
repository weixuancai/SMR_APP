namespace Client_Test
{
    partial class Form
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
            this.send = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.connect = new System.Windows.Forms.Button();
            this.logViewer = new System.Windows.Forms.ListBox();
            this.commandBox = new System.Windows.Forms.ComboBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.userCardNumber = new System.Windows.Forms.TextBox();
            this.addUser = new System.Windows.Forms.Button();
            this.receiveData = new System.Windows.Forms.Button();
            this.checkCi = new System.Windows.Forms.Button();
            this.timeZone = new System.Windows.Forms.Button();
            this.acsGroup = new System.Windows.Forms.Button();
            this.inquiryTZ = new System.Windows.Forms.Button();
            this.inquiryAG = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.delUser = new System.Windows.Forms.Button();
            this.cmb_Device = new System.Windows.Forms.ComboBox();
            this.btn_Inquiry_PAM = new System.Windows.Forms.Button();
            this.disconnect = new System.Windows.Forms.Button();
            this.btn_AddAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(12, 157);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(189, 21);
            this.send.TabIndex = 1;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.Send_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Device:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Command";
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(12, 56);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(189, 21);
            this.connect.TabIndex = 7;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // logViewer
            // 
            this.logViewer.FormattingEnabled = true;
            this.logViewer.ItemHeight = 12;
            this.logViewer.Location = new System.Drawing.Point(222, 11);
            this.logViewer.Name = "logViewer";
            this.logViewer.Size = new System.Drawing.Size(566, 196);
            this.logViewer.TabIndex = 8;
            this.logViewer.SelectedIndexChanged += new System.EventHandler(this.LogViewer_SelectedIndexChanged);
            // 
            // commandBox
            // 
            this.commandBox.FormattingEnabled = true;
            this.commandBox.Location = new System.Drawing.Point(12, 133);
            this.commandBox.Name = "commandBox";
            this.commandBox.Size = new System.Drawing.Size(189, 20);
            this.commandBox.TabIndex = 9;
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(12, 196);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(189, 22);
            this.userName.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "Card ID";
            // 
            // userCardNumber
            // 
            this.userCardNumber.Location = new System.Drawing.Point(12, 232);
            this.userCardNumber.Name = "userCardNumber";
            this.userCardNumber.Size = new System.Drawing.Size(189, 22);
            this.userCardNumber.TabIndex = 13;
            // 
            // addUser
            // 
            this.addUser.Location = new System.Drawing.Point(12, 256);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(189, 21);
            this.addUser.TabIndex = 14;
            this.addUser.Text = "Add User";
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // receiveData
            // 
            this.receiveData.Location = new System.Drawing.Point(222, 212);
            this.receiveData.Name = "receiveData";
            this.receiveData.Size = new System.Drawing.Size(75, 21);
            this.receiveData.TabIndex = 15;
            this.receiveData.Text = "Receive Data";
            this.receiveData.UseVisualStyleBackColor = true;
            this.receiveData.Click += new System.EventHandler(this.ReceiveData_Click);
            // 
            // checkCi
            // 
            this.checkCi.Location = new System.Drawing.Point(307, 212);
            this.checkCi.Name = "checkCi";
            this.checkCi.Size = new System.Drawing.Size(77, 21);
            this.checkCi.TabIndex = 16;
            this.checkCi.Text = "Check CI";
            this.checkCi.UseVisualStyleBackColor = true;
            this.checkCi.Click += new System.EventHandler(this.CheckCi_Click);
            // 
            // timeZone
            // 
            this.timeZone.Location = new System.Drawing.Point(396, 213);
            this.timeZone.Name = "timeZone";
            this.timeZone.Size = new System.Drawing.Size(80, 19);
            this.timeZone.TabIndex = 17;
            this.timeZone.Text = "TimeZone";
            this.timeZone.UseVisualStyleBackColor = true;
            this.timeZone.Click += new System.EventHandler(this.TimeZone_Click);
            // 
            // acsGroup
            // 
            this.acsGroup.Location = new System.Drawing.Point(492, 215);
            this.acsGroup.Name = "acsGroup";
            this.acsGroup.Size = new System.Drawing.Size(71, 18);
            this.acsGroup.TabIndex = 18;
            this.acsGroup.Text = "AcsGroup";
            this.acsGroup.UseVisualStyleBackColor = true;
            this.acsGroup.Click += new System.EventHandler(this.AcsGroup_Click);
            // 
            // inquiryTZ
            // 
            this.inquiryTZ.Location = new System.Drawing.Point(396, 248);
            this.inquiryTZ.Name = "inquiryTZ";
            this.inquiryTZ.Size = new System.Drawing.Size(79, 28);
            this.inquiryTZ.TabIndex = 19;
            this.inquiryTZ.Text = "InquiryTZ";
            this.inquiryTZ.UseVisualStyleBackColor = true;
            this.inquiryTZ.Click += new System.EventHandler(this.InquiryTZ_Click);
            // 
            // inquiryAG
            // 
            this.inquiryAG.Location = new System.Drawing.Point(497, 251);
            this.inquiryAG.Name = "inquiryAG";
            this.inquiryAG.Size = new System.Drawing.Size(65, 25);
            this.inquiryAG.TabIndex = 20;
            this.inquiryAG.Text = "Inquiry AG";
            this.inquiryAG.UseVisualStyleBackColor = true;
            this.inquiryAG.Click += new System.EventHandler(this.InquiryAG_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(585, 214);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 21;
            // 
            // delUser
            // 
            this.delUser.Location = new System.Drawing.Point(12, 284);
            this.delUser.Name = "delUser";
            this.delUser.Size = new System.Drawing.Size(189, 23);
            this.delUser.TabIndex = 22;
            this.delUser.Text = "Del User";
            this.delUser.UseVisualStyleBackColor = true;
            this.delUser.Click += new System.EventHandler(this.DelUser_Click);
            // 
            // cmb_Device
            // 
            this.cmb_Device.FormattingEnabled = true;
            this.cmb_Device.Location = new System.Drawing.Point(12, 30);
            this.cmb_Device.Name = "cmb_Device";
            this.cmb_Device.Size = new System.Drawing.Size(121, 20);
            this.cmb_Device.TabIndex = 23;
            // 
            // btn_Inquiry_PAM
            // 
            this.btn_Inquiry_PAM.Location = new System.Drawing.Point(585, 251);
            this.btn_Inquiry_PAM.Name = "btn_Inquiry_PAM";
            this.btn_Inquiry_PAM.Size = new System.Drawing.Size(75, 23);
            this.btn_Inquiry_PAM.TabIndex = 24;
            this.btn_Inquiry_PAM.Text = "查詢使用者";
            this.btn_Inquiry_PAM.UseVisualStyleBackColor = true;
            this.btn_Inquiry_PAM.Click += new System.EventHandler(this.Btn_Inquiry_PAM_Click);
            // 
            // disconnect
            // 
            this.disconnect.Location = new System.Drawing.Point(12, 84);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(189, 23);
            this.disconnect.TabIndex = 25;
            this.disconnect.Text = "Disconnect";
            this.disconnect.UseVisualStyleBackColor = true;
            this.disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // btn_AddAdmin
            // 
            this.btn_AddAdmin.Location = new System.Drawing.Point(585, 284);
            this.btn_AddAdmin.Name = "btn_AddAdmin";
            this.btn_AddAdmin.Size = new System.Drawing.Size(100, 23);
            this.btn_AddAdmin.TabIndex = 26;
            this.btn_AddAdmin.Text = "新增所有超級卡";
            this.btn_AddAdmin.UseVisualStyleBackColor = true;
            this.btn_AddAdmin.Click += new System.EventHandler(this.Btn_AddAdmin_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 325);
            this.Controls.Add(this.btn_AddAdmin);
            this.Controls.Add(this.disconnect);
            this.Controls.Add(this.btn_Inquiry_PAM);
            this.Controls.Add(this.cmb_Device);
            this.Controls.Add(this.delUser);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.inquiryAG);
            this.Controls.Add(this.inquiryTZ);
            this.Controls.Add(this.acsGroup);
            this.Controls.Add(this.timeZone);
            this.Controls.Add(this.checkCi);
            this.Controls.Add(this.receiveData);
            this.Controls.Add(this.addUser);
            this.Controls.Add(this.userCardNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.commandBox);
            this.Controls.Add(this.logViewer);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.send);
            this.Name = "Form";
            this.Text = "CardReader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.ListBox logViewer;
        private System.Windows.Forms.ComboBox commandBox;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox userCardNumber;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.Button receiveData;
        private System.Windows.Forms.Button checkCi;
        private System.Windows.Forms.Button timeZone;
        private System.Windows.Forms.Button acsGroup;
        private System.Windows.Forms.Button inquiryTZ;
        private System.Windows.Forms.Button inquiryAG;
        private System.Windows.Forms.TextBox textBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button delUser;
        private System.Windows.Forms.ComboBox cmb_Device;
        private System.Windows.Forms.Button btn_Inquiry_PAM;
        private System.Windows.Forms.Button disconnect;
        private System.Windows.Forms.Button btn_AddAdmin;
    }
}

