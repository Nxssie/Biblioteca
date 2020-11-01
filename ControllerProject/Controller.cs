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

        public Controller()
        {
            try
            {
                mv = new MainView();
                mv.ButtonClick += Listeners;
                mv.ShowDialog();
            } catch (NullReferenceException nre)
            {
                MessageBox.Show("Contacte con el desarrollador de la aplicación. Error: NullReferenceException", "Error",MessageBoxButtons.OK);
                Console.WriteLine(nre.Message);
            } catch (Exception e)
            {
                MessageBox.Show("Contacte con el desarrollador de la aplicación. Error: GeneralException", "Error", MessageBoxButtons.OK);
                Console.WriteLine(e.Message);
            }
            
            
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
            try { 
                mv.Close();
                mv.Dispose();
                new SearchController();
            }
            catch (NullReferenceException nre)
            {
                MessageBox.Show("Contacte con el desarrollador de la aplicación. Error: NullReferenceException", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(nre.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show("Contacte con el desarrollador de la aplicación. Error: GeneralException", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(e.Message);
            }
        }

        private void OpenList()
        {
            try { 
                mv.Close();
                mv.Dispose();
                new ListController();
            }
            catch (NullReferenceException nre)
            {
                MessageBox.Show("Contacte con el desarrollador de la aplicación. Error: NullReferenceException", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(nre.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show("Contacte con el desarrollador de la aplicación. Error: GeneralException", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(e.Message);
            }
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
