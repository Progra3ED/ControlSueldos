using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlSueldos
{
    class Asistencia
    {
        //Lleva el control de las horas trabajadas de cada empleado cada mes
        int noEmpleado;
        int horasMes;
        string mes;

        public int NoEmpleado { get => noEmpleado; set => noEmpleado = value; }
        public int HorasMes { get => horasMes; set => horasMes = value; }
        public string Mes { get => mes; set => mes = value; }
    }
}
