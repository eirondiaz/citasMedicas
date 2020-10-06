using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace citasMedicas
{
    abstract class Persona : Datos
    {
        public int id { get; set; }
        public string cedula { get; set; }
        public string nombre { get; set; }
        public long telefono { get; set; }
        public string email { get; set; }

        public abstract DataTable LlenarGrid();

        public abstract bool DataNoRepeat(string column, TextBox txtBox);

        public virtual void Guardar(Paciente pac)
        {
            con.Open();
            string cmd = $"insert into pacientes values ({pac.id}, '{pac.cedula}', '{pac.nombre}', {pac.telefono}, '{pac.email}', '{pac.direccion}')";
            comando = new SqlCommand(cmd, con);
            comando.ExecuteNonQuery();
            con.Close();
        }

        public virtual void Guardar(Medicos med)
        {
            con.Open();
            string cmd = $"insert into medicos values ({med.id}, '{med.cedula}', {med.exequatur}, '{med.nombre}', {med.telefono}, '{med.email}', {med.clinica})";
            comando = new SqlCommand(cmd, con);
            comando.ExecuteNonQuery();
            con.Close();
        }

        public virtual DataTable Buscar(string cmd)
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

        public virtual string cedFormat(string cadena) 
        {
            string p, s, t;

            p = cadena.Substring(0, 3);
            s = cadena.Substring(3, 7);
            t = cadena.Substring(10, 1);

            return p + "-" + s + "-" + t;
        }
    }
}
