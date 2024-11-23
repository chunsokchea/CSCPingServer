using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCPingServer
{
    public partial class FormSQLConnection : Form
    {
        private Dictionary<string, string> connectionStrings = new Dictionary<string, string>();
        public FormSQLConnection()
        {
            InitializeComponent();
        }
        private void btnAddConnectionString_Click(object sender, EventArgs e)
        {
            string serverIp = txtServerIP.Text.Trim();
            string userId = txtUserId.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (!string.IsNullOrEmpty(serverIp) && !string.IsNullOrEmpty(userId) && !string.IsNullOrEmpty(password))
            {
                string connectionString = $"Server={serverIp};Database=master;User Id={userId};Password={password};";
                if (!connectionStrings.ContainsKey(serverIp))
                {
                    connectionStrings.Add(serverIp, connectionString);
                    lstConnectionStrings.Items.Add(serverIp);
                    ClearInputs();
                }
            }
        }
        private void ClearInputs()
        {
            txtServerIP.Clear();
            txtUserId.Clear();
            txtPassword.Clear();
        }

        private async void btnCheckConnections_Click(object sender, EventArgs e)
        {
            dgvConnectionStatus.Rows.Clear();
            var ips = lstConnectionStrings.Items.Cast<string>().ToList();

            foreach (var ip in ips)
            {
                await CheckSqlConnectionAsync(ip);
            }
        }

        private async Task CheckSqlConnectionAsync(string serverIp)
        {
            string connectionString = connectionStrings[serverIp];
            await Task.Run(() =>
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        Invoke(new Action(() =>
                        {
                            dgvConnectionStatus.Rows.Add(serverIp, "Connected");
                        }));
                    }
                    catch (Exception ex)
                    {
                        Invoke(new Action(() =>
                        {
                            dgvConnectionStatus.Rows.Add(serverIp, $"Failed: {ex.Message}");
                        }));
                    }
                }
            });
        }
    }
}
