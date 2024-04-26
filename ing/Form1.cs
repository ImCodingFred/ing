using MySql.Data;
using MySql.Data.MySqlClient;
using System.ComponentModel;
namespace ing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string server;
        string database;
        string username;
        string password;
        string kapcsolatnev;
        string lekerdezes;


        void betoltes()
        {
            DGV.Rows.Clear();
            server = "linsql.verebely.dc";
            database = "diak36";
            username = "diak36";
            password = "BXGERT";
            kapcsolatnev = $"SERVER={server};DATABASE={database};UID={username};PASSWORD={password}";
            MySqlConnection con = new MySqlConnection(kapcsolatnev);
            con.Open();
            lekerdezes = "SELECT ingatlan.*, partner.pnev, ugynok.unev FROM ingatlan natural join partner natural join ugynok ORDER BY iazon ";
            MySqlCommand parancs = new MySqlCommand(lekerdezes, con);
            MySqlDataReader mdr = parancs.ExecuteReader();
            while (mdr.Read())
            {
                DGV.Rows.Add(mdr["iazon"], mdr["kerulet"], mdr["pnev"], mdr["ar"], mdr["unev"], mdr["nm"], mdr["tipus"], mdr["eladdatum"]);
            }
            con.Close();


            lekerdezes = "SELECT * FROM partner ORDER BY pnev";
            cb_partner.Items.Clear();
            cb_partner.SelectedIndex = 0;
            cb_partner.Items.Add("Válasszon partnert!");
            con.Open() ;
            parancs = new MySqlCommand(lekerdezes , con);
            mdr = parancs.ExecuteReader();
            if (mdr.HasRows)
            {
                while (mdr.Read())
                {
                    cb_partner.Items.Add(mdr["pnev"]);
                }
            }
            con.Close();


            lekerdezes = "SELECT * FROM ugynok ORDER BY unev";
            cb_ugynok.Items.Clear();
            cb_ugynok.SelectedIndex = 0;
            cb_ugynok.Items.Add("Válasszon ügynököt!");
            con.Open();
            parancs = new MySqlCommand(lekerdezes, con);
            mdr = parancs.ExecuteReader();
            if (mdr.HasRows)
            {
                while (mdr.Read())
                {
                    cb_ugynok.Items.Add(mdr["unev"]);
                }
            }
            con.Close();
        }

        private void DGV_Load(object sender, EventArgs e)
        {
            betoltes();
            
        }

        private void tb_ar_TextChanged(object sender, EventArgs e)
        {
            if (tb_ar.TextLength > 0)
            {
                try
                {
                    int szam = Convert.ToInt32(tb_ar.Text);
                }
                catch
                {
                    MessageBox.Show("Számot adjon meg", "Üzenet", MessageBoxButtons.OK);
                    tb_ar.Clear();
                    tb_ar.Focus();
                }
            }
        }

        private void tb_kerulet_TextChanged(object sender, EventArgs e)
        {
            if (tb_kerulet.TextLength > 0)
            {
                try
                {
                    int szam = Convert.ToInt32(tb_kerulet.Text);
                }
                catch
                {
                    MessageBox.Show("Számot adjon meg", "Üzenet", MessageBoxButtons.OK);
                    tb_kerulet.Clear();
                    tb_kerulet.Focus();
                }
            }
        }

        private void tb_meret_TextChanged(object sender, EventArgs e)
        {
            if (tb_meret.TextLength > 0)
            {
                try
                {
                    int szam = Convert.ToInt32(tb_meret.Text);
                }
                catch
                {
                    MessageBox.Show("Számot adjon meg", "Üzenet", MessageBoxButtons.OK);
                    tb_meret.Clear();
                    tb_meret.Focus();
                }
            }
        }

        private void btn_ment_Click(object sender, EventArgs e)
        {
            bool van = false;
            if (tb_iazon.TextLength==0)
            {
                MessageBox.Show("Adja meg az ingatlan Azonosítóját!", "Üzenet", MessageBoxButtons.OK);
                tb_iazon.Focus();
                server = "linsql.verebely.dc";
                database = "diak36";
                username = "diak36";
                password = "BXGERT";
                kapcsolatnev = $"SERVER={server};DATABASE={database};UID={username};PASSWORD={password}";
                MySqlConnection con = new MySqlConnection(kapcsolatnev);
                con.Open();
                lekerdezes = $"SELECT iazon from ingatlan where iazon = {tb_iazon.Text}";
                MySqlCommand parancs = new MySqlCommand(lekerdezes, con);
                MySqlDataReader mdr = parancs.ExecuteReader();
                if (mdr.HasRows)
                {
                    van = true;
                }
                con.Close();
            }
            else if (tb_kerulet.TextLength == 0)
            {
                MessageBox.Show("Adja meg a kerületet", "Üzenet", MessageBoxButtons.OK);
                tb_kerulet.Focus();
            }
            else if (cb_partner.SelectedIndex == 0)
            {
                MessageBox.Show("Adja meg a partner azonosítóját", "Üzenet", MessageBoxButtons.OK);
                cb_partner.Focus();
            }
            else if (tb_ar.TextLength == 0)
            {
                MessageBox.Show("Adja meg az árat", "Üzenet", MessageBoxButtons.OK);
                tb_ar.Focus();
            }
            else if (cb_ugynok.SelectedIndex == 0)
            {
                MessageBox.Show("Adja meg az ügynök azonosítóját", "Üzenet", MessageBoxButtons.OK);
                cb_ugynok.Focus();
            }
            else if (tb_meret.TextLength == 0)
            {
                MessageBox.Show("Adja meg a méretet", "Üzenet", MessageBoxButtons.OK);
                tb_meret.Focus();
            }
            else if (tb_tipus.TextLength == 0)
            {
                MessageBox.Show("Adja meg a tipust", "Üzenet", MessageBoxButtons.OK);
                tb_tipus.Focus();
            }
            else
            {

                if (van)
                {
                    MessageBox.Show("Létezik már ilyen ingatlan azonosító", "Üzenet", MessageBoxButtons.OK);
                    tb_iazon.Focus();
                }
                else
                {
                    server = "linsql.verebely.dc";
                    database = "diak36";
                    username = "diak36";
                    password = "BXGERT";
                    kapcsolatnev = $"SERVER={server};DATABASE={database};UID={username};PASSWORD={password}";
                    MySqlConnection con = new MySqlConnection(kapcsolatnev);
                    con.Open();
                    lekerdezes = $"INSERT INTO ingatlan(iazon,kerulet,pazon,ar,uazon,nm,tipus,eladdatum) " +
                        $"VALUES('{tb_iazon.Text}','{tb_kerulet.Text}','{cb_partner.Text}','{tb_ar.Text}','{cb_ugynok.Text}','{tb_meret.Text}','{tb_tipus.Text}',null)";
                    MySqlCommand parancs = new MySqlCommand(lekerdezes, con);
                    MySqlDataReader mdr = parancs.ExecuteReader();
                    con.Close();
                    betoltes();
                }
            }
        }
    }
}
