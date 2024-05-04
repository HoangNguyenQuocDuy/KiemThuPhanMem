using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19_Duy_N1_tinhte.vn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_19_duy_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA_19_duy.Text);
            double b = double.Parse(txtB_19_duy.Text);
            double c = double.Parse(txtC_19_duy.Text);

            Triangle triangle = new Triangle(a, b, c);  

            lbResult_19_duy.Text = triangle.CalculateArea().ToString();
        }
    }
}
