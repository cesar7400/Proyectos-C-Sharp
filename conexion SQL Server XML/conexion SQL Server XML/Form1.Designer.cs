namespace conexion_SQL_Server_XML
{
    partial class FrmConexionXMLSqlServer
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCnString = new System.Windows.Forms.TextBox();
            this.txtNameApp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXmlSqlServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la cadena de conexion LOCAL";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(595, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Una vez que estes listo dale a \"Generar cadena de conexion\", se creara un Archivo" +
    " que contendra, tu conexion Encryptada. Ahora tu conexion es mas Segura ante Pos" +
    "ibles hackers";
            // 
            // txtCnString
            // 
            this.txtCnString.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnString.Location = new System.Drawing.Point(21, 89);
            this.txtCnString.Name = "txtCnString";
            this.txtCnString.Size = new System.Drawing.Size(592, 26);
            this.txtCnString.TabIndex = 2;
            // 
            // txtNameApp
            // 
            this.txtNameApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameApp.Location = new System.Drawing.Point(21, 164);
            this.txtNameApp.Name = "txtNameApp";
            this.txtNameApp.Size = new System.Drawing.Size(592, 26);
            this.txtNameApp.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingrese nombre aplicación ";
            // 
            // btnXmlSqlServer
            // 
            this.btnXmlSqlServer.Location = new System.Drawing.Point(21, 196);
            this.btnXmlSqlServer.Name = "btnXmlSqlServer";
            this.btnXmlSqlServer.Size = new System.Drawing.Size(232, 45);
            this.btnXmlSqlServer.TabIndex = 5;
            this.btnXmlSqlServer.Text = "Generar archivo XML de conexión";
            this.btnXmlSqlServer.UseVisualStyleBackColor = true;
            this.btnXmlSqlServer.Click += new System.EventHandler(this.btnXmlSqlServer_Click);
            // 
            // FrmConexionXMLSqlServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 249);
            this.Controls.Add(this.btnXmlSqlServer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNameApp);
            this.Controls.Add(this.txtCnString);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmConexionXMLSqlServer";
            this.Text = "conexion SQL Server XML";
            this.Load += new System.EventHandler(this.FrmConexionXMLSqlServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCnString;
        private System.Windows.Forms.TextBox txtNameApp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXmlSqlServer;
    }
}

