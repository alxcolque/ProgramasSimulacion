using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimulacionNovienbre2019.UC_Controls;

namespace SimulacionNovienbre2019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// //
        /// </summary>
        /// <param name="c"></param>
       
        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            pnlPrincipal.Controls.Clear();
            pnlPrincipal.Controls.Add(c);
        }
        
        private void btnPollos_Click_1(object sender, EventArgs e)
        {
            UC_DestinoDelPollo uch = new UC_DestinoDelPollo();
            AddControlsToPanel(uch);
        }

        private void btnCraps_Click(object sender, EventArgs e)
        {
            UC_Craps uch = new UC_Craps();
            AddControlsToPanel(uch);
        }

        private void btnMaximo_Click(object sender, EventArgs e)
        {
            UC_Azucar uch = new UC_Azucar();
            AddControlsToPanel(uch);
        }
    }
}
