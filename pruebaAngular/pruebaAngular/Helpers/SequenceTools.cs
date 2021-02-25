using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pruebaAngular.Helpers
{
    public class SequenceTools
    {
        public static string connectionString = "USER ID=ELIBRERIA;Password=Libro2021;DATA SOURCE=localhost:1521/orcl";
        public static int NextValSequence(String sequence)
        {
            using (OracleConnection con = new OracleConnection(connectionString))
            {
                using (OracleCommand cmd = con.CreateCommand())
                {
                    try
                    {
                        int nextVal = 0;
                        con.Open();
                        cmd.CommandText = "SELECT " + sequence + ".nextVal FROM dual";
                        OracleDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            nextVal = reader.GetInt32(0);
                        }
                        reader.Dispose();
                        return nextVal;
                    }
                    catch (Exception ex)
                    {
                        return -1;
                    }
                }
            }
        }
    }
}
