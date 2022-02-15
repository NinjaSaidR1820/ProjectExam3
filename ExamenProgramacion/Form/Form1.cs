using ExamenProgramacion.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenProgramacion
{
    public partial class Form1 : Form
    {
        List<Ingenieria> lista = new List<Ingenieria>();

        Ingenieria ing;

        List<Universitario> lista2 = new List<Universitario>();

        Universitario u;

        public void GuardarIngeniero()
        {
            ing = new Ingenieria(txtNombreyApellido.Text, int.Parse(txtEdad.Text), cbSegs.Text, txtCarnet.Text, cbNivelAcademico.Text,
                cbUniversidad.Text, cbCarrera.Text, cbMateriasInscritas.Text, int.Parse(txtNotas.Text),
                txtNombreProyecto.Text, int.Parse(txtHoraTotales.Text), int.Parse(txtHoraCompletadas.Text));

            lista.Add(ing);

            dgvPersona.DataSource = null;
            dgvPersona.DataSource = lista;

        }

        public void GuardarPersona()
        {
            u = new Universitario(txtNombreyApellido.Text, int.Parse(txtEdad.Text), cbSegs.Text, txtCarnet.Text, cbNivelAcademico.Text,
                cbUniversidad.Text, cbCarrera.Text, cbMateriasInscritas.Text, int.Parse(txtNotas.Text));

            lista2.Add(u);

            dgvPersona.DataSource = null;
            dgvPersona.DataSource = lista2;

        }







        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Estas Seguro que quieres salir?", "Registro De Estudiantes",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (r == DialogResult.Yes) this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (cbCarrera.Text == "Ingenieria")
            {
                GuardarIngeniero();

            }

            if (cbCarrera.Text == "Medicina")
            {
                GuardarPersona();

            }
            if (cbCarrera.Text == "Arquitectura")
            {
                GuardarPersona();

            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("D");




            if(cbCarrera.SelectedIndex == 0)
            {
                txtNombreProyecto.Visible = true;
                txtHoraCompletadas.Visible = true;
                txtHoraTotales.Visible = true;

                lblHoraC.Visible = true;
                lblProyecto.Visible = true;
                lblHorasT.Visible = true;

            }

            if (cbCarrera.SelectedIndex == 1)
            {
                txtNombreProyecto.Visible = false;
                txtHoraCompletadas.Visible = false;
                txtHoraTotales.Visible = false;

                lblHoraC.Visible = false;
                lblProyecto.Visible = false;
                lblHorasT.Visible = false;

            }

            if (cbCarrera.SelectedIndex == 2)
            {
                txtNombreProyecto.Visible = false;
                txtHoraCompletadas.Visible = false;
                txtHoraTotales.Visible = false;

                lblHoraC.Visible = false;
                lblProyecto.Visible = false;
                lblHorasT.Visible = false;

            }




        }


       




        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            if(cblistas.Text == "lista1")
            {
                dgvPersona.DataSource = lista;

            }


            if (cblistas.Text == "lista2")
            {
                dgvPersona.DataSource = lista2;

            }


           

        }
    }
}
