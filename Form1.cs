using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlSueldos
{
    public partial class Form1 : Form
    {
        List<Empleado> empleados = new List<Empleado>();
        List<Asistencia> asistencias = new List<Asistencia>();


        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
           
              

            FileStream stream = new FileStream("empleado.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
                
            while (reader.Peek() > -1)                
            {
                //Declaramos un objeto empleado de la clase Empleado
                //para ingresarle los datos leidos del archivo
                //y luego guardar el empleado en la lista empleados
                Empleado empleado = new Empleado();
                empleado.NoEmpleado = Convert.ToInt32 (reader.ReadLine());
                empleado.Nombre = reader.ReadLine();
                empleado.SueldoHora = float.Parse(reader.ReadLine());

            empleados.Add(empleado);

            }            
            reader.Close();

            FileStream stream2 = new FileStream("asistencia.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader2 = new StreamReader(stream2);

            while (reader2.Peek() > -1)
            {
                //Declaramos un objeto asistencia de la clase Asistencia
                //para ingresarle los datos leidos del archivo
                //y luego guardar las asitencia en la lista asistencias
                Asistencia asistencia = new Asistencia();

                asistencia.NoEmpleado = Convert.ToInt32(reader2.ReadLine());
                asistencia.HorasMes = Convert.ToInt32(reader2.ReadLine());
                asistencia.Mes = reader2.ReadLine();

                asistencias.Add(asistencia);
            }            
            reader2.Close();

            //Desplegar en los gridviews

            dataGridViewEmpleado.DataSource = null;
            dataGridViewEmpleado.DataSource = empleados;
            dataGridViewEmpleado.Refresh();

            dataGridViewAsistencia.DataSource = null;
            dataGridViewAsistencia.DataSource = asistencias;
            dataGridViewAsistencia.Refresh();

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            //Como el calculo de sueldo solo se usaran en este botón 
            //la lista de EmpleadoSueldo se puede declara localmente
            List<EmpleadoSueldo> empleadoSueldos = new List<EmpleadoSueldo>();


            //Un ciclo para recorrer la lista de empleados
            for (int i = 0; i < empleados.Count; i++)
            {            
                //Por cada empleado que se recorre
                //se recorre la lista de asistencias para buscar sus asistencias
                for (int j = 0; j < asistencias.Count; j++)
                {
                    //ver si el numero del empleado es igual al 
                    //numero del empleado en la asistencia                    
                    if (empleados[i].NoEmpleado == asistencias[j].NoEmpleado)
                    {
                        //creamos un objeto empleadoSueldo de la clase Empleadosueldo
                        //para guardar los datos del sueldo e irlos metiendo a una lista
                        EmpleadoSueldo empleadoSueldo = new EmpleadoSueldo();
                        //guardamos el número de empleado
                        empleadoSueldo.NoEmpleado = empleados[i].NoEmpleado;
                        //guardamos el nombre del empleado
                        empleadoSueldo.NombreEmpleado = empleados[i].Nombre;
                        //calculamos el sueldo correspondiente
                        //el sueldo por hora en empleado x las horas trabajadas en la asistencia
                        empleadoSueldo.SueldoMes = empleados[i].SueldoHora * asistencias[j].HorasMes;
                        empleadoSueldo.Mes = asistencias[j].Mes;

                        //Guardamos en la lista 
                        empleadoSueldos.Add(empleadoSueldo);
                    }
                }
            }
            //Mostrar en el gridview la lista de empleadoSueldos
            dataGridViewSueldo.DataSource = null;
            dataGridViewSueldo.DataSource = empleadoSueldos;
            dataGridViewSueldo.Refresh();
        }
    }
}
