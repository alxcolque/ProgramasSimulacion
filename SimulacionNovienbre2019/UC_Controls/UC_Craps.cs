using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulacionNovienbre2019.UC_Controls
{
    public partial class UC_Craps : UserControl
    {
        public UC_Craps()
        {
            InitializeComponent();
        }
        private int lanzar()
        {
            int suma = 0;
            Random rnd = new Random();
            int d1 = rnd.Next(1, 6);
            lblDado1.Text = "" + d1;
            int d2 = rnd.Next(1, 6);
            lblDado2.Text = "" + d2;
            suma = d1 + d2;
            lblSuma.Text = "" + suma;
            return suma;
        }
        private void resultados(int r)
        {
            if (r == 1)
            {
                pnlGanaste.Visible = true;
                btnJugar.Visible = false;
                btnOK.Visible = true;
                btnIntentar.Visible = false;
                lblProb.Text = "0.22222";
            }
            else if (r == 0)
            {
                pnlPerdiste.Visible = true;
                btnJugar.Visible = false;
                btnOK.Visible = true;
                btnIntentar.Visible = false;
                lblProb.Text = "0.27071";
            }
            else
            {
                MessageBox.Show("Maldicion");
            }
        }
        int puntos = 0;
        private void btnJugar_Click(object sender, EventArgs e)
        {
            imgif.Visible = true;
            //pnlPerdiste.Visible = false;
            //pnlGanaste.Visible = false;
            int t = lanzar();
            if (t == 7 || t == 11)
            {
                resultados(1);
            }
            else if (t == 2 || t == 3 || t == 12)
            {
                resultados(0);

            }
            else
            {
                puntos = t;
                lblPuntos.Text = "" + puntos;
                btnIntentar.Visible = true;
                btnJugar.Visible = false;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            UC_Craps uch = new UC_Craps();
            AddControlsToPanel(uch);
        }
        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(c);
        }
        private void btnIntentar_Click(object sender, EventArgs e)
        {
            int t;
            btnIntentar.Visible = true;
            t = lanzar();
            if (t == puntos)
            {
                resultados(1);
            }
            else
            {
                if (t == 7)
                {
                    resultados(0);
                }
            }

            lblPuntos.Text = "" + puntos;
        }

        private void btnCraps_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
