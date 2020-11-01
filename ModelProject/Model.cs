using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca.Model
{
    public class Model
    {
        Connection DatabaseConnection = new Connection();
        MySqlConnection connector;

        public Model()
        {
            connector = DatabaseConnection.CreateConnection();
            connector.Open();
        }

        public MySqlDataAdapter GetAllAlumnos()
        {
            CheckConnection();
            string select = "SELECT * FROM ALUMNOS";
            MySqlDataAdapter AllAlumnos = new MySqlDataAdapter(select, connector);
            connector.Close();
            return AllAlumnos;
        }

        public void DeleteAlumno(string dni)
        {
            CheckConnection();

            if(CheckPrestamoPendiente(dni))
            {
                string query = "DELETE FROM ALUMNOS WHERE dni='" + dni + "'";
                MySqlCommand command = new MySqlCommand(query, connector);
                MySqlDataReader deleteReader = command.ExecuteReader();
                connector.Close();
                deleteReader.Close();
            } else
            {
                UnableToDeleteAlumno();
                connector.Close();
            }
            
        }

        private bool CheckPrestamoPendiente(string dni)
        {
            CheckConnection();
            string query = "SELECT * FROM PRESTAMOS WHERE codAlumno='" + dni + "' + estado='pendiente'";
            MySqlCommand command = new MySqlCommand(query, connector);
            MySqlDataReader prestamosReader = command.ExecuteReader();

            if (prestamosReader.HasRows)
            {
                prestamosReader.Close();
                return false;
                
            } else if (!prestamosReader.HasRows)
            {
                prestamosReader.Close();
                return true;
                
            } else
            {
                MessageBox.Show("Ha ocurrido un error inesperado");
                return false;
                
            }
        }

        public Alumno GetAlumno(string dni)
        {
            CheckConnection();
            Alumno sample;
            string querySelect = "SELECT dni, nombre, apellido1, apellido2 FROM ALUMNOS WHERE dni='" + dni + "'";
            MySqlCommand query = new MySqlCommand(querySelect, connector);
            MySqlDataReader dataReader = query.ExecuteReader();

            string Dni = "";
            string Nombre = "";
            string PrimApellido = "";
            string SegApellido = "";

            while (dataReader.Read())
            {
                Dni = dataReader.GetString(0);
                Nombre = dataReader.GetString(1);
                PrimApellido = dataReader.GetString(2);
                SegApellido = dataReader.GetString(3);
            }
            dataReader.Close();
            connector.Close();

            sample = new Alumno(Dni, Nombre, PrimApellido, SegApellido);


            return sample;
        }

        public void CheckConnection()
        {
            if (connector.State == ConnectionState.Closed)
            {
                connector.Open();
            }
        }

        public void UnableToDeleteAlumno()
        {
            const string message = "El usuario que intenta eliminar tiene un prestamo pendiente";
            const string caption = "Usuario";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Warning);
        }

    }
}
