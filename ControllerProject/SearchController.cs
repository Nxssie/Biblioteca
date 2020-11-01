using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Biblioteca.View;
using Biblioteca.Model;

namespace Biblioteca.Controller
{
    class SearchController
    {

        SearchView sv;
        Model.Model model;

        public SearchController()
        {
            try
            {
                model = new Model.Model();
                sv = new SearchView();
                sv.ClickButton += Listeners;
                sv.ShowDialog();
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

        private void Listeners(int value)
        {
            
            if(value == 0)
            {
                ReturnToMain();
            } else if (value == 1)
            {
                SearchAlumno();
            } else if (value == 2)
            {
                ShowDeleteMessage();
            }

        }

        private void FillAlumnoLabels(Alumno alumno)
        {
            sv.GetDniLabel.Text = alumno.Dni;
            sv.GetNombreLabel.Text = alumno.Nombre;
            sv.GetPrimApellidoLabel.Text = alumno.PrimApellido;
            sv.GetSegApellidoLabel.Text = alumno.SegApellido;
        }

        private void ReturnToMain()
        {
            const string message = "Está seguro de querer salir?";
            const string caption = "Confirmación";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.OKCancel,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                sv.Close();
                sv.Dispose();
                new Controller();
            }
        }

        private void SearchAlumno()
        {
            try
            {
                Alumno alumno = model.GetAlumno(sv.GetDniTextBox.Text);
                    
                if(alumno != null)
                {
                    FillAlumnoLabels(alumno);
                } else
                {
                    MessageBox.Show("El alumno no existe", "Alumno inexistente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                
            } catch (Exception e)
            {
                MessageBox.Show("Contacte con el desarrollador de la aplicación. Error: GeneralException", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(e.Message);
            }
            
        }

        private void DeleteAlumno()
        {
            try
            {
                if(model.CheckPrestamoPendiente(sv.GetDniLabel.Text)){
                    model.UnableToDeleteAlumno();
                } else
                {
                    model.DeleteAlumno(sv.GetDniLabel.Text);
                    RefreshForm();
                }
                
            }
            catch (Exception e)
            {
                MessageBox.Show("Contacte con el desarrollador de la aplicación. Error: GeneralException", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(e.Message);
            }
        }

        private void RefreshForm()
        {
            sv.GetDniLabel.Text = "[Busqueda pendiente]";
            sv.GetNombreLabel.Text = "[Busqueda pendiente]";
            sv.GetPrimApellidoLabel.Text = "[Busqueda pendiente]";
            sv.GetSegApellidoLabel.Text = "[Busqueda pendiente]";
        }

        private void ShowDeleteMessage()
        {
            const string message = "Está seguro de querer eliminar este alumno?";
            const string caption = "Eliminar alumno";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.OKCancel,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                DeleteAlumno();
            }
        }
    }
}
