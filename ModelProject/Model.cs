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
        MySqlConnection Connector;

        public Model()
        {
            Connector = DatabaseConnection.CreateConnection();
            Connector.Open();
        }

        public MySqlDataAdapter GetAllAlumnos()
        {
            CheckConnection();
            string select = "SELECT * FROM ALUMNOS";
            MySqlDataAdapter AllAlumnos = new MySqlDataAdapter(select, Connector);
            Connector.Close();
            return AllAlumnos;
        }

        public void DeleteAlumno(string dni)
        {
            CheckConnection();

            if(CheckPrestamoPendiente(dni))
            {
                string Query = "DELETE FROM ALUMNOS WHERE dni='" + dni + "'";
                MySqlCommand Command = new MySqlCommand(Query, Connector);
                MySqlDataReader deleteReader = Command.ExecuteReader();
                Connector.Close();
                deleteReader.Close();
            } else
            {
                UnableToDeleteAlumno();
                Connector.Close();
            }
            
        }

        private bool CheckPrestamoPendiente(string dni)
        {
            CheckConnection();
            string Query = "SELECT * FROM PRESTAMOS WHERE codAlumno='" + dni + "' + estado='pendiente'";
            MySqlCommand Command = new MySqlCommand(Query, Connector);
            MySqlDataReader prestamosReader = Command.ExecuteReader();

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
            Alumno Sample;
            string QuerySelect = "SELECT dni, nombre, apellido1, apellido2 FROM ALUMNOS WHERE dni='" + dni + "'";
            MySqlCommand Query = new MySqlCommand(QuerySelect, Connector);
            MySqlDataReader dataReader = Query.ExecuteReader();

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
            Connector.Close();

            Sample = new Alumno(Dni, Nombre, PrimApellido, SegApellido);


            return Sample;
        }

        public void CheckConnection()
        {
            if (Connector.State == ConnectionState.Closed)
            {
                Connector.Open();
            }
        }

        public void UnableToDeleteAlumno()
        {
            const string Message = "El usuario que intenta eliminar tiene un prestamo pendiente";
            const string Caption = "Usuario";
            MessageBox.Show(Message, Caption,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Warning);
        }

    }
}
