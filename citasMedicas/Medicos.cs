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
    class Medicos : Persona
    {
        public int exequatur { get; set; }
        public int clinica { get; set; }

        public override DataTable LlenarGrid()
        {
            con.Open();
            string cmd = "select medicos.id_medico, medicos.cedula, medicos.exequatur, medicos.nombre, medicos.tel, medicos.email, clinicas.nombre as clinica from medicos inner join clinicas on clinicas.id_clinica = medicos.id_clinica";
            comando = new SqlCommand(cmd, con);
            comando.ExecuteNonQuery();
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable table = new DataTable();
            data.Fill(table);
            con.Close();
            return table;
        }

        public override bool DataNoRepeat(string column, TextBox txtBox)
        {
            bool repeat = false;

            con.Open();
            ds = new DataSet();
            string cmd = $"select {column} from medicos";
            SqlDataAdapter dp = new SqlDataAdapter(cmd, con);
            dp.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (ds.Tables[0].Rows[i][column].ToString() == txtBox.Text.ToString())
                {
                    repeat = true;
                    break;
                }
                else
                {
                    repeat = false;
                }
            }
            con.Close();
            return repeat;
        }

        public void CbbDepen(ComboBox cb, ComboBox cbbDependiente)
        {
            con.Open();
            string cmd = $"select medicos.nombre from medicos inner join clinicas on clinicas.id_clinica = medicos.id_clinica where clinicas.nombre='{cbbDependiente.Text}'";
            comando = new SqlCommand(cmd, con);
            dr = comando.ExecuteReader();
            while (dr.Read())
            {
                cb.Items.Add(dr["nombre"].ToString());
            }
            dr.Close();
            con.Close();
        }
    }
}
