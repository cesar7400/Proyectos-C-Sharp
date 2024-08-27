using System.Windows.Controls;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;
using WpfAppTickets.controller;
using WpfAppTickets.model;
using System.Data;
using System.Linq;

namespace WpfAppTickets.view
{
    /// <summary>
    /// Lógica de interacción para frmTicket.xaml
    /// </summary>
    public partial class frmTicket : Page
    {
        public frmTicket()
        {
            InitializeComponent();
        }
        frmMain frmMain = new frmMain();
        private bool update;
        private string idTicket = "";
        private DataTable dataTable; //La fuente de datos original
        private DataTable filteredTable; //La tabla filtrada por busquedad

        private void clearData()
        {
            cmbArea.SelectedIndex = -1;
            txtDepartamento.Clear();
            txtAsunto.Clear();
            txtDescripcion.Clear();
            txtPrioridad.Clear();
            txtPuesto.Clear();
            cmbNivel.SelectedIndex = -1;
            txtWhastapp.Clear();
            dpFechaTicket.SelectedDate = null;
            txtSucursal.Clear();
            txtComentarios.Clear();
            btnGuardar.Content = "Guardar";
            update = false;
            idTicket = "";
        }
        private void areas()
        {
            ClsTicketController clsTicketController = new ClsTicketController();
            cmbArea.ItemsSource = clsTicketController.dataSetListArea().Tables[0].DefaultView;
            this.cmbArea.DisplayMemberPath = "descripcion";
            this.cmbArea.SelectedValuePath = "id";
        }
        private void ticket()
        {
            var idTicket = new List<KeyValuePair<string, string>>();
            idTicket.Add(new KeyValuePair<string, string>("@idUsuario", frmMain.Id));
            ClsTicketController clsTicketController = new ClsTicketController();
            var listTicket = clsTicketController.DataTableTicket(idTicket);
            dataTable = listTicket;
            //Limitar el número de filas que se mostrarán en el DataGridView*/
            //Cambia este valor según tus necesidades
            int maxRowsToShow = 30;
            if (dataTable.Rows.Count > 0)
            {
                var rowsToShow = dataTable.AsEnumerable().Take(maxRowsToShow).CopyToDataTable();
                // Asignar el DataTable filtrado y limitado al DataGridView
                grdTicket.ItemsSource = rowsToShow.DefaultView;
                grdTicket.CanUserSortColumns = false;
            }
        }
        private void guardar()
        {
            if (cmbArea.Text == string.Empty || cmbArea.SelectedValue == null)
            {
                MessageBox.Show("seleccionar area", "Mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                cmbArea.Focus();
                return;
            }
            else if (txtDepartamento.Text == string.Empty)
            {
                MessageBox.Show("Ingresar departamento", "Mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                txtDepartamento.Focus();
                return;
            }
            else if (txtDescripcion.Text == string.Empty)
            {
                MessageBox.Show("Ingresar descripción", "Mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                txtDescripcion.Focus();
                return;
            }
            else if (txtPrioridad.Text == string.Empty)
            {
                MessageBox.Show("Ingresar prioridad", "Mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                txtPrioridad.Focus();
                return;
            }
            else if (cmbNivel.Text == string.Empty || cmbNivel.SelectedValue == null)
            {
                MessageBox.Show("seleccionar nivel", "Mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                cmbNivel.Focus();
                return;
            }
            else if (txtWhastapp.Text == string.Empty)
            {
                MessageBox.Show("Ingresar WhastApp", "Mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                txtWhastapp.Focus();
                return;
            }
            else if (dpFechaTicket.Text == string.Empty)
            {
                MessageBox.Show("Ingresar fecha", "Mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                dpFechaTicket.Focus();
                return;
            }
            else
            {
                ClsTicketController clsTicketController = new ClsTicketController();
                var myList = new List<KeyValuePair<string, string>>();

                myList.Add(new KeyValuePair<string, string>("@idArea", cmbArea.SelectedValue.ToString()));
                myList.Add(new KeyValuePair<string, string>("@departamento", txtDepartamento.Text.Trim()));
                myList.Add(new KeyValuePair<string, string>("@asunto", txtAsunto.Text.Trim()));
                myList.Add(new KeyValuePair<string, string>("@descripcion", txtDescripcion.Text.Trim()));
                myList.Add(new KeyValuePair<string, string>("@prioridad", txtPrioridad.Text.Trim()));
                myList.Add(new KeyValuePair<string, string>("@puesto", txtPuesto.Text.Trim()));
                myList.Add(new KeyValuePair<string, string>("@nivel", cmbNivel.Text.ToString()));
                myList.Add(new KeyValuePair<string, string>("@whastapp", Regex.Replace(txtWhastapp.Text.Trim(), @"[\(\)\-\ ]", "")));
                myList.Add(new KeyValuePair<string, string>("@fecha", dpFechaTicket.SelectedDate.Value.ToString("dd-MM-yyyy")));
                myList.Add(new KeyValuePair<string, string>("@comentarios", txtComentarios.Text.Trim()));
                myList.Add(new KeyValuePair<string, string>("@sucursal", txtSucursal.Text.Trim()));
                myList.Add(new KeyValuePair<string, string>("@idUsuario", frmMain.Id));

                if (!update)
                {
                    if (clsTicketController.strInsertTicket(myList))
                    {
                        clearData();
                        ticket();
                        MessageBox.Show("Ticket guardado correctamente", "mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                else
                {
                    if(idTicket == "")
                    {
                        MessageBox.Show("seleccionar ticket", "Mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                        grdTicket.Focus();
                        return;
                    }
                    else
                    {
                        myList.Add(new KeyValuePair<string, string>("@id", idTicket));
                        if (clsTicketController.strUpdateTicket(myList))
                        {
                            ticket();
                            update = false;
                            txtBuscarTicket.Clear();
                            clearData();
                            MessageBox.Show("Ticket modificado correctamente", "mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }
                }
            }
        }

        private void txtWhastapp_GotFocus(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtWhastapp.Text))
            {
                ClsLibraryModel clsLibraryModel = new ClsLibraryModel();
                clsLibraryModel.FormatMask(txtWhastapp, "0000000000");
            }
        }

        private void txtWhastapp_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtWhastapp.Text))
            {
                ClsLibraryModel clsLibraryModel = new ClsLibraryModel();
                clsLibraryModel.FormatMask(txtWhastapp, "000-000-00-00", "+57");
            }
        }

        private void txtWhastapp_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //permite solo números y una longitud máxima de 14 (incluidos los caracteres de formato)
            if (!Regex.IsMatch(e.Text, @"^[0-9]*$") || txtWhastapp.Text.Length >= 14)
            {
                e.Handled = true;
            }
        }

        private void imgClose_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //cerrar form
            NavigationService?.Navigate(null);
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            guardar();
        }

        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            clearData();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            areas();
            ticket();
        }

        private void btnSeleccionar_Click(object sender, RoutedEventArgs e)
        {
            //comprobar si la fila es seleccionada
            if (grdTicket.SelectedItem != null)
            {
                ClsLibraryModel clsLibraryModel = new ClsLibraryModel();
                //obtener la fila seleccionada
                DataRowView rowView = grdTicket.SelectedItem as DataRowView;
                //comprobar si el DataRowView que no sea nulo
                if (rowView != null)
                {
                    //obtener el valor de la celda deseada<<la primera columna>>
                    //mostrar valor seleccionado
                    idTicket = rowView.Row[0].ToString();
                    cmbArea.SelectedValue = rowView.Row[1].ToString();
                    txtDepartamento.Text = rowView.Row[3].ToString();
                    txtAsunto.Text = rowView.Row[4].ToString();
                    txtDescripcion.Text = rowView.Row[5].ToString();
                    txtPrioridad.Text = rowView.Row[6].ToString();
                    txtPuesto.Text = rowView.Row[7].ToString();
                    cmbNivel.Text = rowView.Row[8].ToString();
                    txtWhastapp.Text = rowView.Row[9].ToString();
                    dpFechaTicket.Text = rowView.Row[10].ToString();
                    txtSucursal.Text = rowView.Row[12].ToString();
                    txtComentarios.Text = rowView.Row[11].ToString();
                    update = true;
                    btnGuardar.Content = "Guardar cambios";
                }
            }
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            //comprobar si la fila es seleccionada
            if (grdTicket.SelectedItem != null)
            {
                ClsLibraryModel clsLibraryModel = new ClsLibraryModel();
                //obtener la fila seleccionada
                DataRowView rowView = grdTicket.SelectedItem as DataRowView;
                //comprobar si el DataRowView que no sea nulo
                if (rowView != null)
                {
                    
                    MessageBoxResult confirmar = MessageBox.Show($"Desea eliminar ticket número {rowView.Row[0].ToString()} del departamento {rowView.Row[3].ToString()}", "Pregunta", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if(confirmar == MessageBoxResult.Yes)
                    {
                        var myList = new List<KeyValuePair<string, string>>();
                        myList.Add(new KeyValuePair<string, string>("@id", rowView.Row[0].ToString()));
                        ClsTicketController clsTicketController = new ClsTicketController();
                        clsTicketController.strDeleteTicket(myList);
                        txtBuscarTicket.Clear();
                        ticket();
                        clearData();
                        MessageBox.Show($"Ticket número {rowView.Row[0].ToString()} del departamento {rowView.Row[3].ToString()} ha sido eliminado","información",MessageBoxButton.OK,MessageBoxImage.Information);
                    }
                }
            }
        }

        private void txtBuscarTicket_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (dataTable != null)
            {
                filteredTable = dataTable.Clone();
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row["descripcion"].ToString().ToUpperInvariant().Contains(txtBuscarTicket.Text.Trim().ToUpperInvariant()) || 
                        row["departamento"].ToString().ToUpperInvariant().Contains(txtBuscarTicket.Text.Trim().ToUpperInvariant()) ||
                        row["asunto"].ToString().ToUpperInvariant().Contains(txtBuscarTicket.Text.Trim().ToUpperInvariant()) ||
                        row["ticketDescripcion"].ToString().ToUpperInvariant().Contains(txtBuscarTicket.Text.Trim().ToUpperInvariant()) ||
                        row["prioridad"].ToString().ToUpperInvariant().Contains(txtBuscarTicket.Text.Trim().ToUpperInvariant()) ||
                        row["puesto"].ToString().ToUpperInvariant().Contains(txtBuscarTicket.Text.Trim().ToUpperInvariant()) ||
                        row["nivel"].ToString().ToUpperInvariant().Contains(txtBuscarTicket.Text.Trim().ToUpperInvariant()) ||
                        row["whatsapp"].ToString().ToUpperInvariant().Contains(txtBuscarTicket.Text.Trim().ToUpperInvariant()) ||
                        row["fecha"].ToString().ToUpperInvariant().Contains(txtBuscarTicket.Text.Trim().ToUpperInvariant()) ||
                        row["comentarios"].ToString().ToUpperInvariant().Contains(txtBuscarTicket.Text.Trim().ToUpperInvariant()) ||
                        row["sucursal"].ToString().ToUpperInvariant().Contains(txtBuscarTicket.Text.Trim().ToUpperInvariant()) ||
                        row["descripcionArea"].ToString().ToUpperInvariant().Contains(txtBuscarTicket.Text.Trim().ToUpperInvariant())

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
                    grdTicket.ItemsSource = rowsToShow.DefaultView;
                }
                else
                {
                    filteredTable.Clear();
                    grdTicket.ItemsSource = filteredTable.DefaultView;
                }
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            clearData();
            txtBuscarTicket.Clear();
        }
    }
}
