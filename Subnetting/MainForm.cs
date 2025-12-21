using Subnetting;
using System.ComponentModel;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Subnetting
{
    public partial class MainForm : Form
    {
        private TextBox nudTextBox;

        List<IPv4Network> allDataPerRow = new List<IPv4Network>();
        List<IPv4Network> filteredDataPerRow = new List<IPv4Network>();

        bool displayPowerOfTwo;

        // Default values
        byte[] Bytes = { 192, 168, 1, 0 };
        byte CIDR = 24;

        /* Properties */

        public Button FilterTableButton => btnFilterTable;
        public List<IPv4Network> AllDataPerRow => allDataPerRow;
        public List<IPv4Network> FilteredDataPerRow => filteredDataPerRow;
        public DataGridView DgvSubnetting => dgvSubetting;
        public bool DisplayPowerOfTwo => displayPowerOfTwo;

        private void ValidateInput()
        {
            Bytes = Helpers.ConvertIPToBytes(txtIPAddress.Text);
            bool IsIPValid = Bytes.Length == 4 && txtIPAddress.Text == Helpers.NormalizeIP(txtIPAddress.Text);

            if (IsIPValid)
            {
                btnCompute.Enabled = true;

                if (Bytes[0] == 127)
                {
                    lblWarning.Text = "⚠️ IP Address is loopback";
                    lblWarning.Visible = true;
                }
                else if (Bytes[0] > 223)
                {
                    lblWarning.Text = "⚠️ IP Address is multicast";
                    lblWarning.Visible = true;
                }
                else if (Bytes[0] == 169 && Bytes[1] == 254)
                {
                    lblWarning.Text = "⚠️ IP Address is link-local";
                    lblWarning.Visible = true;
                }
                else
                {
                    byte minCIDR = Helpers.GetClassfulCIDR(new IPv4(Bytes));

                    lblWarning.Visible = CIDR < minCIDR;

                    if (lblWarning.Visible)
                        lblWarning.Text = "⚠️ CIDR is below the IP class standard";
                }
            }
            else
            {
                btnCompute.Enabled = false;
                lblWarning.Visible = false;
                lblWarning.Visible = false;
            }
        }
        public void UpdateCount(List<IPv4Network> data)
        {
            lblEntriesCount.Text = $"Showing: {data.Count} of {allDataPerRow.Count} entries";
            lblEntriesCount.Left = ClientSize.Width - (lblEntriesCount.Width + 10);
        }
        private void DisplaySubnetsHosts(List<IPv4Network> DataToUse, bool displayMode)
        {
            if (displayPowerOfTwo)
            {
                for (int i = 0; i < dgvSubetting.Rows.Count - 1; ++i)
                {
                    IPv4Network ipNet = DataToUse[i];

                    byte subnetsExp = Helpers.GetExponent(ipNet.NumberOfSubnets);
                    byte hostsExp = Helpers.GetExponent(ipNet.NumberOfHosts + 2);

                    dgvSubetting.Rows[i].Cells[7].Value = $"2^{subnetsExp}";
                    dgvSubetting.Rows[i].Cells[8].Value = $"(2^{hostsExp}) - 2";
                }
            }
            else
            {
                for (int i = 0; i < dgvSubetting.Rows.Count - 1; ++i)
                {
                    IPv4Network ipNet = DataToUse[i];

                    dgvSubetting.Rows[i].Cells[7].Value = ipNet.NumberOfSubnets;
                    dgvSubetting.Rows[i].Cells[8].Value = ipNet.NumberOfHosts;
                }
            }
        }
        public MainForm()
        {
            InitializeComponent();

            nudTextBox = (TextBox)nudCIDR.Controls[1];
            nudTextBox.TextChanged += nudTextBox_TextChanged;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            lblEntriesCount.Text = "Showing: 0 of 0 entries";
        }
        private void txtIPAddress_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }
        private void nudCIDR_ValueChanged(object sender, EventArgs e)
        {
            CIDR = (byte)nudCIDR.Value;
            ValidateInput();
        }
        private void nudTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(nudTextBox.Text, out decimal val))
                return; // Invalid input, do nothing

            // Clamp to NumericUpDown limits
            if (val < nudCIDR.Minimum) val = nudCIDR.Minimum;
            if (val > nudCIDR.Maximum) val = nudCIDR.Maximum;

            nudCIDR.Value = val;
        }
        private void btnCompute_Click(object sender, EventArgs e)
        {
            IPv4 ipAddress = new IPv4(Bytes);
            IPv4Network ipNet = new IPv4Network(ipAddress, CIDR);

            allDataPerRow.Add(ipNet);
            dgvSubetting.Rows.Add(ipNet.GetInfo(displayPowerOfTwo));

            UpdateCount(allDataPerRow);
        }
        private void btnGenerateData_Click(object sender, EventArgs e)
        {
            txtIPAddress.Text = Helpers.GenerateRandomIP();

            byte minCIDR = Helpers.GetClassfulCIDR(new IPv4(Helpers.ConvertIPToBytes(txtIPAddress.Text)));
            byte CIDR_ = Helpers.GenerateRandomCIDR(minCIDR);

            nudCIDR.Value = CIDR_;
        }
        private void btnGenerateEntries_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < nudNumberOfRandomEntriesToAdd.Value; ++i)
            {
                string[] bytesStr = (Helpers.GenerateRandomIP()).Split('.'); // Generate a random IP and split it into 4 string octets
                byte[] bytes = Array.ConvertAll(bytesStr, byte.Parse);

                IPv4 ipAddr = new IPv4(bytes);

                byte minCIDR = Helpers.GetClassfulCIDR(ipAddr);

                IPv4Network ipNet = new IPv4Network(ipAddr, Helpers.GenerateRandomCIDR(minCIDR));

                allDataPerRow.Add(ipNet);
                dgvSubetting.Rows.Add(ipNet.GetInfo(displayPowerOfTwo));
            }

            UpdateCount(allDataPerRow);
        }
        private void btnFilterTable_Click(object sender, EventArgs e)
        {
            FilteringForm ff = new FilteringForm(this);
            ff.Show();
            btnFilterTable.Enabled = false;
        }
        private void btnClearTable_Click(object sender, EventArgs e)
        {
            allDataPerRow.Clear();
            dgvSubetting.Rows.Clear();
            UpdateCount(allDataPerRow);
        }

        private void chkDisplayPowerOfTwo_CheckedChanged(object sender, EventArgs e)
        {
            List<IPv4Network> DataToUse = btnFilterTable.Enabled ? allDataPerRow : filteredDataPerRow;

            displayPowerOfTwo = chkDisplayPowerOfTwo.Checked;

            DisplaySubnetsHosts(DataToUse, displayPowerOfTwo);
        }
    }
}