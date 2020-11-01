using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model
{
    public class Alumno
    {
        private string dni;
        private string nombre;
        private string primApellido;
        private string segApellido;


        public Alumno(string dni, string nombre, string primApellido, string segApellido)
        {
            this.Dni = dni;
            this.Nombre = nombre;
            this.PrimApellido = primApellido;
            this.SegApellido = segApellido;
        }

        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string PrimApellido { get => primApellido; set => primApellido = value; }
        public string SegApellido { get => segApellido; set => segApellido = value; }
    }
}
