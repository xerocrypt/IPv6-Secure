using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net;
using System.Security.Cryptography;

namespace Client_Application_CS
{
    public partial class frmClient : Form
    {

        string currentAddress;
        string currentAddressAsString;
        string noDelimiters;
        string sessionKey;
        string sysTime = DateTime.Now.ToString("HH:mm:ss");
        string stringToHash;
        string hashedString;
        string newAddress;
        string shortAddress;
        string newAddressString;


        public frmClient()
        {
            InitializeComponent();


            // Load network interface list in drop-down on startup
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if ((nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet) || (nic.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)) //&& (nic.OperationalStatus == OperationalStatus.Up))
                {
                    cmbNetInterfaces.Items.Add(nic.Description);
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabContacts_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdGenerateAddress_Click(object sender, EventArgs e)
        {
            // Get current IPv6 address
            // Read from network interface

            // Populate Current Address field with the address from the selected network interface

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                foreach (UnicastIPAddressInformation ip in nic.GetIPProperties().UnicastAddresses)
                {
                    if (nic.Description == cmbNetInterfaces.SelectedItem.ToString())
                    {
                        if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6)
                        {
                            currentAddress = ip.Address.ToString();
                            txtCurrentAddress.Text = currentAddress.ToString();
   
                        }
                    }
                }
            }

            // Convert current address to string
            noDelimiters = String.Join("", currentAddress.Split(':'));
            currentAddressAsString = noDelimiters.Substring(0, noDelimiters.Length - 3);
        } 

        private void cmdLoadPrivateKey_Click(object sender, EventArgs e)
        {
            // Load private RSA key into configuration.
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lists groups and contacts within the MyNet
        }

        private void cmdJoin_Click(object sender, EventArgs e)
        {
            // Join group or initiate messaging with peer
        }

        private void cmdSendMsg_Click(object sender, EventArgs e)
        {
            // Send message to group or peer
        }

        private void cmdSearchGroup_Click(object sender, EventArgs e)
        {
            // Search for group or broadcast address
        }

        private void cmdSubscribeGroup_Click(object sender, EventArgs e)
        {
            // Subscribe to broadcast group
        }

        private void cmdGenNewIPv6_Click(object sender, EventArgs e)
        {
            // Generate new IPv6 address using SAGA
            sessionKey = txtSessionKey.Text;

            stringToHash = (sessionKey + currentAddressAsString);

            // Generate hash value for the above   
            hashedString = MD5Hash(stringToHash);


            // Get last eight bytes of hash fingerprint
            string lastEight = hashedString.Substring(hashedString.Length - 8);

            // Replace last digits of address with lastEight
            shortAddress = currentAddressAsString.Remove(currentAddressAsString.Length -8);
            newAddressString = (shortAddress + lastEight);
            txtPrivateKey.Text = newAddress;
            txtPrivateKey.Text = newAddressString;


            // Add delimiters to the address string
        }

    private void cmdSaveConfig_Click(object sender, EventArgs e)
        {
            // Update configuration
            // Write new address to database
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }


        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
    }
}
