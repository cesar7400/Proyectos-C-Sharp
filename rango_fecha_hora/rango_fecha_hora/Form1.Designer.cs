namespace rango_fecha_hora
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DtpHoraFinal = new System.Windows.Forms.DateTimePicker();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.LblRestaMinutos = new System.Windows.Forms.Label();
            this.LblSumaMinutos = new System.Windows.Forms.Label();
            this.LblCantidadSegundos = new System.Windows.Forms.Label();
            this.LblCantidadMinutos = new System.Windows.Forms.Label();
            this.LblCantidadHoras = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.Label21 = new System.Windows.Forms.Label();
            this.Label22 = new System.Windows.Forms.Label();
            this.Label23 = new System.Windows.Forms.Label();
            this.Label24 = new System.Windows.Forms.Label();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.LblRestaDias = new System.Windows.Forms.Label();
            this.LblSumaDias = new System.Windows.Forms.Label();
            this.LblCantidadAños = new System.Windows.Forms.Label();
            this.LblCantidadMeses = new System.Windows.Forms.Label();
            this.LblCantidadDias = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.DtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.NudFechaFinal = new System.Windows.Forms.NumericUpDown();
            this.Label3 = new System.Windows.Forms.Label();
            this.NudFechaInicio = new System.Windows.Forms.NumericUpDown();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.DtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.DtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.Label4 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.NudHoraFinal = new System.Windows.Forms.NumericUpDown();
            this.Label7 = new System.Windows.Forms.Label();
            this.NudHoraInicio = new System.Windows.Forms.NumericUpDown();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.GroupBox3.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudFechaFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudFechaInicio)).BeginInit();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudHoraFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudHoraInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // DtpHoraFinal
            // 
            this.DtpHoraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DtpHoraFinal.Location = new System.Drawing.Point(98, 45);
            this.DtpHoraFinal.Name = "DtpHoraFinal";
            this.DtpHoraFinal.ShowUpDown = true;
            this.DtpHoraFinal.Size = new System.Drawing.Size(96, 20);
            this.DtpHoraFinal.TabIndex = 9;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.GroupBox5);
            this.GroupBox3.Controls.Add(this.GroupBox4);
            this.GroupBox3.Location = new System.Drawing.Point(12, 238);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(556, 163);
            this.GroupBox3.TabIndex = 22;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Resultados";
            // 
            // GroupBox5
            // 
            this.GroupBox5.Controls.Add(this.LblRestaMinutos);
            this.GroupBox5.Controls.Add(this.LblSumaMinutos);
            this.GroupBox5.Controls.Add(this.LblCantidadSegundos);
            this.GroupBox5.Controls.Add(this.LblCantidadMinutos);
            this.GroupBox5.Controls.Add(this.LblCantidadHoras);
            this.GroupBox5.Controls.Add(this.Label20);
            this.GroupBox5.Controls.Add(this.Label21);
            this.GroupBox5.Controls.Add(this.Label22);
            this.GroupBox5.Controls.Add(this.Label23);
            this.GroupBox5.Controls.Add(this.Label24);
            this.GroupBox5.Location = new System.Drawing.Point(280, 19);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new System.Drawing.Size(270, 138);
            this.GroupBox5.TabIndex = 1;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "Resultados de Horas";
            // 
            // LblRestaMinutos
            // 
            this.LblRestaMinutos.Location = new System.Drawing.Point(185, 112);
            this.LblRestaMinutos.Name = "LblRestaMinutos";
            this.LblRestaMinutos.Size = new System.Drawing.Size(73, 13);
            this.LblRestaMinutos.TabIndex = 19;
            this.LblRestaMinutos.Text = "00";
            this.LblRestaMinutos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblSumaMinutos
            // 
            this.LblSumaMinutos.Location = new System.Drawing.Point(182, 91);
            this.LblSumaMinutos.Name = "LblSumaMinutos";
            this.LblSumaMinutos.Size = new System.Drawing.Size(76, 13);
            this.LblSumaMinutos.TabIndex = 18;
            this.LblSumaMinutos.Text = "00";
            this.LblSumaMinutos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCantidadSegundos
            // 
            this.LblCantidadSegundos.Location = new System.Drawing.Point(215, 68);
            this.LblCantidadSegundos.Name = "LblCantidadSegundos";
            this.LblCantidadSegundos.Size = new System.Drawing.Size(43, 13);
            this.LblCantidadSegundos.TabIndex = 17;
            this.LblCantidadSegundos.Text = "00";
            this.LblCantidadSegundos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCantidadMinutos
            // 
            this.LblCantidadMinutos.Location = new System.Drawing.Point(218, 45);
            this.LblCantidadMinutos.Name = "LblCantidadMinutos";
            this.LblCantidadMinutos.Size = new System.Drawing.Size(40, 13);
            this.LblCantidadMinutos.TabIndex = 16;
            this.LblCantidadMinutos.Text = "00";
            this.LblCantidadMinutos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCantidadHoras
            // 
            this.LblCantidadHoras.Location = new System.Drawing.Point(218, 22);
            this.LblCantidadHoras.Name = "LblCantidadHoras";
            this.LblCantidadHoras.Size = new System.Drawing.Size(40, 13);
            this.LblCantidadHoras.TabIndex = 15;
            this.LblCantidadHoras.Text = "00";
            this.LblCantidadHoras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Location = new System.Drawing.Point(12, 112);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(138, 13);
            this.Label20.TabIndex = 14;
            this.Label20.Text = "Hora final restando minutos:";
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Location = new System.Drawing.Point(12, 91);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(145, 13);
            this.Label21.TabIndex = 13;
            this.Label21.Text = "Hora inicio sumando minutos:";
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Location = new System.Drawing.Point(12, 68);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(197, 13);
            this.Label22.TabIndex = 12;
            this.Label22.Text = "Cantidad de segundos entre las 2 horas:";
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Location = new System.Drawing.Point(12, 45);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(187, 13);
            this.Label23.TabIndex = 11;
            this.Label23.Text = "Cantidad de minutos entre las 2 horas:";
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.Location = new System.Drawing.Point(12, 22);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(177, 13);
            this.Label24.TabIndex = 10;
            this.Label24.Text = "Cantidad de horas entre las 2 horas:";
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.LblRestaDias);
            this.GroupBox4.Controls.Add(this.LblSumaDias);
            this.GroupBox4.Controls.Add(this.LblCantidadAños);
            this.GroupBox4.Controls.Add(this.LblCantidadMeses);
            this.GroupBox4.Controls.Add(this.LblCantidadDias);
            this.GroupBox4.Controls.Add(this.Label14);
            this.GroupBox4.Controls.Add(this.Label13);
            this.GroupBox4.Controls.Add(this.Label12);
            this.GroupBox4.Controls.Add(this.Label11);
            this.GroupBox4.Controls.Add(this.Label10);
            this.GroupBox4.Location = new System.Drawing.Point(9, 19);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(265, 138);
            this.GroupBox4.TabIndex = 0;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Resultados de Fechas";
            // 
            // LblRestaDias
            // 
            this.LblRestaDias.Location = new System.Drawing.Point(183, 112);
            this.LblRestaDias.Name = "LblRestaDias";
            this.LblRestaDias.Size = new System.Drawing.Size(70, 13);
            this.LblRestaDias.TabIndex = 9;
            this.LblRestaDias.Text = "00";
            this.LblRestaDias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblSumaDias
            // 
            this.LblSumaDias.Location = new System.Drawing.Point(183, 91);
            this.LblSumaDias.Name = "LblSumaDias";
            this.LblSumaDias.Size = new System.Drawing.Size(70, 13);
            this.LblSumaDias.TabIndex = 8;
            this.LblSumaDias.Text = "00";
            this.LblSumaDias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCantidadAños
            // 
            this.LblCantidadAños.Location = new System.Drawing.Point(206, 68);
            this.LblCantidadAños.Name = "LblCantidadAños";
            this.LblCantidadAños.Size = new System.Drawing.Size(47, 13);
            this.LblCantidadAños.TabIndex = 7;
            this.LblCantidadAños.Text = "00";
            this.LblCantidadAños.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCantidadMeses
            // 
            this.LblCantidadMeses.Location = new System.Drawing.Point(206, 45);
            this.LblCantidadMeses.Name = "LblCantidadMeses";
            this.LblCantidadMeses.Size = new System.Drawing.Size(47, 13);
            this.LblCantidadMeses.TabIndex = 6;
            this.LblCantidadMeses.Text = "00";
            this.LblCantidadMeses.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCantidadDias
            // 
            this.LblCantidadDias.Location = new System.Drawing.Point(206, 22);
            this.LblCantidadDias.Name = "LblCantidadDias";
            this.LblCantidadDias.Size = new System.Drawing.Size(47, 13);
            this.LblCantidadDias.TabIndex = 5;
            this.LblCantidadDias.Text = "00";
            this.LblCantidadDias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(18, 112);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(130, 13);
            this.Label14.TabIndex = 4;
            this.Label14.Text = "Fecha final restando días:";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(18, 91);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(137, 13);
            this.Label13.TabIndex = 3;
            this.Label13.Text = "Fecha inicio sumando días:";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(18, 68);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(180, 13);
            this.Label12.TabIndex = 2;
            this.Label12.Text = "Cantidad de años entre las 2 fechas:";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(18, 45);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(187, 13);
            this.Label11.TabIndex = 1;
            this.Label11.Text = "Cantidad de meses entre las 2 fechas:";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(18, 22);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(178, 13);
            this.Label10.TabIndex = 0;
            this.Label10.Text = "Cantidad de días entre las 2 fechas:";
            // 
            // DtpHoraInicio
            // 
            this.DtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DtpHoraInicio.Location = new System.Drawing.Point(98, 19);
            this.DtpHoraInicio.Name = "DtpHoraInicio";
            this.DtpHoraInicio.ShowUpDown = true;
            this.DtpHoraInicio.Size = new System.Drawing.Size(96, 20);
            this.DtpHoraInicio.TabIndex = 8;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("BtnCalcular.Image")));
            this.BtnCalcular.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCalcular.Location = new System.Drawing.Point(424, 106);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(144, 126);
            this.BtnCalcular.TabIndex = 24;
            this.BtnCalcular.Text = "Calcular fecha";
            this.BtnCalcular.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.NudFechaFinal);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.NudFechaInicio);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.DtpFechaFinal);
            this.GroupBox1.Controls.Add(this.DtpFechaInicio);
            this.GroupBox1.Location = new System.Drawing.Point(12, 106);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(200, 126);
            this.GroupBox1.TabIndex = 20;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Selección de fechas";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(6, 100);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(117, 13);
            this.Label5.TabIndex = 7;
            this.Label5.Text = "Restar días fecha final:";
            // 
            // NudFechaFinal
            // 
            this.NudFechaFinal.Location = new System.Drawing.Point(149, 97);
            this.NudFechaFinal.Name = "NudFechaFinal";
            this.NudFechaFinal.Size = new System.Drawing.Size(45, 20);
            this.NudFechaFinal.TabIndex = 6;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(6, 73);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(128, 13);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "Agregar días fecha inicio:";
            // 
            // NudFechaInicio
            // 
            this.NudFechaInicio.Location = new System.Drawing.Point(149, 71);
            this.NudFechaInicio.Name = "NudFechaInicio";
            this.NudFechaInicio.Size = new System.Drawing.Size(45, 20);
            this.NudFechaInicio.TabIndex = 4;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(6, 51);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(62, 13);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Fecha final:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(6, 25);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(67, 13);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Fecha inicio:";
            // 
            // DtpFechaFinal
            // 
            this.DtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaFinal.Location = new System.Drawing.Point(98, 45);
            this.DtpFechaFinal.Name = "DtpFechaFinal";
            this.DtpFechaFinal.Size = new System.Drawing.Size(96, 20);
            this.DtpFechaFinal.TabIndex = 1;
            // 
            // DtpFechaInicio
            // 
            this.DtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaInicio.Location = new System.Drawing.Point(98, 19);
            this.DtpFechaInicio.Name = "DtpFechaInicio";
            this.DtpFechaInicio.Size = new System.Drawing.Size(96, 20);
            this.DtpFechaInicio.TabIndex = 0;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(143)))), ((int)(((byte)(214)))));
            this.Label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.SystemColors.Control;
            this.Label4.Location = new System.Drawing.Point(0, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(571, 54);
            this.Label4.TabIndex = 19;
            this.Label4.Text = "Suma - Resta de fechas y horas ";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Label6);
            this.GroupBox2.Controls.Add(this.NudHoraFinal);
            this.GroupBox2.Controls.Add(this.Label7);
            this.GroupBox2.Controls.Add(this.NudHoraInicio);
            this.GroupBox2.Controls.Add(this.Label8);
            this.GroupBox2.Controls.Add(this.Label9);
            this.GroupBox2.Controls.Add(this.DtpHoraFinal);
            this.GroupBox2.Controls.Add(this.DtpHoraInicio);
            this.GroupBox2.Location = new System.Drawing.Point(218, 106);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(200, 126);
            this.GroupBox2.TabIndex = 21;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Selección de horas";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(6, 100);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(131, 13);
            this.Label6.TabIndex = 15;
            this.Label6.Text = "Restar restar minutos final:";
            // 
            // NudHoraFinal
            // 
            this.NudHoraFinal.Location = new System.Drawing.Point(149, 97);
            this.NudHoraFinal.Name = "NudHoraFinal";
            this.NudHoraFinal.Size = new System.Drawing.Size(45, 20);
            this.NudHoraFinal.TabIndex = 14;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(6, 73);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(137, 13);
            this.Label7.TabIndex = 13;
            this.Label7.Text = "Agregar minutos hora inicio:";
            // 
            // NudHoraInicio
            // 
            this.NudHoraInicio.Location = new System.Drawing.Point(149, 71);
            this.NudHoraInicio.Name = "NudHoraInicio";
            this.NudHoraInicio.Size = new System.Drawing.Size(45, 20);
            this.NudHoraInicio.TabIndex = 12;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(6, 51);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(55, 13);
            this.Label8.TabIndex = 11;
            this.Label8.Text = "Hora final:";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(6, 25);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(60, 13);
            this.Label9.TabIndex = 10;
            this.Label9.Text = "Hora inicio:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 404);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.GroupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudFechaFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudFechaInicio)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudHoraFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudHoraInicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DateTimePicker DtpHoraFinal;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.GroupBox GroupBox5;
        internal System.Windows.Forms.Label LblRestaMinutos;
        internal System.Windows.Forms.Label LblSumaMinutos;
        internal System.Windows.Forms.Label LblCantidadSegundos;
        internal System.Windows.Forms.Label LblCantidadMinutos;
        internal System.Windows.Forms.Label LblCantidadHoras;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.Label Label23;
        internal System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.Label LblRestaDias;
        internal System.Windows.Forms.Label LblSumaDias;
        internal System.Windows.Forms.Label LblCantidadAños;
        internal System.Windows.Forms.Label LblCantidadMeses;
        internal System.Windows.Forms.Label LblCantidadDias;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.DateTimePicker DtpHoraInicio;
        internal System.Windows.Forms.Button BtnCalcular;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.NumericUpDown NudFechaFinal;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.NumericUpDown NudFechaInicio;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DateTimePicker DtpFechaFinal;
        internal System.Windows.Forms.DateTimePicker DtpFechaInicio;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.NumericUpDown NudHoraFinal;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.NumericUpDown NudHoraInicio;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label9;
    }
}

