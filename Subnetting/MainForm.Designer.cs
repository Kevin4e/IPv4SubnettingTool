namespace Subnetting
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvSubetting = new DataGridView();
            colIPAddress = new DataGridViewTextBoxColumn();
            colCIDR = new DataGridViewTextBoxColumn();
            colClass = new DataGridViewTextBoxColumn();
            colSubnetMask = new DataGridViewTextBoxColumn();
            colNetworkIP = new DataGridViewTextBoxColumn();
            colSubnetIP = new DataGridViewTextBoxColumn();
            colSubnetBroadcastIP = new DataGridViewTextBoxColumn();
            colNumberOfSubnets = new DataGridViewTextBoxColumn();
            colNumberOfHosts = new DataGridViewTextBoxColumn();
            txtIPAddress = new TextBox();
            btnCompute = new Button();
            lblIPAddress = new Label();
            lblCIDR = new Label();
            grpInputData = new GroupBox();
            lblWarning = new Label();
            nudCIDR = new NumericUpDown();
            btnGenerateData = new Button();
            nudNumberOfRandomEntriesToAdd = new NumericUpDown();
            lblNumberOfRandomEntriesToAdd = new Label();
            btnGenerateEntries = new Button();
            btnFilterTable = new Button();
            grpGenerate = new GroupBox();
            grpOthers = new GroupBox();
            btnClearTable = new Button();
            chkDisplayPowerOfTwo = new CheckBox();
            lblEntriesCount = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSubetting).BeginInit();
            grpInputData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCIDR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNumberOfRandomEntriesToAdd).BeginInit();
            grpGenerate.SuspendLayout();
            grpOthers.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSubetting
            // 
            dgvSubetting.AllowUserToResizeColumns = false;
            dgvSubetting.AllowUserToResizeRows = false;
            dgvSubetting.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgvSubetting.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubetting.Columns.AddRange(new DataGridViewColumn[] { colIPAddress, colCIDR, colClass, colSubnetMask, colNetworkIP, colSubnetIP, colSubnetBroadcastIP, colNumberOfSubnets, colNumberOfHosts });
            dgvSubetting.Location = new Point(0, 39);
            dgvSubetting.Name = "dgvSubetting";
            dgvSubetting.ReadOnly = true;
            dgvSubetting.Size = new Size(943, 410);
            dgvSubetting.TabIndex = 22;
            // 
            // colIPAddress
            // 
            colIPAddress.HeaderText = "IP Address";
            colIPAddress.Name = "colIPAddress";
            colIPAddress.ReadOnly = true;
            // 
            // colCIDR
            // 
            colCIDR.HeaderText = "CIDR";
            colCIDR.Name = "colCIDR";
            colCIDR.ReadOnly = true;
            // 
            // colClass
            // 
            colClass.HeaderText = "Class";
            colClass.Name = "colClass";
            colClass.ReadOnly = true;
            // 
            // colSubnetMask
            // 
            colSubnetMask.HeaderText = "Subnet Mask";
            colSubnetMask.Name = "colSubnetMask";
            colSubnetMask.ReadOnly = true;
            // 
            // colNetworkIP
            // 
            colNetworkIP.HeaderText = "Network IP";
            colNetworkIP.Name = "colNetworkIP";
            colNetworkIP.ReadOnly = true;
            // 
            // colSubnetIP
            // 
            colSubnetIP.HeaderText = "Subnet IP";
            colSubnetIP.Name = "colSubnetIP";
            colSubnetIP.ReadOnly = true;
            // 
            // colSubnetBroadcastIP
            // 
            colSubnetBroadcastIP.HeaderText = "Broadcast IP";
            colSubnetBroadcastIP.Name = "colSubnetBroadcastIP";
            colSubnetBroadcastIP.ReadOnly = true;
            // 
            // colNumberOfSubnets
            // 
            colNumberOfSubnets.HeaderText = "# Subnets";
            colNumberOfSubnets.Name = "colNumberOfSubnets";
            colNumberOfSubnets.ReadOnly = true;
            // 
            // colNumberOfHosts
            // 
            colNumberOfHosts.HeaderText = "# Hosts";
            colNumberOfHosts.Name = "colNumberOfHosts";
            colNumberOfHosts.ReadOnly = true;
            // 
            // txtIPAddress
            // 
            txtIPAddress.BorderStyle = BorderStyle.FixedSingle;
            txtIPAddress.Location = new Point(6, 44);
            txtIPAddress.Name = "txtIPAddress";
            txtIPAddress.Size = new Size(100, 23);
            txtIPAddress.TabIndex = 23;
            txtIPAddress.Text = "192.168.1.0";
            txtIPAddress.TextChanged += txtIPAddress_TextChanged;
            // 
            // btnCompute
            // 
            btnCompute.Location = new Point(138, 43);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(114, 46);
            btnCompute.TabIndex = 24;
            btnCompute.Text = "Compute";
            btnCompute.UseVisualStyleBackColor = true;
            btnCompute.Click += btnCompute_Click;
            // 
            // lblIPAddress
            // 
            lblIPAddress.AutoSize = true;
            lblIPAddress.Location = new Point(6, 26);
            lblIPAddress.Name = "lblIPAddress";
            lblIPAddress.Size = new Size(62, 15);
            lblIPAddress.TabIndex = 25;
            lblIPAddress.Text = "IP Address";
            // 
            // lblCIDR
            // 
            lblCIDR.AutoSize = true;
            lblCIDR.Location = new Point(6, 75);
            lblCIDR.Name = "lblCIDR";
            lblCIDR.Size = new Size(33, 15);
            lblCIDR.TabIndex = 26;
            lblCIDR.Text = "CIDR";
            // 
            // grpInputData
            // 
            grpInputData.Controls.Add(lblWarning);
            grpInputData.Controls.Add(nudCIDR);
            grpInputData.Controls.Add(lblIPAddress);
            grpInputData.Controls.Add(txtIPAddress);
            grpInputData.Controls.Add(lblCIDR);
            grpInputData.Controls.Add(btnCompute);
            grpInputData.Location = new Point(12, 455);
            grpInputData.Name = "grpInputData";
            grpInputData.Size = new Size(264, 127);
            grpInputData.TabIndex = 29;
            grpInputData.TabStop = false;
            grpInputData.Text = "Input Data";
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.Font = new Font("Segoe UI", 8F);
            lblWarning.Location = new Point(61, 97);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(115, 13);
            lblWarning.TabIndex = 29;
            lblWarning.Text = "Warning Placeholder";
            lblWarning.Visible = false;
            // 
            // nudCIDR
            // 
            nudCIDR.Location = new Point(6, 92);
            nudCIDR.Maximum = new decimal(new int[] { 32, 0, 0, 0 });
            nudCIDR.Name = "nudCIDR";
            nudCIDR.Size = new Size(52, 23);
            nudCIDR.TabIndex = 28;
            nudCIDR.Value = new decimal(new int[] { 24, 0, 0, 0 });
            nudCIDR.ValueChanged += nudCIDR_ValueChanged;
            // 
            // btnGenerateData
            // 
            btnGenerateData.Location = new Point(12, 22);
            btnGenerateData.Name = "btnGenerateData";
            btnGenerateData.Size = new Size(185, 33);
            btnGenerateData.TabIndex = 30;
            btnGenerateData.Text = "Generate Data";
            btnGenerateData.UseVisualStyleBackColor = true;
            btnGenerateData.Click += btnGenerateData_Click;
            // 
            // nudNumberOfRandomEntriesToAdd
            // 
            nudNumberOfRandomEntriesToAdd.Location = new Point(12, 94);
            nudNumberOfRandomEntriesToAdd.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudNumberOfRandomEntriesToAdd.Name = "nudNumberOfRandomEntriesToAdd";
            nudNumberOfRandomEntriesToAdd.Size = new Size(47, 23);
            nudNumberOfRandomEntriesToAdd.TabIndex = 32;
            // 
            // lblNumberOfRandomEntriesToAdd
            // 
            lblNumberOfRandomEntriesToAdd.AutoSize = true;
            lblNumberOfRandomEntriesToAdd.Location = new Point(12, 71);
            lblNumberOfRandomEntriesToAdd.Name = "lblNumberOfRandomEntriesToAdd";
            lblNumberOfRandomEntriesToAdd.Size = new Size(185, 15);
            lblNumberOfRandomEntriesToAdd.TabIndex = 33;
            lblNumberOfRandomEntriesToAdd.Text = "Number of random entries to add";
            // 
            // btnGenerateEntries
            // 
            btnGenerateEntries.Location = new Point(65, 93);
            btnGenerateEntries.Name = "btnGenerateEntries";
            btnGenerateEntries.Size = new Size(132, 25);
            btnGenerateEntries.TabIndex = 34;
            btnGenerateEntries.Text = "Generate Entries";
            btnGenerateEntries.UseVisualStyleBackColor = true;
            btnGenerateEntries.Click += btnGenerateEntries_Click;
            // 
            // btnFilterTable
            // 
            btnFilterTable.Location = new Point(31, 21);
            btnFilterTable.Name = "btnFilterTable";
            btnFilterTable.Size = new Size(162, 43);
            btnFilterTable.TabIndex = 35;
            btnFilterTable.Text = "Filter Table";
            btnFilterTable.UseVisualStyleBackColor = true;
            btnFilterTable.Click += btnFilterTable_Click;
            // 
            // grpGenerate
            // 
            grpGenerate.Controls.Add(lblNumberOfRandomEntriesToAdd);
            grpGenerate.Controls.Add(btnGenerateEntries);
            grpGenerate.Controls.Add(btnGenerateData);
            grpGenerate.Controls.Add(nudNumberOfRandomEntriesToAdd);
            grpGenerate.Location = new Point(367, 455);
            grpGenerate.Name = "grpGenerate";
            grpGenerate.Size = new Size(209, 127);
            grpGenerate.TabIndex = 36;
            grpGenerate.TabStop = false;
            grpGenerate.Text = "Generate";
            // 
            // grpOthers
            // 
            grpOthers.Controls.Add(btnClearTable);
            grpOthers.Controls.Add(btnFilterTable);
            grpOthers.Location = new Point(708, 455);
            grpOthers.Name = "grpOthers";
            grpOthers.Size = new Size(223, 127);
            grpOthers.TabIndex = 37;
            grpOthers.TabStop = false;
            grpOthers.Text = "Others";
            // 
            // btnClearTable
            // 
            btnClearTable.Location = new Point(31, 72);
            btnClearTable.Name = "btnClearTable";
            btnClearTable.Size = new Size(162, 43);
            btnClearTable.TabIndex = 36;
            btnClearTable.Text = "Clear Table";
            btnClearTable.UseVisualStyleBackColor = true;
            btnClearTable.Click += btnClearTable_Click;
            // 
            // chkDisplayPowerOfTwo
            // 
            chkDisplayPowerOfTwo.AutoSize = true;
            chkDisplayPowerOfTwo.Location = new Point(12, 9);
            chkDisplayPowerOfTwo.Name = "chkDisplayPowerOfTwo";
            chkDisplayPowerOfTwo.Size = new Size(213, 19);
            chkDisplayPowerOfTwo.TabIndex = 0;
            chkDisplayPowerOfTwo.Text = "Show Hosts/Subnets as Powers of 2";
            chkDisplayPowerOfTwo.UseVisualStyleBackColor = true;
            chkDisplayPowerOfTwo.CheckedChanged += chkDisplayPowerOfTwo_CheckedChanged;
            // 
            // lblEntriesCount
            // 
            lblEntriesCount.AutoSize = true;
            lblEntriesCount.Location = new Point(807, 13);
            lblEntriesCount.Name = "lblEntriesCount";
            lblEntriesCount.RightToLeft = RightToLeft.Yes;
            lblEntriesCount.Size = new Size(128, 15);
            lblEntriesCount.TabIndex = 39;
            lblEntriesCount.Text = "Showing: X of Y Entries";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 592);
            Controls.Add(chkDisplayPowerOfTwo);
            Controls.Add(lblEntriesCount);
            Controls.Add(grpOthers);
            Controls.Add(grpGenerate);
            Controls.Add(grpInputData);
            Controls.Add(dgvSubetting);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "IPv4 Subnetting Tool by Kevin4e | v1.0.1";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSubetting).EndInit();
            grpInputData.ResumeLayout(false);
            grpInputData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCIDR).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNumberOfRandomEntriesToAdd).EndInit();
            grpGenerate.ResumeLayout(false);
            grpGenerate.PerformLayout();
            grpOthers.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSubetting;
        private TextBox txtIPAddress;
        private Button btnCompute;
        private Label lblIPAddress;
        private Label lblCIDR;
        private GroupBox grpInputData;
        private Button btnGenerateData;
        private NumericUpDown nudNumberOfRandomEntriesToAdd;
        private Label lblNumberOfRandomEntriesToAdd;
        private Button btnGenerateEntries;
        private Button btnFilterTable;
        private DataGridViewTextBoxColumn colIPAddress;
        private DataGridViewTextBoxColumn colCIDR;
        private DataGridViewTextBoxColumn colClass;
        private DataGridViewTextBoxColumn colSubnetMask;
        private DataGridViewTextBoxColumn colNetworkIP;
        private DataGridViewTextBoxColumn colSubnetIP;
        private DataGridViewTextBoxColumn colSubnetBroadcastIP;
        private DataGridViewTextBoxColumn colNumberOfSubnets;
        private DataGridViewTextBoxColumn colNumberOfHosts;
        private GroupBox grpGenerate;
        private GroupBox grpOthers;
        private NumericUpDown nudCIDR;
        private Label lblWarning;
        private Button btnClearTable;
        private CheckBox chkDisplayPowerOfTwo;
        private Label lblEntriesCount;
    }
}
