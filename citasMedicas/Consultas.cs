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
    public partial class Consultas : Form
    {
        Datos dt = new Datos();
        Paciente pac = new Paciente();
        Medicos med = new Medicos();
        Citas cit = new Citas();
        public Consultas()
        {
            InitializeComponent();
        }

        private void picSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            picBuscarb.Visible = true;
            picBuscar.Visible = false;
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            picBuscarb.Visible = false;
            picBuscar.Visible = true;
        }

        private void txtBuscarMed_Enter(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
        }

        private void txtBuscarMed_Leave(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
        }

        private void txtBuscarCitas_Enter(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
        }

        private void txtBuscarCitas_Leave(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;
        }

        private void btnPacBuscar_Click(object sender, EventArgs e)
        {
            if (rbPacNombre.Checked == true)
            {
                string nombre = txtPacBuscar.Text;
                string cmd = $"select * from pacientes where nombre like '{nombre}%'";
                dgPacientes.DataSource = pac.Buscar(cmd);
            }
            else 
            {
                string email = txtPacBuscar.Text;
                string cmd = $"select * from pacientes where email like '{email}%'";
                dgPacientes.DataSource = pac.Buscar(cmd);
            }
        }

        private void Consultas_Load(object sender, EventArgs e)
        {
            dgPacientes.DataSource = pac.LlenarGrid();
            dgMedicos.DataSource = med.LlenarGrid();
            dgCitas.DataSource = cit.LlenarGrid();
        }

        private void rbPacNombre_CheckedChanged(object sender, EventArgs e)
        {
            txtPacBuscar.Text = "";
            dgPacientes.DataSource = pac.LlenarGrid();
        }

        private void rbPacEmail_CheckedChanged(object sender, EventArgs e)
        {
            txtPacBuscar.Text = "";
            dgPacientes.DataSource = pac.LlenarGrid();
        }

        private void btnMedBuscar_Click(object sender, EventArgs e)
        {
            if (rbMedNombre.Checked == true)
            {
                string nombre = txtMedBuscar.Text;
                string cmd = $"select * from medicos where nombre like '{nombre}%'";
                dgMedicos.DataSource = med.Buscar(cmd);
            }
            else
            {
                string exequatur = txtMedBuscar.Text;
                string cmd = $"select * from medicos where exequatur like '{exequatur}%'";
                dgMedicos.DataSource = med.Buscar(cmd);
            }
        }

        private void rbMedNombre_CheckedChanged(object sender, EventArgs e)
        {
            txtMedBuscar.Text = "";
            dgMedicos.DataSource = med.LlenarGrid();
        }

        private void rbExequatur_CheckedChanged(object sender, EventArgs e)
        {
            txtMedBuscar.Text = "";
            dgMedicos.DataSource = med.LlenarGrid();
        }

        private void btnCitBuscar_Click(object sender, EventArgs e)
        {
            string medico = "";
            int exequatur = 0;
            string cmd = "";

            if (rbCitNom.Checked == true)
            {
                if (txtCitBuscar.Text == string.Empty)
                {
                    cmd = $"select citas.causa, citas.fecha, citas.hora, pacientes.nombre as paciente, medicos.nombre as medico, citas.clinica from citas inner join medicos on medicos.id_medico = citas.medico inner join pacientes on pacientes.id_paciente = citas.paciente";
                }
                else 
                {
                    foreach (char cha in txtCitBuscar.Text)
                    {
                        try
                        {
                            if (char.IsLetter(cha))
                            {
                                medico = txtCitBuscar.Text;
                                cmd = $"select citas.causa, citas.fecha, citas.hora, pacientes.nombre as paciente, medicos.nombre as medico, citas.clinica from citas inner join medicos on medicos.id_medico = citas.medico inner join pacientes on pacientes.id_paciente = citas.paciente where medicos.nombre like '{medico}%'";
                            }
                            else if (char.IsDigit(cha))
                            {
                                exequatur = int.Parse(txtCitBuscar.Text);
                                cmd = $"select citas.causa, citas.fecha, citas.hora, pacientes.nombre as paciente, medicos.nombre as medico, citas.clinica from citas inner join medicos on medicos.id_medico = citas.medico inner join pacientes on pacientes.id_paciente = citas.paciente where medicos.exequatur like '{exequatur}%'";
                            }
                        }
                        catch (Exception er) 
                        {
                            cmd = $"select citas.causa, citas.fecha, citas.hora, pacientes.nombre as paciente, medicos.nombre as medico, citas.clinica from citas inner join medicos on medicos.id_medico = citas.medico inner join pacientes on pacientes.id_paciente = citas.paciente where medicos.nombre = 'hjasijmf'";
                        }
                    }
                }
              
                dgCitas.DataSource = cit.Buscar(cmd);
            }
            else 
            {
                string paciente = txtCitBuscar.Text;
                cmd = $"select citas.causa, citas.fecha, citas.hora, pacientes.nombre as paciente, medicos.nombre as medico, citas.clinica from citas inner join medicos on medicos.id_medico = citas.medico inner join pacientes on pacientes.id_paciente = citas.paciente where pacientes.nombre like '{paciente}%'";
                dgCitas.DataSource = cit.Buscar(cmd);
            }
        }

        private void rbCitNom_CheckedChanged(object sender, EventArgs e)
        {
            txtCitBuscar.Text = "";
            dgCitas.DataSource = cit.LlenarGrid();
        }

        private void rbCitPaciente_CheckedChanged(object sender, EventArgs e)
        {
            txtCitBuscar.Text = "";
            dgCitas.DataSource = cit.LlenarGrid();
        }


        //evento para que busque automaticamente
        private void txtPacBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (rbPacNombre.Checked == true)
            {
                string nombre = txtPacBuscar.Text;
                string cmd = $"select * from pacientes where nombre like '{nombre}%'";
                dgPacientes.DataSource = pac.Buscar(cmd);
            }
            else
            {
                string email = txtPacBuscar.Text;
                string cmd = $"select * from pacientes where email like '{email}%'";
                dgPacientes.DataSource = pac.Buscar(cmd);
            }
        }
    }
}
