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
    public partial class frmCalculator : Form
    {
        public string select;

        public delegate void CalculatorUpdateEventHandler(int index, float NilaiA, float NilaiB);
        public event CalculatorUpdateEventHandler OnCreate;
        public frmCalculator()
        {
            InitializeComponent();
        }

        public frmCalculator(string title)
            : this()
        {
            this.Text = title;
        }
        private void btnProses_Click(object sender, EventArgs e)
        {
            float NilaiA = Convert.ToSingle(txtNilaiA.Text);
            float NilaiB = Convert.ToSingle(txtNilaiB.Text);

            if (select == "Penambahan")
            {
                OnCreate(0, NilaiA, NilaiB);
            }
            else if (select == "Pengurangan")
            {
                OnCreate(1, NilaiA, NilaiB);
            }
            else if (select == "Perkalian")
            {
                OnCreate(2, NilaiA, NilaiB);
            }
            else if (select == "Pembagian")
            {
                OnCreate(3, NilaiA, NilaiB);
            }
        }

        private void cmbOperasi_SelectedIndexChanged(object sender, EventArgs e)
        {
            select = cmbOperasi.SelectedItem.ToString();
        }
    }
}
