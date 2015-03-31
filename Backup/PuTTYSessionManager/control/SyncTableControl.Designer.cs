namespace uk.org.riseley.puttySessionManager.control
{
    partial class TableControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sessionNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localFolderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remoteFolderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localHostnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remoteHostnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.resetButton = new System.Windows.Forms.Button();
            this.syncButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.ignoreButton = new System.Windows.Forms.Button();
            this.removeUnchangedButton = new System.Windows.Forms.Button();
            this.renameButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sessionNameColumn,
            this.localFolderColumn,
            this.remoteFolderColumn,
            this.localHostnameColumn,
            this.remoteHostnameColumn,
            this.statusColumn,
            this.actionColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 6);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(687, 267);
            this.dataGridView1.TabIndex = 1;
            // 
            // sessionNameColumn
            // 
            this.sessionNameColumn.HeaderText = "Session Name";
            this.sessionNameColumn.Name = "sessionNameColumn";
            this.sessionNameColumn.ReadOnly = true;
            // 
            // localFolderColumn
            // 
            this.localFolderColumn.HeaderText = "Local Folder";
            this.localFolderColumn.Name = "localFolderColumn";
            this.localFolderColumn.ReadOnly = true;
            // 
            // remoteFolderColumn
            // 
            this.remoteFolderColumn.HeaderText = "Remote Folder";
            this.remoteFolderColumn.Name = "remoteFolderColumn";
            this.remoteFolderColumn.ReadOnly = true;
            // 
            // localHostnameColumn
            // 
            this.localHostnameColumn.HeaderText = "Local Hostname";
            this.localHostnameColumn.Name = "localHostnameColumn";
            this.localHostnameColumn.ReadOnly = true;
            // 
            // remoteHostnameColumn
            // 
            this.remoteHostnameColumn.HeaderText = "Remote Hostname";
            this.remoteHostnameColumn.Name = "remoteHostnameColumn";
            this.remoteHostnameColumn.ReadOnly = true;
            // 
            // statusColumn
            // 
            this.statusColumn.HeaderText = "Status";
            this.statusColumn.Name = "statusColumn";
            this.statusColumn.ReadOnly = true;
            // 
            // actionColumn
            // 
            this.actionColumn.HeaderText = "Action";
            this.actionColumn.Items.AddRange(new object[] {
            "Ignore",
            "Update"});
            this.actionColumn.Name = "actionColumn";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.updateButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ignoreButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.removeUnchangedButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.syncButton, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.resetButton, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.renameButton, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.94268F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.05732F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(693, 314);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // resetButton
            // 
            this.resetButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resetButton.Location = new System.Drawing.Point(493, 282);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(51, 23);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // syncButton
            // 
            this.syncButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.syncButton.Location = new System.Drawing.Point(556, 282);
            this.syncButton.Name = "syncButton";
            this.syncButton.Size = new System.Drawing.Size(127, 23);
            this.syncButton.TabIndex = 6;
            this.syncButton.Text = "Synchronize Sessions";
            this.syncButton.UseVisualStyleBackColor = true;
            this.syncButton.Click += new System.EventHandler(this.syncButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateButton.Location = new System.Drawing.Point(3, 282);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(97, 23);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "Update Selection";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // ignoreButton
            // 
            this.ignoreButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ignoreButton.Location = new System.Drawing.Point(106, 282);
            this.ignoreButton.Name = "ignoreButton";
            this.ignoreButton.Size = new System.Drawing.Size(97, 23);
            this.ignoreButton.TabIndex = 4;
            this.ignoreButton.Text = "Ignore Selection";
            this.ignoreButton.UseVisualStyleBackColor = true;
            this.ignoreButton.Click += new System.EventHandler(this.ignoreButton_Click);
            // 
            // removeUnchangedButton
            // 
            this.removeUnchangedButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.removeUnchangedButton.Location = new System.Drawing.Point(209, 282);
            this.removeUnchangedButton.Name = "removeUnchangedButton";
            this.removeUnchangedButton.Size = new System.Drawing.Size(116, 23);
            this.removeUnchangedButton.TabIndex = 7;
            this.removeUnchangedButton.Text = "Remove Unchanged";
            this.removeUnchangedButton.UseVisualStyleBackColor = true;
            this.removeUnchangedButton.Click += new System.EventHandler(this.removeUnchangedButton_Click);
            // 
            // renameButton
            // 
            this.renameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.renameButton.Location = new System.Drawing.Point(331, 282);
            this.renameButton.Name = "renameButton";
            this.renameButton.Size = new System.Drawing.Size(156, 23);
            this.renameButton.TabIndex = 8;
            this.renameButton.Text = "Identify Renamed Sessions";
            this.renameButton.UseVisualStyleBackColor = true;
            this.renameButton.Click += new System.EventHandler(this.renameButton_Click);
            // 
            // TableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TableControl";
            this.Size = new System.Drawing.Size(693, 314);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button ignoreButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button syncButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localFolderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remoteFolderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localHostnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remoteHostnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn actionColumn;
        private System.Windows.Forms.Button removeUnchangedButton;
        private System.Windows.Forms.Button renameButton;
    }
}
