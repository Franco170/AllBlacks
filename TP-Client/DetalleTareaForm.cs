using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Client
{
    public partial class DetalleTareaForm : Form
    {
        private Tarea tarea;

        public DetalleTareaForm()
        {
            InitializeComponent();
        }
        
        public DetalleTareaForm(Tarea tarea)
        {
            InitializeComponent();
            this.tarea = tarea;

            // Llena los campos de texto y combobox con los detalles de la tarea
            textBoxNombre.Text = tarea.Nombre;
            textBoxDescripcion.Text = tarea.Descripcion;
            comboBoxPrioridad.SelectedItem = tarea.Prioridad;
            comboBoxEstado.SelectedItem = tarea.Estado;
            textBoxAutor.Text = tarea.Autor;
            textBoxEncargado.Text = tarea.Encargado;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Obtiene los valores editados por el usuario
            tarea.Nombre = textBoxNombre.Text;
            tarea.Descripcion = textBoxDescripcion.Text;
            tarea.Prioridad = comboBoxPrioridad.SelectedItem.ToString();
            tarea.Estado = comboBoxEstado.SelectedItem.ToString();
            tarea.Autor = textBoxAutor.Text;
            tarea.Encargado = textBoxEncargado.Text;

            // Envía la tarea actualizada al servidor
            //EnviarTareaActualizadaAlServidor(tarea);

            // Cierra la ventana modal
            this.Close();
        }

        private void linkLabelEditar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
    }

    
}
