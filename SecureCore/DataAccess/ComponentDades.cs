using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class ComponentDades
    {
        string cnx;
        SqlConnection conn;
        string query;
        DataSet dts;

        public void Connectar()
        {
            ConnectionStringSettings conf;
            conf = ConfigurationManager.ConnectionStrings["SecureCoreG5ConnectionString"];
            if (conf != null) cnx = conf.ConnectionString;
            conn = new SqlConnection(cnx);
        }

        public DataSet PortarTaula(string nomTaula)
        {
            SqlDataAdapter adapter;
            dts = new DataSet();

            query = "select * from " + nomTaula;
            adapter = new SqlDataAdapter(query, conn);

            conn.Open();
            adapter.Fill(dts, nomTaula);
            conn.Close();

            return dts;
        }
        public int Actualitzar(string query, DataSet dts)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder cmdbuilder = new SqlCommandBuilder(adapter);

            int result = adapter.Update(dts.Tables[0]);

            cmdbuilder.Dispose();
            adapter.Dispose();

            return result;
        }

        public DataSet PortarPerConsulta(string query)
        {
            SqlDataAdapter adapter;
            dts = new DataSet();

            adapter = new SqlDataAdapter(query, conn);

            conn.Open();
            adapter.Fill(dts);
            conn.Close();

            return dts;
        }

        public DataSet PortarPerConsulta(string query, string nomTaula)
        {
            SqlDataAdapter adapter;
            dts = new DataSet();

            adapter = new SqlDataAdapter(query, conn);

            conn.Open();
            adapter.Fill(dts, nomTaula);
            conn.Close();

            return dts;
        }

        public DataTable PortarDataTable(string query)
        {
            SqlDataAdapter adapter;
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter(query, conn);

            conn.Open();
            adapter.Fill(dt);
            conn.Close();

            return dt;
        }

        public DataSet AfegirDataTable(string query, DataSet dts)
        {
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter(query, conn);

            conn.Open();
            adapter.Fill(dts);
            conn.Close();

            return dts;
        }

        public int Executa(string query)
        {
            SqlCommand comanda;
            int result;
            comanda = new SqlCommand(query, conn);

            conn.Open();
            result = comanda.ExecuteNonQuery();
            conn.Close();

            return result;
        }

        public SqlCommand GeneraConsultaCerca(string nomTaula, Dictionary<string, object> condicions)
        {
            SqlCommand command = conn.CreateCommand();

            string query = "select * from [" + nomTaula + "] where ";
            int camps = 0;

            foreach (KeyValuePair<string, object> condicio in condicions)
            {
                if (camps > 0)
                {
                    query += " and ";
                }

                string nomParametre = "@valor" + camps;
                query += "[" + condicio.Key + "] = " + nomParametre;

                command.Parameters.Add(new SqlParameter(nomParametre, condicio.Value));
                camps++;
            }
            command.CommandText = query;

            return command;
        }
    }
}
