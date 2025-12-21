namespace Subnetting
{
    partial class FilteringForm
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
            chkIPAddress = new CheckBox();
            chkCIDR = new CheckBox();
            chkClass = new CheckBox();
            chkSubnetMask = new CheckBox();
            chkNetworkIP = new CheckBox();
            chkSubnetIP = new CheckBox();
            chkSubnetBroadcastIP = new CheckBox();
            chkNumberOfSubnets = new CheckBox();
            chkNumberOfHosts = new CheckBox();
            txtIPAddressFilter = new TextBox();
            txtCIDRFilter = new TextBox();
            txtClassFilter = new TextBox();
            txtSubnetMaskFilter = new TextBox();
            txtNetworkIPFilter = new TextBox();
            txtSubnetIPFilter = new TextBox();
            txtSubnetBroadcastIPFilter = new TextBox();
            txtNumberOfSubnetsFilter = new TextBox();
            txtNumberOfHostsFilter = new TextBox();
            btnApply = new Button();
            lblIPAddressFilterWarning = new Label();
            lblCIDRFilterWarning = new Label();
            lblClassFilterWarning = new Label();
            lblSubnetMaskFilterWarning = new Label();
            lblNetworkIPFilterWarning = new Label();
            lblSubnetIPFilterWarning = new Label();
            lblSubnetBroadcastIPFilterWarning = new Label();
            lblNumberOfSubnets = new Label();
            lblNumberOfHosts = new Label();
            btnClearFilter = new Button();
            SuspendLayout();
            // 
            // chkIPAddress
            // 
            chkIPAddress.AutoSize = true;
            chkIPAddress.Location = new Point(11, 14);
            chkIPAddress.Name = "chkIPAddress";
            chkIPAddress.Size = new Size(81, 19);
            chkIPAddress.TabIndex = 0;
            chkIPAddress.Text = "IP Address";
            chkIPAddress.UseVisualStyleBackColor = true;
            chkIPAddress.CheckedChanged += chkIPAddress_CheckedChanged;
            // 
            // chkCIDR
            // 
            chkCIDR.AutoSize = true;
            chkCIDR.Location = new Point(11, 43);
            chkCIDR.Name = "chkCIDR";
            chkCIDR.Size = new Size(52, 19);
            chkCIDR.TabIndex = 1;
            chkCIDR.Text = "CIDR";
            chkCIDR.UseVisualStyleBackColor = true;
            chkCIDR.CheckedChanged += chkCIDR_CheckedChanged;
            // 
            // chkClass
            // 
            chkClass.AutoSize = true;
            chkClass.Location = new Point(11, 72);
            chkClass.Name = "chkClass";
            chkClass.Size = new Size(53, 19);
            chkClass.TabIndex = 2;
            chkClass.Text = "Class";
            chkClass.UseVisualStyleBackColor = true;
            chkClass.CheckedChanged += chkClass_CheckedChanged;
            // 
            // chkSubnetMask
            // 
            chkSubnetMask.AutoSize = true;
            chkSubnetMask.Location = new Point(11, 101);
            chkSubnetMask.Name = "chkSubnetMask";
            chkSubnetMask.Size = new Size(94, 19);
            chkSubnetMask.TabIndex = 3;
            chkSubnetMask.Text = "Subnet Mask";
            chkSubnetMask.UseVisualStyleBackColor = true;
            chkSubnetMask.CheckedChanged += chkSubnetMask_CheckedChanged;
            // 
            // chkNetworkIP
            // 
            chkNetworkIP.AutoSize = true;
            chkNetworkIP.Location = new Point(11, 130);
            chkNetworkIP.Name = "chkNetworkIP";
            chkNetworkIP.Size = new Size(84, 19);
            chkNetworkIP.TabIndex = 4;
            chkNetworkIP.Text = "Network IP";
            chkNetworkIP.UseVisualStyleBackColor = true;
            chkNetworkIP.CheckedChanged += chkNetworkIP_CheckedChanged;
            // 
            // chkSubnetIP
            // 
            chkSubnetIP.AutoSize = true;
            chkSubnetIP.Location = new Point(11, 159);
            chkSubnetIP.Name = "chkSubnetIP";
            chkSubnetIP.Size = new Size(76, 19);
            chkSubnetIP.TabIndex = 5;
            chkSubnetIP.Text = "Subnet IP";
            chkSubnetIP.UseVisualStyleBackColor = true;
            chkSubnetIP.CheckedChanged += chkSubnetIP_CheckedChanged;
            // 
            // chkSubnetBroadcastIP
            // 
            chkSubnetBroadcastIP.AutoSize = true;
            chkSubnetBroadcastIP.Location = new Point(11, 188);
            chkSubnetBroadcastIP.Name = "chkSubnetBroadcastIP";
            chkSubnetBroadcastIP.Size = new Size(91, 19);
            chkSubnetBroadcastIP.TabIndex = 6;
            chkSubnetBroadcastIP.Text = "Broadcast IP";
            chkSubnetBroadcastIP.UseVisualStyleBackColor = true;
            chkSubnetBroadcastIP.CheckedChanged += chkSubnetBroadcastIP_CheckedChanged;
            // 
            // chkNumberOfSubnets
            // 
            chkNumberOfSubnets.AutoSize = true;
            chkNumberOfSubnets.Location = new Point(11, 217);
            chkNumberOfSubnets.Name = "chkNumberOfSubnets";
            chkNumberOfSubnets.Size = new Size(78, 19);
            chkNumberOfSubnets.TabIndex = 7;
            chkNumberOfSubnets.Text = "# Subnets";
            chkNumberOfSubnets.UseVisualStyleBackColor = true;
            chkNumberOfSubnets.CheckedChanged += chkNumberOfSubnets_CheckedChanged;
            // 
            // chkNumberOfHosts
            // 
            chkNumberOfHosts.AutoSize = true;
            chkNumberOfHosts.Location = new Point(11, 246);
            chkNumberOfHosts.Name = "chkNumberOfHosts";
            chkNumberOfHosts.Size = new Size(66, 19);
            chkNumberOfHosts.TabIndex = 8;
            chkNumberOfHosts.Text = "# Hosts";
            chkNumberOfHosts.UseVisualStyleBackColor = true;
            chkNumberOfHosts.CheckedChanged += chkNumberOfHosts_CheckedChanged;
            // 
            // txtIPAddressFilter
            // 
            txtIPAddressFilter.BorderStyle = BorderStyle.FixedSingle;
            txtIPAddressFilter.Enabled = false;
            txtIPAddressFilter.Location = new Point(127, 10);
            txtIPAddressFilter.Name = "txtIPAddressFilter";
            txtIPAddressFilter.Size = new Size(100, 23);
            txtIPAddressFilter.TabIndex = 9;
            txtIPAddressFilter.TextChanged += txtIPAddressFilter_TextChanged;
            // 
            // txtCIDRFilter
            // 
            txtCIDRFilter.BorderStyle = BorderStyle.FixedSingle;
            txtCIDRFilter.Enabled = false;
            txtCIDRFilter.Location = new Point(127, 39);
            txtCIDRFilter.Name = "txtCIDRFilter";
            txtCIDRFilter.Size = new Size(100, 23);
            txtCIDRFilter.TabIndex = 10;
            txtCIDRFilter.TextChanged += txtCIDRFilter_TextChanged;
            // 
            // txtClassFilter
            // 
            txtClassFilter.BorderStyle = BorderStyle.FixedSingle;
            txtClassFilter.Enabled = false;
            txtClassFilter.Location = new Point(127, 68);
            txtClassFilter.Name = "txtClassFilter";
            txtClassFilter.Size = new Size(100, 23);
            txtClassFilter.TabIndex = 11;
            txtClassFilter.TextChanged += txtClassFilter_TextChanged;
            // 
            // txtSubnetMaskFilter
            // 
            txtSubnetMaskFilter.BorderStyle = BorderStyle.FixedSingle;
            txtSubnetMaskFilter.Enabled = false;
            txtSubnetMaskFilter.Location = new Point(127, 97);
            txtSubnetMaskFilter.Name = "txtSubnetMaskFilter";
            txtSubnetMaskFilter.Size = new Size(100, 23);
            txtSubnetMaskFilter.TabIndex = 12;
            txtSubnetMaskFilter.TextChanged += txtSubnetMaskFilter_TextChanged;
            // 
            // txtNetworkIPFilter
            // 
            txtNetworkIPFilter.BorderStyle = BorderStyle.FixedSingle;
            txtNetworkIPFilter.Enabled = false;
            txtNetworkIPFilter.Location = new Point(127, 126);
            txtNetworkIPFilter.Name = "txtNetworkIPFilter";
            txtNetworkIPFilter.Size = new Size(100, 23);
            txtNetworkIPFilter.TabIndex = 13;
            txtNetworkIPFilter.TextChanged += txtNetworkIPFilter_TextChanged;
            // 
            // txtSubnetIPFilter
            // 
            txtSubnetIPFilter.BorderStyle = BorderStyle.FixedSingle;
            txtSubnetIPFilter.Enabled = false;
            txtSubnetIPFilter.Location = new Point(127, 155);
            txtSubnetIPFilter.Name = "txtSubnetIPFilter";
            txtSubnetIPFilter.Size = new Size(100, 23);
            txtSubnetIPFilter.TabIndex = 14;
            txtSubnetIPFilter.TextChanged += txtSubnetIPFilter_TextChanged;
            // 
            // txtSubnetBroadcastIPFilter
            // 
            txtSubnetBroadcastIPFilter.BorderStyle = BorderStyle.FixedSingle;
            txtSubnetBroadcastIPFilter.Enabled = false;
            txtSubnetBroadcastIPFilter.Location = new Point(127, 184);
            txtSubnetBroadcastIPFilter.Name = "txtSubnetBroadcastIPFilter";
            txtSubnetBroadcastIPFilter.Size = new Size(100, 23);
            txtSubnetBroadcastIPFilter.TabIndex = 15;
            txtSubnetBroadcastIPFilter.TextChanged += txtSubnetBroadcastIPFilter_TextChanged;
            // 
            // txtNumberOfSubnetsFilter
            // 
            txtNumberOfSubnetsFilter.BorderStyle = BorderStyle.FixedSingle;
            txtNumberOfSubnetsFilter.Enabled = false;
            txtNumberOfSubnetsFilter.Location = new Point(127, 213);
            txtNumberOfSubnetsFilter.Name = "txtNumberOfSubnetsFilter";
            txtNumberOfSubnetsFilter.Size = new Size(100, 23);
            txtNumberOfSubnetsFilter.TabIndex = 16;
            txtNumberOfSubnetsFilter.TextChanged += txtNumberOfSubnetsFilter_TextChanged;
            // 
            // txtNumberOfHostsFilter
            // 
            txtNumberOfHostsFilter.BorderStyle = BorderStyle.FixedSingle;
            txtNumberOfHostsFilter.Enabled = false;
            txtNumberOfHostsFilter.Location = new Point(127, 242);
            txtNumberOfHostsFilter.Name = "txtNumberOfHostsFilter";
            txtNumberOfHostsFilter.Size = new Size(100, 23);
            txtNumberOfHostsFilter.TabIndex = 17;
            txtNumberOfHostsFilter.TextChanged += txtNumberOfHostsFilter_TextChanged;
            // 
            // btnApply
            // 
            btnApply.Location = new Point(10, 284);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(116, 45);
            btnApply.TabIndex = 18;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // lblIPAddressFilterWarning
            // 
            lblIPAddressFilterWarning.AutoSize = true;
            lblIPAddressFilterWarning.Font = new Font("Segoe UI", 14F);
            lblIPAddressFilterWarning.Location = new Point(227, 8);
            lblIPAddressFilterWarning.Name = "lblIPAddressFilterWarning";
            lblIPAddressFilterWarning.Size = new Size(30, 25);
            lblIPAddressFilterWarning.TabIndex = 19;
            lblIPAddressFilterWarning.Text = "W";
            lblIPAddressFilterWarning.Visible = false;
            // 
            // lblCIDRFilterWarning
            // 
            lblCIDRFilterWarning.AutoSize = true;
            lblCIDRFilterWarning.Font = new Font("Segoe UI", 14F);
            lblCIDRFilterWarning.Location = new Point(227, 37);
            lblCIDRFilterWarning.Name = "lblCIDRFilterWarning";
            lblCIDRFilterWarning.Size = new Size(30, 25);
            lblCIDRFilterWarning.TabIndex = 20;
            lblCIDRFilterWarning.Text = "W";
            lblCIDRFilterWarning.Visible = false;
            // 
            // lblClassFilterWarning
            // 
            lblClassFilterWarning.AutoSize = true;
            lblClassFilterWarning.Font = new Font("Segoe UI", 14F);
            lblClassFilterWarning.Location = new Point(227, 67);
            lblClassFilterWarning.Name = "lblClassFilterWarning";
            lblClassFilterWarning.Size = new Size(30, 25);
            lblClassFilterWarning.TabIndex = 21;
            lblClassFilterWarning.Text = "W";
            lblClassFilterWarning.Visible = false;
            // 
            // lblSubnetMaskFilterWarning
            // 
            lblSubnetMaskFilterWarning.AutoSize = true;
            lblSubnetMaskFilterWarning.Font = new Font("Segoe UI", 14F);
            lblSubnetMaskFilterWarning.Location = new Point(227, 95);
            lblSubnetMaskFilterWarning.Name = "lblSubnetMaskFilterWarning";
            lblSubnetMaskFilterWarning.Size = new Size(30, 25);
            lblSubnetMaskFilterWarning.TabIndex = 22;
            lblSubnetMaskFilterWarning.Text = "W";
            lblSubnetMaskFilterWarning.Visible = false;
            // 
            // lblNetworkIPFilterWarning
            // 
            lblNetworkIPFilterWarning.AutoSize = true;
            lblNetworkIPFilterWarning.Font = new Font("Segoe UI", 14F);
            lblNetworkIPFilterWarning.Location = new Point(227, 124);
            lblNetworkIPFilterWarning.Name = "lblNetworkIPFilterWarning";
            lblNetworkIPFilterWarning.Size = new Size(30, 25);
            lblNetworkIPFilterWarning.TabIndex = 23;
            lblNetworkIPFilterWarning.Text = "W";
            lblNetworkIPFilterWarning.Visible = false;
            // 
            // lblSubnetIPFilterWarning
            // 
            lblSubnetIPFilterWarning.AutoSize = true;
            lblSubnetIPFilterWarning.Font = new Font("Segoe UI", 14F);
            lblSubnetIPFilterWarning.Location = new Point(227, 153);
            lblSubnetIPFilterWarning.Name = "lblSubnetIPFilterWarning";
            lblSubnetIPFilterWarning.Size = new Size(30, 25);
            lblSubnetIPFilterWarning.TabIndex = 24;
            lblSubnetIPFilterWarning.Text = "W";
            lblSubnetIPFilterWarning.Visible = false;
            // 
            // lblSubnetBroadcastIPFilterWarning
            // 
            lblSubnetBroadcastIPFilterWarning.AutoSize = true;
            lblSubnetBroadcastIPFilterWarning.Font = new Font("Segoe UI", 14F);
            lblSubnetBroadcastIPFilterWarning.Location = new Point(227, 182);
            lblSubnetBroadcastIPFilterWarning.Name = "lblSubnetBroadcastIPFilterWarning";
            lblSubnetBroadcastIPFilterWarning.Size = new Size(30, 25);
            lblSubnetBroadcastIPFilterWarning.TabIndex = 25;
            lblSubnetBroadcastIPFilterWarning.Text = "W";
            lblSubnetBroadcastIPFilterWarning.Visible = false;
            // 
            // lblNumberOfSubnets
            // 
            lblNumberOfSubnets.AutoSize = true;
            lblNumberOfSubnets.Font = new Font("Segoe UI", 14F);
            lblNumberOfSubnets.Location = new Point(227, 211);
            lblNumberOfSubnets.Name = "lblNumberOfSubnets";
            lblNumberOfSubnets.Size = new Size(30, 25);
            lblNumberOfSubnets.TabIndex = 26;
            lblNumberOfSubnets.Text = "W";
            lblNumberOfSubnets.Visible = false;
            // 
            // lblNumberOfHosts
            // 
            lblNumberOfHosts.AutoSize = true;
            lblNumberOfHosts.Font = new Font("Segoe UI", 14F);
            lblNumberOfHosts.Location = new Point(227, 240);
            lblNumberOfHosts.Name = "lblNumberOfHosts";
            lblNumberOfHosts.Size = new Size(30, 25);
            lblNumberOfHosts.TabIndex = 27;
            lblNumberOfHosts.Text = "W";
            lblNumberOfHosts.Visible = false;
            // 
            // btnClearFilter
            // 
            btnClearFilter.Location = new Point(132, 284);
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Size = new Size(116, 45);
            btnClearFilter.TabIndex = 28;
            btnClearFilter.Text = "Clear Filter";
            btnClearFilter.UseVisualStyleBackColor = true;
            btnClearFilter.Click += btnClearFilter_Click;
            // 
            // FilteringForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(258, 341);
            Controls.Add(btnClearFilter);
            Controls.Add(lblNumberOfHosts);
            Controls.Add(lblNumberOfSubnets);
            Controls.Add(lblSubnetBroadcastIPFilterWarning);
            Controls.Add(lblSubnetIPFilterWarning);
            Controls.Add(lblNetworkIPFilterWarning);
            Controls.Add(lblSubnetMaskFilterWarning);
            Controls.Add(lblClassFilterWarning);
            Controls.Add(lblCIDRFilterWarning);
            Controls.Add(lblIPAddressFilterWarning);
            Controls.Add(btnApply);
            Controls.Add(txtNumberOfHostsFilter);
            Controls.Add(txtNumberOfSubnetsFilter);
            Controls.Add(txtSubnetBroadcastIPFilter);
            Controls.Add(txtSubnetIPFilter);
            Controls.Add(txtNetworkIPFilter);
            Controls.Add(txtSubnetMaskFilter);
            Controls.Add(txtClassFilter);
            Controls.Add(txtCIDRFilter);
            Controls.Add(txtIPAddressFilter);
            Controls.Add(chkNumberOfHosts);
            Controls.Add(chkNumberOfSubnets);
            Controls.Add(chkSubnetBroadcastIP);
            Controls.Add(chkSubnetIP);
            Controls.Add(chkNetworkIP);
            Controls.Add(chkSubnetMask);
            Controls.Add(chkClass);
            Controls.Add(chkCIDR);
            Controls.Add(chkIPAddress);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FilteringForm";
            Text = "Filtering Tab";
            FormClosed += FilteringForm_FormClosed;
            Load += FilteringForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkIPAddress;
        private CheckBox chkCIDR;
        private CheckBox chkClass;
        private CheckBox chkSubnetMask;
        private CheckBox chkNetworkIP;
        private CheckBox chkSubnetIP;
        private CheckBox chkSubnetBroadcastIP;
        private CheckBox chkNumberOfSubnets;
        private CheckBox chkNumberOfHosts;
        private TextBox txtIPAddressFilter;
        private TextBox txtCIDRFilter;
        private TextBox txtClassFilter;
        private TextBox txtSubnetMaskFilter;
        private TextBox txtNetworkIPFilter;
        private TextBox txtSubnetIPFilter;
        private TextBox txtSubnetBroadcastIPFilter;
        private TextBox txtNumberOfSubnetsFilter;
        private TextBox txtNumberOfHostsFilter;
        private Button btnApply;
        private Label lblIPAddressFilterWarning;
        private Label lblCIDRFilterWarning;
        private Label lblClassFilterWarning;
        private Label lblSubnetMaskFilterWarning;
        private Label lblNetworkIPFilterWarning;
        private Label lblSubnetIPFilterWarning;
        private Label lblSubnetBroadcastIPFilterWarning;
        private Label lblNumberOfSubnets;
        private Label lblNumberOfHosts;
        private Button btnClearFilter;
    }
}