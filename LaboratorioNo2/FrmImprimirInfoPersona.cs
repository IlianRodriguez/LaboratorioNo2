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
    public partial class FrmImprimirInfoPersona : Form
    {
        private string nombre;
        private string apellido;
        private string cedula;
        private double salarioBrutoMensual, salarioMensualNeto, seguroSocial, seguroEducativo, 
            salarioBrutoAnual, impuestoSobreRenta;

        public FrmImprimirInfoPersona(string nombre, string apellido, string cedula, double salarioBrutoMensual)
        {
            InitializeComponent();

            this.nombre = nombre;
            this.apellido = apellido;
            this.cedula = cedula;
            this.salarioBrutoMensual = salarioBrutoMensual;
        }

        private void lbNombreResultado_Click(object sender, EventArgs e)
        {
        }

        private void lbCedulaResultado_Click(object sender, EventArgs e)
        {
        }

        private void lbSalarioBrutoImpresion_Click(object sender, EventArgs e)
        {
        }
        private void lbSalarioMensualNeto_Click(object sender, EventArgs e)
        {
        }

        private void lbSeguroSocial_Click(object sender, EventArgs e)
        {

        }

        private void lbSeguroEducativo_Click(object sender, EventArgs e)
        {
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Método para calcular el seguro social
        private void CalcularSeguroSocial()
        {
            seguroSocial = (salarioBrutoMensual * 9.75) / 100;
        }

        private void lbCalculadoraSalarioNeto_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Método para calcular el seguro educativo
        private void CalcularSeguroEducativo()
        {
            seguroEducativo = (salarioBrutoMensual * 1.25) / 100;
        }

        private void lbEstudiante_Click(object sender, EventArgs e)
        {

        }

        private void lbDeduccionesSalariales2_Click(object sender, EventArgs e)
        {

        }

        private void lbDetallesEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void lbResultadoSalarial1_Click(object sender, EventArgs e)
        {

        }

        private void lbResultadoSalarial2_Click(object sender, EventArgs e)
        {

        }

        private void lbDetallesEmpleado2_Click(object sender, EventArgs e)
        {

        }

        // Método para calcular el salario neto
        private void CalcularSalarioNeto()
        {
            salarioMensualNeto = salarioBrutoMensual - (seguroSocial + seguroEducativo+ impuestoSobreRenta);
        }

        private void lbImpuestoSobreRenta_Click(object sender, EventArgs e)
        {

        }

        // Método para calcular el salario bruto anual
        private double CalcularSalarioBrutoAnual(double salarioBrutoMensual)
        {
            return salarioBrutoMensual * 12;
        }

        // Método para calcular el impuesto sobre la renta mensual
        private double CalcularImpuestoSobreRenta(double salarioBrutoAnual)
        {
            double impuestoISR = 0;

            if (salarioBrutoAnual <= 11000.00)
            {
                impuestoISR = 0;
            }
            else if (salarioBrutoAnual <= 50000.00)
            {
                double excedente = salarioBrutoAnual - 11000.00;
                impuestoISR = excedente * 0.15;
            }
            else
            {
                double excedente = salarioBrutoAnual - 50000.00;
                impuestoISR = 5850.00 + (excedente * 0.25);
            }

            return impuestoISR / 13; 
        }

        // Evento Load del formulario
        private void FrmImprimirInfoEmpleado_Load(object sender, EventArgs e)
        {
            double salarioBrutoAnual = CalcularSalarioBrutoAnual(salarioBrutoMensual);
            impuestoSobreRenta = CalcularImpuestoSobreRenta(salarioBrutoAnual);

            CalcularSeguroSocial();
            CalcularSeguroEducativo();
            CalcularSalarioNeto();

            lbNombreResultado.Text = "NOMBRE: " + nombre + " " + apellido;
            lbCedulaResultado.Text = "CÉDULA: " + cedula;
            lbSalarioBrutoImpresion.Text = "SALARIO BRUTO MENSUAL: B/. " + Math.Round(salarioBrutoMensual, 2).ToString("N2");
            lbSeguroSocial.Text = "PAGO SEGURO SOCIAL: B/. " + Math.Round(seguroSocial, 2).ToString("N2");
            lbSeguroEducativo.Text = "PAGO SEGURO EDUCATIVO: B/. " + Math.Round(seguroEducativo, 2).ToString("N2");
            lbSalarioNetoMensual.Text = "SALARIO NETO MENSUAL: B/. " + Math.Round(salarioMensualNeto, 2).ToString("N2");
            lbImpuestoSobreRentaMensual.Text = "IMPUESTO SOBRE RENTA MENSUAL: B/. " + Math.Round(impuestoSobreRenta, 2).ToString("N2");
        }
    }
}
