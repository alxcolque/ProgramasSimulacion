using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimulacionNovienbre2019.Properties;

namespace SimulacionNovienbre2019.UC_Controls
{
    public partial class UC_DestinoDelPollo : UserControl
    {
        public UC_DestinoDelPollo()
        {
            InitializeComponent();
        }
        
        private void btnCerrarPnl_Click(object sender, EventArgs e)
        {
            Application.Restart();
            //this.Visible = false;
            //this.Visible = true;
            //pnlPrincipal.Controls.Clear();
            /*this.Dispose();
            Form1 uch = new Form1();*/
        }
        private void imprimir(long dia, double rnh, long chuevo, double reh, string ceh, double rep, string cep, double gneta )
        {
            dtgvPollos.Rows.Add(dia,rnh,chuevo,reh,ceh,rep,cep,gneta);
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            dtgvPollos.Rows.Clear();
            dtgvPollos.Refresh();
            long cdia = 0 , chuevo=0;
            double rnh=0, reh = 0,rep=0;
            double gneta = 0, gdia=0;
            int nhd, nRompe = 0, vive = 0, muere = 0, nhuevo = 0;
            string eh = "-", cep = "-";
            int dmax = int.Parse(txtDMax.Text);
            Random rnd = new Random();
            Random rnd1 = new Random();
            Random rnd2 = new Random();
            try
            {
                do
                {
                    cdia++;
                    ///Aleatorio pone huevo dia
                    rnh = rnd.NextDouble();
                    if (rnh >= 0 && rnh <= 0.135)
                    {
                        nhd = 0;
                        imprimir(cdia, Math.Round(rnh, 4), chuevo, Math.Round(reh, 4), eh, Math.Round(rep, 4), cep, gneta);
                    }
                    else 
                    {
                        if (rnh > 0.135 && rnh <= 0.406)
                        {
                            nhd = 1;
                        }
                        else if (rnh > 0.406 && rnh <= 0.677)
                        {
                            nhd = 2;
                        }
                        else if (rnh > 0.677 && rnh <= 0.857)
                        {
                            nhd = 3;
                        }
                        else if (rnh > 0.857 && rnh <= 0.947)
                        {
                            nhd = 4;
                        }
                        else if (rnh > 0.947 && rnh <= 0.982)
                        {
                            nhd = 5;
                        }
                        else if (rnh > 0.982 && rnh <= 0.995)
                        {
                            nhd = 6;
                        }
                        else
                        {
                            nhd = 7;
                        }
                        ///jeje
                        chuevo = nhd;
                        while (nhd != 0)
                        {
                            ///aleatorio estado huevo para 0=rompe, 1 = pollo, 2 = huevo
                            reh = rnd1.NextDouble();
                            if (reh >= 0 && reh <= 0.20)
                            {
                                eh = "Rompe";
                                nRompe++;
                                imprimir(cdia, Math.Round(rnh, 4), chuevo, Math.Round(reh, 4), eh, Math.Round(rep, 4), cep, 0);
                                rnh = 0;
                                chuevo = 0;

                                eh = "-";
                            }
                            else if (reh > 0.20 && reh <= 0.50)
                            {
                                // Aleatorio si es pollo 0=muere, 1=vive
                                eh = "Pollo";
                                rep = rnd2.NextDouble();
                                if (rep >= 0 && rep <= 0.2)
                                {
                                    cep = "Muere";
                                    muere++;
                                    imprimir(cdia, Math.Round(rnh, 4), chuevo, Math.Round(reh, 4), eh, Math.Round(rep, 4), cep, 0);
                                    rnh = 0;
                                    chuevo = 0;
                                    rep = 0;
                                    cep = "-";
                                }
                                else
                                {
                                    cep = "Vive";
                                    gneta += double.Parse(txtPVPollo.Text);
                                    gdia = double.Parse(txtPVPollo.Text);
                                    vive++;
                                    imprimir(cdia, Math.Round(rnh, 4), chuevo, Math.Round(reh, 4), eh, Math.Round(rep, 4), cep, gdia);
                                    rnh = 0;
                                    chuevo = 0;
                                    rep = 0;
                                    cep = "-";
                                } 
                            }
                            else
                            {
                                eh = "huevo";
                                gneta += double.Parse(txtPVHuevo.Text);
                                gdia = double.Parse(txtPVHuevo.Text);
                                nhuevo++;
                                imprimir(cdia, Math.Round(rnh, 4), chuevo, Math.Round(reh, 4), eh, Math.Round(rep, 4), cep, gdia);
                                rnh = 0;
                                chuevo = 0;
                                rep = 0;
                                eh = "-";
                            }
                            nhd--;
                        }
                    }

                } while (cdia < dmax);

                lblGNeta.Text = "" + gneta + " $";
                lblRompe.Text = "" + nRompe;
                lblPollo.Text = "" + vive;
                lblHuevo.Text = "" + nhuevo;
                lblPolloMuere.Text = "" + muere;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Las Cosas andan mal");
                this.Refresh();
                throw ex;
                //

            }
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            Frm_Detalle uch = new Frm_Detalle();
            uch.ShowDialog();
        }
    }
}
