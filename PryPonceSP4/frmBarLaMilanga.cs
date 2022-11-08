using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryPonceSP4
{
    public partial class frmBarLaMilanga : Form
    {
        public int[,] MatDatos = new int[5, 4];
        public int[] VecDatos = new int[10]; //De la posicion 0 a la 4 cargo los valores totales de cada mozo, del 5 en adelante los totales globales.

        public frmBarLaMilanga()
        {
            InitializeComponent();
        }
        private void frmBarLaMilanga_Load(object sender, EventArgs e)
        {
            int i = 0;

            for (i = 0; i <= 4; i++)
            {
                dgvGrilla.Rows.Add();
            }
            //Asigno nombres a la primer columna
            dgvGrilla.Rows[0].Cells[0].Value = "JULIO";
            dgvGrilla.Rows[1].Cells[0].Value = "ESTEBAN";
            dgvGrilla.Rows[2].Cells[0].Value = "JAVIER";
            dgvGrilla.Rows[3].Cells[0].Value = "GONZALO";
            dgvGrilla.Rows[4].Cells[0].Value = "ALBERTO";
            //Todas las celdas de la columna cero "Mozo" son ineditables
            dgvGrilla.Columns[0].ReadOnly = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            int varBandera = 0;
            int f = 0;
            int c = 1; //La variable c se iguala a 1 para tomar unicamnte los valores que ingrese el usuario.
            int cmat = 0;
            while (f <= 4)
            {
                while (c <= 4)
                {
                    //Me aseguro de que la grilla sea llenada adecuadamente.
                    if (dgvGrilla.Rows[f].Cells[c].Value == null || dgvGrilla.Rows[f].Cells[c].Value == "")
                    {
                        varBandera++;
                    }
                    c++;
                }
                c = 1;
                f++;
            }

            if (varBandera == 0)
            {
                //Habilito los botones de consulta al asegurarme de que la grilla ha sido llenada correctamente.
                btnMozoDelDia.Enabled = true;
                btnTotales.Enabled = true;
                //Igualo las variables a cero para recorrer de nuevo la grilla y llenar el array.
                f = 0;
                c = 1;
                //Carga de datos en la matriz
                while (f <= 4)
                {
                    while (c <= 4 && cmat <= MatDatos.GetLength(1))
                    {
                        MatDatos[f, cmat] = Convert.ToInt32(dgvGrilla.Rows[f].Cells[c].Value);
                        c++;
                        cmat++;
                    }
                    c = 1;
                    cmat = 0;
                    f++;
                }
            }
            else
            {
                //Deshabilito los botones de consulta y muestro un mensaje de error.
                btnMozoDelDia.Enabled = false;
                btnTotales.Enabled = false;
                MessageBox.Show("Asegurese de ingresar valores numéricos desde cero incluido en adelante.", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnMozoDelDia_Click(object sender, EventArgs e)
        {
            int c = 0;
            int f = 0;
            int varSuma = 0;
            int varMayor = 0;
            int varPosicion = 0; //capturo la posicion del mayor valor para identificar al mozo correspondiente.
            while (f < MatDatos.GetLength(0))
            {
                while (c < MatDatos.GetLength(1))
                {
                    varSuma = varSuma + MatDatos[f, c];
                    c++;
                }
                VecDatos[f] = varSuma;
                c = 0;
                f++;
                varSuma = 0;
            }

            f = 0;
            varMayor = VecDatos[0];
            while (f <= 4)
            {
                if (VecDatos[f] >= varMayor)
                {
                    varMayor = VecDatos[f];
                    varPosicion = f;
                }
                f++;
            }

            switch (varPosicion)
            {
                case 0:
                    txtMozoDelDia.Text = "Julio";
                    break;
                case 1:
                    txtMozoDelDia.Text = "Esteban";
                    break;
                case 2:
                    txtMozoDelDia.Text = "Javier";
                    break;
                case 3:
                    txtMozoDelDia.Text = "Gonzalo";
                    break;
                case 4:
                    txtMozoDelDia.Text = "Alberto";
                    break;
            }

        }

        private void btnTotales_Click(object sender, EventArgs e)
        {
            int f = 0;
            int c = 0;
            int i = 5;
            int varSuma = 0;
            int varTotal = 0;

            while (c < MatDatos.GetLength(1) && i <= 9)
            {
                varSuma = 0;
                while (f < MatDatos.GetLength(0))
                {
                    varSuma = varSuma + MatDatos[f, c];
                    f++;
                }
                VecDatos[i] = varSuma;
                varTotal = varTotal + varSuma;
                f = 0;
                c++;
                i++;
            }

            VecDatos[9] = varTotal;

            txtComida.Text = Convert.ToString(VecDatos[5]);
            txtBebidasSinAlcohol.Text = Convert.ToString(VecDatos[6]);
            txtBebidasConAlcohol.Text = Convert.ToString(VecDatos[7]);
            txtPostre.Text = Convert.ToString(VecDatos[8]);
            txtTotales.Text = Convert.ToString(VecDatos[9]);
        }
    }


}
 