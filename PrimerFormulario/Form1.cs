using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerFormulario
{
    public partial class Form1 : Form
    {
        private int valorCalculado;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_load(object sender, EventArgs e)

        {
        }


        private void Calcular_Click(object sender, EventArgs e)
        {   //CONVERT.TOINT32 CONVIERTE STRING A ENTEROS...


            valorCalculado = SumarNumeros(Convert.ToInt32(this.txt1.Text), Convert.ToInt32(this.txt2.Text));
            //EL SIGNO $ PERMITE JUNTO CON LAS LLAVES MOSTRAR EL VALOR DE UNA VARIABLE
            // SIN EL SIGNO NO LO PERMITE
            MessageBox.Show($"La suma es : { valorCalculado}");

        }
        #region metodos
        private int SumarNumeros(int num1, int num2)
        {
           
            int valorAuxiliar = 0;
            valorAuxiliar = num1 + num2;
            return valorAuxiliar;
        }
            #endregion

        }
    }

