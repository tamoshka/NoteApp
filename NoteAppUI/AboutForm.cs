using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteAppUI
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Переход на репозиторий проекта.
        /// </summary>
        private void GitLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = GitLink.Text,
                UseShellExecute = true
            });
        }

        /// <summary>
        /// Сохранение электронной почты автора.
        /// </summary>
        private void EmailLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(EmailLink.Text);
            MessageBox.Show(
                "Email был скопирован в буфер обмена",
                "Информация",
                MessageBoxButtons.OK);
        }
    }
}
