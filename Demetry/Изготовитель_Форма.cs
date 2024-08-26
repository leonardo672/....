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
    public partial class Изготовитель_Форма : Form
    {
        Подключения_ДБ DBConnection = new Подключения_ДБ();
        MySqlCommand Command;
        MySqlDataAdapter DA;
        DataTable DT;
        public Изготовитель_Форма()
        {
            InitializeComponent();
            DBConnection.Connect();

        }

        private void Изготовитель_Форма_Load(object sender, EventArgs e)
        {
            try
            {
                DBConnection.Connection.Open();
                Command = new MySqlCommand("Select * From изготовитель ", DBConnection.Connection);
                Command.ExecuteNonQuery();
                DT = new DataTable();
                DA = new MySqlDataAdapter(Command);
                DA.Fill(DT);
                изгDGV.DataSource = DT.DefaultView;
                DBConnection.Connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
