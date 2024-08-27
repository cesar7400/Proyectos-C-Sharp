using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTickets.model
{
    internal class ClsSeguimientoModel
    {
        ClsConexionModel clsConexionModel = new ClsConexionModel();
        public DataSet dataSetTicketCodigo()
        {
            DataSet ds = new DataSet();
            if (clsConexionModel.Connection())
            {
                var listTicket = clsConexionModel.SqlDataAdapter("SELECT id, concat(id,' ',departamento)as departamento FROM ticket", CommandType.Text);
                listTicket.Fill(ds);
                clsConexionModel.connection.Close();
            }
            return ds;
        }

        public DataSet dataSetTecnico()
        {
            DataSet ds = new DataSet();
            if (clsConexionModel.Connection())
            {
                var listTicket = clsConexionModel.SqlDataAdapter("SELECT id, concat(nombre,' ',apellidos)as nombres FROM personal", CommandType.Text);
                listTicket.Fill(ds);
                clsConexionModel.connection.Close();
            }
            return ds;
        }

        public bool strInsertSeguimiento(List<KeyValuePair<string, string>> strCmd)
        {
            bool strSQL = false;
            if (clsConexionModel.Connection())
            {
                if (clsConexionModel.strInserUpdate("insert into seguimientos (idTicket, idPersonal, seguimiento, estado) values(@idTicket, @idPersonal, @seguimiento, @estado)", CommandType.Text, strCmd))
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

        public DataSet dataSetSeguimientos()
        {
            DataSet ds = new DataSet();
            if (clsConexionModel.Connection())
            {
                var listUser = clsConexionModel.SqlDataAdapter("SELECT seguimientos.id, ticket.id AS ticket, personal.id ,concat(personal.nombre, ' ',personal.apellidos)as nombres, seguimientos.seguimiento, personal.especialidad, seguimientos.estado FROM seguimientos INNER JOIN ticket ON seguimientos.idTicket = ticket.id INNER JOIN personal ON seguimientos.idPersonal = personal.id", CommandType.Text);
                listUser.Fill(ds);
                clsConexionModel.connection.Close();
            }
            return ds;
        }

        public bool strtUpdateSeguimiento(List<KeyValuePair<string, string>> strCmd)
        {
            bool estatus;
            if (clsConexionModel.Connection())
            {
                if (clsConexionModel.strInserUpdate("update seguimientos set idTicket = @idTicket, idPersonal = @idPersonal, seguimiento = @seguimiento, estado = @estado where id = @id", CommandType.Text, strCmd))
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

        public bool strtDeleteSeguimiento(List<KeyValuePair<string, string>> strCmd)
        {
            bool estatus;
            if (clsConexionModel.Connection())
            {
                if (clsConexionModel.strInserUpdate("delete from seguimientos where id=@id", CommandType.Text, strCmd))
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
