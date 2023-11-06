using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TP_Client
{
    class Cliente
    {
        public string Nombre { get; set; }
        public Socket Socket { get; set; }

    }
}
