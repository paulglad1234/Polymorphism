using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphism
{
    public partial class Polymorphism_Sample_Form : Form
    {
        Product p;
        NotEturnalProduct ne_p;
        public Polymorphism_Sample_Form()
        {
            InitializeComponent();
        }

        private void inputButton1_Click(object sender, EventArgs e)
        {
            p = new Product(nameTextBox1.Text, (int)priceNumeric1.Value, (int)number_Numeric1.Value);
        }

        private void inputButton2_Click(object sender, EventArgs e)
        {
            ne_p = new NotEturnalProduct(nameTextBox2.Text, (int)priceNumeric2.Value, (int)number_Numeric2.Value,
                (int)yearNumeric.Value);
        }

        private void outputButton1_Click(object sender, EventArgs e)
        {
            if (p == null)
                outputTextBox1.Text = "Дайте экземпляр";
            else outputTextBox1.Lines = p.Output();
        }

        private void outputButton2_Click(object sender, EventArgs e)
        {
            if (ne_p == null)
                outputTextBox2.Text = "Дайте экземпляр";
            else
                outputTextBox2.Lines = ne_p.Output();
        }
    }
}
