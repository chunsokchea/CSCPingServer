
namespace CSCPingServer
{
    partial class FormSQLConnection
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
            this.txtServerIP = new System.Windows.Forms.MaskedTextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.dgvConnectionStatus = new System.Windows.Forms.DataGridView();
            this.ConnectionString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstConnectionStrings = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnectionStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // txtServerIP
            // 
            this.txtServerIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServerIP.Location = new System.Drawing.Point(23, 27);
            this.txtServerIP.Mask = "###.###.###.###";
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(110, 24);
            this.txtServerIP.TabIndex = 5;
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(139, 31);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(110, 20);
            this.txtUserId.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(255, 31);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // dgvConnectionStatus
            // 
            this.dgvConnectionStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConnectionStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConnectionString,
            this.Status});
            this.dgvConnectionStatus.Location = new System.Drawing.Point(24, 175);
            this.dgvConnectionStatus.Name = "dgvConnectionStatus";
            this.dgvConnectionStatus.Size = new System.Drawing.Size(331, 150);
            this.dgvConnectionStatus.TabIndex = 9;
            // 
            // ConnectionString
            // 
            this.ConnectionString.HeaderText = "Connection String";
            this.ConnectionString.Name = "ConnectionString";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // lstConnectionStrings
            // 
            this.lstConnectionStrings.FormattingEnabled = true;
            this.lstConnectionStrings.Location = new System.Drawing.Point(24, 66);
            this.lstConnectionStrings.Name = "lstConnectionStrings";
            this.lstConnectionStrings.Size = new System.Drawing.Size(331, 95);
            this.lstConnectionStrings.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 32);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAddConnectionString_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(382, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 32);
            this.button2.TabIndex = 12;
            this.button2.Text = "Check";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnCheckConnections_Click);
            // 
            // FormSQLConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstConnectionStrings);
            this.Controls.Add(this.dgvConnectionStatus);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.txtServerIP);
            this.Name = "FormSQLConnection";
            this.Text = "FormSQLConnection";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnectionStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtServerIP;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.DataGridView dgvConnectionStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConnectionString;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.ListBox lstConnectionStrings;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}