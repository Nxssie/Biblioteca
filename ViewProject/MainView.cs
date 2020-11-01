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
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        public delegate void ActionButton(int valor);

        public event ActionButton ButtonClick;

        private void ExitBttn_Click(object sender, EventArgs e)
        {
            ButtonClick(0);
        }

        private void SearchBttn_Click(object sender, EventArgs e)
        {
            ButtonClick(1);
        }

        private void ListBttn_Click(object sender, EventArgs e)
        {
            ButtonClick(2);
        }

        
    }
}
