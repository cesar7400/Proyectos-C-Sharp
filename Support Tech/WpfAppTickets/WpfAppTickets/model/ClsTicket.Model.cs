using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTickets.model
{
    public class ClsTicketModel
    {
        ClsConexionModel clsConexionModel = new ClsConexionModel();
        public bool strInsertTicket(List<KeyValuePair<string, string>> strCmd)
        {
            bool strSQL = false;
            if (clsConexionModel.Connection())
            {
                if (clsConexionModel.strInserUpdate("insert into ticket (idArea, departamento, asunto, descripcion, prioridad, puesto, nivel, whastapp, fecha, comentarios, sucursal, idUsuario) values(@idArea, @departamento, @asunto, @descripcion, @prioridad, @puesto, @nivel, @whastapp, @fecha, @comentarios, @sucursal, @idUsuario)", CommandType.Text, strCmd))
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

        public DataSet dataSetListArea()
        {
            DataSet ds = new DataSet();
            if (clsConexionModel.Connection())
            {
                var listUser = clsConexionModel.SqlDataAdapter("select id, descripcion from areas", CommandType.Text);
                listUser.Fill(ds);
                clsConexionModel.connection.Close();
            }
            return ds;
        }

        public DataSet dataSetTicket(List<KeyValuePair<string, string>> strCmd)
        {
            DataSet ds = new DataSet();
            if (clsConexionModel.Connection())
            {
                var listUser = clsConexionModel.SqlDataAdapter("SELECT ticket.id, ticket.idArea, areas.descripcion, ticket.departamento, ticket.asunto, ticket.descripcion AS ticketDescripcion, ticket.prioridad, ticket.puesto, ticket.nivel, '(' + LEFT(ticket.whastapp, 3) + ') ' + SUBSTRING(ticket.whastapp, 4, 3) + ' ' + SUBSTRING(ticket.whastapp, 7, 3) + ' ' + SUBSTRING(ticket.whastapp, 10, 2) + ' ' + RIGHT(ticket.whastapp, 2) AS whatsapp, FORMAT (ticket.fecha, 'yyyy/MM/dd ') as fecha, ticket.comentarios, ticket.sucursal, areas.descripcion as descripcionArea FROM ticket INNER JOIN areas ON ticket.idArea = areas.id WHERE ticket.idUsuario = @idUsuario", CommandType.Text, strCmd);
                listUser.Fill(ds);
                clsConexionModel.connection.Close();
            }
            return ds;
        }

        public bool strtUpdateTicket(List<KeyValuePair<string, string>> strCmd)
        {
            bool estatus;
            if (clsConexionModel.Connection())
            {
                if (clsConexionModel.strInserUpdate("update ticket set idArea = @idArea, departamento = @departamento, asunto = @asunto, descripcion = @descripcion, prioridad = @prioridad, puesto = @puesto, nivel = @nivel, whastapp = @whastapp, fecha = @fecha, comentarios = @comentarios, sucursal = @sucursal where id=@id", CommandType.Text, strCmd))
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

        public bool strtDeleteTicket(List<KeyValuePair<string, string>> strCmd)
        {
            bool estatus;
            if (clsConexionModel.Connection())
            {
                if (clsConexionModel.strInserUpdate("delete from ticket where id=@id", CommandType.Text, strCmd))
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
