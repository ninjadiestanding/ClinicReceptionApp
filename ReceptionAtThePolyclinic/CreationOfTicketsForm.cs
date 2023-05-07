using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ReceptionAtThePolyclinic
{
    public partial class CreationOfTicketsForm : Form
    {
        private SqlConnection sqlConnection = null;

        public CreationOfTicketsForm()
        {
            InitializeComponent();
        }

        private void СreationOfTicketsForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
            sqlConnection.Open();

            if (sqlConnection.State != ConnectionState.Open)
            {
                MessageBox.Show("Подключение к базе данных не установлено! Обратитесь к системному администратору!");
            }

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT Position FROM Positions", sqlConnection);

            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet);

            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                PositionComboBox.Items.Add(dataSet.Tables[0].Rows[i].ItemArray[0].ToString());
            }
        }

        private void PositionComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            EmployeeComboBox.Text = null;

            SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT CONCAT(Surname, ' ', Name, ' ', MiddleName) AS ФИО FROM Employees JOIN Positions ON Positions.PositionCode = Employees.PositionCode WHERE Positions.Position = N'{PositionComboBox.Text}'", sqlConnection);

            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet);

            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                EmployeeComboBox.Items.Add(dataSet.Tables[0].Rows[i].ItemArray[0].ToString());
            }
        }

        private void CreateTicketsButton_Click(object sender, EventArgs e)
        {
            string s = EmployeeComboBox.Text;
            string[] initials = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT EmployeeCode FROM Employees WHERE Surname = N'{initials[0]}' AND Name = N'{initials[1]}' AND MiddleName = N'{initials[2]}'", sqlConnection);

            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet);


            TimeSpan[] ShiftArray;
            if (FirstShiftRadioButton.Checked == true)
            {
                ShiftArray = new TimeSpan[24] { new TimeSpan(08, 00, 00), new TimeSpan(08, 15, 00),
             new TimeSpan(08, 30, 00), new TimeSpan(08, 45, 00), new TimeSpan(09, 00, 00), new TimeSpan(09, 15, 00),
             new TimeSpan(09, 30, 00), new TimeSpan(09, 45, 00), new TimeSpan(10, 00, 00), new TimeSpan(10, 15, 00),
             new TimeSpan(10, 30, 00), new TimeSpan(10, 45, 00), new TimeSpan(11, 00, 00), new TimeSpan(11, 15, 00),
             new TimeSpan(11, 30, 00), new TimeSpan(11, 45, 00), new TimeSpan(12, 00, 00), new TimeSpan(12, 15, 00),
             new TimeSpan(12, 30, 00), new TimeSpan(12, 45, 00), new TimeSpan(13, 00, 00), new TimeSpan(13, 15, 00),
             new TimeSpan(13, 30, 00), new TimeSpan(13, 45, 00),};
            }
            else
            {
                ShiftArray = new TimeSpan[24] { new TimeSpan(14, 00, 00), new TimeSpan(14, 15, 00),
             new TimeSpan(14, 30, 00), new TimeSpan(14, 45, 00), new TimeSpan(15, 00, 00), new TimeSpan(15, 15, 00),
             new TimeSpan(15, 30, 00), new TimeSpan(15, 45, 00), new TimeSpan(16, 00, 00), new TimeSpan(16, 15, 00),
             new TimeSpan(16, 30, 00), new TimeSpan(16, 45, 00), new TimeSpan(17, 00, 00), new TimeSpan(17, 15, 00),
             new TimeSpan(17, 30, 00), new TimeSpan(17, 45, 00), new TimeSpan(18, 00, 00), new TimeSpan(18, 15, 00),
             new TimeSpan(18, 30, 00), new TimeSpan(18, 45, 00), new TimeSpan(19, 00, 00), new TimeSpan(19, 15, 00),
             new TimeSpan(19, 30, 00), new TimeSpan(19, 45, 00)};
            }

            for (int i = 0; i < ShiftArray.Length; i++)
            {
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO [Tickets] (Date, Time, Cabinet, EmployeeCode) VALUES (@Date, @Time, @Cabinet, @EmployeeCode)", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@Date", MonthCalendar.SelectionRange.Start.ToString("MM/dd/yyyy"));
                sqlCommand.Parameters.AddWithValue("@Time", ShiftArray[i]);
                sqlCommand.Parameters.AddWithValue("@Cabinet", int.Parse(CabinetComboBox.Text));
                sqlCommand.Parameters.AddWithValue("@EmployeeCode", int.Parse(dataSet.Tables[0].Rows[0].ItemArray[0].ToString()));
                sqlCommand.ExecuteNonQuery();
            }
            Close();
        }
    }
}
