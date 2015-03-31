namespace uk.org.riseley.puttySessionManager.form
{
    partial class ExportDialog
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exportTypeTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.registryRadioButton = new System.Windows.Forms.RadioButton();
            this.csvRadioButton = new System.Windows.Forms.RadioButton();
            this.clipRadioButton = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.exportTypeTableLayout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.exportTypeTableLayout);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // exportTypeTableLayout
            // 
            this.exportTypeTableLayout.ColumnCount = 1;
            this.exportTypeTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.exportTypeTableLayout.Controls.Add(this.registryRadioButton, 0, 0);
            this.exportTypeTableLayout.Controls.Add(this.csvRadioButton, 0, 1);
            this.exportTypeTableLayout.Controls.Add(this.clipRadioButton, 0, 2);
            this.exportTypeTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exportTypeTableLayout.Location = new System.Drawing.Point(3, 17);
            this.exportTypeTableLayout.Name = "exportTypeTableLayout";
            this.exportTypeTableLayout.RowCount = 3;
            this.exportTypeTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.exportTypeTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.exportTypeTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.exportTypeTableLayout.Size = new System.Drawing.Size(203, 74);
            this.exportTypeTableLayout.TabIndex = 2;
            // 
            // registryRadioButton
            // 
            this.registryRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registryRadioButton.AutoSize = true;
            this.registryRadioButton.Location = new System.Drawing.Point(59, 3);
            this.registryRadioButton.Name = "registryRadioButton";
            this.registryRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.registryRadioButton.Size = new System.Drawing.Size(84, 17);
            this.registryRadioButton.TabIndex = 0;
            this.registryRadioButton.Text = "Registry File";
            this.registryRadioButton.UseVisualStyleBackColor = true;
            // 
            // csvRadioButton
            // 
            this.csvRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.csvRadioButton.AutoSize = true;
            this.csvRadioButton.Location = new System.Drawing.Point(70, 26);
            this.csvRadioButton.Name = "csvRadioButton";
            this.csvRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.csvRadioButton.Size = new System.Drawing.Size(63, 17);
            this.csvRadioButton.TabIndex = 1;
            this.csvRadioButton.Text = "CSV File";
            this.csvRadioButton.UseVisualStyleBackColor = true;
            // 
            // clipRadioButton
            // 
            this.clipRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clipRadioButton.AutoSize = true;
            this.clipRadioButton.Location = new System.Drawing.Point(19, 51);
            this.clipRadioButton.Name = "clipRadioButton";
            this.clipRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.clipRadioButton.Size = new System.Drawing.Size(164, 17);
            this.clipRadioButton.TabIndex = 2;
            this.clipRadioButton.Text = "Copy hostnames to clipboard";
            this.clipRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clipRadioButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.okButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cancelButton, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(215, 140);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // okButton
            // 
            this.okButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.okButton.Location = new System.Drawing.Point(16, 106);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 27);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(123, 106);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 27);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // ExportDialog
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(215, 140);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(221, 142);
            this.Name = "ExportDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Export Sessions To...";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.exportTypeTableLayout.ResumeLayout(false);
            this.exportTypeTableLayout.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.RadioButton csvRadioButton;
        private System.Windows.Forms.RadioButton registryRadioButton;
        private System.Windows.Forms.TableLayoutPanel exportTypeTableLayout;
        private System.Windows.Forms.RadioButton clipRadioButton;
    }
}