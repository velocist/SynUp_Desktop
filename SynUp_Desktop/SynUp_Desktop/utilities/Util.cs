using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SynUp_Desktop.utilities
{
    public static class Util
    {
        /// <summary>
        /// Confirmation dialog that will let the user confirm they action or cancel it.
        /// </summary>
        /// <param name="message"></param>
        /// <returns>Button click</returns>
        public static bool confirmationDialog(string message, string titleForm)
        {
            return (MessageBox.Show(message, titleForm, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
        }
    }
}
