using ImageFS;
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

namespace ImageSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Server = DESKTOP-1GLFNAF\SQLEXPRESS; Database =ImageDB; trusted_connection = true");
            connect.Open();
            SqlCommand cmd = new SqlCommand("ImageGet", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", txtText.Text);
            SqlDataReader dr = cmd.ExecuteReader();
           while(dr.Read())
            {
                picP1.Image =ImageProcessing.Base64ToImage( dr["ImageString"].ToString());
            }
            connect.Close();
        }
    }
}
