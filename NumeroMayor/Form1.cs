using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumeroMayor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btbir_Click(object sender, EventArgs e)
        {
            string numero1 = txtnumero1.Text;
            string numero2 = txtnumero2.Text;

            int numero1int = Convert.ToInt32(numero1);
            int numero2int = Convert.ToInt32(numero2);

            if (numero1int > numero2int)
            {
                lblresultado1.Text = Convert.ToString(numero1int);
                lblresultado2.Text = Convert.ToString(numero2int);
                lblresultado1.Visible = true;
                lblresultado2.Visible = true;
                lbliguales.Visible = false;
            }
            else
                if (numero2int > numero1int)
                     {
                        lblresultado1.Text = Convert.ToString(numero2int);
                        lblresultado2.Text = Convert.ToString(numero1int);
                        lblresultado1.Visible = true;
                        lblresultado2.Visible = true;
                        lbliguales.Visible = false;
            }
                    else
                       {
                            lblresultado1.Text = Convert.ToString(numero2int);
                            lblresultado2.Text = Convert.ToString(numero1int);
                            lblresultado1.Visible = true;
                            lblresultado2.Visible = true;
                            lbliguales.Text = "Los número son iguales";
                            lbliguales.Visible = true;
                        }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblresultado1.Visible = false;
            lblresultado2.Visible = false;
            lbliguales.Visible = false;
        }
    }
}
