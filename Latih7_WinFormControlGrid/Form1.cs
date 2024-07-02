using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace Latih7_WinFormControlGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = GenerateData();
            dataGridView1.DataSource = data;
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
