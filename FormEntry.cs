using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasCalculatorApp
{
    public partial class FormEntry : Form
    {
        public delegate void CreateUpdateEventHandler(int nilaiA, int nilaiB, int index);

        public event CreateUpdateEventHandler Perhitungan;

        public FormEntry()
        {
            InitializeComponent();
        }

        private void btnProses_Click_1(object sender, EventArgs e)
        {
            var a = Convert.ToInt32(txtNilaiA.Text);
            var b = Convert.ToInt32(txtNilaiB.Text);

            Perhitungan(a, b, cbOperasi.SelectedIndex);
        }
    }
}
