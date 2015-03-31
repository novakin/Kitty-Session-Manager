/* 
 * Copyright (C) 2008 David Riseley 
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
namespace uk.org.riseley.puttySessionManager.control.options
{
    partial class GeneralOptionsControl
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
            this.generalTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.puttyTextBox = new System.Windows.Forms.TextBox();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.locatePuttyButton = new System.Windows.Forms.Button();
            this.taskbarCheckBox = new System.Windows.Forms.CheckBox();
            this.startupMinimizeCheckBox = new System.Windows.Forms.CheckBox();
            this.confirmExitCheckBox = new System.Windows.Forms.CheckBox();
            this.chooseDialogFontButton = new System.Windows.Forms.Button();
            this.sampleDialogTextbox = new System.Windows.Forms.TextBox();
            this.autoMinimizeCheckBox = new System.Windows.Forms.CheckBox();
            this.onTopCheckBox = new System.Windows.Forms.CheckBox();
            this.transparencyCheckBox = new System.Windows.Forms.CheckBox();
            this.autostartCheckBox = new System.Windows.Forms.CheckBox();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.generalTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // generalTableLayout
            // 
            this.generalTableLayout.AutoSize = true;
            this.generalTableLayout.ColumnCount = 4;
            this.generalTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.generalTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.generalTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.generalTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.generalTableLayout.Controls.Add(this.puttyTextBox, 2, 5);
            this.generalTableLayout.Controls.Add(this.trackBar, 0, 3);
            this.generalTableLayout.Controls.Add(this.locatePuttyButton, 0, 5);
            this.generalTableLayout.Controls.Add(this.taskbarCheckBox, 0, 2);
            this.generalTableLayout.Controls.Add(this.startupMinimizeCheckBox, 2, 0);
            this.generalTableLayout.Controls.Add(this.confirmExitCheckBox, 0, 1);
            this.generalTableLayout.Controls.Add(this.chooseDialogFontButton, 0, 4);
            this.generalTableLayout.Controls.Add(this.sampleDialogTextbox, 2, 4);
            this.generalTableLayout.Controls.Add(this.autoMinimizeCheckBox, 3, 1);
            this.generalTableLayout.Controls.Add(this.onTopCheckBox, 3, 2);
            this.generalTableLayout.Controls.Add(this.transparencyCheckBox, 2, 2);
            this.generalTableLayout.Controls.Add(this.autostartCheckBox, 0, 0);
            this.generalTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalTableLayout.Location = new System.Drawing.Point(0, 0);
            this.generalTableLayout.Name = "generalTableLayout";
            this.generalTableLayout.RowCount = 6;
            this.generalTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.generalTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.generalTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.generalTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.generalTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.generalTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.generalTableLayout.Size = new System.Drawing.Size(355, 188);
            this.generalTableLayout.TabIndex = 30;
            // 
            // puttyTextBox
            // 
            this.puttyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generalTableLayout.SetColumnSpan(this.puttyTextBox, 2);
            this.puttyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "PuttyLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.puttyTextBox.Location = new System.Drawing.Point(132, 152);
            this.puttyTextBox.Name = "puttyTextBox";
            this.puttyTextBox.ReadOnly = true;
            this.puttyTextBox.Size = new System.Drawing.Size(221, 20);
            this.puttyTextBox.TabIndex = 14;
            this.puttyTextBox.Text = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.PuttyLocation;
            this.puttyTextBox.TextChanged += new System.EventHandler(this.puttyTextBox_TextChanged);
            // 
            // trackBar
            // 
            this.trackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.generalTableLayout.SetColumnSpan(this.trackBar, 4);
            this.trackBar.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "TransparencyEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.trackBar.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "TransparencyValueInt", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.trackBar.Enabled = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.TransparencyEnabled;
            this.trackBar.Location = new System.Drawing.Point(3, 72);
            this.trackBar.Maximum = 99;
            this.trackBar.Minimum = 20;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(350, 45);
            this.trackBar.TabIndex = 18;
            this.trackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar.Value = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.TransparencyValueInt;
            // 
            // locatePuttyButton
            // 
            this.locatePuttyButton.AutoSize = true;
            this.generalTableLayout.SetColumnSpan(this.locatePuttyButton, 2);
            this.locatePuttyButton.Location = new System.Drawing.Point(3, 152);
            this.locatePuttyButton.Name = "locatePuttyButton";
            this.locatePuttyButton.Size = new System.Drawing.Size(123, 23);
            this.locatePuttyButton.TabIndex = 15;
            this.locatePuttyButton.Text = "&Locate kitty.exe";
            this.locatePuttyButton.UseVisualStyleBackColor = true;
            this.locatePuttyButton.Click += new System.EventHandler(this.locatePuttyButton_Click);
            // 
            // taskbarCheckBox
            // 
            this.taskbarCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.taskbarCheckBox.AutoSize = true;
            this.taskbarCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.taskbarCheckBox.Checked = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.ShowInTaskbar;
            this.taskbarCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.generalTableLayout.SetColumnSpan(this.taskbarCheckBox, 2);
            this.taskbarCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "ShowInTaskbar", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.taskbarCheckBox.Location = new System.Drawing.Point(24, 49);
            this.taskbarCheckBox.Name = "taskbarCheckBox";
            this.taskbarCheckBox.Size = new System.Drawing.Size(102, 17);
            this.taskbarCheckBox.TabIndex = 27;
            this.taskbarCheckBox.Text = "&Show in taskbar";
            this.optionsToolTip.SetToolTip(this.taskbarCheckBox, "Show PSM in the taskbar when the window is visible");
            this.taskbarCheckBox.UseVisualStyleBackColor = true;
            this.taskbarCheckBox.Click += new System.EventHandler(this.taskbarCheckBox_Click);
            // 
            // startupMinimizeCheckBox
            // 
            this.startupMinimizeCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.startupMinimizeCheckBox.AutoSize = true;
            this.startupMinimizeCheckBox.Checked = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.MinimizeOnStart;
            this.generalTableLayout.SetColumnSpan(this.startupMinimizeCheckBox, 2);
            this.startupMinimizeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "MinimizeOnStart", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.startupMinimizeCheckBox.Location = new System.Drawing.Point(237, 3);
            this.startupMinimizeCheckBox.Name = "startupMinimizeCheckBox";
            this.startupMinimizeCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.startupMinimizeCheckBox.Size = new System.Drawing.Size(116, 17);
            this.startupMinimizeCheckBox.TabIndex = 22;
            this.startupMinimizeCheckBox.Text = "Minimize on &startup";
            this.startupMinimizeCheckBox.UseVisualStyleBackColor = true;
            // 
            // confirmExitCheckBox
            // 
            this.confirmExitCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.confirmExitCheckBox.AutoSize = true;
            this.confirmExitCheckBox.Checked = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.ConfirmExit;
            this.confirmExitCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.generalTableLayout.SetColumnSpan(this.confirmExitCheckBox, 2);
            this.confirmExitCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "ConfirmExit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.confirmExitCheckBox.Location = new System.Drawing.Point(31, 26);
            this.confirmExitCheckBox.Name = "confirmExitCheckBox";
            this.confirmExitCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.confirmExitCheckBox.Size = new System.Drawing.Size(95, 17);
            this.confirmExitCheckBox.TabIndex = 28;
            this.confirmExitCheckBox.Text = "&Confirm on exit";
            this.confirmExitCheckBox.UseVisualStyleBackColor = true;
            // 
            // chooseDialogFontButton
            // 
            this.chooseDialogFontButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chooseDialogFontButton.AutoSize = true;
            this.generalTableLayout.SetColumnSpan(this.chooseDialogFontButton, 2);
            this.chooseDialogFontButton.Location = new System.Drawing.Point(3, 123);
            this.chooseDialogFontButton.Name = "chooseDialogFontButton";
            this.chooseDialogFontButton.Size = new System.Drawing.Size(123, 23);
            this.chooseDialogFontButton.TabIndex = 16;
            this.chooseDialogFontButton.Text = "C&hoose Dialog Font";
            this.optionsToolTip.SetToolTip(this.chooseDialogFontButton, "Set the font for all dialogs in the application.\r\nWarning: This may upset the dia" +
        "log layouts.\r\nYou are advised to restart after altering this");
            this.chooseDialogFontButton.UseVisualStyleBackColor = true;
            this.chooseDialogFontButton.Click += new System.EventHandler(this.chooseFontButton_Click);
            // 
            // sampleDialogTextbox
            // 
            this.sampleDialogTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.generalTableLayout.SetColumnSpan(this.sampleDialogTextbox, 2);
            this.sampleDialogTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "DialogFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.sampleDialogTextbox.Font = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.DialogFont;
            this.sampleDialogTextbox.Location = new System.Drawing.Point(132, 124);
            this.sampleDialogTextbox.Name = "sampleDialogTextbox";
            this.sampleDialogTextbox.ReadOnly = true;
            this.sampleDialogTextbox.Size = new System.Drawing.Size(221, 21);
            this.sampleDialogTextbox.TabIndex = 17;
            this.sampleDialogTextbox.Text = "Sample Text for Dialogs";
            this.sampleDialogTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // autoMinimizeCheckBox
            // 
            this.autoMinimizeCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.autoMinimizeCheckBox.AutoSize = true;
            this.autoMinimizeCheckBox.Checked = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.MinimizeOnUse;
            this.autoMinimizeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "MinimizeOnUse", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.autoMinimizeCheckBox.Location = new System.Drawing.Point(263, 26);
            this.autoMinimizeCheckBox.Name = "autoMinimizeCheckBox";
            this.autoMinimizeCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.autoMinimizeCheckBox.Size = new System.Drawing.Size(90, 17);
            this.autoMinimizeCheckBox.TabIndex = 25;
            this.autoMinimizeCheckBox.Text = "&Auto minimize";
            this.optionsToolTip.SetToolTip(this.autoMinimizeCheckBox, "If enabled, PSM will hide itself when a new session\r\nor folder of sessions is lau" +
        "ched");
            this.autoMinimizeCheckBox.UseVisualStyleBackColor = true;
            // 
            // onTopCheckBox
            // 
            this.onTopCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.onTopCheckBox.AutoSize = true;
            this.onTopCheckBox.Checked = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.AlwaysOnTop;
            this.onTopCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.onTopCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "AlwaysOnTop", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.onTopCheckBox.Location = new System.Drawing.Point(261, 49);
            this.onTopCheckBox.Name = "onTopCheckBox";
            this.onTopCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.onTopCheckBox.Size = new System.Drawing.Size(92, 17);
            this.onTopCheckBox.TabIndex = 19;
            this.onTopCheckBox.Text = "Always on &top";
            this.onTopCheckBox.UseVisualStyleBackColor = true;
            // 
            // transparencyCheckBox
            // 
            this.transparencyCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.transparencyCheckBox.AutoSize = true;
            this.transparencyCheckBox.Checked = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.TransparencyEnabled;
            this.transparencyCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "TransparencyEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.transparencyCheckBox.Location = new System.Drawing.Point(132, 49);
            this.transparencyCheckBox.Name = "transparencyCheckBox";
            this.transparencyCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.transparencyCheckBox.Size = new System.Drawing.Size(123, 17);
            this.transparencyCheckBox.TabIndex = 13;
            this.transparencyCheckBox.Text = "Enable trans&parency";
            this.transparencyCheckBox.UseVisualStyleBackColor = true;
            // 
            // autostartCheckBox
            // 
            this.autostartCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.autostartCheckBox.AutoSize = true;
            this.generalTableLayout.SetColumnSpan(this.autostartCheckBox, 2);
            this.autostartCheckBox.Location = new System.Drawing.Point(34, 3);
            this.autostartCheckBox.Name = "autostartCheckBox";
            this.autostartCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.autostartCheckBox.Size = new System.Drawing.Size(92, 17);
            this.autostartCheckBox.TabIndex = 23;
            this.autostartCheckBox.Text = "Start on lo&gon";
            this.optionsToolTip.SetToolTip(this.autostartCheckBox, "Automatically start PSM on Windows login");
            this.autostartCheckBox.UseVisualStyleBackColor = true;
            this.autostartCheckBox.Click += new System.EventHandler(this.autostartCheckBox_CheckedChanged);
            // 
            // fontDialog
            // 
            this.fontDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.fontDialog.ShowColor = true;
            this.fontDialog.ShowEffects = false;
            // 
            // GeneralOptionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.generalTableLayout);
            this.Name = "GeneralOptionsControl";
            this.Size = new System.Drawing.Size(355, 188);
            this.generalTableLayout.ResumeLayout(false);
            this.generalTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel generalTableLayout;
        private System.Windows.Forms.TextBox puttyTextBox;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Button locatePuttyButton;
        private System.Windows.Forms.CheckBox taskbarCheckBox;
        private System.Windows.Forms.CheckBox startupMinimizeCheckBox;
        private System.Windows.Forms.CheckBox confirmExitCheckBox;
        private System.Windows.Forms.Button chooseDialogFontButton;
        private System.Windows.Forms.TextBox sampleDialogTextbox;
        private System.Windows.Forms.CheckBox autoMinimizeCheckBox;
        private System.Windows.Forms.CheckBox onTopCheckBox;
        private System.Windows.Forms.CheckBox transparencyCheckBox;
        private System.Windows.Forms.CheckBox autostartCheckBox;
        private System.Windows.Forms.FontDialog fontDialog;
    }
}
