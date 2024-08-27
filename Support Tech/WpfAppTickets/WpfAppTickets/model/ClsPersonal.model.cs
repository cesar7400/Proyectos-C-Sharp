using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTickets.model
{
    public class ClsPersonalModel
    {
        ClsConexionModel clsConexionModel = new ClsConexionModel();
        public DataSet dataSetPersonal()
        {
            DataSet ds = new DataSet();
            if (clsConexionModel.Connection())
            {
                var listUser = clsConexionModel.SqlDataAdapter("SELECT id, nombre, apellidos, especialidad, FORMAT (fechaIngreso, 'dd/MM/yyyy ') as fechaIngreso, horario, documento, mail, '(' + LEFT(whatsapp, 3) + ') ' + SUBSTRING(whatsapp, 4, 3) + ' ' + SUBSTRING(whatsapp, 7, 3) + ' ' + SUBSTRING(whatsapp, 10, 2) + ' ' + RIGHT(whatsapp, 2) AS whatsapp, (case when estado = '1' then 'Activo' else 'Desactivado' end)as estado FROM  personal", CommandType.Text);
                listUser.Fill(ds);
                clsConexionModel.connection.Close();
            }
            return ds;
        }
        public string[] dataExist(string key, string value)
        {
            var strCmd = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>(key, value)
            };

            string[] strValues = new string[] { };

            if (clsConexionModel.Connection())
            {
                var SqlReader = clsConexionModel.sqlDataReader("select " + strCmd[0].Key.Remove(0, 1) + " from personal where " + strCmd[0].Key.Remove(0, 1) + " = " + strCmd[0].Key + "", CommandType.Text, strCmd);
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
        public bool strInsertPersonal(List<KeyValuePair<string, string>> strCmd)
        {
            bool estatus;
            if (clsConexionModel.Connection())
            {
                if (clsConexionModel.strInserUpdate("insert into personal(nombre, apellidos,especialidad,fechaIngreso,horario,documento,mail,whatsapp,estado) values (@nombre, @apellidos,@especialidad,@fechaIngreso,@horario,@documento,@mail,@whatsapp,@estado)", CommandType.Text, strCmd))
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
        public bool strtUpdatePersonal(List<KeyValuePair<string, string>> strCmd)
        {
            bool estatus;
            if (clsConexionModel.Connection())
            {
                if (clsConexionModel.strInserUpdate("update personal set nombre = @nombre, apellidos = @apellidos, especialidad = @especialidad, fechaIngreso = @fechaIngreso, horario = @horario, documento = @documento,mail = @mail, whatsapp = @whatsapp, estado = @estado where id = @id ", CommandType.Text, strCmd))
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