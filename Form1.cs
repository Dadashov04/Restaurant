using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace rest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public SqlConnection con = new SqlConnection("data source=DESKTOP-OI9V01D\\SQLEXPRESS;initial catalog=Restoran; integrated security=SSPI");
        SqlCommand com;
        // nujno li soyedinity otcet s receptom cerez kl
        string a = "";
        double b = 0, Kol = 0, Cena = 0;
        int n;

        public void Otcet(string s) //
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(s, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        public double Sum(string s)
        {
            con.Open();
            SqlCommand com = new SqlCommand(s, con);
            object x = com.ExecuteScalar();
            con.Close();
            if (x == DBNull.Value)
            return 0;
            return Convert.ToDouble(x);
        }

        public double Otr(string s, int p)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(s, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            if (p == 1)
                return Convert.ToDouble(ds.Tables[0].Rows[0].ItemArray[2].ToString());
            else return Convert.ToDouble(ds.Tables[0].Rows[0].ItemArray[1].ToString());
        }

        public void Otr1(string s)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(s, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            listBox1.DataSource = ds.Tables[0];
            listBox2.DataSource = ds.Tables[0];
        }

        public int Otr2(string s)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(s, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return(ds.Tables[0].Rows.Count);
        }

        public void otr(string s)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(s, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            dataGridView1.DataSource = ds.Tables[0];
        }

        void Upd()
        {
            con.Open();
            string kol = (b * n).ToString().Replace(',', '.');
            com = new SqlCommand("update Cena set Kol = Kol - " + kol + " where Produkt ='" + a + "'", con);
            com.ExecuteNonQuery();
            con.Close();
        
        }
        void Soxr()
        {
            string kol = (b * n).ToString().Replace(',', '.');
            string cena = (Cena * n).ToString().Replace(',', '.');

            if (Otr2("Select * from Otcet where Produkt like '" + a +"' and Tarix='" + DateTime.Today.ToShortDateString() + "'") == 0)
            {
                con.Open();
                com = new SqlCommand("insert into Otcet(Produkt, Kol, Cena, Tarix) values('" + a + "'," + kol + "," + cena + ",'" + DateTime.Today.ToShortDateString() + "')", con);
                com.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                con.Open();
                com = new SqlCommand("update Otcet set Kol = Kol + " + kol + " where Produkt='" + a + "' and Tarix='" + DateTime.Today.ToShortDateString() + "'", con);
                com.ExecuteNonQuery();
                con.Close();
                //--------------------
                con.Open();
                com = new SqlCommand("update Otcet set Cena = Cena + " + cena +" where Produkt='" + a + "' and Tarix='" + DateTime.Today.ToShortDateString() + "'", con);
                com.ExecuteNonQuery();
                con.Close();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restoranDataSet8.Recept' table. You can move, or remove it, as needed.
            this.receptTableAdapter3.Fill(this.restoranDataSet8.Recept);
            // TODO: This line of code loads data into the 'restoranDataSet7.Recept' table. You can move, or remove it, as needed.
            this.receptTableAdapter2.Fill(this.restoranDataSet7.Recept);
            // TODO: This line of code loads data into the 'restoranDataSet5.Otcet' table. You can move, or remove it, as needed.
            this.otcetTableAdapter1.Fill(this.restoranDataSet5.Otcet);
            // TODO: This line of code loads data into the 'restoranDataSet4.Blyudo' table. You can move, or remove it, as needed.
            this.blyudoTableAdapter1.Fill(this.restoranDataSet4.Blyudo);

            otr("select * from Otcet");
            Otr1("select* from recept where Kluch like "+"1");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // int K = listBox2.Items.Count; MessageBox.Show(K.ToString());
            n= Convert.ToInt16(textBox1.Text);
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                listBox2.SelectedIndex = i; listBox1.SelectedIndex = i;
                a = listBox2.Text;
                b = Convert.ToDouble(listBox1.Text);
                
                Kol= Otr("Select* from cena where Produkt like '" + a + "'", 1);
                Cena = Otr("Select* from cena where Produkt like '" + a + "'", 0);

                if (b * n <= Kol)
                {
                    Upd();
                    Soxr();
                }
                else
                    MessageBox.Show("Nexvatka Producta "+a+" v kol. :"+(b*n-Kol).ToString());
            }
            otr("select*from Otcet");
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Otr1("select* from recept where Kluch  =" + (comboBox1.SelectedIndex + 1).ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
    Otcet("select * from Otcet where Tarix='" + dateTimePicker1.Value.ToShortDateString() + "'");
    MessageBox.Show("Cena: " + Sum("select SUM(Cena) from Otcet where Tarix='" + dateTimePicker1.Value.ToShortDateString() + "'") +
                   "\nKol: " + Sum("select SUM(Kol) from Otcet where Tarix='" + dateTimePicker1.Value.ToShortDateString() + "'"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cena = textBox3.Text.Replace(',', '.');
            string kol = textBox4.Text.Replace(',', '.');

            if (Otr2("Select * from Cena where Produkt like '" + textBox2.Text + "'") == 0)
            {
                con.Open();
                com = new SqlCommand("insert into Cena(Produkt, Kol, Cena) values('" + textBox2.Text + "'," + kol + "," +cena + ")", con);
                com.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                con.Open();
                com = new SqlCommand( "update Cena set Kol = Kol + " + kol +" where Produkt='" + textBox2.Text + "'", con);
                com.ExecuteNonQuery();
                con.Close();
            }
        }
      }
}
