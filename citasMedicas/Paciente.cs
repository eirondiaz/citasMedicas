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
    class Paciente : Persona
    {
        public string direccion { get; set; }

        public override DataTable LlenarGrid()
        {
            con.Open();
            string cmd = $"select * from pacientes";
            comando = new SqlCommand(cmd, con);
            comando.ExecuteNonQuery();
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable table = new DataTable();
            data.Fill(table);
            con.Close();
            return table;
        }

        //metodo que sirve para que el valor de una fila no se repita en la BD.
        //por ejemplo: que no haya 2 ID iguales en una tabla
        public override bool DataNoRepeat(string column, TextBox txtBox)
        {
            bool repeat = false;

            con.Open();
            ds = new DataSet();
            string cmd = $"select {column} from pacientes";
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
            string cmd = $"select nombre from pacientes";
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
