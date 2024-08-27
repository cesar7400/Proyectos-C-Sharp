using System.Xml;

namespace conexion_SQL_Server_XML
{
    public class Desencryptacion
    {
        private string dbcnString = "";
        private string CnString = "";
        //public string appPwdUnique = "admin_system";
        private string nameApp = "";

        public string DbCnString
        {
            get { return dbcnString; }
            set { dbcnString = value; }
        }
        public string Cnstr
        {
            get { return CnString; }
            set { CnString = value; }
        }
        public string NameApp
        {
            get { return nameApp; }
            set { nameApp = value; }
        }
        public object checkServer()
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("ConnectionString.xml");
            XmlElement root = xml.DocumentElement;
            dbcnString = root.Attributes.Item(0).Value;
            Encryptacion ecn = new Encryptacion();
            CnString = ecn.Decrypt(dbcnString, nameApp, int.Parse("256"));
            return CnString;
        }
    }
}
