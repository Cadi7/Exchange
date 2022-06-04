using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace individual2
{
    public partial class Form2 : Form
    {
        cumparare myForm = new cumparare();
        vanzare myForm2 = new vanzare();
        public Form2()
        {


            DataTable dt = new DataTable();
            InitializeComponent();
            DataSet dsa = new DataSet();
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=master;Integrated Security=True");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select pretc, pretv  from dbo.vcumparare", con);
            da.Fill(dsa);



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

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                myForm2.Visible = false;
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                myForm.FormBorderStyle = FormBorderStyle.None;
                myForm.Dock = DockStyle.Fill;
                myForm.BringToFront();
                panel2.Controls.Add(myForm);
                myForm.Show();

            }

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Esti sigur ca vrei sa iesi?", "Confirmare", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                Close();
                Form1 form1 = new Form1();
                form1.Show();
            }
            if (res == DialogResult.Cancel)
            {
                Show();
            }
        }

        class calcule
        {

            private float cantitate = temp.nrschimbvalutar;
            private float cantitate2 = temp.nrschimbvalutar2;
            private string convertion = temp.valutadetin + temp.valutavreau;
            private string convertion2 = temp.valutaofer + temp.valutaprimesc;
            public float Val1
            {
                get { return cantitate; }
                set { cantitate = value; }
            }

            public float Val2
            {
                get { return cantitate2; }
                set { cantitate2 = value; }
            }
            public string Convertion
            {
                get
                {
                    return convertion;
                }
                set
                {
                    convertion = value;
                }

            }

            public string Convertion2
            {
                get
                {
                    return convertion2;
                }
                set
                {
                    convertion2 = value;
                }

            }

            public double Conversie()
            {
                double result = 0;

                switch (Convertion)
                {
                    //mdl to x
                    case "MDLMDL":
                        result = Val1 * 1;
                        break;
                    case "MDLUSD":
                        result = Val1 / valuta.usdc;
                        break;
                    case "MDLEUR":
                        result = Val1 / valuta.eurc;
                        break;
                    case "MDLGBP":
                        result = Val1 / valuta.gbpc;
                        break;
                    case "MDLRON":
                        result = Val1 / valuta.ronc;
                        break;
                    case "MDLUAH":
                        result = Val1 / valuta.uahc;
                        break;
                    case "MDLRUB":
                        result = Val1 / valuta.rubc;
                        break;
                    //usd to x
                    case "USDMDL":
                        result = Val1 * valuta.usdc;
                        break;
                    case "USDUSD":
                        result = Val1 * 1;
                        break;
                    case "USDEUR":
                        result = Val1 * valuta.usdc / valuta.eurc;
                        break;
                    case "USDGBP":
                        result = Val1 * valuta.usdc / valuta.gbpc;
                        break;
                    case "USDRON":
                        result = Val1 * valuta.usdc / valuta.ronc;
                        break;
                    case "USDUAH":
                        result = Val1 * valuta.usdc / valuta.uahc;
                        break;
                    case "USDRUB":
                        result = Val1 * valuta.usdc / valuta.rubc;
                        break;

                    //gbp to x
                    case "GBPMDL":
                        result = Val1 * valuta.gbpc;
                        break;
                    case "GBPUSD":
                        result = Val1 * 1;
                        break;
                    case "GBPEUR":
                        result = Val1 * valuta.gbpc / valuta.eurc;
                        break;
                    case "GBPGBP":
                        result = Val1 * valuta.gbpc / valuta.gbpc;
                        break;
                    case "GBPRON":
                        result = Val1 * valuta.gbpc / valuta.ronc;
                        break;
                    case "GBPUAH":
                        result = Val1 * valuta.gbpc / valuta.uahc;
                        break;
                    case "GBPRUB":
                        result = Val1 * valuta.gbpc / valuta.rubc;
                        break;

                    //eur to x
                    case "EURMDL":
                        result = Val1 * valuta.eurc;
                        break;
                    case "EURUSD":
                        result = Val1 * valuta.eurc / valuta.usdc;
                        break;
                    case "EUREUR":
                        result = Val1 * valuta.eurc / valuta.eurc;
                        break;
                    case "EURGBP":
                        result = Val1 * valuta.eurc / valuta.gbpc;
                        break;
                    case "EURRON":
                        result = Val1 * valuta.eurc / valuta.ronc;
                        break;
                    case "EURUAH":
                        result = Val1 * valuta.eurc / valuta.uahc;
                        break;
                    case "EURRUB":
                        result = Val1 * valuta.eurc / valuta.rubc;
                        break;

                    //ron to x
                    case "RONMDL":
                        result = Val1 * valuta.ronc;
                        break;
                    case "RONUSD":
                        result = Val1 * valuta.ronc / valuta.usdc;
                        break;
                    case "RONEUR":
                        result = Val1 * valuta.ronc / valuta.eurc;
                        break;
                    case "RONGBP":
                        result = Val1 * valuta.ronc / valuta.gbpc;
                        break;
                    case "RONRON":
                        result = Val1 * valuta.ronc / valuta.ronc;
                        break;
                    case "RONUAH":
                        result = Val1 * valuta.ronc / valuta.uahc;
                        break;
                    case "RONRUB":
                        result = Val1 * valuta.ronc / valuta.rubc;
                        break;

                    //uah to x
                    case "UAHMDL":
                        result = Val1 * valuta.uahc;
                        break;
                    case "UAHUSD":
                        result = Val1 * valuta.uahc / valuta.usdc;
                        break;
                    case "UAHEUR":
                        result = Val1 * valuta.uahc / valuta.eurc;
                        break;
                    case "UAHGBP":
                        result = Val1 * valuta.uahc / valuta.gbpc;
                        break;
                    case "UAHRON":
                        result = Val1 * valuta.uahc / valuta.ronc;
                        break;
                    case "UAHUAH":
                        result = Val1 * valuta.uahc / valuta.uahc;
                        break;
                    case "UAHRUB":
                        result = Val1 * valuta.uahc / valuta.rubc;
                        break;

                    // rub to x
                    case "RUBMDL":
                        result = Val1 * valuta.rubc;
                        break;
                    case "RUBUSD":
                        result = Val1 * valuta.rubc / valuta.usdc;
                        break;
                    case "RUBEUR":
                        result = Val1 * valuta.rubc / valuta.eurc;
                        break;
                    case "RUBGBP":
                        result = Val1 * valuta.rubc / valuta.gbpc;
                        break;
                    case "RUBRON":
                        result = Val1 * valuta.rubc / valuta.ronc;
                        break;
                    case "RUBUAH":
                        result = Val1 * valuta.rubc / valuta.uahc;
                        break;
                    case "RUBRUB":
                        result = Val1 * valuta.rubc / valuta.rubc;
                        break;

                }


                return result;
            }
            public double Conversie2()
            {
                double result = 0;

                switch (Convertion2)
                {
                    //mdl to x
                    case "MDLMDL":
                        result = Val2 * 1;
                        break;
                    case "MDLUSD":
                        result = Val2 * valuta.usdv;
                        break;
                    case "MDLEUR":
                        result = Val2 * valuta.eurv;
                        break;
                    case "MDLGBP":
                        result = Val2 * valuta.gbpv;
                        break;
                    case "MDLRON":
                        result = Val2 * valuta.ronv;
                        break;
                    case "MDLUAH":
                        result = Val2 * valuta.uahv;
                        break;
                    case "MDLRUB":
                        result = Val2 * valuta.rubv;
                        break;
                    //usd to x
                    case "USDMDL":
                        result = Val2 * valuta.usdv;
                        break;
                    case "USDUSD":
                        result = Val2 * 1;
                        break;
                    case "USDEUR":
                        result = Val2 * valuta.eurv / valuta.usdv;
                        break;
                    case "USDGBP":
                        result = Val2 * valuta.gbpv / valuta.usdv;
                        break;
                    case "USDRON":
                        result = Val2 * valuta.ronv / valuta.usdv;
                        break;
                    case "USDUAH":
                        result = Val2 * valuta.uahv / valuta.usdv;
                        break;
                    case "USDRUB":
                        result = Val2 * valuta.rubv / valuta.usdv;
                        break;

                    //eur to x
                    case "EURMDL":
                        result = Val2 * valuta.eurv;
                        break;
                    case "EURUSD":
                        result = Val2 * valuta.usdc / valuta.eurv;
                        break;
                    case "EUREUR":
                        result = Val2 * valuta.eurv / valuta.eurv;
                        break;
                    case "EURGBP":
                        result = Val2 * valuta.gbpv / valuta.eurv;
                        break;
                    case "EURRON":
                        result = Val2 * valuta.ronv / valuta.eurv;
                        break;
                    case "EURUAH":
                        result = Val2 * valuta.uahv / valuta.eurv;
                        break;
                    case "EURRUB":
                        result = Val2 * valuta.rubv / valuta.eurv;
                        break;


                    //gbp to x
                    case "GBPMDL":
                        result = Val2 * valuta.gbpc;
                        break;
                    case "GBPUSD":
                        result = Val2 * 1;
                        break;
                    case "GBPEUR":
                        result = Val2 * valuta.eurc / valuta.gbpc;
                        break;
                    case "GBPGBP":
                        result = Val2 * valuta.gbpc / valuta.gbpc;
                        break;
                    case "GBPRON":
                        result = Val2 * valuta.ronc / valuta.gbpc;
                        break;
                    case "GBPUAH":
                        result = Val2 * valuta.uahc / valuta.gbpc;
                        break;
                    case "GBPRUB":
                        result = Val2 * valuta.rubc / valuta.gbpc;
                        break;


                    //ron to x
                    case "RONMDL":
                        result = Val2 * valuta.ronv;
                        break;
                    case "RONUSD":
                        result = Val2 * valuta.usdv / valuta.ronv;
                        break;
                    case "RONEUR":
                        result = Val2 * valuta.eurv / valuta.ronv;
                        break;
                    case "RONGBP":
                        result = Val2 * valuta.gbpv / valuta.ronv;
                        break;
                    case "RONRON":
                        result = Val2 * valuta.ronv / valuta.ronv;
                        break;
                    case "RONUAH":
                        result = Val2 * valuta.uahv / valuta.ronv;
                        break;
                    case "RONRUB":
                        result = Val2 * valuta.rubv / valuta.ronv;
                        break;

                    //uah to x
                    case "UAHMDL":
                        result = Val2 * valuta.uahv;
                        break;
                    case "UAHUSD":
                        result = Val2 * valuta.usdv / valuta.uahv;
                        break;
                    case "UAHEUR":
                        result = Val2 * valuta.eurv / valuta.uahv;
                        break;
                    case "UAHGBP":
                        result = Val2 * valuta.gbpv / valuta.uahv;
                        break;
                    case "UAHRON":
                        result = Val2 * valuta.ronv / valuta.uahv;
                        break;
                    case "UAHUAH":
                        result = Val2 * valuta.uahv / valuta.uahv;
                        break;
                    case "UAHRUB":
                        result = Val2 * valuta.rubv / valuta.uahv;
                        break;

                    // rub to x
                    case "RUBMDL":
                        result = Val2 * valuta.rubv;
                        break;
                    case "RUBUSD":
                        result = Val2 * valuta.usdv / valuta.rubv;
                        break;
                    case "RUBEUR":
                        result = Val2 * valuta.eurv / valuta.rubv;
                        break;
                    case "RUBGBP":
                        result = Val2 * valuta.gbpv / valuta.rubv;
                        break;
                    case "RUBRON":
                        result = Val2 * valuta.ronv / valuta.rubv;
                        break;
                    case "RUBUAH":
                        result = Val2 * valuta.uahv / valuta.rubv;
                        break;
                    case "RUBRUB":
                        result = Val2 * valuta.rubc / valuta.rubv;
                        break;

                }


                return result;
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            calcule calc = new calcule();
            string calcul = calc.Conversie().ToString();
            string calcul2 = calc.Conversie2().ToString();

            if (radioButton1.Checked == true)
            {
                if ((temp.nrschimbvalutar != 0) && (temp.valutadetin != null) && (temp.valutavreau != null))
                {
                    MessageBox.Show("De " + temp.nrschimbvalutar + " " + temp.valutadetin + " vei primi " + Math.Round(float.Parse(calcul), 2) + " " + temp.valutavreau);
                }
                else MessageBox.Show("Nu ai introdus toate valorile!");
            }
else if (radioButton2.Checked == true)
            {
                if ((temp.nrschimbvalutar2 != 0) && (temp.valutaprimesc != null) && (temp.valutaofer != null))
                {
                    MessageBox.Show("Pentru a primi " + temp.nrschimbvalutar2 + " " + temp.valutaprimesc + " va trebui sa oferi " + Math.Round(float.Parse(calcul2), 2) + " " + temp.valutaofer);
                }
                else MessageBox.Show("Nu ai introdus toate valorile!");
            }
           
        }
           

    private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {

                myForm.Visible = false;
                myForm2.TopLevel = false;
                myForm2.AutoScroll = true;
                myForm2.FormBorderStyle = FormBorderStyle.None;
                myForm2.Dock = DockStyle.Fill;
                myForm2.BringToFront();
                panel2.Controls.Add(myForm2);
                myForm2.Show();

            }

        }
    }

    }
