using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppTickets.model;

namespace WpfAppTickets.controller
{
    public class ClsTicketController
    {
        ClsTicketModel clsTicketModel = new ClsTicketModel();
        public bool strInsertTicket(List<KeyValuePair<string, string>> strCmd)
        {
            if (clsTicketModel.strInsertTicket(strCmd))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataSet dataSetListArea()
        {
            var listUser = clsTicketModel.dataSetListArea();
            return listUser;
        }

        public DataTable DataTableTicket(List<KeyValuePair<string, string>> strCmd)
        {
            DataTable dt = new DataTable();
            var listTicket = clsTicketModel.dataSetTicket(strCmd);
            if (listTicket != null)
            {
                dt = listTicket.Tables[0];
            }
            return dt;
        }

        public bool strUpdateTicket(List<KeyValuePair<string, string>> strCmd)
        {
            bool estatus;
            if (clsTicketModel.strtUpdateTicket(strCmd))
            {
                estatus = true;
            }
            else
            {
                estatus = false;
            }
            return estatus;
        }

        public bool strDeleteTicket(List<KeyValuePair<string, string>> strCmd)
        {
            bool estatus;
            if (clsTicketModel.strtDeleteTicket(strCmd))
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
