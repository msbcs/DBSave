using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=MIC;Initial Catalog=TestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO insert_data(name, nationality, mb_no) VALUES ('"+txt_name.Text+"', '"+txt_nationality.Text+ "', '" + txt_mn.Text + "')", con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("saved");
            }
            else
            {
                MessageBox.Show("error");
            }

                con.Close();

        }

    }
}
