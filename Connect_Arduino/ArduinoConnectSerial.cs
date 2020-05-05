using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace Connect_Arduino
{
    class ArduinoConnectSerial
    {

        private SerialPort Verbindung;
  

        public void NachrichtSenden(string nachricht)
        {
            if (Verbindung != null && Verbindung.IsOpen)
            {
                Verbindung.WriteLine(nachricht);
            }
        }

        public void Verbinden(string port)
        {
            Verbindung = new SerialPort(port, 9600);
            Verbindung.NewLine = "\n";
            Verbindung.Open();
            NachrichtSenden("verbunden");
          }

        public void Trennen()
        {
            if (Verbindung != null && Verbindung.IsOpen)
            {
                NachrichtSenden("trennen");
                Verbindung.Close();
            }

        }

    }
}
