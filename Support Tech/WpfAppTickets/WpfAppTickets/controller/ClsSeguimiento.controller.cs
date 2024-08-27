using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppTickets.model;

namespace WpfAppTickets.controller
{
    internal class ClsSeguimientoController
    {
        ClsSeguimientoModel clsSeguimientoModel = new ClsSeguimientoModel();
        public DataSet DataTableTicketCodigo()
        {
            var listTicket = clsSeguimientoModel.dataSetTicketCodigo();
            return listTicket;
        }

        public DataSet DataTableTecnico()
        {
            var listTicket = clsSeguimientoModel.dataSetTecnico();
            return listTicket;
        }

        public bool strInsertSeguimiento(List<KeyValuePair<string, string>> strCmd)
        {
            if (clsSeguimientoModel.strInsertSeguimiento(strCmd))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable DataTableSeguimientos()
        {
            DataTable dt = new DataTable();
            var lisSeguimientos = clsSeguimientoModel.dataSetSeguimientos();
            if (lisSeguimientos != null)
            {
                dt = lisSeguimientos.Tables[0];
            }
            return dt;
        }
        public bool strUpdateSeguimiento(List<KeyValuePair<string, string>> strCmd)
        {
            bool estatus;
            if (clsSeguimientoModel.strtUpdateSeguimiento(strCmd))
            {
                estatus = true;
            }
            else
            {
                estatus = false;
            }
            return estatus;
        }
        public bool strDeleteSeguimiento(List<KeyValuePair<string, string>> strCmd)
        {
            bool estatus;
            if (clsSeguimientoModel.strtDeleteSeguimiento(strCmd))
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
