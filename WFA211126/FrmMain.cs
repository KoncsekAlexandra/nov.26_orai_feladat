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
    public partial class FrmMain : Form
    {
        public string ConnectionString { get; private set; }

        public FrmMain()
        {
            ConnectionString =
                "Server = (localdb)\\MSSQLLocalDB;" +
                "AttachDBFileName = |DataDirectory|\\zoldseges.mdf";
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
            => FillDGV();

        private void FillDGV()
        {
            dgv.Rows.Clear();
            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                var r = new SqlCommand(
                    "SELECT datum, nev, egysegAr * mennyiseg " +
                    "FROM zoldseg " +
                    "INNER JOIN eladas ON id = zoldseg " +
                    $"WHERE nev LIKE '{tbKereses.Text}%';", c)
                    .ExecuteReader();
                while (r.Read())
                {
                    dgv.Rows.Add(
                        r.GetDateTime(0).ToString("yyyy-MM-dd"),
                        r[1],
                        r[2] + " Ft");
                }
            }
        }

        private void TbKereses_TextChanged(object sender, EventArgs e)
            => FillDGV();

        private void BtnUjTermek_Click(object sender, EventArgs e)
            => new FrmUjTermek(ConnectionString).ShowDialog();
    }
}
