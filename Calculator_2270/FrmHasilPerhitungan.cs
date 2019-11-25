using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_2270
{
    public partial class frmHasilPerhitungan : Form
    {
        public frmHasilPerhitungan()
        {
            InitializeComponent();
        }

        private void frmCalculator_OnCreate(int index, float NilaiA, float NilaiB)
        {
            var calculator = new Calculator();

            if(index == 0)
            {
                lsbHasilPerhitungan.Items.Add(string.Format("Hasil Penambahan : {0} + {1} = {2}", NilaiA, NilaiB, calculator.tambah(NilaiA, NilaiB)));
            }
            else if (index == 1)
            {
                lsbHasilPerhitungan.Items.Add(string.Format("Hasil Pengurangan : {0} - {1} = {2}", NilaiA, NilaiB, calculator.kurang(NilaiA, NilaiB)));
            }
            else if (index == 2)
            {
                lsbHasilPerhitungan.Items.Add(string.Format("Hasil Perkalian : {0} * {1} = {2}", NilaiA, NilaiB, calculator.kali(NilaiA, NilaiB)));
            }
            else if (index == 3)
            {
                lsbHasilPerhitungan.Items.Add(string.Format("Hasil Pembagian : {0} / {1} = {2}", NilaiA, NilaiB, calculator.bagi(NilaiA, NilaiB)));
            }
        }

        private void FrmHasilPerhitungan_Load(object sender, EventArgs e)
        {

        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            frmCalculator frmCalculator = new frmCalculator();
            frmCalculator.OnCreate += frmCalculator_OnCreate;
            frmCalculator.ShowDialog();
        }

        private void lsbHasilPerhitungan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
