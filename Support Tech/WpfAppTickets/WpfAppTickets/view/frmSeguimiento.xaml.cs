using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfAppTickets.controller;
using WpfAppTickets.model;

namespace WpfAppTickets.view
{
    /// <summary>
    /// Lógica de interacción para frmSeguimiento.xaml
    /// </summary>
    public partial class frmSeguimiento : Page
    {
        public frmSeguimiento()
        {
            InitializeComponent();
        }
        private bool update;
        private string idSeg = "";
        private DataTable dataTable; //La fuente de datos original
        private DataTable filteredTable; //La tabla filtrada por busquedad

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ticketCodigo();
            tecnico();
            seguimientos();
        }

        private void ticketCodigo()
        {
            ClsSeguimientoController clsSeguimientoController = new ClsSeguimientoController();
            cmbCodigoTicket.ItemsSource = clsSeguimientoController.DataTableTicketCodigo().Tables[0].DefaultView;
            this.cmbCodigoTicket.DisplayMemberPath = "departamento";
            this.cmbCodigoTicket.SelectedValuePath = "id";
        }

        private void tecnico()
        {
            ClsSeguimientoController clsSeguimientoController = new ClsSeguimientoController();
            cmbTecnico.ItemsSource = clsSeguimientoController.DataTableTecnico().Tables[0].DefaultView;
            this.cmbTecnico.DisplayMemberPath = "nombres";
            this.cmbTecnico.SelectedValuePath = "id";
        }
        private void seguimientos()
        {
            ClsSeguimientoController clsSeguimientoController = new ClsSeguimientoController();
            var listSeguimientos = clsSeguimientoController.DataTableSeguimientos();
            dataTable = listSeguimientos;
            //Limitar el número de filas que se mostrarán en el DataGridView*/
            //Cambia este valor según tus necesidades
            int maxRowsToShow = 30;
            if (dataTable.Rows.Count > 0)
            {
                var rowsToShow = dataTable.AsEnumerable().Take(maxRowsToShow).CopyToDataTable();
                // Asignar el DataTable filtrado y limitado al DataGridView
                grdSeguimiento.ItemsSource = rowsToShow.DefaultView;
                grdSeguimiento.CanUserSortColumns = false;
            }
        }
        private void clearData()
        {
            cmbCodigoTicket.SelectedIndex = -1;
            cmbTecnico.SelectedIndex = -1;
            txtSeguimiento.Clear();
            cmbEstado.SelectedIndex = -1;
            update = false;
            txtBuscarSeguimiento.Clear();
            btnGuardar.Content = "guardar";
        }
        private void guardar()
        {
            if (cmbCodigoTicket.Text == string.Empty || cmbCodigoTicket.SelectedValue == null)
            {
                MessageBox.Show("seleccionar código ticket", "Mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                cmbCodigoTicket.Focus();
                return;
            }
            else if (cmbTecnico.Text == string.Empty || cmbTecnico.SelectedValue == null)
            {
                MessageBox.Show("seleccionar técnico", "Mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                cmbTecnico.Focus();
                return;
            }
            else if (txtSeguimiento.Text == string.Empty)
            {
                MessageBox.Show("Ingresar seguimiento", "Mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                txtSeguimiento.Focus();
                return;
            }
            else if (cmbEstado.Text == string.Empty || cmbEstado.SelectedValue == null)
            {
                MessageBox.Show("seleccionar estado", "Mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                cmbTecnico.Focus();
                return;
            }
            else
            {
                ClsSeguimientoController clsSeguimientoController = new ClsSeguimientoController();
                var myList = new List<KeyValuePair<string, string>>();

                myList.Add(new KeyValuePair<string, string>("@idTicket", cmbCodigoTicket.SelectedValue.ToString()));
                myList.Add(new KeyValuePair<string, string>("@idPersonal", cmbTecnico.SelectedValue.ToString()));
                myList.Add(new KeyValuePair<string, string>("@seguimiento", txtSeguimiento.Text.Trim()));
                myList.Add(new KeyValuePair<string, string>("@estado", cmbEstado.Text.Trim()));
                myList.Add(new KeyValuePair<string, string>("@id", idSeg));

                if (!update)
                {
                    if (clsSeguimientoController.strInsertSeguimiento(myList))
                    {
                        clearData();
                        seguimientos();
                        MessageBox.Show("Ticket guardado correctamente", "mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                else
                {
                    if (clsSeguimientoController.strUpdateSeguimiento(myList))
                    {
                        seguimientos();
                        clearData();
                        MessageBox.Show("Ticket modificado correctamente", "mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            guardar();
        }

        private void btnSeleccionar_Click(object sender, RoutedEventArgs e)
        {
            //comprobar si la fila es seleccionada
            if (grdSeguimiento.SelectedItem != null)
            {
                //obtener la fila seleccionada
                DataRowView rowView = grdSeguimiento.SelectedItem as DataRowView;
                //comprobar si el DataRowView que no sea nulo
                if (rowView != null)
                {
                    //obtener el valor de la celda deseada<<la primera columna>>
                    //mostrar valor seleccionado
                    idSeg = rowView.Row[0].ToString();
                    cmbCodigoTicket.SelectedValue = rowView.Row[1].ToString();
                    cmbTecnico.SelectedValue = rowView.Row[2].ToString();
                    txtSeguimiento.Text = rowView.Row[4].ToString();
                    cmbEstado.Text = rowView.Row[6].ToString();
                    update = true;
                    btnGuardar.Content = "Guardar cambios";
                }
            }
        }
        
        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            //comprobar si la fila es seleccionada
            if (grdSeguimiento.SelectedItem != null)
            {
                ClsLibraryModel clsLibraryModel = new ClsLibraryModel();
                //obtener la fila seleccionada
                DataRowView rowView = grdSeguimiento.SelectedItem as DataRowView;
                //comprobar si el DataRowView que no sea nulo
                if (rowView != null)
                {

                    MessageBoxResult confirmar = MessageBox.Show($"Desea eliminar seguimiento número {rowView.Row[0].ToString()}", "Pregunta", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (confirmar == MessageBoxResult.Yes)
                    {
                        var myList = new List<KeyValuePair<string, string>>();
                        myList.Add(new KeyValuePair<string, string>("@id", rowView.Row[0].ToString()));
                        ClsSeguimientoController clsSeguimientoController = new ClsSeguimientoController();
                        clsSeguimientoController.strDeleteSeguimiento(myList);
                        txtBuscarSeguimiento.Clear();
                        seguimientos();
                        clearData();
                        MessageBox.Show($"Seguimiento {rowView.Row[0].ToString()} del departamento {rowView.Row[3].ToString()} ha sido eliminado", "información", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
        }

        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            clearData();
        }

        private void imgClose_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //cerrar form
            NavigationService?.Navigate(null);
        }

        private void txtBuscarSeguimiento_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (dataTable != null)
            {
                CultureInfo culture = CultureInfo.CurrentCulture;

                filteredTable = dataTable.Clone();
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row["ticket"].ToString().ToUpperInvariant().Contains(txtBuscarSeguimiento.Text.Trim().ToUpperInvariant()) ||
                        row["nombres"].ToString().ToUpperInvariant().Contains(txtBuscarSeguimiento.Text.Trim().ToUpperInvariant()) ||
                        row["seguimiento"].ToString().ToUpperInvariant().Contains(txtBuscarSeguimiento.Text.Trim().ToUpperInvariant()) ||
                        row["especialidad"].ToString().ToUpperInvariant().Contains(txtBuscarSeguimiento.Text.Trim().ToUpperInvariant()) ||
                        row["estado"].ToString().ToUpperInvariant().Contains(txtBuscarSeguimiento.Text.Trim().ToUpperInvariant())
                        )
                    {
                        filteredTable.ImportRow(row);
                    }
                }
                // Limitar el número de filas que se mostrarán en el DataGridView
                int maxRowsToShow = 30;//Cambia este valor según tus necesidades
                if (filteredTable.Rows.Count > 0)
                {
                    var rowsToShow = filteredTable.AsEnumerable().Take(maxRowsToShow).CopyToDataTable();
                    //Asignar el DataTable filtrado y limitado al DataGridView
                    grdSeguimiento.ItemsSource = rowsToShow.DefaultView;
                }
                else
                {
                    filteredTable.Clear();
                    grdSeguimiento.ItemsSource = filteredTable.DefaultView;
                }
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            clearData();
        }
    }
}
