using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rango_fecha_hora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void CalcularFechas()
        {
            // Obtenemos las fechas en formato DATE
            DateTime fechainicio = DtpFechaInicio.Value.Date;
            DateTime fechaFinal = DtpFechaFinal.Value.Date;

            // Calculamos la diferencia de dias entre las 2 fechas
            LblCantidadDias.Text = (fechaFinal - fechainicio).Days.ToString();

            // Calculamos la diferencia de meses entre las 2 fechas
            LblCantidadMeses.Text = ((fechaFinal.Year - fechainicio.Year) * 12 + fechaFinal.Month - fechainicio.Month).ToString();

            // Calculamos la diferencia de años entre las 2 fechas
            LblCantidadAños.Text = (fechaFinal.Year - fechainicio.Year).ToString();

            // Calculamos la fecha inicio sumando los dias indicados
            LblSumaDias.Text = fechainicio.AddDays((double)NudFechaInicio.Value).ToShortDateString();

            // Calculamos la fecha final restando los dias indicados
            LblRestaDias.Text = fechaFinal.AddDays(-(double)NudFechaFinal.Value).ToShortDateString();
        }
        public void CalcularHoras()
        {
            // Obtenemos las horas en formato DateTime
            DateTime HoraInicio = DtpHoraInicio.Value;
            DateTime HoraFinal = DtpHoraFinal.Value;

            // Calculamos la diferencia de horas entre las 2 horas
            LblCantidadHoras.Text = ((int)(HoraFinal - HoraInicio).TotalHours).ToString();

            // Calculamos la diferencia de minutos entre las 2 horas
            LblCantidadMinutos.Text = ((int)(HoraFinal - HoraInicio).TotalMinutes).ToString();

            // Calculamos la diferencia de segundos entre las 2 horas
            LblCantidadSegundos.Text = ((int)(HoraFinal - HoraInicio).TotalSeconds).ToString();

            // Calculamos la hora inicio sumando los minutos indicados
            LblSumaMinutos.Text = HoraInicio.AddMinutes((double)NudHoraInicio.Value).ToString(@"hh\:mm");

            // Calculamos la hora final restando los minutos indicados
            LblRestaMinutos.Text = HoraFinal.AddMinutes(-((double)NudHoraFinal.Value)).ToString(@"hh\:mm");
        }
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            CalcularFechas();
            CalcularHoras();
        }
    }
}
