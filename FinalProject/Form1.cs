using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        public Peliculas peliculas = new Peliculas();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Pelicula pelicula = new Pelicula();
            pelicula.Titulo = txtTitulo.Text;
            pelicula.Productora = txtProductora.Text;
            pelicula.Pais = txtPais.Text;
            pelicula.Genero = cmbGenero.SelectedItem.ToString();
            pelicula.Idioma = cmbIdioma.SelectedItem.ToString();
            pelicula.Fecha = Convert.ToInt32(mtxtFecha.Text);
            pelicula.Tduracion = Convert.ToInt32(mtxtDuracion.Text);
            pelicula.Director = txtDirector.Text;
            peliculas.Agregar(pelicula);
            MessageBox.Show("Datos guardados con exito");
            limpiar();

        }
        public void limpiar()
        {
            txtTitulo.Text = "";
            txtProductora.Text = "";
            txtPais.Text = "";
            cmbGenero.Text = "";
            cmbIdioma.Text = "";
            mtxtFecha.Text = "";
            mtxtDuracion.Text = "";

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            limpiar();
            this.Hide();
            MostrarPeliculas mostrarpeliculas = new MostrarPeliculas();
            mostrarpeliculas.Show();
            mostrarpeliculas.peliculas = peliculas;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

