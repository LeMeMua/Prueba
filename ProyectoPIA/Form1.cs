using ProyectoPIA.Repository;
using System.Data;

namespace ProyectoPIA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            readEmpleados();
        }

        private void readEmpleados()
        {
            // Crear DataTable
            // Crear DataTable
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Nombre");
            dataTable.Columns.Add("Edad");
            dataTable.Columns.Add("Celular");
            dataTable.Columns.Add("Carrera");
            dataTable.Columns.Add("Editar", typeof(byte[])); // Columna de tipo byte[]
            dataTable.Columns.Add("Eliminar", typeof(byte[])); // Columna de tipo byte[]

            // Obtener datos del repositorio
            var repo = new Empleadorepository();
            var empleados = repo.getempleados();

            // Llenar DataTable
            foreach (var empleado in empleados)
            {
                var row = dataTable.NewRow();

                var edit_icon = Properties.Resource1.edit_icon;
                var delete_icon = Properties.Resource1.delete_icon;
                row["Editar"] = edit_icon; // Guardar imagen como byte[]
                row["Eliminar"] = delete_icon; // Guardar imagen como byte[]
                row["ID"] = empleado.id;
                row["Nombre"] = empleado.name;
                row["Edad"] = empleado.edad;
                row["Celular"] = empleado.celular;
                row["Carrera"] = empleado.carrera;

                dataTable.Rows.Add(row);
            }

            // Asignar DataTable al DataGridView
            this.empleadoTable.DataSource = dataTable;

            // Convertir las columnas "Editar" y "Eliminar" en columnas de imagen
            ((DataGridViewImageColumn)this.empleadoTable.Columns["Editar"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            ((DataGridViewImageColumn)this.empleadoTable.Columns["Eliminar"]).ImageLayout = DataGridViewImageCellLayout.Zoom;

            // Asegurar que las columnas "Editar" y "Eliminar" estén al final
            this.empleadoTable.Columns["Editar"].DisplayIndex = this.empleadoTable.Columns.Count - 2;
            this.empleadoTable.Columns["Eliminar"].DisplayIndex = this.empleadoTable.Columns.Count - 1;
        }

            // Función para convertir Image a byte[]
            private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmpleadoCrear empleadoCrear = new EmpleadoCrear();
            empleadoCrear.ShowDialog();
            
        }
    }
}
