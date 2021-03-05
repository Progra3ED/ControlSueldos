using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlSueldos
{
    class EmpleadoSueldo
    {
        //Esta clase va servir para vincular las otras dos de forma más fácil
        //Esta clase va a contener los datos que necesitamos mostrar en el reporte

        //El numero de empleado es por medio del cual vincularemos las otras dos clases
        int noEmpleado;
        //Necesitamos desplegar el nombre del empleado
        string nombreEmpleado;
        //Guardará el sueldo que se va a calcular del sueldoHora x horasMes
        float sueldoMes;
        //Necesitamos desplegar el mes que se está pagando
        string mes;

        public int NoEmpleado { get => noEmpleado; set => noEmpleado = value; }
        public string NombreEmpleado { get => nombreEmpleado; set => nombreEmpleado = value; }
        public float SueldoMes { get => sueldoMes; set => sueldoMes = value; }
        public string Mes { get => mes; set => mes = value; }
    }
}
