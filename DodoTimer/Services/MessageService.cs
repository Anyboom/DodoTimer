using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DodoTimer.Services
{
    class MessageService
    {
        public static void ShowError(string message) => MessageBox.Show(message, Settings.TitleProject, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        public static void ShowWarn(string message) => MessageBox.Show(message, Settings.TitleProject, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
        public static void ShowInfo(string message) => MessageBox.Show(message, Settings.TitleProject, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        public static DialogResult ShowQuestion(string message, MessageBoxButtons buttons) => MessageBox.Show(message, Settings.TitleProject, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
    }
}
