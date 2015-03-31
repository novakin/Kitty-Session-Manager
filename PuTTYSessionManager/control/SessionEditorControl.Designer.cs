/* 
 * Copyright (C) 2006,2007 David Riseley 
 *
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation; either version 2
 * of the License, or (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
 */
namespace uk.org.riseley.puttySessionManager.control
{
    partial class SessionEditorControl
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.exportButton = new System.Windows.Forms.Button();
            this.copySessionAttribButton = new System.Windows.Forms.Button();
            this.newSessionButton = new System.Windows.Forms.Button();
            this.deleteSesssionsButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sessionNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionPathColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hostnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.86792F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.10962F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.90388F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.15337F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.Controls.Add(this.exportButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.copySessionAttribButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.newSessionButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.deleteSesssionsButton, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.closeButton, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(489, 378);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // exportButton
            // 
            this.exportButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exportButton.Location = new System.Drawing.Point(3, 347);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(75, 23);
            this.exportButton.TabIndex = 0;
            this.exportButton.Text = "Export Sessions";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // copySessionAttribButton
            // 
            this.copySessionAttribButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.copySessionAttribButton.Location = new System.Drawing.Point(84, 347);
            this.copySessionAttribButton.Name = "copySessionAttribButton";
            this.copySessionAttribButton.Size = new System.Drawing.Size(136, 23);
            this.copySessionAttribButton.TabIndex = 1;
            this.copySessionAttribButton.Text = "Copy Session Attributes";
            this.copySessionAttribButton.UseVisualStyleBackColor = true;
            this.copySessionAttribButton.Click += new System.EventHandler(this.copySessionAttribButton_Click);
            // 
            // newSessionButton
            // 
            this.newSessionButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newSessionButton.Location = new System.Drawing.Point(228, 347);
            this.newSessionButton.Name = "newSessionButton";
            this.newSessionButton.Size = new System.Drawing.Size(88, 23);
            this.newSessionButton.TabIndex = 2;
            this.newSessionButton.Text = "New Session";
            this.newSessionButton.UseVisualStyleBackColor = true;
            this.newSessionButton.Click += new System.EventHandler(this.newSessionButton_Click);
            // 
            // deleteSesssionsButton
            // 
            this.deleteSesssionsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteSesssionsButton.Location = new System.Drawing.Point(326, 347);
            this.deleteSesssionsButton.Name = "deleteSesssionsButton";
            this.deleteSesssionsButton.Size = new System.Drawing.Size(98, 23);
            this.deleteSesssionsButton.TabIndex = 3;
            this.deleteSesssionsButton.Text = "Delete Sessions";
            this.deleteSesssionsButton.UseVisualStyleBackColor = true;
            this.deleteSesssionsButton.Click += new System.EventHandler(this.deleteSesssionsButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.closeButton.Location = new System.Drawing.Point(434, 347);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(50, 23);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sessionNameColumn,
            this.sessionPathColumn,
            this.hostnameColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 5);
            this.dataGridView1.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "TreeFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Font = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.TreeFont;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(483, 334);
            this.dataGridView1.TabIndex = 5;
            // 
            // sessionNameColumn
            // 
            this.sessionNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sessionNameColumn.FillWeight = 30F;
            this.sessionNameColumn.HeaderText = "Session Name";
            this.sessionNameColumn.Name = "sessionNameColumn";
            this.sessionNameColumn.ReadOnly = true;
            // 
            // sessionPathColumn
            // 
            this.sessionPathColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sessionPathColumn.FillWeight = 35F;
            this.sessionPathColumn.HeaderText = "Path";
            this.sessionPathColumn.Name = "sessionPathColumn";
            this.sessionPathColumn.ReadOnly = true;
            // 
            // hostnameColumn
            // 
            this.hostnameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hostnameColumn.FillWeight = 35F;
            this.hostnameColumn.HeaderText = "Hostname";
            this.hostnameColumn.Name = "hostnameColumn";
            this.hostnameColumn.ReadOnly = true;
            // 
            // SessionEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SessionEditorControl";
            this.Size = new System.Drawing.Size(489, 378);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button copySessionAttribButton;
        private System.Windows.Forms.Button newSessionButton;
        private System.Windows.Forms.Button deleteSesssionsButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionPathColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hostnameColumn;
    }
}
