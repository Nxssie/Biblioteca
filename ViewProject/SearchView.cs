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
    public partial class SearchView : Form
    {
        public SearchView()
        {
            InitializeComponent();
        }

        public delegate void ActionButton(int value);
        public event ActionButton ClickButton;

        private void searchBttn_Click(object sender, EventArgs e)
        {
            ClickButton(1);
        }

        private void DeleteBttn_Click(object sender, EventArgs e)
        {
            ClickButton(2);
        }

        private void salirBttn_Click(object sender, EventArgs e)
        {
            ClickButton(0);
        }
    }
}
