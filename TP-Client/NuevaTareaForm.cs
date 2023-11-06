using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Sockets;

namespace TP_Client
{
    public partial class NuevaTareaForm : Form
    {
        Socket clienteSocket;
        string nombreCliente;
        public NuevaTareaForm(Socket cliente, string nombre)
        {
            InitializeComponent();
            clienteSocket = cliente;
            nombreCliente = nombre;

        }

        // Propiedad pública para obtener el título de la tarea
        public string TituloTarea
        {
            get { return textBoxTitulo.Text; } 
        }

        public string PrioridadTarea
        {
            get { return comboBoxPrioridad.SelectedItem.ToString(); } 
        }

        public string EstadoTarea
        {
            get { return comboBoxEstado.SelectedItem.ToString(); } 
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            // Obtén el título de la tarea ingresado por el usuario desde el TextBox
            string tituloTarea = textBoxTitulo.Text.ToString();
            string descripcionTarea = textBoxDescripción.Text.ToString();
            string encargadoTarea = textBoxEncargado.Text.ToString();
            string prioridadTarea = comboBoxPrioridad.SelectedItem.ToString();
            string autorTarea = nombreCliente;
            string estadoTarea = comboBoxEstado.SelectedItem.ToString();

            Tarea nuevaTarea = new Tarea(tituloTarea, descripcionTarea, prioridadTarea, estadoTarea, autorTarea, encargadoTarea);

            // Agrega la nueva tarjeta a la lista de tarjetas en el formulario principal
            if (Owner is TableForm mainForm)
            {
                mainForm.AgregarTarea(nuevaTarea);
            }

            // Configura el resultado del formulario modal como DialogResult.OK para indicar éxito
            DialogResult = DialogResult.OK;

            // Serializa la tarea a JSON (puedes usar una biblioteca como Json.NET)
            string tareaSerializada = JsonConvert.SerializeObject(nuevaTarea);

            // Envía los datos al servidor
            byte[] buffer = Encoding.UTF8.GetBytes("NUEVA_TAREA" + tareaSerializada);
            clienteSocket.Send(buffer);

            // Cierra el formulario modal
            Close();
        }
    }
}
