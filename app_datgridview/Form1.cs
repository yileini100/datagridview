using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_datgridview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {

            string nombre = txt_Nombre.Text;
            string correo = txt_Correo.Text;


            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(correo))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                dgv_Datos.Rows.Add(txt_Nombre.Text, txt_Correo.Text);
            }

            txt_Nombre.Clear();
            txt_Correo.Clear();
            txt_Nombre.Focus();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_Datos.Rows.Count > 0)
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }
            else
            {
                int fila;
                fila = dgv_Datos.CurrentRow.Index;
                DialogResult respuesta;
                respuesta = MessageBox.Show("Desea eliminar este registro?", "Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    dgv_Datos.Rows.RemoveAt(fila);
                    MessageBox.Show("Resgistro Eliminar");
                }

               

            }

            

        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Nombre.Clear();
            txt_Correo.Clear();
            dgv_Datos.Rows.Clear();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
