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
    public partial class Procesos : Form
    {
        int idCit = 0;
        Datos dt = new Datos();
        Paciente pac = new Paciente();
        Medicos med = new Medicos();
        Clinica cli = new Clinica();
        Citas cit = new Citas();
        public Procesos()
        {
            InitializeComponent();
        }

        private void picSalir_Click(object sender, EventArgs e)
        {    
            this.Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Mantenimientos.Validar(groupBox1))
            {
                MessageBox.Show("Debes llenar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else 
            {
                try
                {
                    Citas cit = new Citas();

                    cit.causa = txtCausa.Text;
                    cit.fecha = dateTimePicker1.Text;
                    cit.hora = int.Parse(txtHora.Text);
                    DataSet ds = dt.getId("id_paciente", "pacientes", cbbPaciente);
                    cit.paciente = int.Parse(ds.Tables[0].Rows[0]["id_paciente"].ToString());
                    ds = dt.getId("id_medico", "medicos", cbbMedico);
                    cit.medico = int.Parse(ds.Tables[0].Rows[0]["id_medico"].ToString());
                    cit.clinica = cbbClinica.Text;

                    cit.Guardar(cit);
                    MessageBox.Show("Cita agregada correctamente");
                    cbbClinica.Items.Clear();
                    cbbPaciente.Items.Clear();
                    cbbMedico.Items.Clear();
                    Mantenimientos.Limpiar(groupBox1);
                    dgCitas.DataSource = cit.LlenarGrid();
                }
                catch (Exception er) 
                {
                    MessageBox.Show("El campo hora solo acepta numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void Procesos_Load(object sender, EventArgs e)
        {
            dgCitas.DataSource = cit.LlenarGrid();

            cli.FillCbb(cbbClinica);
            pac.FillCbb(cbbPaciente);
        }

        private void cbbClinica_Click(object sender, EventArgs e)
        {
            cbbClinica.Items.Clear();
            cli.FillCbb(cbbClinica);
        }

        private void cbbPaciente_Click(object sender, EventArgs e)
        {
            cbbPaciente.Items.Clear();
            pac.FillCbb(cbbPaciente);
        }

        private void cbbMedico_Click(object sender, EventArgs e)
        {
            cbbMedico.Items.Clear();
            med.CbbDepen(cbbMedico, cbbClinica);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            idCit = 0;
            cbbClinica.Items.Clear();
            cbbPaciente.Items.Clear();
            cbbMedico.Items.Clear();
            cli.FillCbb(cbbClinica);
            pac.FillCbb(cbbPaciente);
            Mantenimientos.Limpiar(groupBox1);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idCit == 0) 
            {
                MessageBox.Show("Debes seleccionar una cita para poder editar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (Mantenimientos.Validar(groupBox1))
            {
                MessageBox.Show("Debes llenar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    Citas cit = new Citas();

                    cit.id = idCit;
                    cit.causa = txtCausa.Text;
                    cit.fecha = dateTimePicker1.Text;
                    cit.hora = int.Parse(txtHora.Text);
                    DataSet ds = dt.getId("id_paciente", "pacientes", cbbPaciente);
                    cit.paciente = int.Parse(ds.Tables[0].Rows[0]["id_paciente"].ToString());
                    ds = dt.getId("id_medico", "medicos", cbbMedico);
                    cit.medico = int.Parse(ds.Tables[0].Rows[0]["id_medico"].ToString());
                    cit.clinica = cbbClinica.Text;

                    cit.Editar(cit);
                    MessageBox.Show("Cita editada correctamente");
                    idCit = 0;
                    cbbClinica.Items.Clear();
                    cbbPaciente.Items.Clear();
                    cbbMedico.Items.Clear();
                    cli.FillCbb(cbbClinica);
                    pac.FillCbb(cbbPaciente);
                    Mantenimientos.Limpiar(groupBox1);
                    dgCitas.DataSource = cit.LlenarGrid();
                }
                catch (Exception er)
                {
                    MessageBox.Show("El campo hora solo acepta numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void dgCitas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgCitas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    cbbMedico.Items.Clear();

                    dgCitas.CurrentCell.Selected = true;
                    idCit = int.Parse(dgCitas.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString());
                    txtCausa.Text = dgCitas.Rows[e.RowIndex].Cells["causa"].FormattedValue.ToString();
                    dateTimePicker1.Text = dgCitas.Rows[e.RowIndex].Cells["fecha"].FormattedValue.ToString();
                    string hora = dgCitas.Rows[e.RowIndex].Cells["hora"].FormattedValue.ToString();
                    if (hora.Substring(1, 1) == ":")
                    {
                        txtHora.Text = hora.Substring(0, 1);
                    }
                    else
                    {
                        txtHora.Text = hora.Substring(0, 2);
                    }
                    cbbClinica.Text = dgCitas.Rows[e.RowIndex].Cells["clinica"].FormattedValue.ToString();
                    cbbMedico.Text = dgCitas.Rows[e.RowIndex].Cells["medico"].FormattedValue.ToString();
                    cbbPaciente.Text = dgCitas.Rows[e.RowIndex].Cells["paciente"].FormattedValue.ToString();
                }
            }
            catch (Exception er)
            {

            }
        }
    }
}
