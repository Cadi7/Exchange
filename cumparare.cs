using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace individual2
{
    public partial class cumparare : Form
    {
   
        public cumparare()
        {
          InitializeComponent();
          
          

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            temp.nrschimbvalutar = float.Parse(textBox1.Text);
        }

     

        private void cumparare_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            temp.valutadetin= comboBox2.GetItemText(comboBox2.SelectedItem);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            temp.valutavreau = comboBox1.GetItemText(comboBox1.SelectedItem);
        }
    }

       
}
