using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Client
{
    public partial class Form1 : Form
    {
        Cliente miCliente = new Cliente(); // Crea una instancia de Cliente

        private Socket clienteSocket;
        private IPEndPoint servidorEndPoint;

        public Form1()
        {
            InitializeComponent();

            // Inicializa el socket del cliente
            clienteSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        }

        private void btnAceptarNombre_Click_1(object sender, EventArgs e)
        {
            miCliente.Nombre = txtName.Text; // Asigna el nombre ingresado

            try
            {
                // Cierra la conexión si ya está abierta
                if (clienteSocket != null && clienteSocket.Connected)
                {
                    clienteSocket.Close();
                    clienteSocket.Dispose();
                }

                // Crea una nueva instancia del socket del cliente
                clienteSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                // Configura el punto de conexión del servidor (ajusta la dirección IP y el puerto según corresponda)
                servidorEndPoint = new IPEndPoint(IPAddress.Parse(txtHost.Text), int.Parse(txtPort.Text));

                // Obtén el nombre del cliente
                string nombreCliente = string.IsNullOrEmpty(miCliente.Nombre) ? "NombreDesconocido" : miCliente.Nombre;

                // Envía el nombre del cliente al servidor
                byte[] nombreData = Encoding.ASCII.GetBytes(nombreCliente);
                clienteSocket.Connect(servidorEndPoint);
                clienteSocket.Send(nombreData);

                if (clienteSocket.Connected)
                {
                    TableForm tablero = new TableForm(clienteSocket, nombreCliente);
                    tablero.Show(); // Muestra el nuevo formulario
                    this.Hide();
                    
                }

            }
            catch (Exception ex)
            {
                // Actualiza el estado de la conexión en el TextBox en caso de error
                Console.WriteLine("Error al conectar con el servidor: " + ex.Message);
            }
        }
    }
}
