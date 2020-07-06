using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace AppPortCom
{
    public partial class Form1 : Form
    {
        private string donnees;
        private string donneesIn;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] noms_ports = SerialPort.GetPortNames();
            cbNomPort.Items.AddRange(noms_ports);
        }

        private void btnOuvrir_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cbNomPort.SelectedItem.ToString();
                serialPort1.BaudRate = Convert.ToInt32(cbBaudPort.SelectedItem.ToString());
                serialPort1.DataBits = Convert.ToInt32(cbNbrBit.SelectedItem.ToString());
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cbStopBit.SelectedItem.ToString());
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cbPariteBit.SelectedItem.ToString());

                serialPort1.Open();
                MessageBox.Show("Port" + serialPort1.PortName + " ouvert", "Ouverture", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception erreur)
            {
                MessageBox.Show(erreur.Message,"Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }

        private void btnEnvoiData_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                donnees = tbData.Text;
                serialPort1.Write(donnees);
            }
        }

        private void btnRecevoir_Click(object sender, EventArgs e)
        {
            donneesIn = serialPort1.ReadExisting();
            tbDataIn.Text = donneesIn;
        }
    }
}
