using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23100217_EquipoFutbol
{
    public partial class Form1 : Form
    {
        clsPartido miPartido = new clsPartido();

        public Form1()
        {
            InitializeComponent();
        }
        public void EliminarDatos()
        {
            txtNombreJugador.Text = "";
            txtNumJugador.Text = "";
            txtMinJugados.Text = "";

            if (rbPortero.Checked != true)
            {
                txtGolesAnotados.Text = "";
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {

            MessageBox.Show(miPartido.ToString());
            
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {

            if (txtNombreJugador.Text == "" || txtNumJugador.Text == "" || txtMinJugados.Text == "")
            {
                MessageBox.Show("No deje ningun espacio vacio", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (rbPortero.Checked != true)
                {
                    if (txtGolesAnotados.Text != "")
                    {
                        miPartido.Nombre = txtNombreJugador.Text;
                        miPartido.NumJugador = int.Parse(txtNumJugador.Text);
                        miPartido.MinJugados = int.Parse(txtMinJugados.Text);
                        if (rbPortero.Checked == true)
                        {
                            miPartido.Posicion = "Portero";
                        }
                        else
                        {
                            if (rbDefensa.Checked == true)
                            {
                                miPartido.Posicion = "Defensa";
                            }
                            else if (rbMedio.Checked == true)
                            {
                                miPartido.Posicion = "Medio";
                            }
                            else if (rbDelantero.Checked == true)
                            {
                                miPartido.Posicion = "Delantero";
                            }

                            miPartido.GolesAnotados = txtGolesAnotados.Text;
                        }
                        EliminarDatos();

                    }
                    else
                    {
                        MessageBox.Show("No deje ningun espacio vacio", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
                else
                {
                    miPartido.Nombre = txtNombreJugador.Text;
                    miPartido.NumJugador = int.Parse(txtNumJugador.Text);
                    miPartido.MinJugados = int.Parse(txtMinJugados.Text);
                    if (rbPortero.Checked == true)
                    {
                        miPartido.Posicion = "Portero";
                    }
                    else
                    {
                        if (rbDefensa.Checked == true)
                        {
                            miPartido.Posicion = "Defensa";
                        }
                        else if (rbMedio.Checked == true)
                        {
                            miPartido.Posicion = "Medio";
                        }
                        else if (rbDelantero.Checked == true)
                        {
                            miPartido.Posicion = "Delantero";
                        }

                    }
                    EliminarDatos();

                }
            }

        }
        //Desactivar o Activar Goles
        private void rbPortero_CheckedChanged(object sender, EventArgs e)
        {
            label4.Enabled = false; txtGolesAnotados.Enabled = false;
            txtGolesAnotados.Text = "";
        }

        private void rbDefensa_CheckedChanged(object sender, EventArgs e)
        {
            label4.Enabled = true; txtGolesAnotados.Enabled = true;
            txtGolesAnotados.Text = "";

        }

        private void rbMedio_CheckedChanged(object sender, EventArgs e)
        {
            label4.Enabled = true; txtGolesAnotados.Enabled = true;
            txtGolesAnotados.Text = "";

        }

        private void rbDelantero_CheckedChanged(object sender, EventArgs e)
        {
            label4.Enabled = true; txtGolesAnotados.Enabled = true;
            txtGolesAnotados.Text = "";

        }
        //Fin Desactivar o Activar Goles
    }
}
