using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTickets.model
{
    public class ClsUsuarioModel
    {
        ClsConexionModel clsConexionModel = new ClsConexionModel();
        public List<string> loginUsuario(string user, string pass)
        {
            List<string> resultList = new List<string>();
            if (clsConexionModel.Connection())
            {
                ClsLibraryModel clsLibraryModel = new ClsLibraryModel();
                var myList = new List<KeyValuePair<string, string>>();
                myList.Add(new KeyValuePair<string, string>("@login", user));
                myList.Add(new KeyValuePair<string, string>("@pass", clsLibraryModel.Encrypt(pass)));
                var SqlReader = clsConexionModel.sqlDataReader("select id, estado from Usuarios where login = @login and pass = @pass", CommandType.Text, myList);
                if (SqlReader.HasRows)
                {
                    while (SqlReader.Read())
                    {
                        for (int i = 0; i < SqlReader.FieldCount; i++)
                        {
                            resultList.Add(SqlReader.GetValue(i).ToString());
                        }
                    }
                }
                clsConexionModel.connection.Close();
                SqlReader.Close();
            }
            else
            {
                resultList = null;
            }
            return resultList;
        }
        public DataSet dataSetUsuarios()
        {
            DataSet ds = new DataSet();
            if (clsConexionModel.Connection())
            {
                var listUser = clsConexionModel.SqlDataAdapter("select id, concat(nombre,' ',apellidos)as nombres from personal", CommandType.Text);
                listUser.Fill(ds);
                clsConexionModel.connection.Close();
            }
            return ds;
        }
        public string[] dataExistLogin(string key, string value)
        {
            var strCmd = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>(key, value)
            };

            string[] strValues = new string[] { };

            if (clsConexionModel.Connection())
            {
                var SqlReader = clsConexionModel.sqlDataReader("select " + strCmd[0].Key.Remove(0, 1) + " from usuarios where " + strCmd[0].Key.Remove(0, 1) + " = " + strCmd[0].Key + "", CommandType.Text, strCmd);
                if (SqlReader.HasRows)
                {
                    while (SqlReader.Read())
                    {
                        for (int i = 0; i < SqlReader.FieldCount; i++)
                        {
                            strValues = strValues.Concat(new string[] { SqlReader.GetValue(i).ToString() }).ToArray();
                        }
                    }
                }
                clsConexionModel.connection.Close();
                SqlReader.Close();
            }
            return strValues;
        }
        public bool strInsertUsuario(List<KeyValuePair<string, string>> strCmd)
        {
            bool strSQL = false;
            if (clsConexionModel.Connection())
            {
                if (clsConexionModel.strInserUpdate("insert into usuarios(login, pass, nivel, estado, idPersonal) values(@login, @pass, @nivel, @estado, @idPersonal)", CommandType.Text, strCmd))
                {
                    clsConexionModel.connection.Close();
                    strSQL = true;
                }
                else
                {
                    strSQL = false;
                }
            }
            return strSQL;
        }
        public DataSet dataSetUsuariosList()
        {
            DataSet ds = new DataSet();
            if (clsConexionModel.Connection())
            {
                var listUser = clsConexionModel.SqlDataAdapter("SELECT personal.id, usuarios.login, usuarios.pass, concat(personal.nombre,' ',personal.apellidos)as nombres, usuarios.nivel, (case when usuarios.estado = '1' then 'Activo' else 'Desactivado' end)as estado, usuarios.idPersonal FROM personal INNER JOIN usuarios ON personal.id = usuarios.idPersonal", CommandType.Text);
                listUser.Fill(ds);
                clsConexionModel.connection.Close();
            }
            return ds;
        }
        public bool strtUpdateUsuario(List<KeyValuePair<string, string>> strCmd)
        {
            bool estatus;
            if (clsConexionModel.Connection())
            {
                if (clsConexionModel.strInserUpdate("update usuarios set login = @login, pass = @pass, nivel = @nivel, estado = @estado where idPersonal = @idPersonal", CommandType.Text, strCmd))
                {
                    estatus = true;
                    clsConexionModel.connection.Close();
                }
                else
                {
                    estatus = false;
                }
            }
            else
            {
                estatus = false;
            }
            return estatus;
        }
    }
}
