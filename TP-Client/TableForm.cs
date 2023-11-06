using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Client
{
    public partial class TableForm : Form
    {
        Socket clienteSocket;
        string nombreCliente;
        private ArrayList tareas = new ArrayList();

        private Thread actualizacionThread; 

        public TableForm(Socket socket, string nombre)
        {
            
            InitializeComponent();
            clienteSocket = socket;
            nombreCliente = nombre;

            // Configura y inicia el hilo de actualización
            actualizacionThread = new Thread(RecibirActualizaciones);
            actualizacionThread.IsBackground = true;
            actualizacionThread.Start();

        }

        private void ProcesarActualizacion(string actualizacion)
        {
            if (flowLayoutPanel1.InvokeRequired)
            {
                flowLayoutPanel1.Invoke((MethodInvoker)delegate {
                    ProcesarActualizacion(actualizacion);
                });
                return;
            }

            // Dividir la actualización en líneas
            string[] lineas = actualizacion.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            // Supongamos que el formato de la actualización es una lista de nombres de tarjetas separados por comas
            string[] nombresTarjetas = actualizacion.Split(';');

            // Borra todas las tarjetas existentes en el tablero
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();
            flowLayoutPanel3.Controls.Clear();
            flowLayoutPanel4.Controls.Clear();
            flowLayoutPanel5.Controls.Clear();

            
            // Recorrer las líneas y crea una tarjeta para el primer campo de cada línea
            foreach (string linea in lineas)
            {
                // Dividir la línea por el separador ';' y toma el primer campo
                string[] campos = linea.Split(';');
                if (campos.Length > 0)
                {
                    string primerCampo = campos[0];
                    string segundoCampo = campos[1];
                    string tercerCampo = campos[2];
                    if (!string.IsNullOrWhiteSpace(primerCampo))
                    {
                        crearBotonTarjeta(primerCampo, segundoCampo, tercerCampo);
                    }
                }
            }
        }

        private void RecibirActualizaciones()
        {
            while (true)
            {
                try
                {
                    if (clienteSocket.Poll(10, SelectMode.SelectRead) && clienteSocket.Available == 0)
                    {
                        // El socket ha sido cerrado o está disponible
                        break; // Salir del bucle para detener la recepción de actualizaciones
                    }

                    byte[] buffer = new byte[1024];
                    int bytesRead = clienteSocket.Receive(buffer);
                    if (bytesRead == 0)
                    {
                        // No se recibieron datos, lo que podría indicar una desconexión.
                        break; // Salir del bucle para detener la recepción de actualizaciones
                    }
                    string actualizacion = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                    // Llamar al ProcesarActualizacion en el subproceso principal de la interfaz de usuario
                    ProcesarActualizacion(actualizacion);
                }
                catch (SocketException ex)
                {
                    Console.WriteLine("Error al recibir actualizaciones: " + ex.Message);
                    break; // Salir del bucle en caso de error
                }
            }
        }


        public void crearBotonTarjeta(string nombre, string prioridad, string estado)
        {
            // Crear y configura un botón Kanban personalizado
            KanbanCardButton kanbanCardButton = new KanbanCardButton(prioridad);
            kanbanCardButton.Text = nombre;
            kanbanCardButton.Size = new Size(150, 75);

            // Vincular el evento de clic al botón
            //kanbanCardButton.Click += KanbanCardButton_Click;

            // Agrega el botón personalizado al TableLayoutPanel o Panel
            if (estado == "Por Hacer")
            {
                flowLayoutPanel2.Controls.Add(kanbanCardButton);
            }
            else if (estado == "En Proceso")
            {
                flowLayoutPanel3.Controls.Add(kanbanCardButton);
            }
            else if (estado == "Bajo Prueba")
            {
                flowLayoutPanel4.Controls.Add(kanbanCardButton);
            }
            else if (estado == "Hecho")
            {
                flowLayoutPanel5.Controls.Add(kanbanCardButton);
            }
            else
            {
                flowLayoutPanel1.Controls.Add(kanbanCardButton);
            }

            // Configurar la ubicación del botón dentro del contenedor
            kanbanCardButton.Location = new Point(10, 10);
        }

        public void AgregarTarea(Tarea tarea)
        {
            tareas.Add(tarea);
            
        }

        private void btnNewCard_Click(object sender, EventArgs e)
        {

            try
            {
                // Crear una instancia del formulario modal
                NuevaTareaForm crearTareaForm = new NuevaTareaForm(clienteSocket, nombreCliente);

                // Mostrar el formulario modal como cuadro de diálogo modal
                DialogResult result = crearTareaForm.ShowDialog();

                // Después de que se cierre el formulario modal, verificar el resultado (si es necesario)
                if (result == DialogResult.OK)
                {
                    // Crear y configurar un botón Kanban personalizado con el nombre de la tarea
                    string tituloTarea = crearTareaForm.TituloTarea; // get el título de la tarea desde el formulario modal
                    string prioridadTarea = crearTareaForm.PrioridadTarea;
                    string estadoTarea = crearTareaForm.EstadoTarea;
                    crearBotonTarjeta(tituloTarea, prioridadTarea, estadoTarea); // Pasar el título de la tarea al método crearBotonTarjeta
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                // Cierra la conexión con el servidor
                clienteSocket.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                // Actualiza el estado de la conexión en el TextBox en caso de error
                Console.WriteLine("Error al desconectar: " + ex.Message);
            }
        }
    }

    public class KanbanCardButton : Button
    {
        public KanbanCardButton(string prioridad)
        {
            // Configura el aspecto del botón Kanban
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 2;
            //this.BackColor = Color.LightBlue;
            if (prioridad == "Alta")
            {
                this.BackColor = Color.DarkRed;
            }
            else if (prioridad == "Media")
            {
                this.BackColor = Color.DarkGreen;
            }
            else if (prioridad == "Baja")
            {
                this.BackColor = Color.DarkCyan;
            }

            this.ForeColor = Color.White;
            this.Font = new Font("Arial", 10);
            this.TextAlign = ContentAlignment.MiddleCenter;

            this.Click += KanbanCardButton_Click;

        }

        public void KanbanCardButton_Click(object sender, EventArgs e)
        {
            // Muestra la ventana modal con los detalles de la tarjeta
            var detalleTareaForm = new DetalleTareaForm();
            detalleTareaForm.ShowDialog();
            if (sender is KanbanCardButton kanbanCardButton)
            {
                string nombreTarjeta = kanbanCardButton.Text;

                // Enviar el nombre de la tarea al servidor
                EnviarNombreTareaAlServidor(nombreTarjeta);
            }
        }

        private void EnviarNombreTareaAlServidor(string nombreTarea)
        {
            try
            {
                // Conecta con el servidor y envía el nombre de la tarea
                using (TcpClient client = new TcpClient("127.0.0.1", 1234))
                using (NetworkStream stream = client.GetStream())
                {
                    // Convierte el nombre de la tarea en bytes
                    byte[] nombreTareaBytes = Encoding.ASCII.GetBytes(nombreTarea);

                    // Envía el nombre de la tarea al servidor
                    stream.Write(nombreTareaBytes, 0, nombreTareaBytes.Length);

                    // Espera y lee la respuesta del servidor (los detalles de la tarjeta)
                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    string informacionTarjeta = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                    // Deserializa la cadena JSON en un objeto Tarea
                    Tarea tarea = JsonConvert.DeserializeObject<Tarea>(informacionTarjeta);

                    // Muestra la ventana modal para editar la tarjeta
                    DetalleTareaForm editarTareaForm = new DetalleTareaForm(tarea);
                    editarTareaForm.ShowDialog();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener información de la tarjeta desde el servidor: " + ex.Message);
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Dibuja bordes personalizados
            using (Pen pen = new Pen(Color.DarkBlue, 2))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, this.Width - 1, this.Height - 1);
            }
        }
    }
}

