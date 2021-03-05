using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlSueldos
{
    class Empleado
    {
        //Para los datos del empleado

        int noEmpleado;
        string nombre;
        float sueldoHora;

        public int NoEmpleado { get => noEmpleado; set => noEmpleado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public float SueldoHora { get => sueldoHora; set => sueldoHora = value; }
    }
}
