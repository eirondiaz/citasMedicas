using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace citasMedicas
{
    class Datos
    {
        protected SqlConnection con = new SqlConnection("Data Source=DESKTOP-9ER53EB\\EQUIPO;Initial Catalog=citasmedicasdb;Integrated Security=True");
        protected SqlCommand comando;
        protected SqlDataReader dr;
        protected DataSet ds;

        //metodo para obtener id
        public DataSet getId(string column, string tabla, ComboBox cbb) 
        {
            ds = new DataSet();
            string cmd = $"select {column} from {tabla} where nombre='{cbb.Text}'";
            SqlDataAdapter dp = new SqlDataAdapter(cmd, con);
            dp.Fill(ds);
            con.Close();
            return ds;
        }
    }
}
