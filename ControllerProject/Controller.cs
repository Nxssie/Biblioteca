using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Biblioteca.Model;
using Biblioteca.View;
using MySql.Data.MySqlClient;

namespace Biblioteca.Controller
{
    public class Controller
    {
        MainView mv;
        Model.Model model;

        public Controller()
        {
            model = new Model.Model();
            mv = new MainView();
            mv.ButtonClick += Listeners;
            mv.ShowDialog();
            
        }

        public void Listeners(int valor)
        {
            if(valor == 0)
            {
                CloseApplication();
            } else if (valor == 1)
            {
                OpenSearch();
            } else if (valor == 2)
            {
                OpenList();
            }
        }

        private void OpenSearch()
        {
            mv.Close();
            mv.Dispose();
            new SearchController();
        }

        private void OpenList()
        {
            mv.Close();
            mv.Dispose();
            new ListController();
        }
        
        private void CloseApplication()
        {
            const string message = "Está seguro de querer salir de la aplicación?";
            const string caption = "Confirmación";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.OKCancel,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

    }
}
