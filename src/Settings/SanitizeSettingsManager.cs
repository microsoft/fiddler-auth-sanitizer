using System;
using System.Collections.Generic;
using System.Linq;
using Fiddler;

namespace FiddlerSanitizer
{
    public class SanitizeSettingsManager
    {
        // Defaults
        private const bool DefaultEnabled = true;
        private const bool DefaultSanitizeOnSave = true;
        private const bool DefaultSanitizeImmediately = false;
        private const string DefaultRedactedText = "<REDACTED>";
        private static readonly string[] DefaultRequestHeadersToRedact = { "Authorization", "Cookie" };
        private static readonly string[] DefaultResponseHeadersToRedact = { "Set-Cookie" };

        // Settings
        private readonly BoolSetting enabledSetting = new BoolSetting("enabled", DefaultEnabled);
        private readonly BoolSetting sanitizeOnSaveSetting = new BoolSetting("sanitize-on-save", DefaultSanitizeOnSave);
        private readonly BoolSetting sanitizeImmediatelySetting = new BoolSetting("sanitize-immediately", DefaultSanitizeImmediately);
        private readonly StringSetting redactedTextSetting = new StringSetting("redacted-text", DefaultRedactedText);
        private readonly StringsSetting requestHeadersToRedactSetting = new StringsSetting("request-headers", DefaultRequestHeadersToRedact);
        private readonly StringsSetting responseHeadersToRedactSetting = new StringsSetting("response-headers", DefaultResponseHeadersToRedact);

        // Property accessors
        public bool Enabled { get => enabledSetting.Value; set => enabledSetting.Value = value; }
        public bool SanitizeOnSave { get => sanitizeOnSaveSetting.Value; set => sanitizeOnSaveSetting.Value = value; }
        public bool SanitizeImmediately { get => sanitizeImmediatelySetting.Value; set => sanitizeImmediatelySetting.Value = value; }
        public string RedactedText { get => redactedTextSetting.Value; set => redactedTextSetting.Value = value; }
        public IEnumerable<string> RequestHeadersToRedact { get => requestHeadersToRedactSetting.Value ?? Enumerable.Empty<string>(); set => requestHeadersToRedactSetting.Value = value; }
        public IEnumerable<string> ResponseHeadersToRedact { get => responseHeadersToRedactSetting.Value ?? Enumerable.Empty<string>(); set => responseHeadersToRedactSetting.Value = value; }

        public void ReloadDefaults()
        {
            Enabled = DefaultEnabled;
            RedactedText = DefaultRedactedText;
            RequestHeadersToRedact = DefaultRequestHeadersToRedact;
            ResponseHeadersToRedact = DefaultResponseHeadersToRedact;
        }
    }
}