using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subnetting
{
    public partial class FilteringForm : Form
    {
        private MainForm mainForm;

        private bool IsIPValid(string s)
        {
            return Helpers.ConvertIPToBytes(s).Length == 4 && s == Helpers.NormalizeIP(s);
        }
        private void FillTable(List<IPv4Network> data)
        {
            mainForm.DgvSubnetting.Rows.Clear();

            foreach (var ipv4network in data)
            {
                mainForm.DgvSubnetting.Rows.Add(ipv4network.GetInfo(mainForm.DisplayPowerOfTwo));
            }
        }
        private void ValidateInput()
        {
            bool allValid = true;

            if (chkIPAddress.Checked)
            {
                if (!IsIPValid(txtIPAddressFilter.Text))
                {
                    lblIPAddressFilterWarning.Visible = true;
                    allValid = false;
                }
                else
                    lblIPAddressFilterWarning.Visible = false;
            }

            if (chkCIDR.Checked)
            {
                ulong CIDR;
                if (!ulong.TryParse(txtCIDRFilter.Text, out CIDR) || CIDR > 32)
                {
                    lblCIDRFilterWarning.Visible = true;
                    allValid = false;
                }
                else
                    lblCIDRFilterWarning.Visible = false;
            }

            if (chkClass.Checked)
            {
                string ipClass = txtClassFilter.Text;
                if (ipClass != "A" && ipClass != "B" && ipClass != "C")
                {
                    lblClassFilterWarning.Visible = true;
                    allValid = false;
                }
                else
                    lblClassFilterWarning.Visible = false;
            }

            if (chkSubnetMask.Checked)
            {
                if (!IsIPValid(txtSubnetMaskFilter.Text))
                {
                    lblSubnetMaskFilterWarning.Visible = true;
                    allValid = false;
                }
                else
                    lblSubnetMaskFilterWarning.Visible = false;
            }

            if (chkNetworkIP.Checked)
            {
                if (!IsIPValid(txtNetworkIPFilter.Text))
                {
                    lblNetworkIPFilterWarning.Visible = true;
                    allValid = false;
                }
                else
                    lblNetworkIPFilterWarning.Visible = false;
            }

            if (chkSubnetIP.Checked)
            {
                if (!IsIPValid(txtSubnetIPFilter.Text))
                {
                    lblSubnetIPFilterWarning.Visible = true;
                    allValid = false;
                }
                else
                    lblSubnetIPFilterWarning.Visible = false;
            }

            if (chkSubnetBroadcastIP.Checked)
            {
                if (!IsIPValid(txtSubnetBroadcastIPFilter.Text))
                {
                    lblSubnetBroadcastIPFilterWarning.Visible = true;
                    allValid = false;
                }
                else
                    lblSubnetBroadcastIPFilterWarning.Visible = false;
            }

            if (chkNumberOfSubnets.Checked)
            {
                ulong numberOfSubnets;
                if (!ulong.TryParse(txtNumberOfSubnetsFilter.Text, out numberOfSubnets))
                {
                    lblNumberOfSubnets.Visible = true;
                    allValid = false;
                }
                else
                    lblNumberOfSubnets.Visible = false;
            }

            if (chkNumberOfHosts.Checked)
            {
                ulong numberOfHosts;
                if (!ulong.TryParse(txtNumberOfHostsFilter.Text, out numberOfHosts))
                {
                    lblNumberOfHosts.Visible = true;
                    allValid = false;
                }
                else
                    lblNumberOfHosts.Visible = false;
            }

            btnApply.Enabled = allValid;
        }
        public FilteringForm(MainForm form)
        {
            InitializeComponent();
            mainForm = form;
        }
        private void FilteringForm_Load(object sender, EventArgs e)
        {
            lblIPAddressFilterWarning.Text = "⚠️";
            lblCIDRFilterWarning.Text = "⚠️";
            lblClassFilterWarning.Text = "⚠️";
            lblSubnetMaskFilterWarning.Text = "⚠️";
            lblNetworkIPFilterWarning.Text = "⚠️";
            lblSubnetIPFilterWarning.Text = "⚠️";
            lblSubnetBroadcastIPFilterWarning.Text = "⚠️";
            lblNumberOfSubnets.Text = "⚠️";
            lblNumberOfHosts.Text = "⚠️";

            btnClearFilter.Enabled = false;
        }
        private void FilteringForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (btnClearFilter.Enabled)
                FillTable(mainForm.AllDataPerRow);

            mainForm.FilterTableButton.Enabled = true;
            mainForm.UpdateCount(mainForm.AllDataPerRow);
        }

        private void chkIPAddress_CheckedChanged(object sender, EventArgs e)
        {
            txtIPAddressFilter.Enabled = chkIPAddress.Checked;
            if (!chkIPAddress.Checked) lblIPAddressFilterWarning.Visible = false;
            ValidateInput();
        }

        private void chkCIDR_CheckedChanged(object sender, EventArgs e)
        {
            txtCIDRFilter.Enabled = chkCIDR.Checked;
            if (!chkCIDR.Checked) lblCIDRFilterWarning.Visible = false;
            ValidateInput();
        }

        private void chkClass_CheckedChanged(object sender, EventArgs e)
        {
            txtClassFilter.Enabled = chkClass.Checked;
            if (!chkClass.Checked) lblClassFilterWarning.Visible = false;
            ValidateInput();
        }

        private void chkSubnetMask_CheckedChanged(object sender, EventArgs e)
        {
            txtSubnetMaskFilter.Enabled = chkSubnetMask.Checked;
            if (!chkSubnetMask.Checked) lblSubnetMaskFilterWarning.Visible = false;
            ValidateInput();
        }

        private void chkNetworkIP_CheckedChanged(object sender, EventArgs e)
        {
            txtNetworkIPFilter.Enabled = chkNetworkIP.Checked;
            if (!chkNetworkIP.Checked) lblNetworkIPFilterWarning.Visible = false;
            ValidateInput();
        }

        private void chkSubnetIP_CheckedChanged(object sender, EventArgs e)
        {
            txtSubnetIPFilter.Enabled = chkSubnetIP.Checked;
            if (!chkSubnetIP.Checked) lblSubnetIPFilterWarning.Visible = false;
            ValidateInput();
        }

        private void chkSubnetBroadcastIP_CheckedChanged(object sender, EventArgs e)
        {
            txtSubnetBroadcastIPFilter.Enabled = chkSubnetBroadcastIP.Checked;
            if (!chkSubnetBroadcastIP.Checked) lblSubnetBroadcastIPFilterWarning.Visible = false;
            ValidateInput();
        }

        private void chkNumberOfSubnets_CheckedChanged(object sender, EventArgs e)
        {
            txtNumberOfSubnetsFilter.Enabled = chkNumberOfSubnets.Checked;
            if (!chkNumberOfSubnets.Checked) lblNumberOfSubnets.Visible = false;
            ValidateInput();
        }

        private void chkNumberOfHosts_CheckedChanged(object sender, EventArgs e)
        {
            txtNumberOfHostsFilter.Enabled = chkNumberOfHosts.Checked;
            if (!chkNumberOfHosts.Checked) lblNumberOfHosts.Visible = false;
            ValidateInput();
        }
        private void txtIPAddressFilter_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }

        private void txtCIDRFilter_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }

        private void txtClassFilter_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }

        private void txtSubnetMaskFilter_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }

        private void txtNetworkIPFilter_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }

        private void txtSubnetIPFilter_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }

        private void txtSubnetBroadcastIPFilter_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }

        private void txtNumberOfSubnetsFilter_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }

        private void txtNumberOfHostsFilter_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            mainForm.FilteredDataPerRow.Clear(); // Clear filtered list before using it

            foreach (var ipv4net in mainForm.AllDataPerRow)
            {
                if (chkIPAddress.Checked)
                    if (ipv4net.IPAddress.Address != txtIPAddressFilter.Text.Trim())
                        continue;

                if (chkCIDR.Checked)
                    if (ipv4net.CIDR != byte.Parse(txtCIDRFilter.Text.Trim()))
                        continue;

                if (chkClass.Checked)
                    if (ipv4net.ipClass.ToString() != txtClassFilter.Text.Trim())
                        continue;

                if (chkSubnetMask.Checked)
                    if (ipv4net.SubnetMask.Address != txtSubnetMaskFilter.Text.Trim())
                        continue;

                if (chkNetworkIP.Checked)
                    if (ipv4net.NetworkIP.Address != txtNetworkIPFilter.Text.Trim())
                        continue;

                if (chkSubnetIP.Checked)
                    if (ipv4net.SubnetIP.Address != txtSubnetIPFilter.Text.Trim())
                        continue;

                if (chkSubnetBroadcastIP.Checked)
                    if (ipv4net.SubnetBroadcastIP.Address != txtSubnetBroadcastIPFilter.Text)
                        continue;

                if (chkNumberOfSubnets.Checked)
                    if (!ulong.TryParse(txtNumberOfSubnetsFilter.Text.Trim(), out ulong filterSubnets) || ipv4net.NumberOfSubnets != filterSubnets)
                        continue;

                if (chkNumberOfHosts.Checked)
                    if (!ulong.TryParse(txtNumberOfHostsFilter.Text.Trim(), out ulong filterHosts) || ipv4net.NumberOfHosts != filterHosts)
                        continue;

                mainForm.FilteredDataPerRow.Add(ipv4net);
            }

            FillTable(mainForm.FilteredDataPerRow);

            btnClearFilter.Enabled = true;

            mainForm.UpdateCount(mainForm.FilteredDataPerRow);
        }
        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            FillTable(mainForm.AllDataPerRow);
            btnClearFilter.Enabled = false;
            mainForm.UpdateCount(mainForm.AllDataPerRow);
        }
    }
}