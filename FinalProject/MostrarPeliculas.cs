using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class MostrarPeliculas : Form
    {
        public Peliculas peliculas = new Peliculas();
        public MostrarPeliculas()
        {
            InitializeComponent();
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvCartelera.DataSource = peliculas.ListPeliculas;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (rbTitulo.Checked == true)
            {
                dgvCartelera.DataSource = peliculas.PeliculaxTitulo(txtInformacion.Text);
            }

            if (rbProductora.Checked == true)
            {
                dgvCartelera.DataSource = peliculas.PeliculaXProd(txtInformacion.Text);
            }

            if (rbPais.Checked == true)
            {
                dgvCartelera.DataSource = peliculas.PeliculaXPa(txtInformacion.Text);
            }

            if (rbGenero.Checked == true)
            {
                dgvCartelera.DataSource = peliculas.PeliculaXGene(txtInformacion.Text);
            }
            if (rbIdioma.Checked == true)
            {
                dgvCartelera.DataSource = peliculas.PeliculaXIdi(txtInformacion.Text);
            }
            if (rbFecha.Checked == true)
            {
                dgvCartelera.DataSource = peliculas.PeliculaXfecha(Convert.ToInt32(txtInformacion.Text));
            }
            if (rbTduracion.Checked == true)
            {
                dgvCartelera.DataSource = peliculas.PeliculaXTdu((Convert.ToInt32(txtInformacion.Text)));
            }
            if (rbDirector.Checked == true)
            {
                dgvCartelera.DataSource = peliculas.PeliculaXDirec(txtInformacion.Text);
            }
            
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.form1.Show();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
