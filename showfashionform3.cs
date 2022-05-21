using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Teamproject1
{
    public partial class showfashionform3 : Form
    {
        MySQL mysql = new MySQL("127.0.0.1", "sys", "root", "rlathgml72");
        //bool result = false;
        public showfashionform3()
        {
            InitializeComponent();
        }

        private void toprecommand_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = mysql.Connection();
            string sql = "SELECT * FROM people_main";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataReader reader = new MySqlCommand(sql, connection).ExecuteReader();

            while (reader.Read())
            {
                var weather = "";
                var Tcloth = reader[3].ToString();
                MessageBox.Show("오늘은 날씨가 "+weather+"하니 "+Tcloth+"를 입는 것이 좋습니다!");
            }
            reader.Close();
            connection.Close();

        }

        private void bottomrecommand_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = mysql.Connection();
            string sql = "SELECT * FROM people_main";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataReader reader = new MySqlCommand(sql, connection).ExecuteReader();

            while (reader.Read())
            {
                var Tcloth = reader[3].ToString();
                var Bcloth = reader[4].ToString();
                MessageBox.Show(Tcloth +"에는" + Bcloth + "가 잘 어울릴 것 같아요!");
            }
            reader.Close();
            connection.Close();
        }

        private void accessory_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = mysql.Connection();
            string sql = "SELECT * FROM people_main";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataReader reader = new MySqlCommand(sql, connection).ExecuteReader();

            while (reader.Read())
            {
                var Tcloth = reader[3].ToString();
                var Bcloth = reader[4].ToString();
                var ac = reader[5].ToString();
                MessageBox.Show(Tcloth + "와" + Bcloth + "에는" + ac +"가 잘 어울릴 것 같아요!");
            }
            reader.Close();
            connection.Close();

        }

        private void extra_Click(object sender, EventArgs e)
        {
            
        }
    }
}
