using Clases;
using Clases.Excepciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrador_Repaso
{
    public partial class FrmPrincipal : Form
    {
        Empresa miEmpresa;
      
        public FrmPrincipal()
        {
            InitializeComponent();
            miEmpresa = new Empresa("UTN221");
            Desarrollador desarrollador1 = new Desarrollador(1, "Pepe", "Gomez", 25, "Sistemas", 1500, 30);
            Gerente gerente1 = new Gerente(2, "Maria", "Ruiz", 30, "Gerenciz", 2500, 10);
            Desarrollador desarrollador2 = new Desarrollador(3, "Rosa", "Ali", 35, "Sistemas", 1500, 30);
            Desarrollador desarrollador3 = new Desarrollador(4, "Pepe", "Gomez", 25, "Sistemas", 1500, 30);
            Gerente gerente2 = new Gerente(5, "Luis", "Gomez", 30, "Gerencia", 6000, 10);


            miEmpresa.AñadirEmpleado(desarrollador1);
            miEmpresa.AñadirEmpleado(gerente2);
            miEmpresa.AñadirEmpleado(desarrollador2);
            miEmpresa.AñadirEmpleado(desarrollador3);
            miEmpresa.AñadirEmpleado(gerente1);
            
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try 
            { 
                FrmDesarrollador miFormulario = new FrmDesarrollador();
                if (miFormulario.ShowDialog() == DialogResult.OK)
                {
                    miEmpresa.AñadirEmpleado(miFormulario.DesarrolladorFormulario);
                    MessageBox.Show("Empleado ingresado Exitosamente");
                }
                else
                {
                    MessageBox.Show("Accion cancelada por el usuario. Desarrollador no cargado");
                }
            }
            catch(EmpleadoNoEncotradoException ex)
            {
                MessageBox.Show(ex.Message);
            }


            //foreach(Empleado em in miEmpresa.Empleados)
            //{
            //    MessageBox.Show(em.MostrarInformacion("Corto"));
            //}

            //MessageBox.Show(miFormulario.DesarrolladorFormulario.MostrarInformacion("Corto"));
        }

        private void mostrarTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMostrar mostrar = new FrmMostrar(miEmpresa);
            mostrar.Show();
        }
    }
}
