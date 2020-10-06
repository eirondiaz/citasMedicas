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
    public partial class Mantenimientos : Form
    {
        Datos dt = new Datos();
        Paciente pac = new Paciente();
        Medicos med = new Medicos();
        Clinica cli = new Clinica();

        public Mantenimientos()
        {
            InitializeComponent();
        }

        private void Mantenimientos_Load(object sender, EventArgs e)
        {
            dgPacientes.DataSource = pac.LlenarGrid();       //llenar dataGridView de pacientes
            dgMedicos.DataSource = med.LlenarGrid();         //llenar dataGridView de medicos
            dgClinicas.DataSource = cli.LlenarGrid();        //llenar dataGridView de clinicas
            cli.FillCbb(cbbClinMedic);                       //llenar comboBox de nom clinicas en modulo Medicos
        }

        private void picSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //metodo del evento del boton de guardar pacientes
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar(groupBoxPac))
            {
                MessageBox.Show("Debes llenar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else 
            {
                if (pac.DataNoRepeat("id_paciente", txtId))
                {
                    MessageBox.Show("Ese ID ya existe, por favor ingresa otro diferente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtCedula.Text.Length < 11) 
                {
                    MessageBox.Show("La CEDULA debe tener 11 digitos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    try
                    {
                        Paciente pac = new Paciente();

                        pac.id = int.Parse(txtId.Text);
                        long cedula = long.Parse(txtCedula.Text);
                        pac.cedula = pac.cedFormat(cedula.ToString());
                        pac.telefono = long.Parse(txtTelefono.Text);
                        pac.nombre = txtNombre.Text;
                        pac.email = txtEmail.Text;
                        pac.direccion = txtDireccion.Text;

                        pac.Guardar(pac);

                        MessageBox.Show("Paciente agregado correctamente");
                        dgPacientes.DataSource = pac.LlenarGrid();
                        Limpiar(groupBoxPac);
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show("Los campos ID, CEDULA y TELEFONO solo aceptan números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        //evento del boton limpiar de pacientes
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar(groupBoxPac);
        }

        //metodo del evento del boton de guardar clinicas
        private void btGuarCli_Click(object sender, EventArgs e)
        {
            if (Validar(groupBoxCli))
            {
                MessageBox.Show("Debes llenar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else 
            {
                if (cli.DataNoRepeat("id_clinica", txtIdCli))
                {
                    MessageBox.Show("Ese ID ya existe, por favor ingresa otro diferente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else 
                {
                    try
                    {
                        Clinica cli = new Clinica();

                        cli.id = int.Parse(txtIdCli.Text);
                        cli.nombre = txtNomCli.Text;
                        cli.direccion = txtDirCli.Text;

                        cli.Guardar(cli);
                        MessageBox.Show("Clínica agregada correctamente");
                        dgClinicas.DataSource = cli.LlenarGrid();
                        Limpiar(groupBoxCli);
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show("El campo ID solo acepta números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                
            }
        }

        private void btnLimpCli_Click(object sender, EventArgs e)
        {
            Limpiar(groupBoxCli);
        }

        private void cbbClinMedic_Click(object sender, EventArgs e)
        {
            cbbClinMedic.Items.Clear();
            cli.FillCbb(cbbClinMedic);
        }

        //metodo del evento del boton de guardar medicos
        private void btnMedGuardar_Click(object sender, EventArgs e)
        {
            if (Validar(groupBoxMed))
            {
                MessageBox.Show("Debes llenar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (med.DataNoRepeat("id_medico", txtMedId))
                {
                    MessageBox.Show("Ese ID ya existe, por favor ingresa otro diferente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (med.DataNoRepeat("exequatur", txtMedExeq)) 
                {
                    MessageBox.Show("Ese EXEQUATUR ya existe, por favor ingresa otro diferente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtMedCedula.Text.Length < 11)
                {
                    MessageBox.Show("La CEDULA debe tener 11 digitos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    try
                    {
                        Medicos med = new Medicos();

                        med.id = int.Parse(txtMedId.Text);
                        long cedula = long.Parse(txtMedCedula.Text);
                        med.cedula = med.cedFormat(cedula.ToString());
                        med.exequatur = int.Parse(txtMedExeq.Text);
                        med.nombre = txtMedNombre.Text;
                        med.telefono = long.Parse(txtMedTel.Text);
                        med.email = txtMedEmail.Text;

                        DataSet ds = dt.getId("id_clinica", "clinicas", cbbClinMedic);
                        med.clinica = int.Parse(ds.Tables[0].Rows[0]["id_clinica"].ToString());

                        med.Guardar(med);

                        MessageBox.Show("Medico agregado correctamente");
                        dgMedicos.DataSource = med.LlenarGrid();
                        cbbClinMedic.Items.Clear();
                        Limpiar(groupBoxMed);
                    }
                    catch (Exception er)
                    {
                        //MessageBox.Show(er.Message);
                        MessageBox.Show("Los campos ID, CEDULA, EXEQUATUR y TELEFONO solo aceptan números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        //metodo del boton limpiar medicos
        private void btnMdLimpiar_Click(object sender, EventArgs e)
        {
            Medicos med = new Medicos();
            cbbClinMedic.Items.Clear();
            Limpiar(groupBoxMed);
        }

        public static void Limpiar(GroupBox gb)
        {
            foreach (Control tool in gb.Controls)
            {
                if (tool is TextBox)
                {
                    tool.Text = "";
                }
            }
        }

        //metodo para no aceptar campos vacios
        public static bool Validar(GroupBox gb)
        {
            bool error = false;

            foreach (Control item in gb.Controls)
            {
                if (item is TextBox || item is ComboBox)
                {
                    if (item.Text == string.Empty)
                    {
                        error = true;
                        break;
                    }
                    else
                    {
                        error = false;
                    }
                }
            }

            return error;
        }
    }
}
