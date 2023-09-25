using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProiectPAOO.Data
{
    internal class Connection
    {
        public static MySqlConnection connMaster = new MySqlConnection();

        static string server = "127.0.0.1;";
        static string database = "magazinpantofi;";
        static string Uid = "root;";
        static string password = "root;";

        public static MySqlConnection dataSource()
        {

            connMaster = new MySqlConnection($"server={server} database={database} Uid={Uid} password={password}");
            return connMaster;
        }
        public  string conString() {
            return $"server={server} database={database} Uid={Uid} password={password}";
        }

        public void connOpen()
        {
            dataSource();
            connMaster.Open();
        }

        public void connClose()
        {
            dataSource();
            connMaster.Close();
        }

        public void ExecuteNonQuery(string query)
        {
            using (MySqlConnection conn = dataSource())
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                command.ExecuteNonQuery();
            }
           
        }


        public List<Dictionary<string, object>> ExecuteQuery(string query)
        {
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();

            using (MySqlConnection conn = dataSource())
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Dictionary<string, object> row = new Dictionary<string, object>();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            row[reader.GetName(i)] = reader.GetValue(i);
                        }
                        rows.Add(row);
                    }
                }
            }

            return rows;
        }

        public string[,] PrintOutput(List<Dictionary<string, object>> rows)
        {
            int rowCount = rows.Count;
            int colCount = rows[0].Count;

            string[,] output = new string[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                int j = 0;
                foreach (string key in rows[i].Keys)
                {
                    output[i, j] = rows[i][key].ToString();
                    j++;
                }
            }

            return output;
        }

        public string[,] ExecuteAndPrintQuery(string query)
        {
            List<Dictionary<string, object>> rows = ExecuteQuery(query);
            string[,] output = null;

            if (rows.Count > 0)
            {
                output = PrintOutput(rows);
            }

            return output;
        }

    }
}
