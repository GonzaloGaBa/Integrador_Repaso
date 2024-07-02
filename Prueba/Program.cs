using Clases.Excepciones;
using Clases;

namespace Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Empresa miEmpresa = new Empresa("Globand");
            Console.WriteLine(Empresa.InicioActividades);


            Desarrollador desarrollador1 = new Desarrollador(1, "Pepe", "Gomez", 25, "Sistemas", 1500, 30);
            Gerente gerente1 = new Gerente(5,"Maria", "Ruiz", 30, "Finanzas", 2500, 10);
            Desarrollador desarrollador2 = new Desarrollador(2, "Rosa", "Ali", 35, "Sistemas", 1500, 30);
            Desarrollador desarrollador3 = new Desarrollador(1, "Pepe", "Gomez", 25, "Sistemas", 1800, 30);
            //Console.WriteLine(desarrollador1.MostrarInformacion());
            //Console.WriteLine(desarrollador1.SalarioBase);
            //Console.WriteLine(desarrollador1.SalarioTotal);
            //Console.WriteLine("***************************");
            //Console.WriteLine(gerente1.MostrarInformacion());
            //Console.WriteLine(gerente1.SalarioTotal);
            Console.WriteLine(miEmpresa.AñadirEmpleado(desarrollador1));
            Console.WriteLine(miEmpresa.AñadirEmpleado(desarrollador2));
            Console.WriteLine(miEmpresa.AñadirEmpleado(desarrollador3));
            Console.WriteLine(miEmpresa.AñadirEmpleado(gerente1));

            Console.WriteLine(miEmpresa.MostrarEmpleados());


            Console.WriteLine("***************************");
            Console.WriteLine(miEmpresa.BuscarPorId(2).MostrarInformacion());
            Console.WriteLine("***************************");
            Console.WriteLine(miEmpresa.MostrarUltimoEmpleado());

                desarrollador1.SalarioBase = -256;
            }
            catch(DatoInvalidoException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(EmpleadoNoEncotradoException ex)
            {
                Console.WriteLine(ex.Message);
                ex.LogExcepcion();
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Error no contemplado... comuniquese con sistemas");
            }
        }
    }
}