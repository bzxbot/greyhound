using System;
using System.Windows.Forms;

namespace Greyhound
{
    public static class ErrorMessageBox
    {
        public static void Show(String message, Exception ex)
        {
            string details = string.Empty;

            if (ex != null && ex.Message != null)
            {
                details = ex.Message;

                if (ex.InnerException != null)
                {
                    details += ex.InnerException;
                }
            }

            if (details != string.Empty)
            {
                MessageBox.Show(string.Format("{0}\n\nDetalhes:\n{1}", message, details), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
