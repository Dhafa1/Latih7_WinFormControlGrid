using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace Latih7_WinFormControlGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = GenerateData();
            dataGridView1.DataSource = data;
            
            dataGridView1.Columns["Warna"].DefaultCellStyle.BackColor = Color.LightBlue;
            dataGridView1.Columns["VolumeMesin"].DefaultCellStyle.BackColor = Color.LightGreen;

            dataGridView1.Columns["VolumeMesin"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["MaxKecepatan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["VolumeMesin"].DefaultCellStyle.Format = "N0";

            dataGridView1.Columns["TipeMobil"].DefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Italic);
        }
        private IEnumerable<Mobil> GenerateData()
        {
            var BMW = new Mobil
            {
                TipeMobil = "BMW sedan",
                Warna = "Putih",
                VolumeMesin = 2500,
                MaxKecepatan = 180,
                BahanBakar = "Pertamax Turbo",
                TglProduksi = new DateTime(2020, 1, 2)
            };
            var Fortuner = new Mobil
            {
                TipeMobil = "SUV",
                Warna = "Abu abu",
                VolumeMesin = 2500,
                BahanBakar = "Dex",
                MaxKecepatan = 180,
                TglProduksi = new DateTime(2022, 11, 22)
            };

            var Rubicon = new Mobil
            {
                TipeMobil = "SUV",
                Warna = "Hitam",
                VolumeMesin = 2000,
                BahanBakar = "Dex",
                MaxKecepatan = 180,
                TglProduksi = new DateTime(2022, 3, 30)
            };

            var mobil = new List<Mobil>() { BMW, Fortuner, Rubicon };
            return mobil;
        }
     }
}
