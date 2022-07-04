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

namespace WFA211126
{
    public partial class FrmUjTermek : Form
    {
        public string ConnectionString { get; set; }
        public FrmUjTermek(string connectionString)
        {
            ConnectionString = connectionString;
            InitializeComponent();
        }

        private void BtnUjTermek_Click(object sender, EventArgs e)
        {
            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();

                string nev = tbTermekNev.Text;
                string egysegAr = tbTermekEgysegAr.Text;

                try
                {
                    string errorMessage = "";
                    if (string.IsNullOrWhiteSpace(nev))
                        errorMessage += "A termék neve nem maradhat üresen!\n";
                    int ar;
                    if (!int.TryParse(egysegAr, out ar))
                        errorMessage += "A termék egységára nem szám!\n";
                    if (ar <= 0)
                        errorMessage += "Az egységár nem lehet 0 vagy negatív!\n";
                    if (!string.IsNullOrEmpty(errorMessage))
                        throw new Exception(errorMessage);

                    new SqlCommand(
                        "INSERT INTO zoldseg VALUES " +
                        $"('{nev}', {egysegAr});", c).ExecuteNonQuery();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

                MessageBox.Show("új termék sikeresen rögzítve!");
                Close();
            }
        }

        private void FrmUjTermek_Load(object sender, EventArgs e)
        {
            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                var r = new SqlCommand(
                    "SELECT TOP 1 id FROM zoldseg " +
                    "ORDER BY id DESC;", c)
                    .ExecuteReader();
                r.Read();
                tbID.Text = $"{r.GetInt32(0) + 1}";
            }
        }
    }
}
