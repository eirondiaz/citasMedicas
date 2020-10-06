using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace citasMedicas
{
    class Citas : Datos
    {
        public int id { get; set; }
        public string causa { get; set; }
        public string fecha { get; set; }
        private int Hora;
        public int hora 
        {
            get 
            {
                return Hora;
            }
            set 
            {
                if (value >= 0 && value <= 12)
                {
                    Hora = value;
                }
                else 
                {
                    Hora = 12;
                }
            }
        }
        public int paciente { get; set; }
        public int medico { get; set; }
        public string clinica { get; set; }

        public void Guardar(Citas cit)
        {
            con.Open();
            string cmd = $"insert into citas values ('{cit.causa}', '{cit.fecha}', '{cit.hora.ToString() + ":00"}', {cit.paciente}, {cit.medico}, '{cit.clinica}')";
            comando = new SqlCommand(cmd, con);
            comando.ExecuteNonQuery();
            con.Close();
        }

        public DataTable LlenarGrid()
        {
            con.Open();
            string cmd = "select citas.id_cita as id, citas.causa, citas.fecha, citas.hora, pacientes.nombre as paciente, medicos.nombre as medico, citas.clinica from citas inner join medicos on medicos.id_medico = citas.medico inner join pacientes on pacientes.id_paciente = citas.paciente";
            comando = new SqlCommand(cmd, con);
            comando.ExecuteNonQuery();
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable table = new DataTable();
            data.Fill(table);
            con.Close();
            return table;
        }

        public DataTable Buscar(string cmd)
        {
            con.Open();
            comando = new SqlCommand(cmd, con);
            comando.ExecuteNonQuery();
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable table = new DataTable();
            data.Fill(table);
            con.Close();
            return table;
        }

        public void Editar(Citas cit)
        {
            con.Open();
            string cmd = $"update citas set causa = '{cit.causa}', fecha = '{cit.fecha}', hora = '{cit.hora.ToString() + ":00"}', paciente = {cit.paciente}, medico = {cit.medico}, clinica = '{cit.clinica}' where id_cita = {cit.id}";
            comando = new SqlCommand(cmd, con);
            comando.ExecuteNonQuery();
            con.Close();
        }
    }
}
