using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppTickets.model;

namespace WpfAppTickets.controller
{
    public class ClsPersonalController
    {
        ClsPersonalModel clsPersonalModel = new ClsPersonalModel();
        public DataTable DataTablePersonal()
        {
            DataTable dt = new DataTable();
            var listUser = clsPersonalModel.dataSetPersonal();
            if (listUser != null)
            {
                dt = listUser.Tables[0];
            }
            return dt;
        }
        public string[] dataExist(string key, string value)
        {
            var listUser = clsPersonalModel.dataExist(key, value);
            return listUser;
        }
        public bool strInsertPersonal(List<KeyValuePair<string, string>> strCmd)
        {
            bool estatus;
            if (clsPersonalModel.strInsertPersonal(strCmd))
            {
                estatus = true;
            }
            else
            {
                estatus = false;
            }
            return estatus;
        }
        public bool strUpdatePersonal(List<KeyValuePair<string, string>> strCmd)
        {
            bool estatus;
            if (clsPersonalModel.strtUpdatePersonal(strCmd))
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
