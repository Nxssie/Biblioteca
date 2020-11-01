using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using Biblioteca.View;
using MySql.Data.MySqlClient;

namespace Biblioteca.Controller
{
    public class ListController
    {
        View.ListView lv;
        Model.Model model;

        public ListController()
        {
            try
            {
                lv = new View.ListView();
                model = new Model.Model();
                lv.ButtonClick += Listeners;
                FillDatagrid();
                lv.ShowDialog();
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

        public void FillDatagrid()
        {
            DataSet StudentList = new DataSet();
            MySqlDataAdapter mySqlDataAdapter = model.GetAllAlumnos();
            mySqlDataAdapter.Fill(StudentList);

            StudentList.Tables[0].Columns.Remove("registro");
            StudentList.Tables[0].Columns["dni"].ColumnName = "DNI";
            StudentList.Tables[0].Columns["nombre"].ColumnName = "Nombre";
            StudentList.Tables[0].Columns["apellido1"].ColumnName = "Apellido1";
            StudentList.Tables[0].Columns["apellido2"].ColumnName = "Apellido2";

            lv.GetListDataGrid.DataSource = StudentList.Tables[0];
        }

        public void Listeners(int valor)
        {
            if (valor == 0) {

                const string message = "Está seguro de querer salir?";
                const string caption = "Confirmación";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OKCancel,
                                             MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    lv.Close();
                    lv.Dispose();
                    new Controller();
                }

            }
        }

    }
}
