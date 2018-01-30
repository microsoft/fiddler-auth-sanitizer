namespace FiddlerSanitizer
{
    partial class SanitizerSettingsTab
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
            this.enabledCheckBox = new System.Windows.Forms.CheckBox();
            this.redactedTextLabel = new System.Windows.Forms.Label();
            this.redactedTextBox = new System.Windows.Forms.TextBox();
            this.generalSettingsGroup = new System.Windows.Forms.GroupBox();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.responseHeadersToSanitizeGroup = new System.Windows.Forms.GroupBox();
            this.responseHeadersBox = new System.Windows.Forms.TextBox();
            this.requestHeadersToSanitizeGroup = new System.Windows.Forms.GroupBox();
            this.requestHeadersBox = new System.Windows.Forms.TextBox();
            this.timingGroup = new System.Windows.Forms.GroupBox();
            this.sanitizeImmediatelyBox = new System.Windows.Forms.CheckBox();
            this.sanitizeDuringSaveBox = new System.Windows.Forms.CheckBox();
            this.generalSettingsGroup.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.responseHeadersToSanitizeGroup.SuspendLayout();
            this.requestHeadersToSanitizeGroup.SuspendLayout();
            this.timingGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // enabledCheckBox
            // 
            this.enabledCheckBox.AutoSize = true;
            this.enabledCheckBox.Checked = true;
            this.enabledCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enabledCheckBox.Location = new System.Drawing.Point(22, 17);
            this.enabledCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.enabledCheckBox.Name = "enabledCheckBox";
            this.enabledCheckBox.Size = new System.Drawing.Size(135, 24);
            this.enabledCheckBox.TabIndex = 4;
            this.enabledCheckBox.Text = global::FiddlerSanitizer.Resources.AuthSanitizerTabName;
            this.enabledCheckBox.UseVisualStyleBackColor = true;
            this.enabledCheckBox.CheckedChanged += new System.EventHandler(this.enabledCheckBox_CheckedChanged);
            // 
            // redactedTextLabel
            // 
            this.redactedTextLabel.AutoSize = true;
            this.redactedTextLabel.Location = new System.Drawing.Point(9, 37);
            this.redactedTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.redactedTextLabel.Name = "redactedTextLabel";
            this.redactedTextLabel.Size = new System.Drawing.Size(117, 20);
            this.redactedTextLabel.TabIndex = 6;
            this.redactedTextLabel.Text = "Redacted Text:";
            // 
            // redactedTextBox
            // 
            this.redactedTextBox.Location = new System.Drawing.Point(132, 32);
            this.redactedTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.redactedTextBox.Name = "redactedTextBox";
            this.redactedTextBox.Size = new System.Drawing.Size(401, 26);
            this.redactedTextBox.TabIndex = 7;
            this.redactedTextBox.TextChanged += new System.EventHandler(this.redactedTextBox_TextChanged);
            // 
            // generalSettingsGroup
            // 
            this.generalSettingsGroup.Controls.Add(this.redactedTextBox);
            this.generalSettingsGroup.Controls.Add(this.redactedTextLabel);
            this.generalSettingsGroup.Location = new System.Drawing.Point(4, 2);
            this.generalSettingsGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.generalSettingsGroup.Name = "generalSettingsGroup";
            this.generalSettingsGroup.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.generalSettingsGroup.Size = new System.Drawing.Size(548, 88);
            this.generalSettingsGroup.TabIndex = 5;
            this.generalSettingsGroup.TabStop = false;
            this.generalSettingsGroup.Text = "General Settings";
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.responseHeadersToSanitizeGroup);
            this.settingsPanel.Controls.Add(this.requestHeadersToSanitizeGroup);
            this.settingsPanel.Controls.Add(this.timingGroup);
            this.settingsPanel.Controls.Add(this.generalSettingsGroup);
            this.settingsPanel.Location = new System.Drawing.Point(18, 57);
            this.settingsPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(556, 637);
            this.settingsPanel.TabIndex = 6;
            // 
            // responseHeadersToSanitizeGroup
            // 
            this.responseHeadersToSanitizeGroup.Controls.Add(this.responseHeadersBox);
            this.responseHeadersToSanitizeGroup.Location = new System.Drawing.Point(4, 427);
            this.responseHeadersToSanitizeGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.responseHeadersToSanitizeGroup.Name = "responseHeadersToSanitizeGroup";
            this.responseHeadersToSanitizeGroup.Padding = new System.Windows.Forms.Padding(10, 10, 10, 15);
            this.responseHeadersToSanitizeGroup.Size = new System.Drawing.Size(548, 200);
            this.responseHeadersToSanitizeGroup.TabIndex = 9;
            this.responseHeadersToSanitizeGroup.TabStop = false;
            this.responseHeadersToSanitizeGroup.Text = "Response headers";
            // 
            // responseHeadersBox
            // 
            this.responseHeadersBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.responseHeadersBox.Location = new System.Drawing.Point(10, 29);
            this.responseHeadersBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.responseHeadersBox.Multiline = true;
            this.responseHeadersBox.Name = "responseHeadersBox";
            this.responseHeadersBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.responseHeadersBox.Size = new System.Drawing.Size(528, 156);
            this.responseHeadersBox.TabIndex = 1;
            this.responseHeadersBox.TextChanged += new System.EventHandler(this.responseHeadersBox_TextChanged);
            // 
            // requestHeadersToSanitizeGroup
            // 
            this.requestHeadersToSanitizeGroup.Controls.Add(this.requestHeadersBox);
            this.requestHeadersToSanitizeGroup.Location = new System.Drawing.Point(4, 217);
            this.requestHeadersToSanitizeGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.requestHeadersToSanitizeGroup.Name = "requestHeadersToSanitizeGroup";
            this.requestHeadersToSanitizeGroup.Padding = new System.Windows.Forms.Padding(10, 10, 10, 15);
            this.requestHeadersToSanitizeGroup.Size = new System.Drawing.Size(548, 200);
            this.requestHeadersToSanitizeGroup.TabIndex = 8;
            this.requestHeadersToSanitizeGroup.TabStop = false;
            this.requestHeadersToSanitizeGroup.Text = "Request headers";
            // 
            // requestHeadersBox
            // 
            this.requestHeadersBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requestHeadersBox.Location = new System.Drawing.Point(10, 29);
            this.requestHeadersBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.requestHeadersBox.Multiline = true;
            this.requestHeadersBox.Name = "requestHeadersBox";
            this.requestHeadersBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.requestHeadersBox.Size = new System.Drawing.Size(528, 156);
            this.requestHeadersBox.TabIndex = 0;
            this.requestHeadersBox.TextChanged += new System.EventHandler(this.requestHeadersBox_TextChanged);
            // 
            // timingGroup
            // 
            this.timingGroup.Controls.Add(this.sanitizeImmediatelyBox);
            this.timingGroup.Controls.Add(this.sanitizeDuringSaveBox);
            this.timingGroup.Location = new System.Drawing.Point(4, 98);
            this.timingGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.timingGroup.Name = "timingGroup";
            this.timingGroup.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.timingGroup.Size = new System.Drawing.Size(548, 109);
            this.timingGroup.TabIndex = 6;
            this.timingGroup.TabStop = false;
            this.timingGroup.Text = "Timing";
            // 
            // sanitizeImmediatelyBox
            // 
            this.sanitizeImmediatelyBox.AutoSize = true;
            this.sanitizeImmediatelyBox.Location = new System.Drawing.Point(13, 67);
            this.sanitizeImmediatelyBox.Name = "sanitizeImmediatelyBox";
            this.sanitizeImmediatelyBox.Size = new System.Drawing.Size(364, 24);
            this.sanitizeImmediatelyBox.TabIndex = 9;
            this.sanitizeImmediatelyBox.Text = global::FiddlerSanitizer.Resources.SanitizeAfterEachSession;
            this.sanitizeImmediatelyBox.UseVisualStyleBackColor = true;
            this.sanitizeImmediatelyBox.CheckedChanged += new System.EventHandler(this.sanitizeImmediatelyBox_CheckedChanged);
            // 
            // sanitizeDuringSaveBox
            // 
            this.sanitizeDuringSaveBox.AutoSize = true;
            this.sanitizeDuringSaveBox.Location = new System.Drawing.Point(13, 31);
            this.sanitizeDuringSaveBox.Name = "sanitizeDuringSaveBox";
            this.sanitizeDuringSaveBox.Size = new System.Drawing.Size(177, 24);
            this.sanitizeDuringSaveBox.TabIndex = 8;
            this.sanitizeDuringSaveBox.Text = global::FiddlerSanitizer.Resources.SanitizeDuringSave;
            this.sanitizeDuringSaveBox.UseVisualStyleBackColor = true;
            this.sanitizeDuringSaveBox.CheckedChanged += new System.EventHandler(this.sanitizeDuringSaveBox_CheckedChanged);
            // 
            // SanitizerSettingsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.enabledCheckBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SanitizerSettingsTab";
            this.Size = new System.Drawing.Size(975, 788);
            this.generalSettingsGroup.ResumeLayout(false);
            this.generalSettingsGroup.PerformLayout();
            this.settingsPanel.ResumeLayout(false);
            this.responseHeadersToSanitizeGroup.ResumeLayout(false);
            this.responseHeadersToSanitizeGroup.PerformLayout();
            this.requestHeadersToSanitizeGroup.ResumeLayout(false);
            this.requestHeadersToSanitizeGroup.PerformLayout();
            this.timingGroup.ResumeLayout(false);
            this.timingGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox enabledCheckBox;
        private System.Windows.Forms.Label redactedTextLabel;
        private System.Windows.Forms.TextBox redactedTextBox;
        private System.Windows.Forms.GroupBox generalSettingsGroup;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.GroupBox timingGroup;
        private System.Windows.Forms.GroupBox responseHeadersToSanitizeGroup;
        private System.Windows.Forms.GroupBox requestHeadersToSanitizeGroup;
        private System.Windows.Forms.TextBox responseHeadersBox;
        private System.Windows.Forms.TextBox requestHeadersBox;
        private System.Windows.Forms.CheckBox sanitizeDuringSaveBox;
        private System.Windows.Forms.CheckBox sanitizeImmediatelyBox;
    }
}
