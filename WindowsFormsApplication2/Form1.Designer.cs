namespace WindowsFormsApplication2
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
            this.lsbDevices = new System.Windows.Forms.ListBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.connect = new System.Windows.Forms.Button();
            this.addressList = new System.Windows.Forms.ListBox();
            this.targetName = new System.Windows.Forms.Label();
            this.targetAddress = new System.Windows.Forms.TextBox();
            this.AuthList = new System.Windows.Forms.ListBox();
            this.recieveButton = new System.Windows.Forms.Button();
            this.DataBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lsbDevices
            // 
            this.lsbDevices.FormattingEnabled = true;
            this.lsbDevices.Location = new System.Drawing.Point(80, 10);
            this.lsbDevices.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lsbDevices.Name = "lsbDevices";
            this.lsbDevices.Size = new System.Drawing.Size(202, 134);
            this.lsbDevices.TabIndex = 0;
            this.lsbDevices.SelectedIndexChanged += new System.EventHandler(this.selectTarget);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(9, 158);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(27, 13);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "blah";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(9, 184);
            this.search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(56, 19);
            this.search.TabIndex = 3;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(80, 184);
            this.connect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(56, 19);
            this.connect.TabIndex = 4;
            this.connect.Text = "Pair";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // addressList
            // 
            this.addressList.FormattingEnabled = true;
            this.addressList.Location = new System.Drawing.Point(285, 10);
            this.addressList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addressList.Name = "addressList";
            this.addressList.Size = new System.Drawing.Size(116, 134);
            this.addressList.TabIndex = 5;
            // 
            // targetName
            // 
            this.targetName.AutoSize = true;
            this.targetName.Location = new System.Drawing.Point(248, 158);
            this.targetName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.targetName.Name = "targetName";
            this.targetName.Size = new System.Drawing.Size(45, 13);
            this.targetName.TabIndex = 6;
            this.targetName.Text = "DEBUG";
            // 
            // targetAddress
            // 
            this.targetAddress.Location = new System.Drawing.Point(234, 185);
            this.targetAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.targetAddress.Name = "targetAddress";
            this.targetAddress.Size = new System.Drawing.Size(97, 20);
            this.targetAddress.TabIndex = 7;
            // 
            // AuthList
            // 
            this.AuthList.FormattingEnabled = true;
            this.AuthList.Location = new System.Drawing.Point(9, 10);
            this.AuthList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AuthList.Name = "AuthList";
            this.AuthList.Size = new System.Drawing.Size(67, 134);
            this.AuthList.TabIndex = 8;
            // 
            // recieveButton
            // 
            this.recieveButton.Location = new System.Drawing.Point(150, 184);
            this.recieveButton.Margin = new System.Windows.Forms.Padding(2);
            this.recieveButton.Name = "recieveButton";
            this.recieveButton.Size = new System.Drawing.Size(56, 19);
            this.recieveButton.TabIndex = 9;
            this.recieveButton.Text = "Recieve";
            this.recieveButton.UseVisualStyleBackColor = true;
            this.recieveButton.Click += new System.EventHandler(this.recieveButton_Click);
            // 
            // DataBox
            // 
            this.DataBox.Location = new System.Drawing.Point(406, 12);
            this.DataBox.Multiline = true;
            this.DataBox.Name = "DataBox";
            this.DataBox.Size = new System.Drawing.Size(202, 191);
            this.DataBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 217);
            this.Controls.Add(this.DataBox);
            this.Controls.Add(this.recieveButton);
            this.Controls.Add(this.AuthList);
            this.Controls.Add(this.targetAddress);
            this.Controls.Add(this.targetName);
            this.Controls.Add(this.addressList);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.search);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lsbDevices);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbDevices;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.ListBox addressList;
        private System.Windows.Forms.Label targetName;
        private System.Windows.Forms.TextBox targetAddress;
        private System.Windows.Forms.ListBox AuthList;
        private System.Windows.Forms.Button recieveButton;
        private System.Windows.Forms.TextBox DataBox;
    }
}

