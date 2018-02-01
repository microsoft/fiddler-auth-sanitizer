// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Fiddler;

[assembly: RequiredVersion("4.6.2.0")]
namespace FiddlerSanitizer
{
    public class HeaderSanitizerPlugin : IFiddlerExtension
    {
        private SanitizerSettingsTab authSettingsTab;
        private SanitizeSettingsManager settings;
        
        public void OnLoad()
        {
            var authPage = new TabPage(Resources.AuthSanitizerTabName)
            {
                ImageIndex = (int) SessionIcons.Authorization,
                BackColor = Color.White
            };

            settings = new SanitizeSettingsManager();
            authSettingsTab = new SanitizerSettingsTab(settings);
            authPage.Controls.Add(authSettingsTab);
            FiddlerApplication.UI.tabsViews.TabPages.Add(authPage);

            FiddlerApplication.OnSaveSAZ += FiddlerApplication_OnSaveSAZ;
            FiddlerApplication.AfterSessionComplete += FiddlerApplication_OnAfterSessionComplete;
        }

        private void FiddlerApplication_OnAfterSessionComplete(Session session)
        {
            if (settings.Enabled && settings.SanitizeImmediately)
            {
                SanitizeSession(session, settings.RequestHeadersToRedact, settings.ResponseHeadersToRedact, settings.RedactedText);
            }
        }

        private void FiddlerApplication_OnSaveSAZ(object sender, FiddlerApplication.WriteSAZEventArgs e)
        {
            if (settings.Enabled && settings.SanitizeOnSave)
            {
                SanitizeSessions(e.arrSessions, settings.RequestHeadersToRedact, settings.ResponseHeadersToRedact, settings.RedactedText);
            }
        }

        private void SanitizeSessions(IEnumerable<Session> sessions, IEnumerable<string> requestHeadersToRedact, IEnumerable<string> responseHeadersToRedact, string redactedText)
        {
            foreach (var session in sessions)
            {
                SanitizeSession(session, requestHeadersToRedact, responseHeadersToRedact, redactedText);
            }
        }

        private void SanitizeSession(Session session, IEnumerable<string> requestHeadersToRedact, IEnumerable<string> responseHeadersToRedact, string redactedText)
        {
            foreach (var header in requestHeadersToRedact)
            {
                RedactRequestHeader(session, header, redactedText);
            }

            foreach (var header in responseHeadersToRedact)
            {
                RedactResponseHeader(session, header, redactedText);
            }
        }

        private static void RedactRequestHeader(Session session, string headerName, string redactedText)
        {
            foreach (var header in session.RequestHeaders.Where(x => string.Equals(x.Name, headerName, StringComparison.OrdinalIgnoreCase)))
            {
                header.Value = redactedText;
            }
        }

        private static void RedactResponseHeader(Session session, string headerName, string redactedText)
        {
            foreach (var header in session.ResponseHeaders.Where(x => string.Equals(x.Name, headerName, StringComparison.OrdinalIgnoreCase)))
            {
                header.Value = redactedText;
            }
        }

        public void OnBeforeUnload()
        {
        }
    }
}
