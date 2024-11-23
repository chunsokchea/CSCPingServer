
namespace CSCPingServer
{
    partial class FormCheckServer
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
            this.components = new System.ComponentModel.Container();
            this.lstIPAddresses = new System.Windows.Forms.ListBox();
            this.dgvPingStatus = new System.Windows.Forms.DataGridView();
            this.IPAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoundTripTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddIP = new System.Windows.Forms.Button();
            this.btnPing = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtAddress = new System.Windows.Forms.MaskedTextBox();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPingStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // lstIPAddresses
            // 
            this.lstIPAddresses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstIPAddresses.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lstIPAddresses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstIPAddresses.FormattingEnabled = true;
            this.lstIPAddresses.ItemHeight = 16;
            this.lstIPAddresses.Location = new System.Drawing.Point(12, 57);
            this.lstIPAddresses.Name = "lstIPAddresses";
            this.lstIPAddresses.Size = new System.Drawing.Size(110, 388);
            this.lstIPAddresses.TabIndex = 0;
            // 
            // dgvPingStatus
            // 
            this.dgvPingStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPingStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IPAddress,
            this.Status,
            this.RoundTripTime});
            this.dgvPingStatus.Location = new System.Drawing.Point(70, 176);
            this.dgvPingStatus.Name = "dgvPingStatus";
            this.dgvPingStatus.Size = new System.Drawing.Size(476, 262);
            this.dgvPingStatus.TabIndex = 1;
            this.dgvPingStatus.Visible = false;
            // 
            // IPAddress
            // 
            this.IPAddress.HeaderText = "IP Address";
            this.IPAddress.Name = "IPAddress";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // RoundTripTime
            // 
            this.RoundTripTime.HeaderText = "Round Trip Time";
            this.RoundTripTime.Name = "RoundTripTime";
            // 
            // btnAddIP
            // 
            this.btnAddIP.Location = new System.Drawing.Point(128, 18);
            this.btnAddIP.Name = "btnAddIP";
            this.btnAddIP.Size = new System.Drawing.Size(102, 33);
            this.btnAddIP.TabIndex = 2;
            this.btnAddIP.Text = "Add";
            this.btnAddIP.UseVisualStyleBackColor = true;
            this.btnAddIP.Click += new System.EventHandler(this.btnAddIP_Click);
            // 
            // btnPing
            // 
            this.btnPing.Location = new System.Drawing.Point(236, 18);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(102, 33);
            this.btnPing.TabIndex = 3;
            this.btnPing.Text = "Start";
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2500;
            this.timer1.Tick += new System.EventHandler(this.PingServerAsync);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(12, 21);
            this.txtAddress.Mask = "###.###.###.###";
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(110, 24);
            this.txtAddress.TabIndex = 4;
            // 
            // flowPanel
            // 
            this.flowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowPanel.Location = new System.Drawing.Point(128, 57);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(660, 388);
            this.flowPanel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowPanel);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnPing);
            this.Controls.Add(this.btnAddIP);
            this.Controls.Add(this.lstIPAddresses);
            this.Controls.Add(this.dgvPingStatus);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPingStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstIPAddresses;
        private System.Windows.Forms.DataGridView dgvPingStatus;
        private System.Windows.Forms.Button btnAddIP;
        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.DataGridViewTextBoxColumn IPAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoundTripTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MaskedTextBox txtAddress;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
    }
}

