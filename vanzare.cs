using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace individual2
{
    public partial class vanzare : Form
    {
        public vanzare()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            temp.valutaprimesc = comboBox2.GetItemText(comboBox2.SelectedItem);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            temp.nrschimbvalutar2 = float.Parse(textBox1.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            temp.valutaofer = comboBox1.GetItemText(comboBox1.SelectedItem);
        }
    }
}
