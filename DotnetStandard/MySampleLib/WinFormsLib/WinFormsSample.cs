using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsLib
{
    public class WinFormsSample
    {
        public void ShowMessageBox(string message)
        {
            MessageBox.Show(message);
        }

        public static int Add(int x, int y) => x + y;
    }
}
