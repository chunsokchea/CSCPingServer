using System;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCPingServer
{
    public partial class FormCheckServer : Form
    {
        private const string filePath = "ip_addresses.txt";
        private CancellationTokenSource cancellationTokenSource;
        public FormCheckServer()
        {
            InitializeComponent();
            LoadIPAddressesFromFile();
            cancellationTokenSource = new CancellationTokenSource();
        }
        private void LoadIPAddressesFromFile()
        {
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            var ipAddresses = File.ReadAllLines(filePath).Distinct();
            foreach (var ipAddress in ipAddresses)
            {
                lstIPAddresses.Items.Add(ipAddress);
                AddIPPanel(ipAddress); // Add panel for each IP address
            }
        }

        private void SaveIPAddressToFile(string ipAddress)
        {
            if (!lstIPAddresses.Items.Contains(ipAddress))
            {
                using (StreamWriter sw = File.AppendText(filePath))
                {
                    sw.WriteLine(ipAddress);
                }
            }
        }
        private void btnAddIP_Click(object sender, EventArgs e)
        {
            cancellationTokenSource.Cancel(); // Cancel any ongoing pings
            string ipAddress = txtAddress.Text.Trim();
            if (!string.IsNullOrEmpty(ipAddress) && !lstIPAddresses.Items.Contains(ipAddress))
            {                
                txtAddress.Clear();
                SaveIPAddressToFile(ipAddress);
                lstIPAddresses.Items.Add(ipAddress);                
                //PingAddressAsync(ipAddress); // Auto ping the added IP address asynchronously
                AddIPPanel(ipAddress); // Add panel for the new IP address                
            }
            cancellationTokenSource = new CancellationTokenSource(); // Reset the cancellation token source
            PingAllAddressesAsync(); // Start pinging again with the new list
        }


        private async Task PingAddressAsync(string ipAddress, CancellationToken cancellationToken)
        {
            await Task.Run(() =>
            {
                Ping ping = new Ping();
                try
                {
                    PingReply reply = ping.Send(ipAddress);
                    if (reply.Status == IPStatus.Success)
                    {
                        UpdateIPPanel(ipAddress, "Online", $"{reply.RoundtripTime} ms",true);
                    }
                    else
                    {
                        UpdateIPPanel(ipAddress, "Offline", "N/A",false);
                    }
                }
                catch (Exception ex)
                {
                    UpdateIPPanel(ipAddress, "Error", ex.Message,false);
                }
            });
        }

        private void UpdateIPPanel(string ipAddress, string status, string roundTripTime, bool isOnline)
        {
            Invoke(new Action(() =>
            {
                foreach (Control control in flowPanel.Controls)
                {
                    if (control is Panel panel && panel.Tag.ToString() == ipAddress)
                    {
                        panel.Controls["lblStatus"].Text = $"{status}";
                        panel.Controls["lblRoundTripTime"].Text = $"{roundTripTime}";
                        //panel.BackColor = isOnline ? System.Drawing.Color.Green : System.Drawing.Color.Red;
                        panel.Controls["lblRoundTripTime"].ForeColor= isOnline ? System.Drawing.Color.Green : System.Drawing.Color.Red;
                        panel.Controls["lblStatus"].ForeColor = isOnline ? System.Drawing.Color.Green : System.Drawing.Color.Red;
                        break;
                    }
                }
            }));
        }

        private void AddIPPanel(string ipAddress)
        {
            Panel panel = new Panel
            {
                Tag = ipAddress,
                Size = new System.Drawing.Size(130, 60),
                BorderStyle = BorderStyle.FixedSingle
            };

            Label lblIP = new Label
            {
                Name = "lblIP",
                Text = $"IP : {ipAddress}",
                Location = new System.Drawing.Point(10, 10),
                AutoSize = true
            };

            Label lblStatus = new Label
            {
                Name = "lblStatus",
                Text = "Status",
                Location = new System.Drawing.Point(10, 30),
                AutoSize = true
            };

            Label lblRoundTripTime = new Label
            {
                Name = "lblRoundTripTime",
                Text = "Round Trip",
                Location = new System.Drawing.Point(50, 30),
                AutoSize = true
            };

            panel.Controls.Add(lblIP);
            panel.Controls.Add(lblStatus);
            panel.Controls.Add(lblRoundTripTime);

            flowPanel.Controls.Add(panel);
        }

        private async void PingServerAsync(object sender, EventArgs e)
        {
            //foreach (string ipAddress in lstIPAddresses.Items)
            //{
            //    await PingAddressAsync(ipAddress);
            //}
            var ipAddresses = lstIPAddresses.Items.Cast<string>().ToList();
            foreach (string ipAddress in ipAddresses)
            {
                await PingAddressAsync(ipAddress, cancellationTokenSource.Token);
            }
        }

        private async Task PingAllAddressesAsync()
        {
            var ipAddresses = lstIPAddresses.Items.Cast<string>().ToList();
            foreach (string ipAddress in ipAddresses)
            {
                await PingAddressAsync(ipAddress, cancellationTokenSource.Token);
            }
        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                btnPing.Text = "Start";
            }
            else
            {
                timer1.Start();
                btnPing.Text = "Stop";
            }
        }


    }
}
