using System;
using System.Linq;
using System.Windows.Forms;

namespace FiddlerSanitizer
{
    public partial class SanitizerSettingsTab : UserControl
    {
        private readonly SanitizeSettingsManager settings;

        public SanitizerSettingsTab(SanitizeSettingsManager settings)
        {
            this.settings = settings;
            Load += (sender, args) =>
            {
                InitializeComponent();
                ReloadSettings();
            };
        }      

        private void ReloadSettings()
        {
            DisableEvents();
            SetUiFromSettings();
            EnableEvents();
        }

        private void SetUiFromSettings()
        {
            enabledCheckBox.Checked = settings.Enabled;
            redactedTextBox.Text = settings.RedactedText;
            sanitizeDuringSaveBox.Checked = settings.SanitizeOnSave;
            sanitizeImmediatelyBox.Checked = settings.SanitizeImmediately;
            requestHeadersBox.Text = string.Join(Environment.NewLine, settings.RequestHeadersToRedact);
            responseHeadersBox.Text = string.Join(Environment.NewLine, settings.ResponseHeadersToRedact);
        }

        private void DisableEvents()
        {
            enabledCheckBox.CheckedChanged -= enabledCheckBox_CheckedChanged;
            redactedTextBox.TextChanged -= redactedTextBox_TextChanged;
            sanitizeDuringSaveBox.CheckedChanged -= sanitizeDuringSaveBox_CheckedChanged;
            sanitizeImmediatelyBox.CheckedChanged -= sanitizeImmediatelyBox_CheckedChanged;
            requestHeadersBox.TextChanged -= requestHeadersBox_TextChanged;
            responseHeadersBox.TextChanged -= responseHeadersBox_TextChanged;
        }

        private void EnableEvents()
        {
            enabledCheckBox.CheckedChanged += enabledCheckBox_CheckedChanged;
            redactedTextBox.TextChanged += redactedTextBox_TextChanged;
            sanitizeDuringSaveBox.CheckedChanged += sanitizeDuringSaveBox_CheckedChanged;
            sanitizeImmediatelyBox.CheckedChanged += sanitizeImmediatelyBox_CheckedChanged;
            requestHeadersBox.TextChanged += requestHeadersBox_TextChanged;
            responseHeadersBox.TextChanged += responseHeadersBox_TextChanged;
        }

        private void enabledCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                this.settingsPanel.Enabled = true;
                settings.Enabled = true;
            }
            else
            {
                this.settingsPanel.Enabled = false;
                settings.Enabled = false;
            }
        }

        private void redactedTextBox_TextChanged(object sender, EventArgs e)
        {
            settings.RedactedText = ((TextBox) sender).Text;
        }

        private void requestHeadersBox_TextChanged(object sender, EventArgs e)
        {
            var text = ((TextBox)sender).Text;
            settings.RequestHeadersToRedact = text.Split(new[] {Environment.NewLine}, StringSplitOptions.None).ToList();
        }

        private void responseHeadersBox_TextChanged(object sender, EventArgs e)
        {
            settings.ResponseHeadersToRedact =
               ((TextBox)sender).Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList();
        }

        private void sanitizeDuringSaveBox_CheckedChanged(object sender, EventArgs e)
        {
            settings.SanitizeOnSave = ((CheckBox)sender).Checked;
        }

        private void sanitizeImmediatelyBox_CheckedChanged(object sender, EventArgs e)
        {
            settings.SanitizeImmediately = ((CheckBox)sender).Checked;
        }
    }
}
