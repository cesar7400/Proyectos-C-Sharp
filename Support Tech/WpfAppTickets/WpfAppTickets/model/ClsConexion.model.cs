using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Configuration;
using System.Xml;

namespace WpfAppTickets.model
{
    public class ClsConexionModel
    {
        private SqlConnection _connection;
        private SqlDataReader _reader;
        private string _strConnectionString;
        private string _strError;
        private int _rowsaffected;

        public int rowsAffected
        {
            get { return _rowsaffected; }
            set { _rowsaffected = value; }
        }
        public SqlConnection connection
        {
            get { return _connection; }
            set { _connection = value; }
        }

        public string strError
        {
            get { return _strError; }
            set { _strError = value; }
        }
        public bool Connection()
        {
            try
            {
                _strConnectionString = ConfigurationManager.ConnectionStrings["conexionBD"].ConnectionString;
                _connection = new SqlConnection(_strConnectionString);
                _connection.Open();
                return true;
            }
            catch (Exception error)
            {
                MessageBox.Show("Error de conexión base de datos\n" + error.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
        }
        public SqlDataReader sqlDataReader(string StrSqlQuery, CommandType type, List<KeyValuePair<string, string>> strCmd = null)
        {
            try
            {
                SqlCommand sql = new SqlCommand(StrSqlQuery, _connection);
                sql.CommandType = type;
                if (strCmd != null)
                {
                    foreach (var lst in strCmd)
                    {
                        sql.Parameters.AddWithValue(lst.Key, lst.Value);
                    }
                }
                _reader = sql.ExecuteReader();
                return _reader;
            }
            catch (Exception error)
            {
                MessageBox.Show("Error de consulta\n" + error.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return null;
            }
        }
        public SqlDataAdapter SqlDataAdapter(string strSQL, CommandType type, List<KeyValuePair<string, string>> strCmd = null)
        {
            try
            {
                SqlDataAdapter dap = new SqlDataAdapter(strSQL, _connection);
                dap.SelectCommand.CommandType = type;
                if (strCmd != null)
                {
                    foreach (var lst in strCmd)
                    {
                        dap.SelectCommand.Parameters.AddWithValue(lst.Key, lst.Value);
                    }
                }
                return dap;
            }
            catch (Exception error)
            {
                MessageBox.Show("Error de consulta\n" + error.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return null;
            }
        }
        public bool strInserUpdate(string strSQL, CommandType type, List<KeyValuePair<string, string>> strCmd = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(strSQL, _connection);
                cmd.CommandType = type;
                if (strCmd != null)
                {
                    foreach (var lst in strCmd)
                    {
                        cmd.Parameters.AddWithValue(lst.Key, lst.Value);
                    }
                }
                _rowsaffected = cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al guardar\n" + error.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
        }
    }
}
