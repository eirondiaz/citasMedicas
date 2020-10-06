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
    class Clinica : Datos
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }

        public void Guardar(Clinica cli)
        {
            con.Open();
            string cmd = $"insert into clinicas values ({cli.id}, '{cli.nombre}', '{cli.direccion}')";
            comando = new SqlCommand(cmd, con);
            comando.ExecuteNonQuery();
            con.Close();
        }

        public DataTable LlenarGrid()
        {
            con.Open();
            string cmd = $"select * from clinicas";
            comando = new SqlCommand(cmd, con);
            comando.ExecuteNonQuery();
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable table = new DataTable();
            data.Fill(table);
            con.Close();
            return table;
        }

        public bool DataNoRepeat(string column, TextBox txtBox)
        {
            bool repeat = false;

            con.Open();
            ds = new DataSet();
            string cmd = $"select {column} from clinicas";
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

        public void FillCbb(ComboBox cb)
        {
            con.Open();
            string cmd = $"select nombre from clinicas";
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


