using System;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml;

namespace conexion_SQL_Server_XML
{
    public partial class FrmConexionXMLSqlServer : Form
    {
        public FrmConexionXMLSqlServer()
        {
            InitializeComponent();
        }
        string dbcnString = "";
        //Data Source=DESKTOP-R0VLPAL\SqlExpress;Initial Catalog=BDfactory;Integrated Security=True
        public void SavetoXML(string dbcnString)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("ConnectionString.xml");
            XmlElement xmlelm = xml.DocumentElement;
            xmlelm.Attributes.Item(0).Value = dbcnString;
            XmlTextWriter write = new XmlTextWriter("ConnectionString.xml", null);
            write.Formatting = Formatting.Indented;
            xml.Save(write);
            write.Close();
        }
        public void ReadfromXML()
        {
            try
            {
                Properties.Settings ca = new Properties.Settings();
                txtNameApp.Text = ca.nameAplication;
                XmlDocument xml = new XmlDocument();
                xml.Load("ConnectionString.xml");
                XmlElement xmlelm = xml.DocumentElement;
                dbcnString = xmlelm.Attributes.Item(0).Value;
                Desencryptacion desc = new Desencryptacion();
                Encryptacion ecn = new Encryptacion();
                txtCnString.Text = ecn.Decrypt(dbcnString, desc.NameApp = ca.nameAplication, int.Parse("256"));
            }
            catch (CryptographicException ex)
            {

                MessageBox.Show($"error, {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmConexionXMLSqlServer_Load(object sender, EventArgs e)
        {
            ReadfromXML();
        }

        private void btnXmlSqlServer_Click(object sender, EventArgs e)
        {
            Properties.Settings ca = new Properties.Settings();
            ca.nameAplication = txtNameApp.Text.Trim();
            ca.Save();
            Encryptacion ecn = new Encryptacion();
            Desencryptacion desc = new Desencryptacion();
            SavetoXML(ecn.Encrypt(txtCnString.Text.Trim(), desc.NameApp = txtNameApp.Text.Trim(), int.Parse("256")));
        }
    }
}
