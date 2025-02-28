using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_estudio_ec2
{
    public partial class Form1 : Form
    {
        String nombre;
        int nota1, nota2, nota3, promedio, promedioGeneral;
        public Form1()
        {
            InitializeComponent();
        }

        private void lstNombres_SelectedIndexChanged(object sender, EventArgs e)
        {
            marcar(lstNombres);
        }

        private void lstNota1_SelectedIndexChanged(object sender, EventArgs e)
        {
            marcar(lstNota1);
        }

        private void lstNota2_SelectedIndexChanged(object sender, EventArgs e)
        {
            marcar(lstNota2);
        }

        private void lstNota3_SelectedIndexChanged(object sender, EventArgs e)
        {
            marcar(lstNota3);
        }

        private void lstPromedio_SelectedIndexChanged(object sender, EventArgs e)
        {
            marcar(lstPromedio);
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            int seleccion = lstNombres.SelectedIndex;
            lstNombres.Items.RemoveAt(seleccion);
            lstNota1.Items.RemoveAt(seleccion);
            lstNota2.Items.RemoveAt(seleccion);
            lstNota3.Items.RemoveAt(seleccion);
            lstPromedio.Items.RemoveAt(seleccion);

            int total = 0;
            for (int i = 0; i < lstPromedio.Items.Count; i++)
            {
                total += Convert.ToInt32(lstPromedio.Items[i]);
            }
            txtPromedio.Text = total.ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtPromedio.Clear();
            txtNombre.Clear();
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            nota1 = Convert.ToInt32(txtNota1.Text);
            nota2 = Convert.ToInt32(txtNota2.Text);
            nota3 = Convert.ToInt32(txtNota3.Text);    
            nombre = txtNombre.Text;
            promedio = (nota1 + nota2 + nota3) / 3;

            
            lstNota1.Items.Add(nota1);
            lstNota2.Items.Add(nota2);
            lstNota3.Items.Add(nota3);
            lstNombres.Items.Add(nombre);
            lstPromedio.Items.Add(promedio);

            int total = 0;
            for (int i = 0; i < lstPromedio.Items.Count; i++)
            {
                total += Convert.ToInt32(lstPromedio.Items[i]);
            }
            txtPromedio.Text = total.ToString();
            
        }

        private void marcar(ListBox lista)
        {
            int indice;
            indice = lista.SelectedIndex;
            lstNombres.SelectedIndex = indice;
            lstNota1.SelectedIndex = indice;
            lstNota2.SelectedIndex = indice;
            lstNota3.SelectedIndex = indice;
            lstPromedio.SelectedIndex = indice;
        }
    }
}
