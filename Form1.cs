using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace individual2
{
    public partial class Form1 : Form
    {
 
        public Form1()
        {
            DataTable dt = new DataTable();
            InitializeComponent();
            DataSet dsa = new DataSet();
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial " +
                "Catalog=master;Integrated Security=True");
            con.Open();
           SqlDataAdapter da = new SqlDataAdapter("Select pretc, pretv  from dbo.vcumparare", con);
           da.Fill(dsa);

               

                    label8.Text = dsa.Tables[0].Rows[0]["pretc"].ToString();
                    valuta.usdc = float.Parse(label8.Text);
                    label9.Text = dsa.Tables[0].Rows[1]["pretc"].ToString();
                    valuta.eurc = float.Parse(label9.Text);
                    label10.Text = dsa.Tables[0].Rows[2]["pretc"].ToString();
                    valuta.gbpc = float.Parse(label10.Text);
                    label11.Text = dsa.Tables[0].Rows[3]["pretc"].ToString();
                    valuta.ronc = float.Parse(label11.Text);
                    label12.Text = dsa.Tables[0].Rows[4]["pretc"].ToString();
                    valuta.uahc = float.Parse(label12.Text);
                    label13.Text = dsa.Tables[0].Rows[5]["pretc"].ToString();
                    valuta.rubc = float.Parse(label13.Text);
            label14.Text = dsa.Tables[0].Rows[0]["pretv"].ToString();
            valuta.usdv = float.Parse(label14.Text);
            label15.Text = dsa.Tables[0].Rows[1]["pretv"].ToString();
            valuta.eurv = float.Parse(label15.Text);
            label16.Text = dsa.Tables[0].Rows[2]["pretv"].ToString();
            valuta.gbpv = float.Parse(label16.Text);
            label17.Text = dsa.Tables[0].Rows[3]["pretv"].ToString();
            valuta.ronv = float.Parse(label17.Text);
            label18.Text = dsa.Tables[0].Rows[4]["pretv"].ToString();
            valuta.uahv = float.Parse(label18.Text);
            label19.Text = dsa.Tables[0].Rows[5]["pretv"].ToString();
            valuta.rubv = float.Parse(label19.Text);


            con.Close();

       
        }

        Point lastPoint;
        private void top_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void top_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label20.Text = DateTime.Today.ToString();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Esti sigur ca vrei sa iesi?", "Confirmare", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                MessageBox.Show("Formularul va fi inchis imediat!");
                Application.Exit();
            }
            if (res == DialogResult.Cancel)
            {
                MessageBox.Show("Ai anulat inchiderea!");
                Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
           
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
           
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
          
        }
    }
}
