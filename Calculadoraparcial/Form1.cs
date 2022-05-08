using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadoraparcial
{ public enum Operacion
    { 
    nodefinida = 0,
    suma = 1,
    resta = 2,  
    division = 3,
    multiplicacion = 4,
    }
    public partial class Form1 : Form
    {
        double valor1 = 0;
        double valor2 = 0;
        Operacion operador = Operacion.nodefinida;
        public Form1()
        {
            InitializeComponent();
        }

        private void leerNumero(string numero)
        {
            if (cajares.Text == "0" && cajares.Text != null)
            {
                cajares.Text = numero;
            }
            else
            {
                cajares.Text += numero;
            }
        }
        private double ejecutaroperacion()
        {
            double resultado = 0;
            switch (operador)
            {

                case Operacion.suma:
                    resultado = valor1 + valor2;
                    break;
                case Operacion.resta:
                    resultado = valor1 - valor2;
                    break;
                case Operacion.division:
                    if (valor2 == 0)
                    {
                        MessageBox.Show("no se puede dividir entre 0");
                    }
                    else
                    {
                        resultado = valor1 / valor2;
                    }
                    break;
                case Operacion.multiplicacion:
                    resultado = valor1 * valor2;
                    break;
            }
            return resultado;

        }
        private void btncero_Click(object sender, EventArgs e)
        {
            if(cajares.Text == "0")
                {
                return;
            }else
            {
                cajares.Text += "0";
            }
            
        }

        private void btnuno_Click(object sender, EventArgs e)
        {
            leerNumero("1");
        }

        private void btndos_Click(object sender, EventArgs e)
        {
            leerNumero("2");

        }

        private void btntres_Click(object sender, EventArgs e)
        {
            leerNumero("3");
        }

        private void btncuatro_Click(object sender, EventArgs e)
        {
            leerNumero("4");
        }

        private void btncinco_Click(object sender, EventArgs e)
        {
            leerNumero("5");
        }

        private void btnseis_Click(object sender, EventArgs e)
        {
            leerNumero("6");
        }

        private void btnsiete_Click(object sender, EventArgs e)
        {
            leerNumero("7");
        }

        private void btnocho_Click(object sender, EventArgs e)
        {
            leerNumero("8");
        }

        private void btnnueve_Click(object sender, EventArgs e)
        {
            leerNumero("9");
        }
        private void obtenervalor(string operador)
        {
            valor1 = Convert.ToDouble(cajares.Text);
            lblhist.Text = cajares.Text + operador;
            cajares.Text = "0";

        }
        private void btnsuma_Click(object sender, EventArgs e)
        {
            operador = Operacion.suma;
            obtenervalor("+");
            

        }
       
        private void btnresultado_Click(object sender, EventArgs e)
        {
            if (valor2 == 0 )
            {
            valor2 = Convert.ToDouble(cajares.Text);
                lblhist.Text += valor2 + "=";
                double resultado = ejecutaroperacion();
                valor1 = 0;
                valor2 = 0;
                cajares.Text = Convert.ToString(resultado); 
            }
    }

        private void btnres_Click(object sender, EventArgs e)
        {
            operador = Operacion.resta;
            obtenervalor("-");
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            operador = Operacion.multiplicacion;
            obtenervalor("*");
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            operador = Operacion.division;
            obtenervalor("/");
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            cajares.Text = "0";
            lblhist.Text = ""; 
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            if (cajares.Text.Length > 1 )
            {
                string txtresultado = cajares.Text;
                txtresultado = txtresultado.Substring(0, txtresultado.Length - 1);
                if (txtresultado.Length == 1 && txtresultado.Contains("-"))
                {
                    cajares.Text = "0";
                }
                else
                {
                    cajares.Text = txtresultado;
                }

                
            }
            else
            {
                cajares.Text = "0";
            }
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            if (cajares.Text.Contains("."))
            {
                return;
            }
            cajares.Text += ".";
        }
    }
}
