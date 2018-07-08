using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CalculoDePrestaciones
{
    public partial class CalculadoraPrestaciones : Form
    {
        public CalculadoraPrestaciones()
        {
            InitializeComponent();
            txtSalario.TextChanged += new EventHandler(TotalHandle);
            txtComisiones.TextChanged += new EventHandler(TotalHandle);
        }

        int years, month, days,totalGirdRows;
        double totalesDevengados;
        decimal _totales;
        TimeSpan numberOfDays;
        double count = 0;
        string pluralSingular;

       void TotalHandle(object sender, EventArgs e)
        {
            
            //var textBox = (TextBox)sender;
            _totales = Convert.ToDecimal(txtSalario.Text) + Convert.ToDecimal(txtComisiones.Text);
            txtTotales.Text = _totales.ToString();
             //txtTotales.Text = _totales.ToString();


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if(years==1)
            {
                pluralSingular = " Anio ";
            }
            else
            {
                pluralSingular = " Anios ";

            }

            if(dtpStartDate.Value>dtpEndDate.Value)
            {

                MessageBox.Show("La fecha de ingreso no puede ser mayor que la fecha de salida");
            }
            else
            {
                years = dtpEndDate.Value.Year - dtpStartDate.Value.Year;
                month = dtpEndDate.Value.Month - dtpStartDate.Value.Month;
                if (dtpStartDate.Value.Day > dtpEndDate.Value.Day)
                {

                    numberOfDays = dtpEndDate.Value - dtpStartDate.Value;
                    days = Convert.ToInt16(numberOfDays.TotalDays);
                }else{

                    days = dtpEndDate.Value.Day - dtpStartDate.Value.Day;
                }
           
                txtResult.Text = years.ToString() + pluralSingular + month.ToString() + " Meses y " + days.ToString() + " Dias";
            }
            
          }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtTotales.Text=="" || txtSalario.Text=="0.00")
            {
                MessageBox.Show("Ingrese el salario");

            }else
            {

              salaryGridView.Rows.Add(txtSalario.Text, txtComisiones.Text, txtTotales.Text);
            }
            
            txtSalario.Text = "0.00";
            txtComisiones.Text = "0.00";
            txtTotales.Text = "0.00";

        }

        private void button3_Click(object sender, EventArgs e)
        {

            lblSumatoria.Text = "0.00";
            lblPromedioMensual.Text = "0.00";
            lblSalarioPromedioDiario.Text = "0.00";
            count = 0.00;

            totalGirdRows = salaryGridView.Rows.Count;
            for (int i = 0; i < salaryGridView.Rows.Count;i++ )
            {
                count += Convert.ToDouble(salaryGridView.Rows[i].Cells[2].Value) ;
               ;
            }
           
            lblSumatoria.Text = count.ToString();
            lblPromedioMensual.Text = Math.Round(Convert.ToDouble((count / totalGirdRows)), 2).ToString();
            lblSalarioPromedioDiario.Text = Math.Round(Convert.ToDouble((count / totalGirdRows) / 23.83), 2).ToString();

        }

       private void chkIncluirCesantia_CheckStateChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < salaryGridView.Rows.Count; i++)
            {
                count += Convert.ToDouble(salaryGridView.Rows[i].Cells[2].Value);
                totalGirdRows = salaryGridView.Rows.Count;
            }

            totalesDevengados = Math.Round(Convert.ToDouble((count / totalGirdRows) / 23.83), 2);
           
            if(chkIncluirCesantia.Checked==true)
            {
                if (years == 0 && month >= 3 && month <= 6)
                {

                    totalesDevengados = Math.Round(Convert.ToDouble(lblSalarioPromedioDiario.Text) * 6, 2);
                    lblIncluirCesantia.Text = totalesDevengados.ToString();
                    lblPagoTotal.Text = (Convert.ToDouble(lblIncluirCesantia.Text) + Convert.ToDouble(lblIncluirVacaciones.Text) + Convert.ToDouble(lblSalarioNavidad.Text)).ToString(); 
                }
                else if (month >= 6 && month < 12)
                {

                    totalesDevengados = Math.Round(Convert.ToDouble(lblSalarioPromedioDiario.Text) * 13, 2);
                    lblIncluirCesantia.Text = totalesDevengados.ToString();
                    lblPagoTotal.Text = (Convert.ToDouble(lblIncluirCesantia.Text) + Convert.ToDouble(lblIncluirVacaciones.Text) + Convert.ToDouble(lblSalarioNavidad.Text)).ToString();
                }
                else if (years >= 1 && years < 5)
                {

                    totalesDevengados = Math.Round(Convert.ToDouble(lblSalarioPromedioDiario.Text) * (21*years), 2);
                    lblIncluirCesantia.Text = totalesDevengados.ToString();
                    lblPagoTotal.Text = (Convert.ToDouble(lblIncluirCesantia.Text) + Convert.ToDouble(lblIncluirVacaciones.Text) + Convert.ToDouble(lblSalarioNavidad.Text)).ToString();
                }
                else if (years >= 5)
                {

                    totalesDevengados = Math.Round(Convert.ToDouble(lblSalarioPromedioDiario.Text) * (23 * years), 2);
                    lblIncluirCesantia.Text = totalesDevengados.ToString();
                    lblPagoTotal.Text = (Convert.ToDouble(lblIncluirCesantia.Text) + Convert.ToDouble(lblIncluirVacaciones.Text) + Convert.ToDouble(lblSalarioNavidad.Text)).ToString();
                }

            }
           
            else
            {
                lblIncluirCesantia.Text = "0.00";
                lblPagoTotal.Text = (Convert.ToDouble(lblIncluirCesantia.Text) + Convert.ToDouble(lblIncluirVacaciones.Text) + Convert.ToDouble(lblSalarioNavidad.Text)).ToString();

            }

           
           

        }

        private void chkIncluirVacaciones_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkIncluirVacaciones.Checked == true)
            {
                if (years >= 1 && years < 5)
                {
                    lblIncluirVacaciones.Text=(Math.Round(Convert.ToDouble(lblSalarioPromedioDiario.Text)*14,2)).ToString();
                    lblPagoTotal.Text = (Convert.ToDouble(lblIncluirCesantia.Text) + Convert.ToDouble(lblIncluirVacaciones.Text) + Convert.ToDouble(lblSalarioNavidad.Text)).ToString();
                }
                else if (years >= 5)
                {
                     lblIncluirVacaciones.Text=(Math.Round(Convert.ToDouble(lblSalarioPromedioDiario.Text)*18,2)).ToString();
                     lblPagoTotal.Text = (Convert.ToDouble(lblIncluirCesantia.Text) + Convert.ToDouble(lblIncluirVacaciones.Text) + Convert.ToDouble(lblSalarioNavidad.Text)).ToString();
                }
            }else
                {
                    lblIncluirVacaciones.Text = "0.00";
                    lblPagoTotal.Text = (Convert.ToDouble(lblIncluirCesantia.Text) + Convert.ToDouble(lblIncluirVacaciones.Text) + Convert.ToDouble(lblSalarioNavidad.Text)).ToString();
                 }
            

            }

        private void chkIncluirSalarioNavidad_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkIncluirSalarioNavidad.Checked == true)
            {
                lblSalarioNavidad.Text = (Math.Round(Convert.ToDouble(lblSumatoria.Text) / 12,2)).ToString();
                lblPagoTotal.Text = (Convert.ToDouble(lblIncluirCesantia.Text) + Convert.ToDouble(lblIncluirVacaciones.Text) + Convert.ToDouble(lblSalarioNavidad.Text)).ToString();
            }
            else
            {
                lblSalarioNavidad.Text = "0.00";
                lblPagoTotal.Text = (Convert.ToDouble(lblIncluirCesantia.Text) + Convert.ToDouble(lblIncluirVacaciones.Text) + Convert.ToDouble(lblSalarioNavidad.Text)).ToString();

            }
            

        }

        private void CalculadoraPrestaciones_Load(object sender, EventArgs e)
        {

        }           
   
        }
    }

