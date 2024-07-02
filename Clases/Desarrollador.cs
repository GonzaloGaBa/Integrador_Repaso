using Clases.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Desarrollador : Empleado
    {
        #region Atributos
        private float salarioBase;
        private int lineasDeCodigoPorHora;
        #endregion

        #region Propiedades
        //Implementar Excepciones
        public float SalarioTotal
        {
            get
            {
                return CalcularSalario();
            }
        }
        public float SalarioBase
        {
            get => salarioBase;
            set
            {
                if (value < 0 || value > 500000)
                {
                    throw new DatoInvalidoException("Intento ingresar un sueldo fuera de rango", value.ToString());
                }
               salarioBase = value;
            }
        }

        public int LineasDeCodigoPorHora
        {
            get => lineasDeCodigoPorHora;
            set
            {
                lineasDeCodigoPorHora = value;
            }
        }
        #endregion

        #region Constructores
        public Desarrollador(int id, string nombre, string apellido, int edad, string departamento, float salario,int lineas):
            base(nombre,apellido,edad,departamento,id)
        {
            this.salarioBase = salario;
            this.lineasDeCodigoPorHora = lineas;
        }



        #endregion

        #region Metodos
        // Métodos sobrescritos
        protected override float CalcularSalario()
        {
            return this.salarioBase + (this.lineasDeCodigoPorHora * 0.5f);
        }


        #endregion
    }
}
