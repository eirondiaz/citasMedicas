using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace citasMedicas
{
    public partial class Utilitarios : Form
    {
        double divisa, resultado;
        public Utilitarios()
        {
            InitializeComponent();
        }

        private void picSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void rbUsdDop_CheckedChanged(object sender, EventArgs e)
        {
            lblSimbolo.Location = new Point(55, 200);
            lblSimbolo.Text = "USD$";

            picError.Visible = false;
            lblError.Visible = false;
            lblResult.Visible = false;
            txtDivisa.Text = "";
        }

        private void rbDopUsd_CheckedChanged(object sender, EventArgs e)
        {
            lblSimbolo.Location = new Point(53, 200); ;
            lblSimbolo.Text = "DOP$";

            picError.Visible = false;
            lblError.Visible = false;
            lblResult.Visible = false;
            txtDivisa.Text = "";
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            try
            {
                divisa = double.Parse(txtDivisa.Text);

                if (rbUsdDop.Checked == true)
                {
                    resultado = divisa * 52.80;
                    lblResult.Text = "DOP$ " + resultado.ToString();
                    lblResult.Visible = true;
                }
                else
                {
                    resultado = divisa / 52.80;
                    lblResult.Text = "USD$ " + Math.Round(resultado, 2).ToString();
                    lblResult.Visible = true;
                }  
            }
            catch (Exception error) 
            {
                if (string.IsNullOrWhiteSpace(txtDivisa.Text))
                {
                    lblError.Text = "El campo no puede estar vacío ni contener espacios";
                    picError.Visible = true;
                    lblError.Visible = true;
                }
                else 
                {
                    lblError.Text = "El conversor solo acepta números";
                    picError.Visible = true;
                    lblError.Visible = true;
                }
            }
        }
    }
}
