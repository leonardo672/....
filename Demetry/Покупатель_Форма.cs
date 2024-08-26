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

namespace Demetry
{
    public partial class Покупатель_Форма : Form
    {
        Подключения_ДБ DBConnection = new Подключения_ДБ();
        MySqlCommand Command;
        MySqlDataAdapter DA;
        DataTable DT;
        public Покупатель_Форма()
        {
            InitializeComponent();
            DBConnection.Connect();
        }

        private void Покупатель_Форма_Load(object sender, EventArgs e)
        {
            try
            {
                DBConnection.Connection.Open();
                Command = new MySqlCommand("Select * From покупатель", DBConnection.Connection);
                Command.ExecuteNonQuery();
                DT = new DataTable();
                DA = new MySqlDataAdapter(Command);
                DA.Fill(DT);
                ПокDGV.DataSource = DT.DefaultView;
                DBConnection.Connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
