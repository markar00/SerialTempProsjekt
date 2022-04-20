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

namespace SerialTempProsjekt
{
    public partial class Form1 : Form
    {
        SerialPort sp;
        string data;
        public Form1()
        {
            InitializeComponent();
            string[] porter = SerialPort.GetPortNames();

            foreach (string port in porter)
            {
                cbSeriellePorter.Items.Add(port);
            }
            if (cbSeriellePorter.Items.Count > 0)
                cbSeriellePorter.SelectedIndex = 0;

            btnStart.Enabled = true;
            btnStopp.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // sp = new SerialPort("COM6",9600);
            string portNavn = cbSeriellePorter.Items[cbSeriellePorter.SelectedIndex].ToString();
            sp = new SerialPort(portNavn, 9600);

            try
            {
                sp.Open();
                if (sp.IsOpen)
                {
                    tDeltaT.Enabled = true;
                    btnStart.Enabled = false;
                    btnStopp.Enabled = true;
                }
            }
            catch (Exception unntak)
            {
                MessageBox.Show("Feil (0): " + unntak.Message);
            }
        }

        private void cbSeriellePorter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnStopp_Click(object sender, EventArgs e)
        {
            try
            {
                sp.Close();
                sp.Dispose();
                tDeltaT.Enabled = false;
            }
            catch (Exception unntak)
            {
                MessageBox.Show("Feil (1): " + unntak.Message);
            }

            btnStart.Enabled = true;
            btnStopp.Enabled = false;
        }

        private void btnRydd_Click(object sender, EventArgs e)
        {
            lbHistorikk.Items.Clear();
            txtEnMelding.Text = "";
            txtTMaks.Text = "";
            txtTMin.Text = "";
            txtTSnitt.Text = "";
        }

        private void btnAvslutt_Click(object sender, EventArgs e)
        {
            if (sp != null)
            {
                if (sp.IsOpen) sp.Close();
            }
            Application.Exit();
        }

        private void txtEnMelding_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbHistorikk_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTMaks_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtTMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tDeltaT_Tick(object sender, EventArgs e)
        {
            data = data + sp.ReadExisting();
            data = ProsesserData(data);
        }

        string ProsesserData(string data)
        {
            string svar = "";
            int indeksD = data.IndexOf('$');
            int indeksH = data.IndexOf('#');

            // Dersom vi har kun siste del av en melding, forkaster vi den
            if (indeksD < 0)
            {
                svar = "";
            }
            else if (indeksD > indeksH)
            {
                // Om vi har siste del av en melding og mer data etter den
                // så forkaster vi 'siste del av en melding'
                // Men beholde resten
                svar = data.Substring(indeksD);
            }
            else // Vi har en hel melding (starter med $ og slutter med #
            {
                string enMelding = data.Substring(indeksD, (indeksH - indeksD) + 1);
                VisVerdier(enMelding);
                //lbHistorikk.Items.Add(enMelding);
                lbHistorikk.Items.Insert(0, enMelding);
                svar = data.Substring((indeksH + 1));
            }
            return svar;
        }
        void VisVerdier(string enMelding)
        {
            int indeksA = enMelding.IndexOf('A');
            int indeksB = enMelding.IndexOf('B');


            if (indeksA > 0 && indeksB > 0)
            {
                txtTMaks.Text = enMelding.Substring(indeksA + 1, (indeksB - (indeksA + 1)));
                txtTMin.Text = enMelding.Substring(indeksB + 1, enMelding.Length - (indeksB + 2));
            }
        }

        private void txtTSnitt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
