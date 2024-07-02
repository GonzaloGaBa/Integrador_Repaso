using Clases.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Empresa
    {
        #region Atributos
        private List<Empleado> empleados;
        private Dictionary<int, Empleado> diccionarioEmpleados;
        private Stack<Empleado> pilaEmpleados;
        private static DateTime inicioActividades;
        private string nombre;

        #endregion

        #region Propiedades
        public static DateTime InicioActividades { get => inicioActividades; set => inicioActividades = value; }
        public List<Empleado> Empleados { get => empleados; set => empleados = value; }
        public Dictionary<int, Empleado> DiccionarioEmpleados { get => diccionarioEmpleados; set => diccionarioEmpleados = value; }
        public Stack<Empleado> PilaEmpleados { get => pilaEmpleados; set => pilaEmpleados = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        #endregion

        #region Constructores

        private  Empresa()
        {
            empleados = new List<Empleado>();
            diccionarioEmpleados = new Dictionary<int, Empleado>();
            pilaEmpleados = new Stack<Empleado>();
        }

        public Empresa(string nombre) :this()
        {
            this.nombre = nombre;
        }

        static Empresa ()
        {
            inicioActividades = DateTime.Now;
        }
        #endregion

        #region metodos

        public bool AñadirEmpleado(Empleado empleado)
        {
            bool agrego = false;
            if (!BuscarEmpleado(empleado))
            {
                this.empleados.Add(empleado);
                this.diccionarioEmpleados.Add(empleado.Id, empleado);
                //this.diccionarioEmpleados[empleado.Id] = empleado;
                this.pilaEmpleados.Push(empleado);//Apilar 
                agrego = true;
            }
            else
            {
                throw new EmpleadoNoEncotradoException("El empleado ya se encuentra en la lista", empleado);
            }
            return agrego;           
        }

        private bool BuscarEmpleado(Empleado unEmpleado)
        {
            bool existe = false;

            foreach (Empleado empleado in this.empleados)
            {
                if (empleado == unEmpleado)
                {
                    existe = true;
                }
                
            }


            return existe;
        }

        public string MostrarEmpleados()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var empleado in empleados)
            {
                sb.Append(empleado.MostrarInformacion());
            }
            return sb.ToString();
        }

        public Empleado BuscarPorId(int id)//cambiar por dni
        {
            Empleado emp = null;

            if (this.diccionarioEmpleados.ContainsKey(id))
            {
                emp = this.diccionarioEmpleados[id];
            }
            else
            {
                throw new EmpleadoNoEncotradoException($"No se encuentr el empleado on id: {id} en la nomina");
            }



            return emp;
        }

        public string MostrarUltimoEmpleado()
        {
            string cadena = "No hay epmpleado en pila";
            if(this.pilaEmpleados.Count > 0)
            {
                Empleado ultimo = this.pilaEmpleados.Peek();
                cadena = ultimo.MostrarInformacion();
            }
            return cadena;
        }
        #endregion
    }
}
