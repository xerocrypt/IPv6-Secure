namespace Client_Application_CS
{
    partial class frmClient
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
            this.tabContainer = new System.Windows.Forms.TabControl();
            this.tabMessaging = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMsgToSend = new System.Windows.Forms.TextBox();
            this.cmdJoin = new System.Windows.Forms.Button();
            this.cmdSendMsg = new System.Windows.Forms.Button();
            this.txtChatThread = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabContacts = new System.Windows.Forms.TabPage();
            this.tabMyNet = new System.Windows.Forms.TabPage();
            this.lblSearchGroupHelp = new System.Windows.Forms.Label();
            this.txtGroupSearch = new System.Windows.Forms.TextBox();
            this.cmdSubscribeGroup = new System.Windows.Forms.Button();
            this.cmdSearchGroup = new System.Windows.Forms.Button();
            this.lblFindGroup = new System.Windows.Forms.Label();
            this.grpMyNet = new System.Windows.Forms.GroupBox();
            this.webBrowserWin = new System.Windows.Forms.WebBrowser();
            this.lblGroups = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblMyNetTtitle = new System.Windows.Forms.Label();
            this.tabWeb = new System.Windows.Forms.TabPage();
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.txtNewAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdGenNewIPv6 = new System.Windows.Forms.Button();
            this.cmdLoadPrivateKey = new System.Windows.Forms.Button();
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.lblPrivateKey = new System.Windows.Forms.Label();
            this.lblClientConfigTitle = new System.Windows.Forms.Label();
            this.txtSessionKey = new System.Windows.Forms.TextBox();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtCurrentAddress = new System.Windows.Forms.TextBox();
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblSessionKey = new System.Windows.Forms.Label();
            this.lblIPv6Current = new System.Windows.Forms.Label();
            this.cmdSaveConfig = new System.Windows.Forms.Button();
            this.cmdGetCurrentIPv6 = new System.Windows.Forms.Button();
            this.cmdQuit = new System.Windows.Forms.Button();
            this.lblApplicationTitle = new System.Windows.Forms.Label();
            this.About = new System.Windows.Forms.TabPage();
            this.lblLCSP = new System.Windows.Forms.Label();
            this.lblSAGA = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSAGA = new System.Windows.Forms.TextBox();
            this.aboutLCSP = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.cmbNetInterfaces = new System.Windows.Forms.ComboBox();
            this.lblNetInterfaces = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lstPeers = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblContactDetails = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabContainer.SuspendLayout();
            this.tabMessaging.SuspendLayout();
            this.tabContacts.SuspendLayout();
            this.tabMyNet.SuspendLayout();
            this.grpMyNet.SuspendLayout();
            this.tabConfig.SuspendLayout();
            this.About.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabContainer
            // 
            this.tabContainer.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabContainer.Controls.Add(this.tabMessaging);
            this.tabContainer.Controls.Add(this.tabContacts);
            this.tabContainer.Controls.Add(this.tabMyNet);
            this.tabContainer.Controls.Add(this.tabWeb);
            this.tabContainer.Controls.Add(this.tabConfig);
            this.tabContainer.Controls.Add(this.About);
            this.tabContainer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabContainer.Location = new System.Drawing.Point(3, 49);
            this.tabContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabContainer.Name = "tabContainer";
            this.tabContainer.SelectedIndex = 0;
            this.tabContainer.Size = new System.Drawing.Size(1199, 627);
            this.tabContainer.TabIndex = 0;
            // 
            // tabMessaging
            // 
            this.tabMessaging.BackColor = System.Drawing.Color.White;
            this.tabMessaging.Controls.Add(this.label1);
            this.tabMessaging.Controls.Add(this.txtMsgToSend);
            this.tabMessaging.Controls.Add(this.cmdJoin);
            this.tabMessaging.Controls.Add(this.cmdSendMsg);
            this.tabMessaging.Controls.Add(this.txtChatThread);
            this.tabMessaging.Controls.Add(this.listBox1);
            this.tabMessaging.Location = new System.Drawing.Point(4, 28);
            this.tabMessaging.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabMessaging.Name = "tabMessaging";
            this.tabMessaging.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabMessaging.Size = new System.Drawing.Size(1191, 595);
            this.tabMessaging.TabIndex = 0;
            this.tabMessaging.Text = "Messaging";
            this.tabMessaging.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "MyNet";
            // 
            // txtMsgToSend
            // 
            this.txtMsgToSend.Location = new System.Drawing.Point(244, 419);
            this.txtMsgToSend.Name = "txtMsgToSend";
            this.txtMsgToSend.Size = new System.Drawing.Size(941, 22);
            this.txtMsgToSend.TabIndex = 5;
            // 
            // cmdJoin
            // 
            this.cmdJoin.BackColor = System.Drawing.Color.DarkViolet;
            this.cmdJoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdJoin.ForeColor = System.Drawing.Color.White;
            this.cmdJoin.Location = new System.Drawing.Point(128, 406);
            this.cmdJoin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdJoin.Name = "cmdJoin";
            this.cmdJoin.Size = new System.Drawing.Size(87, 28);
            this.cmdJoin.TabIndex = 4;
            this.cmdJoin.Text = "Join";
            this.cmdJoin.UseVisualStyleBackColor = false;
            this.cmdJoin.Click += new System.EventHandler(this.cmdJoin_Click);
            // 
            // cmdSendMsg
            // 
            this.cmdSendMsg.BackColor = System.Drawing.Color.DarkViolet;
            this.cmdSendMsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSendMsg.ForeColor = System.Drawing.Color.White;
            this.cmdSendMsg.Location = new System.Drawing.Point(1096, 448);
            this.cmdSendMsg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdSendMsg.Name = "cmdSendMsg";
            this.cmdSendMsg.Size = new System.Drawing.Size(87, 28);
            this.cmdSendMsg.TabIndex = 3;
            this.cmdSendMsg.Text = "Send";
            this.cmdSendMsg.UseVisualStyleBackColor = false;
            this.cmdSendMsg.Click += new System.EventHandler(this.cmdSendMsg_Click);
            // 
            // txtChatThread
            // 
            this.txtChatThread.Location = new System.Drawing.Point(242, 43);
            this.txtChatThread.Multiline = true;
            this.txtChatThread.Name = "txtChatThread";
            this.txtChatThread.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtChatThread.Size = new System.Drawing.Size(941, 349);
            this.txtChatThread.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Contacts",
            "Groups"});
            this.listBox1.Location = new System.Drawing.Point(13, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(202, 356);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tabContacts
            // 
            this.tabContacts.BackColor = System.Drawing.Color.White;
            this.tabContacts.Controls.Add(this.groupBox1);
            this.tabContacts.Controls.Add(this.label7);
            this.tabContacts.Controls.Add(this.lblContactDetails);
            this.tabContacts.Controls.Add(this.textBox1);
            this.tabContacts.Controls.Add(this.label6);
            this.tabContacts.Controls.Add(this.progressBar1);
            this.tabContacts.Location = new System.Drawing.Point(4, 28);
            this.tabContacts.Name = "tabContacts";
            this.tabContacts.Padding = new System.Windows.Forms.Padding(3);
            this.tabContacts.Size = new System.Drawing.Size(1191, 595);
            this.tabContacts.TabIndex = 5;
            this.tabContacts.Text = "Contacts";
            this.tabContacts.Click += new System.EventHandler(this.tabContacts_Click);
            // 
            // tabMyNet
            // 
            this.tabMyNet.BackColor = System.Drawing.Color.White;
            this.tabMyNet.Controls.Add(this.lblSearchGroupHelp);
            this.tabMyNet.Controls.Add(this.txtGroupSearch);
            this.tabMyNet.Controls.Add(this.cmdSubscribeGroup);
            this.tabMyNet.Controls.Add(this.cmdSearchGroup);
            this.tabMyNet.Controls.Add(this.lblFindGroup);
            this.tabMyNet.Controls.Add(this.grpMyNet);
            this.tabMyNet.Controls.Add(this.lblGroups);
            this.tabMyNet.Controls.Add(this.listView1);
            this.tabMyNet.Controls.Add(this.lblMyNetTtitle);
            this.tabMyNet.Location = new System.Drawing.Point(4, 28);
            this.tabMyNet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabMyNet.Name = "tabMyNet";
            this.tabMyNet.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabMyNet.Size = new System.Drawing.Size(1191, 595);
            this.tabMyNet.TabIndex = 1;
            this.tabMyNet.Text = "MyNet";
            // 
            // lblSearchGroupHelp
            // 
            this.lblSearchGroupHelp.AutoSize = true;
            this.lblSearchGroupHelp.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchGroupHelp.Location = new System.Drawing.Point(281, 97);
            this.lblSearchGroupHelp.Name = "lblSearchGroupHelp";
            this.lblSearchGroupHelp.Size = new System.Drawing.Size(203, 14);
            this.lblSearchGroupHelp.TabIndex = 9;
            this.lblSearchGroupHelp.Text = "Enter group name or broadcast address.";
            // 
            // txtGroupSearch
            // 
            this.txtGroupSearch.Location = new System.Drawing.Point(284, 72);
            this.txtGroupSearch.Name = "txtGroupSearch";
            this.txtGroupSearch.Size = new System.Drawing.Size(281, 22);
            this.txtGroupSearch.TabIndex = 8;
            // 
            // cmdSubscribeGroup
            // 
            this.cmdSubscribeGroup.BackColor = System.Drawing.Color.DarkViolet;
            this.cmdSubscribeGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSubscribeGroup.ForeColor = System.Drawing.Color.White;
            this.cmdSubscribeGroup.Location = new System.Drawing.Point(571, 105);
            this.cmdSubscribeGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdSubscribeGroup.Name = "cmdSubscribeGroup";
            this.cmdSubscribeGroup.Size = new System.Drawing.Size(87, 28);
            this.cmdSubscribeGroup.TabIndex = 7;
            this.cmdSubscribeGroup.Text = "Subscribe";
            this.cmdSubscribeGroup.UseVisualStyleBackColor = false;
            this.cmdSubscribeGroup.Click += new System.EventHandler(this.cmdSubscribeGroup_Click);
            // 
            // cmdSearchGroup
            // 
            this.cmdSearchGroup.BackColor = System.Drawing.Color.DarkViolet;
            this.cmdSearchGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSearchGroup.ForeColor = System.Drawing.Color.White;
            this.cmdSearchGroup.Location = new System.Drawing.Point(571, 69);
            this.cmdSearchGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdSearchGroup.Name = "cmdSearchGroup";
            this.cmdSearchGroup.Size = new System.Drawing.Size(87, 28);
            this.cmdSearchGroup.TabIndex = 6;
            this.cmdSearchGroup.Text = "Go...";
            this.cmdSearchGroup.UseVisualStyleBackColor = false;
            this.cmdSearchGroup.Click += new System.EventHandler(this.cmdSearchGroup_Click);
            // 
            // lblFindGroup
            // 
            this.lblFindGroup.AutoSize = true;
            this.lblFindGroup.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFindGroup.Location = new System.Drawing.Point(220, 72);
            this.lblFindGroup.Name = "lblFindGroup";
            this.lblFindGroup.Size = new System.Drawing.Size(57, 16);
            this.lblFindGroup.TabIndex = 5;
            this.lblFindGroup.Text = "Search:";
            // 
            // grpMyNet
            // 
            this.grpMyNet.Controls.Add(this.webBrowserWin);
            this.grpMyNet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpMyNet.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMyNet.ForeColor = System.Drawing.Color.DarkOrchid;
            this.grpMyNet.Location = new System.Drawing.Point(217, 140);
            this.grpMyNet.Name = "grpMyNet";
            this.grpMyNet.Size = new System.Drawing.Size(957, 352);
            this.grpMyNet.TabIndex = 4;
            this.grpMyNet.TabStop = false;
            this.grpMyNet.Text = "MyNet Feed";
            // 
            // webBrowserWin
            // 
            this.webBrowserWin.Location = new System.Drawing.Point(6, 31);
            this.webBrowserWin.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserWin.Name = "webBrowserWin";
            this.webBrowserWin.Size = new System.Drawing.Size(947, 274);
            this.webBrowserWin.TabIndex = 1;
            // 
            // lblGroups
            // 
            this.lblGroups.AutoSize = true;
            this.lblGroups.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroups.Location = new System.Drawing.Point(8, 53);
            this.lblGroups.Name = "lblGroups";
            this.lblGroups.Size = new System.Drawing.Size(53, 16);
            this.lblGroups.TabIndex = 3;
            this.lblGroups.Text = "Groups";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(8, 72);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(203, 420);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lblMyNetTtitle
            // 
            this.lblMyNetTtitle.AutoSize = true;
            this.lblMyNetTtitle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyNetTtitle.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblMyNetTtitle.Location = new System.Drawing.Point(8, 4);
            this.lblMyNetTtitle.Name = "lblMyNetTtitle";
            this.lblMyNetTtitle.Size = new System.Drawing.Size(94, 32);
            this.lblMyNetTtitle.TabIndex = 0;
            this.lblMyNetTtitle.Text = "MyNet";
            // 
            // tabWeb
            // 
            this.tabWeb.Location = new System.Drawing.Point(4, 28);
            this.tabWeb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabWeb.Name = "tabWeb";
            this.tabWeb.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabWeb.Size = new System.Drawing.Size(1191, 512);
            this.tabWeb.TabIndex = 2;
            this.tabWeb.Text = "Web";
            this.tabWeb.UseVisualStyleBackColor = true;
            // 
            // tabConfig
            // 
            this.tabConfig.BackColor = System.Drawing.Color.White;
            this.tabConfig.Controls.Add(this.lblNetInterfaces);
            this.tabConfig.Controls.Add(this.cmbNetInterfaces);
            this.tabConfig.Controls.Add(this.txtNewAddress);
            this.tabConfig.Controls.Add(this.label2);
            this.tabConfig.Controls.Add(this.cmdGenNewIPv6);
            this.tabConfig.Controls.Add(this.cmdLoadPrivateKey);
            this.tabConfig.Controls.Add(this.txtPrivateKey);
            this.tabConfig.Controls.Add(this.lblPrivateKey);
            this.tabConfig.Controls.Add(this.lblClientConfigTitle);
            this.tabConfig.Controls.Add(this.txtSessionKey);
            this.tabConfig.Controls.Add(this.txtClientName);
            this.tabConfig.Controls.Add(this.txtCurrentAddress);
            this.tabConfig.Controls.Add(this.lblAppName);
            this.tabConfig.Controls.Add(this.lblSessionKey);
            this.tabConfig.Controls.Add(this.lblIPv6Current);
            this.tabConfig.Controls.Add(this.cmdSaveConfig);
            this.tabConfig.Controls.Add(this.cmdGetCurrentIPv6);
            this.tabConfig.Location = new System.Drawing.Point(4, 28);
            this.tabConfig.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabConfig.Size = new System.Drawing.Size(1191, 595);
            this.tabConfig.TabIndex = 4;
            this.tabConfig.Text = "Settings";
            // 
            // txtNewAddress
            // 
            this.txtNewAddress.Location = new System.Drawing.Point(122, 211);
            this.txtNewAddress.Name = "txtNewAddress";
            this.txtNewAddress.Size = new System.Drawing.Size(507, 22);
            this.txtNewAddress.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "New Address:";
            // 
            // cmdGenNewIPv6
            // 
            this.cmdGenNewIPv6.BackColor = System.Drawing.Color.DarkViolet;
            this.cmdGenNewIPv6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGenNewIPv6.ForeColor = System.Drawing.SystemColors.Window;
            this.cmdGenNewIPv6.Location = new System.Drawing.Point(635, 211);
            this.cmdGenNewIPv6.Name = "cmdGenNewIPv6";
            this.cmdGenNewIPv6.Size = new System.Drawing.Size(75, 34);
            this.cmdGenNewIPv6.TabIndex = 12;
            this.cmdGenNewIPv6.Text = "Generate";
            this.cmdGenNewIPv6.UseVisualStyleBackColor = false;
            this.cmdGenNewIPv6.Click += new System.EventHandler(this.cmdGenNewIPv6_Click);
            // 
            // cmdLoadPrivateKey
            // 
            this.cmdLoadPrivateKey.BackColor = System.Drawing.Color.DarkViolet;
            this.cmdLoadPrivateKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdLoadPrivateKey.ForeColor = System.Drawing.SystemColors.Window;
            this.cmdLoadPrivateKey.Location = new System.Drawing.Point(637, 303);
            this.cmdLoadPrivateKey.Name = "cmdLoadPrivateKey";
            this.cmdLoadPrivateKey.Size = new System.Drawing.Size(75, 34);
            this.cmdLoadPrivateKey.TabIndex = 11;
            this.cmdLoadPrivateKey.Text = "Load...";
            this.cmdLoadPrivateKey.UseVisualStyleBackColor = false;
            this.cmdLoadPrivateKey.Click += new System.EventHandler(this.cmdLoadPrivateKey_Click);
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.Location = new System.Drawing.Point(124, 303);
            this.txtPrivateKey.Multiline = true;
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.Size = new System.Drawing.Size(507, 263);
            this.txtPrivateKey.TabIndex = 10;
            // 
            // lblPrivateKey
            // 
            this.lblPrivateKey.AutoSize = true;
            this.lblPrivateKey.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrivateKey.Location = new System.Drawing.Point(8, 306);
            this.lblPrivateKey.Name = "lblPrivateKey";
            this.lblPrivateKey.Size = new System.Drawing.Size(85, 16);
            this.lblPrivateKey.TabIndex = 9;
            this.lblPrivateKey.Text = "Private Key:";
            // 
            // lblClientConfigTitle
            // 
            this.lblClientConfigTitle.AutoSize = true;
            this.lblClientConfigTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientConfigTitle.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblClientConfigTitle.Location = new System.Drawing.Point(8, 16);
            this.lblClientConfigTitle.Name = "lblClientConfigTitle";
            this.lblClientConfigTitle.Size = new System.Drawing.Size(225, 27);
            this.lblClientConfigTitle.TabIndex = 8;
            this.lblClientConfigTitle.Text = "Client Configuration";
            // 
            // txtSessionKey
            // 
            this.txtSessionKey.Location = new System.Drawing.Point(124, 258);
            this.txtSessionKey.Name = "txtSessionKey";
            this.txtSessionKey.Size = new System.Drawing.Size(507, 22);
            this.txtSessionKey.TabIndex = 7;
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(130, 71);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(267, 22);
            this.txtClientName.TabIndex = 6;
            // 
            // txtCurrentAddress
            // 
            this.txtCurrentAddress.Location = new System.Drawing.Point(130, 121);
            this.txtCurrentAddress.Name = "txtCurrentAddress";
            this.txtCurrentAddress.Size = new System.Drawing.Size(499, 22);
            this.txtCurrentAddress.TabIndex = 5;
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.Location = new System.Drawing.Point(10, 74);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(49, 16);
            this.lblAppName.TabIndex = 4;
            this.lblAppName.Text = "Name:";
            // 
            // lblSessionKey
            // 
            this.lblSessionKey.AutoSize = true;
            this.lblSessionKey.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSessionKey.Location = new System.Drawing.Point(10, 261);
            this.lblSessionKey.Name = "lblSessionKey";
            this.lblSessionKey.Size = new System.Drawing.Size(89, 16);
            this.lblSessionKey.TabIndex = 3;
            this.lblSessionKey.Text = "Session Key:";
            // 
            // lblIPv6Current
            // 
            this.lblIPv6Current.AutoSize = true;
            this.lblIPv6Current.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPv6Current.Location = new System.Drawing.Point(8, 124);
            this.lblIPv6Current.Name = "lblIPv6Current";
            this.lblIPv6Current.Size = new System.Drawing.Size(113, 16);
            this.lblIPv6Current.TabIndex = 2;
            this.lblIPv6Current.Text = "Current Address:";
            // 
            // cmdSaveConfig
            // 
            this.cmdSaveConfig.BackColor = System.Drawing.Color.DarkViolet;
            this.cmdSaveConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSaveConfig.ForeColor = System.Drawing.SystemColors.Window;
            this.cmdSaveConfig.Location = new System.Drawing.Point(1105, 554);
            this.cmdSaveConfig.Name = "cmdSaveConfig";
            this.cmdSaveConfig.Size = new System.Drawing.Size(75, 34);
            this.cmdSaveConfig.TabIndex = 1;
            this.cmdSaveConfig.Text = "Save";
            this.cmdSaveConfig.UseVisualStyleBackColor = false;
            this.cmdSaveConfig.Click += new System.EventHandler(this.cmdSaveConfig_Click);
            // 
            // cmdGetCurrentIPv6
            // 
            this.cmdGetCurrentIPv6.BackColor = System.Drawing.Color.DarkViolet;
            this.cmdGetCurrentIPv6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGetCurrentIPv6.ForeColor = System.Drawing.SystemColors.Window;
            this.cmdGetCurrentIPv6.Location = new System.Drawing.Point(637, 115);
            this.cmdGetCurrentIPv6.Name = "cmdGetCurrentIPv6";
            this.cmdGetCurrentIPv6.Size = new System.Drawing.Size(75, 34);
            this.cmdGetCurrentIPv6.TabIndex = 0;
            this.cmdGetCurrentIPv6.Text = "Get";
            this.cmdGetCurrentIPv6.UseVisualStyleBackColor = false;
            this.cmdGetCurrentIPv6.Click += new System.EventHandler(this.cmdGenerateAddress_Click);
            // 
            // cmdQuit
            // 
            this.cmdQuit.BackColor = System.Drawing.Color.DarkViolet;
            this.cmdQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdQuit.ForeColor = System.Drawing.Color.White;
            this.cmdQuit.Location = new System.Drawing.Point(1100, 13);
            this.cmdQuit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdQuit.Name = "cmdQuit";
            this.cmdQuit.Size = new System.Drawing.Size(87, 28);
            this.cmdQuit.TabIndex = 2;
            this.cmdQuit.Text = "Quit";
            this.cmdQuit.UseVisualStyleBackColor = false;
            this.cmdQuit.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblApplicationTitle
            // 
            this.lblApplicationTitle.AutoSize = true;
            this.lblApplicationTitle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationTitle.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblApplicationTitle.Location = new System.Drawing.Point(12, 11);
            this.lblApplicationTitle.Name = "lblApplicationTitle";
            this.lblApplicationTitle.Size = new System.Drawing.Size(232, 32);
            this.lblApplicationTitle.TabIndex = 3;
            this.lblApplicationTitle.Text = "IPv6Secure Client";
            // 
            // About
            // 
            this.About.BackColor = System.Drawing.Color.White;
            this.About.Controls.Add(this.textBox4);
            this.About.Controls.Add(this.aboutLCSP);
            this.About.Controls.Add(this.txtSAGA);
            this.About.Controls.Add(this.label3);
            this.About.Controls.Add(this.lblSAGA);
            this.About.Controls.Add(this.lblLCSP);
            this.About.Location = new System.Drawing.Point(4, 28);
            this.About.Name = "About";
            this.About.Padding = new System.Windows.Forms.Padding(3);
            this.About.Size = new System.Drawing.Size(1191, 595);
            this.About.TabIndex = 6;
            this.About.Text = "About";
            // 
            // lblLCSP
            // 
            this.lblLCSP.AutoSize = true;
            this.lblLCSP.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLCSP.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblLCSP.Location = new System.Drawing.Point(9, 18);
            this.lblLCSP.Name = "lblLCSP";
            this.lblLCSP.Size = new System.Drawing.Size(473, 27);
            this.lblLCSP.TabIndex = 0;
            this.lblLCSP.Text = "Layered Communications Security Protocol";
            // 
            // lblSAGA
            // 
            this.lblSAGA.AutoSize = true;
            this.lblSAGA.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSAGA.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblSAGA.Location = new System.Drawing.Point(5, 193);
            this.lblSAGA.Name = "lblSAGA";
            this.lblSAGA.Size = new System.Drawing.Size(478, 27);
            this.lblSAGA.TabIndex = 1;
            this.lblSAGA.Text = "LCSP Secret Address Generation Algorithm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkViolet;
            this.label3.Location = new System.Drawing.Point(5, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Encryption and IPsec Tunnel";
            // 
            // txtSAGA
            // 
            this.txtSAGA.BackColor = System.Drawing.Color.White;
            this.txtSAGA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSAGA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSAGA.Location = new System.Drawing.Point(10, 232);
            this.txtSAGA.Multiline = true;
            this.txtSAGA.Name = "txtSAGA";
            this.txtSAGA.ReadOnly = true;
            this.txtSAGA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSAGA.Size = new System.Drawing.Size(635, 112);
            this.txtSAGA.TabIndex = 4;
            this.txtSAGA.Text = "This algorithm is used for generating a secret address within an IPv6\r\nrange, bas" +
    "ed on a session key.";
            this.txtSAGA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // aboutLCSP
            // 
            this.aboutLCSP.BackColor = System.Drawing.Color.White;
            this.aboutLCSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aboutLCSP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutLCSP.Location = new System.Drawing.Point(14, 62);
            this.aboutLCSP.Multiline = true;
            this.aboutLCSP.Name = "aboutLCSP";
            this.aboutLCSP.ReadOnly = true;
            this.aboutLCSP.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.aboutLCSP.Size = new System.Drawing.Size(631, 112);
            this.aboutLCSP.TabIndex = 5;
            this.aboutLCSP.Text = "This is the communications protocol used by the IPv6 client to establish secure c" +
    "ommunication \r\nsessions.\r\n";
            this.aboutLCSP.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(11, 396);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox4.Size = new System.Drawing.Size(634, 112);
            this.textBox4.TabIndex = 6;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // cmbNetInterfaces
            // 
            this.cmbNetInterfaces.FormattingEnabled = true;
            this.cmbNetInterfaces.Location = new System.Drawing.Point(199, 165);
            this.cmbNetInterfaces.Name = "cmbNetInterfaces";
            this.cmbNetInterfaces.Size = new System.Drawing.Size(430, 24);
            this.cmbNetInterfaces.TabIndex = 15;
            // 
            // lblNetInterfaces
            // 
            this.lblNetInterfaces.AutoSize = true;
            this.lblNetInterfaces.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetInterfaces.Location = new System.Drawing.Point(122, 168);
            this.lblNetInterfaces.Name = "lblNetInterfaces";
            this.lblNetInterfaces.Size = new System.Drawing.Size(74, 16);
            this.lblNetInterfaces.TabIndex = 16;
            this.lblNetInterfaces.Text = "Interfaces:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(268, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // lstPeers
            // 
            this.lstPeers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstPeers.FormattingEnabled = true;
            this.lstPeers.ItemHeight = 16;
            this.lstPeers.Location = new System.Drawing.Point(9, 134);
            this.lstPeers.Name = "lstPeers";
            this.lstPeers.ScrollAlwaysVisible = true;
            this.lstPeers.Size = new System.Drawing.Size(268, 336);
            this.lstPeers.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Groups:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Contacts:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(540, 564);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(640, 16);
            this.progressBar1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(415, 564);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Connection/Status:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(310, 113);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(458, 352);
            this.textBox1.TabIndex = 6;
            // 
            // lblContactDetails
            // 
            this.lblContactDetails.AutoSize = true;
            this.lblContactDetails.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactDetails.ForeColor = System.Drawing.Color.Black;
            this.lblContactDetails.Location = new System.Drawing.Point(310, 94);
            this.lblContactDetails.Name = "lblContactDetails";
            this.lblContactDetails.Size = new System.Drawing.Size(55, 16);
            this.lblContactDetails.TabIndex = 7;
            this.lblContactDetails.Text = "Details:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkViolet;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(311, 27);
            this.label7.TabIndex = 8;
            this.label7.Text = "Peers and Multicast Groups";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.lstPeers);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(11, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 519);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1205, 681);
            this.Controls.Add(this.lblApplicationTitle);
            this.Controls.Add(this.cmdQuit);
            this.Controls.Add(this.tabContainer);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmClient";
            this.Text = "IPv6Secure Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabContainer.ResumeLayout(false);
            this.tabMessaging.ResumeLayout(false);
            this.tabMessaging.PerformLayout();
            this.tabContacts.ResumeLayout(false);
            this.tabContacts.PerformLayout();
            this.tabMyNet.ResumeLayout(false);
            this.tabMyNet.PerformLayout();
            this.grpMyNet.ResumeLayout(false);
            this.tabConfig.ResumeLayout(false);
            this.tabConfig.PerformLayout();
            this.About.ResumeLayout(false);
            this.About.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabContainer;
        private System.Windows.Forms.TabPage tabMessaging;
        private System.Windows.Forms.TabPage tabMyNet;
        private System.Windows.Forms.TabPage tabWeb;
        private System.Windows.Forms.TabPage tabConfig;
        private System.Windows.Forms.Button cmdQuit;
        private System.Windows.Forms.TabPage tabContacts;
        private System.Windows.Forms.Label lblGroups;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.WebBrowser webBrowserWin;
        private System.Windows.Forms.Label lblMyNetTtitle;
        private System.Windows.Forms.Label lblClientConfigTitle;
        private System.Windows.Forms.TextBox txtSessionKey;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtCurrentAddress;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblSessionKey;
        private System.Windows.Forms.Label lblIPv6Current;
        private System.Windows.Forms.Button cmdSaveConfig;
        private System.Windows.Forms.Button cmdGetCurrentIPv6;
        private System.Windows.Forms.Label lblApplicationTitle;
        private System.Windows.Forms.Button cmdLoadPrivateKey;
        private System.Windows.Forms.TextBox txtPrivateKey;
        private System.Windows.Forms.Label lblPrivateKey;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMsgToSend;
        private System.Windows.Forms.Button cmdJoin;
        private System.Windows.Forms.Button cmdSendMsg;
        private System.Windows.Forms.TextBox txtChatThread;
        private System.Windows.Forms.Label lblSearchGroupHelp;
        private System.Windows.Forms.TextBox txtGroupSearch;
        private System.Windows.Forms.Button cmdSubscribeGroup;
        private System.Windows.Forms.Button cmdSearchGroup;
        private System.Windows.Forms.Label lblFindGroup;
        private System.Windows.Forms.GroupBox grpMyNet;
        private System.Windows.Forms.TextBox txtNewAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdGenNewIPv6;
        private System.Windows.Forms.TabPage About;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox aboutLCSP;
        private System.Windows.Forms.TextBox txtSAGA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSAGA;
        private System.Windows.Forms.Label lblLCSP;
        private System.Windows.Forms.Label lblNetInterfaces;
        private System.Windows.Forms.ComboBox cmbNetInterfaces;
        private System.Windows.Forms.Label lblContactDetails;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstPeers;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
    }
}

