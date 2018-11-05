using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace _00_DAL
{
    public static class DBAccess
    {
        
        static MySqlConnection Connection = new MySqlConnection("SERVER=127.0.0.1;PORT=3306;UID=root;persistsecurityinfo=True;DATABASE=managertasks;SslMode = none;Allow User Variables=True");


        public static int? RunNonQuery(string query)
        {
            try
            {
                lock(Connection)
                { 
                Connection.Open();
                MySqlCommand command = new MySqlCommand(query, Connection);
                return command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (Connection.State != System.Data.ConnectionState.Closed)
                {
                    Connection.Close();
                }
            }

        }

        public static object RunScalar(string query)
        {
            try
            {
                lock (Connection)
                {
                    Connection.Open();
                    MySqlCommand command = new MySqlCommand(query, Connection);
                    return command.ExecuteScalar();
                }
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                if (Connection.State != System.Data.ConnectionState.Closed)
                {
                    Connection.Close();
                }
            }

        }

        public static List<T> RunReader<T>(string query, Func<MySqlDataReader, List<T>> func)
        {
            try
            {
                lock (Connection)
                {
                    Connection.Open();
                    MySqlCommand command = new MySqlCommand(query, Connection);
                    MySqlDataReader reader = command.ExecuteReader();
                    return func(reader);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (Connection.State != System.Data.ConnectionState.Closed)
                {
                    Connection.Close();
                }
            }

        }

        public static int? RunStore(string nameStore,int managerId)
        {
            try
            {
                lock (Connection)
                {
                    Connection.Open();
                    MySqlCommand command = new MySqlCommand(nameStore, Connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("id", managerId);
                    return command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (Connection.State != System.Data.ConnectionState.Closed)
                {
                    Connection.Close();
                }
            }

        }

    }
}
