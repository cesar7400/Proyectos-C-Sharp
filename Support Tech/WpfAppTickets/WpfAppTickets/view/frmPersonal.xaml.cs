using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using WpfAppTickets.controller;
using WpfAppTickets.model;

namespace WpfAppTickets.view
{
    /// <summary>
    /// Lógica de interacción para frmUsers.xaml
    /// </summary>
    public partial class frmPersonal : Page
    {
        private DataTable dataTable; //La fuente de datos original
        private DataTable filteredTable; //La tabla filtrada por busquedad
        private bool update;
        private string idUser = "";
        List<KeyValuePair<string, string>> listUpdate = new List<KeyValuePair<string, string>>();
        public frmPersonal()
        {
            InitializeComponent();
        }

        private void usuarios()
        {
            ClsPersonalController clsPersonalController = new ClsPersonalController();
            var listUsuarios = clsPersonalController.DataTablePersonal();
            dataTable = listUsuarios;
            //Limitar el número de filas que se mostrarán en el DataGridView
            //Cambia este valor según tus necesidades
            int maxRowsToShow = 30;
            if (dataTable.Rows.Count > 0)
            {
                var rowsToShow = dataTable.AsEnumerable().Take(maxRowsToShow).CopyToDataTable();
                // Asignar el DataTable filtrado y limitado al DataGridView
                grdUsuarios.ItemsSource = rowsToShow.DefaultView;
                grdUsuarios.CanUserSortColumns = false;
            }
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            usuarios();
        }
        private bool validarDatosUsuario(List<KeyValuePair<string, string>> datalist)
        {
            ClsPersonalController clsPersonalController = new ClsPersonalController();
            foreach (var item in datalist)
            {
                var val = clsPersonalController.dataExist(item.Key, item.Value).Length;
                if (item.Key == "@documento" && val > 0)
                {
                    MessageBox.Show("El número de docuemto " + item.Value + " se encuentra registrado con otro usuario", "Mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                    txtDocumento.Focus();
                    return false;
                }
                else if (item.Key == "@mail" && val > 0)
                {
                    MessageBox.Show("El email " + item.Value + " se encuentra registrado con otro usuario", "Mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                    txtEmail.Focus();
                    return false;
                }
            }
            return true;
        }
        private void guardar()
        {
            if (txtNombres.Text == string.Empty)
            {
                MessageBox.Show("Ingresar nombre(s)", "Mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                txtNombres.Focus();
                return;
            }
            else if (txtApellidos.Text == string.Empty)
            {
                MessageBox.Show("Ingresar apellidos(s)", "Mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                txtApellidos.Focus();
                return;
            }
            else if (txtEspecialidad.Text == string.Empty)
            {
                MessageBox.Show("Ingresar especialidad", "Mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                txtEspecialidad.Focus();
                return;
            }
            else if (dpFechIngreso.Text == string.Empty)
            {
                MessageBox.Show("Ingresar fecha ingreso", "Mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                dpFechIngreso.Focus();
                return;
            }
            else if (txtHorario.Text == string.Empty)
            {
                MessageBox.Show("Ingresar horario", "Mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                txtHorario.Focus();
                return;
            }
            else if (txtDocumento.Text == string.Empty)
            {
                MessageBox.Show("Ingresar documento", "Mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                txtDocumento.Focus();
                return;
            }
            else if (txtEmail.Text == string.Empty)
            {
                MessageBox.Show("Ingresar email", "Mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                txtEmail.Focus();
                return;
            }
            else if (txtWhatsApp.Text == string.Empty)
            {
                MessageBox.Show("Ingresar número WhatsApp", "Mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                txtWhatsApp.Focus();
                return;
            }
            else
            {

                ClsPersonalController clsPersonalController = new ClsPersonalController();
                ClsLibraryModel clsLibraryModel = new ClsLibraryModel();
                var myList = new List<KeyValuePair<string, string>>();

                myList.Add(new KeyValuePair<string, string>("@nombre", txtNombres.Text.Trim()));
                myList.Add(new KeyValuePair<string, string>("@apellidos", txtApellidos.Text.Trim()));
                myList.Add(new KeyValuePair<string, string>("@especialidad", txtEspecialidad.Text.Trim()));
                myList.Add(new KeyValuePair<string, string>("@fechaIngreso", dpFechIngreso.SelectedDate.Value.ToString("yyyy-MM-dd")));
                myList.Add(new KeyValuePair<string, string>("@horario", txtHorario.Text.Trim()));
                myList.Add(new KeyValuePair<string, string>("@documento", txtDocumento.Text.Trim()));
                myList.Add(new KeyValuePair<string, string>("@mail", txtEmail.Text.Trim().ToLower()));
                myList.Add(new KeyValuePair<string, string>("@whatsapp", Regex.Replace(txtWhatsApp.Text.Trim(), @"[\(\)\-\ ]", "")));
                myList.Add(new KeyValuePair<string, string>("@estado", chkActivo.IsChecked == true ? "1" : "0"));

                var datalistValidate = new List<KeyValuePair<string, string>>()
                {
                    new KeyValuePair<string, string>("@documento", txtDocumento.Text.Trim()),
                    new KeyValuePair<string, string>("@mail", txtEmail.Text.Trim().ToLower()),
                };
                if (!update)
                {
                    if (validarDatosUsuario(datalistValidate) && clsPersonalController.strInsertPersonal(myList))
                    {
                        clearData();
                        usuarios();
                        MessageBox.Show("Usuario guardado correctamente", "mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                else
                {
                    if (idUser == "")
                    {
                        MessageBox.Show("seleccionar Usuario", "Mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                        grdUsuarios.Focus();
                        return;
                    }
                    else
                    {
                        List<KeyValuePair<string, string>> strValues = new List<KeyValuePair<string, string>>();
                        foreach (var pair in datalistValidate)
                        {
                            if (!pair.Value.Equals(listUpdate.Find(x => x.Key == pair.Key).Value))
                            {
                                strValues.Add(new KeyValuePair<string, string>(pair.Key, pair.Value));
                            }
                        }
                        if (validarDatosUsuario(strValues) || strValues.Count == 0)
                        {
                            myList.Add(new KeyValuePair<string, string>("@id", idUser));
                            if (clsPersonalController.strUpdatePersonal(myList))
                            {
                                usuarios();
                                idUser = "";
                                update = false;
                                txtBuscarUsuario.Clear();
                                btnGuardar.Content = "Guardar";
                                clearData();
                                MessageBox.Show("Usuario modificado correctamente", "mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                            }
                        }

                    }
                }
            }
        }
        private void clearData()
        {
            txtNombres.Clear();
            txtDocumento.Clear();
            txtApellidos.Clear();
            txtEspecialidad.Clear();
            dpFechIngreso.SelectedDate = null;
            txtHorario.Clear();
            txtDocumento.Clear();
            txtEmail.Clear();
            txtWhatsApp.Clear();
            chkActivo.IsChecked = false;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            guardar();
        }

        private void btnEditUsuario_Click(object sender, RoutedEventArgs e)
        {
            //comprobar si la fila es seleccionada
            if (grdUsuarios.SelectedItem != null)
            {
                ClsLibraryModel clsLibraryModel = new ClsLibraryModel();
                //obtener la fila seleccionada
                DataRowView rowView = grdUsuarios.SelectedItem as DataRowView;
                //comprobar si el DataRowView que no sea nulo
                if (rowView != null)
                {
                    listUpdate.Clear();
                    //obtener el valor de la celda deseada<<la primera columna>>
                    //mostrar valor seleccionado
                    idUser = rowView.Row[0].ToString();
                    txtNombres.Text = rowView.Row[1].ToString();
                    txtApellidos.Text = rowView.Row[2].ToString();
                    txtEspecialidad.Text = rowView.Row[3].ToString();
                    dpFechIngreso.Text = rowView.Row[4].ToString();
                    txtHorario.Text = rowView.Row[5].ToString();
                    txtDocumento.Text = rowView.Row[6].ToString();
                    listUpdate.Add(new KeyValuePair<string, string>("@documento", rowView.Row[6].ToString()));
                    txtEmail.Text = rowView.Row[7].ToString();
                    listUpdate.Add(new KeyValuePair<string, string>("@mail", rowView.Row[7].ToString()));
                    txtWhatsApp.Text = rowView.Row[8].ToString();
                    chkActivo.IsChecked = rowView.Row[9].ToString() == "Activo" ? true : false;
                    update = true;
                    btnGuardar.Content = "Guardar cambios";
                }
            }
        }

        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            idUser = "";
            update = false;
            txtBuscarUsuario.Clear();
            btnGuardar.Content = "Guardar";
            clearData();
        }

        private void txtDocumento_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            //solo acepta numeros
            if (!Regex.IsMatch(e.Text, @"^[0-9\b]+$"))
            {
                // Si no lo es, evitar que se muestre
                e.Handled = true;
            }
        }

        private void txtEmail_LostFocus(object sender, RoutedEventArgs e)
        {
            //validar email correcto
            ClsLibraryModel clsLibrary = new ClsLibraryModel();
            if (!clsLibrary.isValidEmail(txtEmail.Text.Trim()) && !string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Dirección de correo electronico no valida, el correo debe tener el formato: nombre@dominio.com, por favor seleccione un correo valido", "Error de correo electronico", MessageBoxButton.OK, MessageBoxImage.Error);
                txtEmail.SelectAll();
            }
        }

        private void txtWhatsApp_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            //permite solo números y una longitud máxima de 14 (incluidos los caracteres de formato)
            if (!Regex.IsMatch(e.Text, @"^[0-9]*$") || txtWhatsApp.Text.Length >= 14)
            {
                e.Handled = true;
            }
        }

        private void txtWhatsApp_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtWhatsApp.Text))
            { 
                ClsLibraryModel clsLibraryModel = new ClsLibraryModel();
                clsLibraryModel.FormatMask(txtWhatsApp, "000-000-00-00", "+57");
            }
        }

        private void txtBuscarUsuario_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (dataTable != null)
            {
                filteredTable = dataTable.Clone();
                foreach (DataRow row in dataTable.Rows)
                {
                    if (string.Concat(row["Nombre"].ToString(), " ", row["apellidos"].ToString()).ToUpperInvariant().Contains(txtBuscarUsuario.Text.Trim().ToUpperInvariant()) || row["documento"].ToString().ToUpperInvariant().Contains(txtBuscarUsuario.Text.Trim().ToUpperInvariant()) || row["whatsapp"].ToString().ToUpperInvariant().Contains(txtBuscarUsuario.Text.Trim().ToUpperInvariant()))
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
                    grdUsuarios.ItemsSource = rowsToShow.DefaultView;
                }
                else
                {
                    filteredTable.Clear();
                    grdUsuarios.ItemsSource = filteredTable.DefaultView;
                }
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            idUser = "";
            update = false;
            txtBuscarUsuario.Clear();
            btnGuardar.Content = "Guardar";
            clearData();
        }

        private void imgClose_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            //cerrar form
            NavigationService?.Navigate(null);
        }

        private void txtWhatsApp_GotFocus(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtWhatsApp.Text))
            {
                ClsLibraryModel clsLibraryModel = new ClsLibraryModel();
                clsLibraryModel.FormatMask(txtWhatsApp, "0000000000");
            }
        }
    }
}
