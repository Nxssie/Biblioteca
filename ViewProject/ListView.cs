using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.View
{
    public partial class ListView : Form
    {
        public ListView()
        {
            InitializeComponent();
        }

        public delegate void buttonAction(int valor);

        public event buttonAction ButtonClick;

        private void exitBttn_Click(object sender, EventArgs e)
        {
            ButtonClick(0);
        }
    }
}
