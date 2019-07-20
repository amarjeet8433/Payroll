using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Payroll
{
    class Connection
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter sda;

        public void connection()
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Payroll;Integrated Security=True;Pooling=False");
            con.Open();
        }

        public void sendData(string query)
        {
            try
            {
                connection();
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                
            }
            con.Close();
        }

        public void getData(string query)
        {
            try
            {
                connection();
                sda = new SqlDataAdapter(query, con);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
