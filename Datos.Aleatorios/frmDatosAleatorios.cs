using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Datos.Aleatorios
{
    public partial class frmDatosAleatorios : Form
    {
        public frmDatosAleatorios()
        {
            InitializeComponent();
        }

        private void frmDatosAleatorios_Load(object sender, EventArgs e)
        {

        }


        private void btnPrueba_Click_1(object sender, EventArgs e)
        {
            Random rnd = new Random();

            string[] nombres = { "Carlos Fernando", "Mar Luna", "Juan Angel", "Ana Lucia", "Pedro", "Lucía", "Roberto Emiliano", "Elena", "Antony", "Eduardo" };
            string[] grupos = { "A", "B", "C", "D", "E", "F", "G", "H" };

            Empleado emp = new Empleado
            {
                Nombre = nombres[rnd.Next(nombres.Length)],
                NumeroEmpleado = rnd.Next(1000, 9999),
                FechaNacimiento = DateTime.Now.AddYears(-rnd.Next(18, 60)).AddDays(rnd.Next(0, 365)),
                Genero = rnd.Next(2) == 0 ? "Masculino" : "Femenino",
                Grupo = grupos[rnd.Next(grupos.Length)],
                Sueldo = rnd.Next(6000, 25000),
                TieneSeguro = rnd.Next(2) == 0
            };

            Nombre.Text = emp.Nombre;
            Numero.Text = emp.NumeroEmpleado.ToString();
            FechaNacimiento.Value = emp.FechaNacimiento;

            if (emp.Genero == "Masculino")
                Masculino.Checked = true;
            else
                Femenino.Checked = true;

            Grupo.Text = emp.Grupo;
            Sueldo.Text = emp.Sueldo.ToString("C");
            Seguro.Checked = emp.TieneSeguro;
        }
    }

}
