using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace csharpconnectoracle
{
    public partial class Form1 : Form
    {
        protected OracleConnection conn;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=orcl;Persist Security Info=True;User ID=viot;Password=viot ";
            conn = new OracleConnection(ConnectionString);
        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from ZHXT_TX_RY_RXZP";
            OracleDataReader dtr = cmd.ExecuteReader();

            int i = 0;
            while(dtr.Read()&&i<100)
            {
                tboracle.Text = tboracle.Text + dtr["ZPBH"] + "\r\n";
                i++;
            }
            dtr.Close();
            conn.Close();
        }

        private void btnselect1_Click(object sender, EventArgs e)
        {
            conn.Open();
            OracleDataAdapter dta = new OracleDataAdapter("select * from ZHXT_TX_RY_RXZP", conn);
            DataTable table = new DataTable("ZHXT_TX_RY_RXZP");
            dta.Fill(dataSet1,"table");
            
            foreach (DataRow theRow in dataSet1.Tables["table"].Rows)
            {
                tboracle.Text = theRow["ZPBH"].ToString() + "\r\n";
            }

            conn.Close();
        }
    }
}
