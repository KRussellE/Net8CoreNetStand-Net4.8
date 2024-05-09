using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NET48Sample
{
    class Class1
    {
        public string myMsg;

        public Class1(string msg)
        {
            myMsg = msg;
            MessageBox.Show("Info: "+ "\n" + myMsg);
        }

    }
}
