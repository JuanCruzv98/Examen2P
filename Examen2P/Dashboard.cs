using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.SkiaSharp;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace Examen2P
{
    public partial class Dashboard : Form
    {
        ConexionMySQL conn = new ConexionMySQL();
        MySqlCommand cmd;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //generar repoprtes
        {
        
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblSeller.Text = Globales.vendedor.nombre;
            CargarDatos();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMedicamento formMedicamento = new frmMedicamento();
            if (formMedicamento.ShowDialog() == DialogResult.OK)
            {
                CargarDatos();
            }
        }

        void CargarDatos()
        {
            
        }

        private void dtgProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgProductos.Rows[e.RowIndex];
                
            }
        }

        Medicamento CargarMed(int id)
        {
            if (id == 0) return null;
            
            
            return null;
        }

        

        private PlotModel CreatePieChart(Dictionary<string, double> data)
        {
            var model = new PlotModel { Title = "Mayores Vendedores" };
            var pieSeries = new PieSeries();

            foreach (var entry in data)
            {
                pieSeries.Slices.Add(new PieSlice(entry.Key, entry.Value) { IsExploded = true });
            }

            model.Series.Add(pieSeries);
            return model;
        }

        private byte[] RenderChartToBuffer(PlotModel model)
        {
            using (var stream = new MemoryStream())
            {
                var exporter = new PngExporter { Width = 600, Height = 400 };
                exporter.Export(model, stream);
                return stream.ToArray();
            }
        }

        private IDocument CreatePDF(byte[] chartImage, DataTable topMedicamentos)
        {
            return Document.Create(container =>
            {
                   
            });
        }

    }
}
