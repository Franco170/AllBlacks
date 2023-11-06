using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Client
{
    public class Tarea
    {
        private string nombre;
        private string descripcion;
        private string prioridad;
        private string estado;
        private string autor;
        private string encargado;

        public Tarea(string nombre, string descripcion, string prioridad, string estado, string autor, string encargado)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.prioridad = prioridad;
            this.estado = estado;
            this.encargado = encargado;
            this.autor = autor;
        }

       
  

        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Prioridad { get => prioridad; set => prioridad = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Encargado { get => encargado; set => encargado = value; }
        public string Autor { get => autor; set => autor = value; }
    }
}
