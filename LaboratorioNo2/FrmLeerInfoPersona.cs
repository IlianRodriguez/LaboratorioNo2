/* 
LABORATORIO 2: CONDICIONES IF, ELSE IF, SWITCH CASE
FECHA DE ENTREGA: 28/08/2024
PERTENECE A: ANA DUARTE (8-1018-2345)
             ILIAN RODRIGUEZ (8-994-2383)
             KEVIN MO (8-1015-2337)
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioNo2
{
    public partial class FrmLeerInfoPersona : Form
    {
        String nombre, apellido, cedula;
        double salarioBrutoMensual;

        public FrmLeerInfoPersona()
        {
            InitializeComponent();
        }
        //Metodo para almacenar los datos ingresados
        void GuardarValores()
        {
            nombre = tbNombre.Text; ;
            apellido = tbApellido.Text;
            cedula = tbCedula.Text;
            salarioBrutoMensual = Convert.ToDouble(tbSalarioBrutoMensual.Text);
        }

        //Label Calculadora de Salario Neto
        private void lbCalculadoraSalarioNeto_Click(object sender, EventArgs e)
        {
        }

        //Label Nomnbre
        private void lbNombre_Click(object sender, EventArgs e)
        {
        }

        //Label Apellido
        private void lbApellido_Click(object sender, EventArgs e)
        {
        }

        //Label Cedula
        private void lbCedula_Click(object sender, EventArgs e)
        {
        }

        //Label Salario Bruto Mensual
        private void lbSalarioBrutoMensual_Click(object sender, EventArgs e)
        {
        }

        //TextBox Nombre
        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            tbNombre.Text = tbNombre.Text.ToUpper(); // Convertir el nombre a mayúsculas
            tbNombre.SelectionStart = tbNombre.Text.Length; // Mover el cursor al final del nombre
        }

        //TextBox Apellido
        private void tbApellido_TextChanged(object sender, EventArgs e)
        {
            tbApellido.Text = tbApellido.Text.ToUpper(); // Convertir el apellido a mayúsculas
            tbApellido.SelectionStart = tbApellido.Text.Length; // Mover el cursor al final del apellido
        }

        //TextBox Cedula
        private void tbCedula_TextChanged(object sender, EventArgs e)
        {
        }

        //TextBox Salario Bruto Mensual
        private void tbSalarioBrutoMensual_TextChanged(object sender, EventArgs e)
        {
        }

        //Boton para guardar los datos y pasar el siguiente form
        private void btCalcular_Click(object sender, EventArgs e)
        {
            GuardarValores();

            FrmImprimirInfoPersona frmImprimirInfoEmpleado = new FrmImprimirInfoPersona(nombre, apellido, cedula, salarioBrutoMensual);
            frmImprimirInfoEmpleado.Show();
            this.Hide();
        }

        //Evento Enter de guia para el ingreso de la cedula
        private void tbCedula_Enter(object sender, EventArgs e)
        {
            if (tbCedula.Text == "00-0000-0000")
            {
                tbCedula.Text = "";
                tbCedula.ForeColor = Color.Black;
            }
        }

        //Evento Leave de guia para el ingreso de la cedula
        private void tbCedula_Leave(object sender, EventArgs e)
        {
            if (tbCedula.Text == "")
            {
                tbCedula.Text = "00-0000-0000";
                tbCedula.ForeColor = Color.Gray;
            }
        }

        //Evento Enter de guia para el ingreso del salario bruto
        private void tbSalarioBrutoMensual_Enter(object sender, EventArgs e)
        {
            if (tbSalarioBrutoMensual.Text == "999.999,99")
            {
                tbSalarioBrutoMensual.Text = "";
                tbSalarioBrutoMensual.ForeColor = Color.Black;
            }
        }

        //Evento Leave de guia para el ingreso del salario bruto
        private void tbSalarioBrutoMensual_Leave(object sender, EventArgs e)
        {
            if (tbSalarioBrutoMensual.Text == "")
            {
                tbSalarioBrutoMensual.Text = "999.999,99";
                tbSalarioBrutoMensual.ForeColor = Color.Gray;
            }
        }

        //Evento para bloquear teclas en tbNombre
        private void tbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloquear la entrada
            }
        }

        //Evento para bloquear teclas en tbApellido
        private void tbApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloquear la entrada
            }
        }

        private void FrmIeerInfoEmpleado_Load(object sender, EventArgs e)
        {

        }

        //Evento para bloquear teclas en tbCedula

        private void tbCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloquear la entrada
            }
        }

        //Evento para bloquear caracteres en tbSalarioBrutoMensual 
        private void tbSalarioBrutoMensual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
