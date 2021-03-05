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
    public partial class UC_Azucar : UserControl
    {
        public UC_Azucar()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            dtgvAzucar.Rows.Clear();
            dtgvAzucar.Refresh();
            int dmax = int.Parse(txtDMax.Text);
            int cbod = int.Parse(txtCBod.Text);
            
            int cord = int.Parse(txtCOrden.Text);
            double pventa = int.Parse(txtPV.Text);
            double pcompra = int.Parse(txtPC.Text);
            int cdia = 0;
            double gneta, rdemazu=0, demazu, invazu = 700, ped = 0, tcadq = 0;
            double vtotal = 0, dins = 0, cdins = 0,tent=0,ctent = 0, tcord = 0;
            double cumant = 0.1, ctmant = 0,inbru = 0;
            Random rnd1 = new Random();
            Random rnd2 = new Random();
            try
            {
                while (cdia <= dmax)
                {
                    cdia++;
                    if (cdia % 7 == 0)
                    {
                        ped = cbod - invazu;
                        tcadq = tcadq + ped * pcompra;
                        tcord = tcord + cord;
                        tent = rnd2.NextDouble();
                        tent = Math.Round(1+2*tent); 
                        ctent++;
                    }
                    else
                    {
                        
                        rdemazu = rnd1.NextDouble();
                        demazu = Convert.ToInt32(-1 / 200 * Math.Log(1 - rdemazu));
                        if (demazu <= invazu)
                        {
                            ctent++;
                            if (ctent == 0)
                            {
                                ctent++;
                                if (ctent == tent)
                                {
                                    invazu = invazu + pventa;
                                    ctent = 0;
                                }

                            }
                            invazu = invazu - demazu;
                            inbru = inbru + demazu * pventa;
                            ctmant = ctmant + invazu * cumant;
                        }
                        else
                        {
                            vtotal = invazu;
                            dins = dins + demazu - invazu;
                            inbru = inbru + invazu;
                            invazu = 0;

                        }

                        dtgvAzucar.Rows.Add(cdia, Math.Round(rdemazu, 4), ctmant);
                    }
                    
                }
                double ctot = ctmant + 100 + 2450;
                gneta = ctot-inbru;
                cdins = pcompra-dins;
                lblCDins.Text = "" + cdins;
                lblVtotal.Text = "" + ctmant;
                lblGNeta.Text = "" + gneta + " Bs";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Las Cosas andan mal");
                this.Refresh();
                throw ex;
                //

            }
        }

        private void btnCerrarPnl_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
