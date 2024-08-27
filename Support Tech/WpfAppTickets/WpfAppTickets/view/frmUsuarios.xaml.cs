using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WpfAppTickets.controller;
using WpfAppTickets.model;

namespace WpfAppTickets.view
{
    /// <summary>
    /// Lógica de interacción para frmUsuarios.xaml
    /// </summary>
    public partial class frmUsuarios : Page
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }
        private bool update;
        List<KeyValuePair<string, string>> listUpdate = new List<KeyValuePair<string, string>>();
        private DataTable filteredTable; //La tabla filtrada por busquedad
        private DataTable dataTable; //La fuente de datos original
        
        private void imgClose_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //cerrar form
            NavigationService?.Navigate(null);
        }
        private void frmUsuarios_Loaded(object sender, RoutedEventArgs e)
        {
            usuarios();
            ClsUsuarioController clsUsuarioController = new ClsUsuarioController();
            cmbEmpleado.ItemsSource = clsUsuarioController.DataTableUsuarios().Tables[0].DefaultView;
            this.cmbEmpleado.DisplayMemberPath = "nombres";
            this.cmbEmpleado.SelectedValuePath = "id";

        }
        private void usuarios()
        {
            ClsUsuarioController clsUsuarioController = new ClsUsuarioController();
            var listUsuarios = clsUsuarioController.DataTableUsuarioList();
            dataTable = listUsuarios;
            //Limitar el número de filas que se mostrarán en el DataGridView*/
            //Cambia este valor según tus necesidades
            int maxRowsToShow = 30;
            if (dataTable.Rows.Count > 0)
            {
                var rowsToShow = dataTable.AsEnumerable().Take(maxRowsToShow).CopyToDataTable();
                // Asignar el DataTable filtrado y limitado al DataGridView
                grdUsuarios.ItemsSource = rowsToShow.DefaultView;
                grdUsuarios.CanUserSortColumns = false;
            }

            foreach (DataRowView blockPass in grdUsuarios.Items)
            {
                blockPass.Row[2] = new string(blockPass.Row[2].ToString().Select(c => '•').ToArray());
            }
        }
        private bool validarDatosUsuario(List<KeyValuePair<string, string>> datalist)
        {
            ClsUsuarioController clsUsuariosController = new ClsUsuarioController();
            foreach (var item in datalist)
            {
                var val = clsUsuariosController.dataExistLogin(item.Key, item.Value).Length;
                if (item.Key == "@login" && val > 0)
                {
                    MessageBox.Show("El login " + item.Value + " se encuentra registrado con otro usuario", "Mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                    txtUsuario.Focus();
                    return false;
                }
                else if (item.Key == "@idPersonal" && val > 0)
                {
                    MessageBox.Show($"El usuario seleccionado {cmbEmpleado.DisplayMemberPath} ya se encuentra registrado", "Mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                    txtUsuario.Focus();
                    return false;
                }
            }
            return true;
        }
        private void clearData()
        {
            txtUsuario.Clear();
            txtPass.Clear();
            txtConfirmPass.Clear();
            cmbEmpleado.SelectedIndex = -1;
            cmbNivel.SelectedIndex = -1;
            chkEstado.IsChecked = false;
        }
        private void guardar()
        {
            if (txtUsuario.Text == string.Empty)
            {
                MessageBox.Show("Ingresar usuario", "Mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                txtUsuario.Focus();
                return;
            }
            else if (txtPass.Password == string.Empty)
            {
                MessageBox.Show("Ingresar contraseña", "Mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                txtPass.Focus();
                return;
            }
            else if (txtPass.Password.Length <6 || txtConfirmPass.Password.Length < 6)
            {
                MessageBox.Show("la contraseña minimo debe llevar 6 caracteres", "Mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                txtPass.Focus();
                return;
            }
            else if (txtConfirmPass.Password == string.Empty)
            {
                MessageBox.Show("Ingresar contraseña", "Mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                txtConfirmPass.Focus();
                return;
            }
            else if (txtPass.Password != txtConfirmPass.Password)
            {
                MessageBox.Show("la contraseña no coincide", "Mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                txtPass.Focus();
                return;
            }
            else if (cmbEmpleado.Text == string.Empty || cmbEmpleado.SelectedValue == null)
            {
                MessageBox.Show("seleccionar empleado", "Mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                cmbEmpleado.Focus();
                return;
            }
            else if (cmbNivel.Text == string.Empty)
            {
                MessageBox.Show("Seleccionar nivel", "Mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                cmbNivel.Focus();
                return;
            }
            else
            {

                ClsUsuarioController clsUsuarioController = new ClsUsuarioController();
                ClsLibraryModel clsLibraryModel = new ClsLibraryModel();
                var myList = new List<KeyValuePair<string, string>>();

                myList.Add(new KeyValuePair<string, string>("@login", txtUsuario.Text.Trim().ToLower()));
                myList.Add(new KeyValuePair<string, string>("@pass", clsLibraryModel.Encrypt(txtConfirmPass.Password.Trim())));
                myList.Add(new KeyValuePair<string, string>("@nivel", cmbNivel.Text.Trim()));
                myList.Add(new KeyValuePair<string, string>("@estado", chkEstado.IsChecked == true ? "1" : "0"));
                myList.Add(new KeyValuePair<string, string>("@idPersonal", cmbEmpleado.SelectedValue.ToString()));

                var datalistValidate = new List<KeyValuePair<string, string>>()
                {
                    new KeyValuePair<string, string>("@login", txtUsuario.Text.Trim()),
                    new KeyValuePair<string, string>("@idPersonal", cmbEmpleado.SelectedValue.ToString())
                };
                if (!update)
                {
                    if (validarDatosUsuario(datalistValidate) && clsUsuarioController.strInsertUsuario(myList))
                    {
                        clearData();
                        usuarios();
                        MessageBox.Show("Usuario guardado correctamente", "mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                else
                {
                    if (cmbEmpleado.SelectedIndex == -1)
                    {
                        MessageBox.Show("seleccionar Usuario", "Mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                        grdUsuarios.Focus();
                        return;
                    }
                    else
                    {
                        datalistValidate.RemoveAt(1);
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
                            if (clsUsuarioController.strUpdateUsuario(myList))
                            {
                                usuarios();
                                update = false;
                                cmbEmpleado.IsEnabled = true;
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

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            guardar();
        }

        private void btnVerContraseña_Click(object sender, RoutedEventArgs e)
        {
            ConfigurarColumnaContraseña();
        }

        private void ConfigurarColumnaContraseña()
        {
            //obtiene la fila seleccionada en el DataGrid
            var filaSeleccionada = grdUsuarios.SelectedItem as DataRowView;
            if (filaSeleccionada != null)
            {
                //obtiene el valor de la celda en la columna específica
                var valorCelda = filaSeleccionada[2];

                string val = new string(valorCelda.ToString().Select(c => '•').ToArray());
                if(valorCelda.ToString() != val)
                {
                    filaSeleccionada[2] = new string(valorCelda.ToString().Select(c => '•').ToArray());
                }
                else
                {
                    filaSeleccionada[2] = dataTable.Rows[grdUsuarios.SelectedIndex][2];//obtiene el valor de la celda de datatable
                }
            }
        }

        private void btnSeleccionar_Click(object sender, RoutedEventArgs e)
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
                    txtUsuario.Text = rowView.Row[1].ToString();
                    listUpdate.Add(new KeyValuePair<string, string>("@login", rowView.Row[1].ToString()));
                    txtPass.Password = rowView.Row[2].ToString();
                    txtConfirmPass.Password = rowView.Row[2].ToString();
                    cmbEmpleado.SelectedValue = rowView.Row[6].ToString();
                    cmbEmpleado.IsEnabled = false;
                    cmbNivel.Text = rowView.Row[4].ToString();
                    chkEstado.IsChecked = rowView.Row[5].ToString() == "Activo" ? true : false;
                    update = true;
                    btnGuardar.Content = "Guardar cambios";
                }
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            clearData();
            update = false;
            cmbEmpleado.SelectedIndex = -1;
            cmbNivel.SelectedIndex = -1;
            txtBuscarUsuario.Clear();
            btnGuardar.Content = "Guardar";
        }

        private void txtBuscarUsuario_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (dataTable != null)
            {
                filteredTable = dataTable.Clone();
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row["nombres"].ToString().ToUpperInvariant().Contains(txtBuscarUsuario.Text.Trim().ToUpperInvariant()) || row["login"].ToString().ToUpperInvariant().Contains(txtBuscarUsuario.Text.Trim().ToUpperInvariant()) || row["estado"].ToString().ToUpperInvariant().Contains(txtBuscarUsuario.Text.Trim().ToUpperInvariant()))
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
                foreach (DataRowView blockPass in grdUsuarios.Items)
                {
                    blockPass.Row[2] = new string(blockPass.Row[2].ToString().Select(c => '•').ToArray()); ;
                }
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            clearData();
            update = false;
            cmbEmpleado.SelectedIndex = -1;
            cmbNivel.SelectedIndex = -1;
            txtBuscarUsuario.Clear();
            txtBuscarUsuario.Focus();
            btnGuardar.Content = "Guardar";
        }
    }
}
