using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppTickets.model;

namespace WpfAppTickets.controller
{
    public class ClsUsuarioController
    {
        ClsUsuarioModel clsUsuarioModel= new ClsUsuarioModel();
        public List<string> loginUsuario(string user, string pass)
        {
            var listUser = clsUsuarioModel.loginUsuario(user, pass);
            return listUser;
        }
        public DataSet DataTableUsuarios()
        {
            var listUser = clsUsuarioModel.dataSetUsuarios();
            return listUser;
        }
        public string[] dataExistLogin(string key, string value)
        {
            var listUserLogin = clsUsuarioModel.dataExistLogin(key, value);
            return listUserLogin;
        }
        public bool strInsertUsuario(List<KeyValuePair<string, string>> strCmd)
        {
            if(clsUsuarioModel.strInsertUsuario(strCmd))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable DataTableUsuarioList()
        {
            DataTable dt = new DataTable();
            var listUser = clsUsuarioModel.dataSetUsuariosList();
            if (listUser != null)
            {
                dt = listUser.Tables[0];
            }
            //se modifica la columna del dataset
            foreach (DataRow fila in dt.Rows)
            {
                ClsLibraryModel clsLibraryModel = new ClsLibraryModel();
                fila["pass"] = clsLibraryModel.Decrypt(fila["pass"].ToString());
            }
            return dt;
        }
        public bool strUpdateUsuario(List<KeyValuePair<string, string>> strCmd)
        {
            bool estatus;
            if (clsUsuarioModel.strtUpdateUsuario(strCmd))
            {
                estatus = true;
            }
            else
            {
                estatus = false;
            }
            return estatus;
        }
    }

}
