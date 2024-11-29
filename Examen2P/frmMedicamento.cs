using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Examen2P
{
    public partial class frmMedicamento : Form
    {
        public Medicamento medicamento;
        ConexionMySQL conn = new ConexionMySQL();
        MySqlCommand cmd;
        public frmMedicamento()
        {
            InitializeComponent();
        }
        public frmMedicamento(Medicamento _medicamento)
        {
            InitializeComponent();
            medicamento = _medicamento;
        }

        private void frmMedicamento_Load(object sender, EventArgs e)
        {
            if (medicamento != null)
            {
                btnEliminar.Visible = true;
                txtNombre.Text = medicamento.nombre;
                txtDescripcion.Text = medicamento.descripcion;
                nudPrecio.Value = medicamento.precio;
                nudStock.Value = medicamento.stock;
            }
        }

        int NewMedicamento()
        {
            return 0;
        }

        int UpdateMedicamento()
        {
            
            return 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (medicamento.id > 0)
            {
                int result = UpdateMedicamento();
                
            }
            else
            {
                int result = NewMedicamento();
                
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
