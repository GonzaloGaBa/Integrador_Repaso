using Clases;

namespace Integrador_Repaso
{
    public partial class FrmDesarrollador : Form
    {

        Desarrollador desarrolladorFormulario;
        public Desarrollador DesarrolladorFormulario 
        { 
            get => desarrolladorFormulario; 
        }

        public FrmDesarrollador()
        {
            InitializeComponent();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string departamento = txtDepartamento.Text;
            int edad = int.Parse(txtEdad.Text);
            float salario = float.Parse(txtBasico.Text);
            int lineas = int.Parse(txtLineas.Text);
            int id = int.Parse(txtId.Text);

            desarrolladorFormulario = new Desarrollador(id, nombre, apellido, edad, departamento, salario, lineas);

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }
    }
}