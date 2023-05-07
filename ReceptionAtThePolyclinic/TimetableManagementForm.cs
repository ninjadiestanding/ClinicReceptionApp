using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ReceptionAtThePolyclinic
{
    public partial class TimetableManagementForm : Form
    {
        private SqlConnection sqlConnection = null;

        public TimetableManagementForm()
        {
            InitializeComponent();
        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
            sqlConnection.Open();

            this.ActiveControl = EmployeeDataGridView;

            if (sqlConnection.State != ConnectionState.Open)
            {
                MessageBox.Show("Подключение к базе данных не установлено! Обратитесь к системному администратору!");
            }
        }

        private void EmployeeDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            EmployeeDataGridView.ClearSelection();
        }


        private void TherapistAppointmentButton_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT EmployeeCode, CONCAT(Surname, ' ', Name, ' ', MiddleName) AS [Врач-терапевт] FROM Employees WHERE PositionCode = 1", sqlConnection);

            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet);

            EmployeeDataGridView.DataSource = dataSet.Tables[0];

            EmployeeDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            EmployeeDataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            EmployeeDataGridView.Columns["EmployeeCode"].Visible = false;
        }

        private void SurgeonAppointmentButton_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT EmployeeCode, CONCAT(Surname, ' ', Name, ' ', MiddleName) AS [Врач-хирург] FROM Employees WHERE PositionCode = 2", sqlConnection);

            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet);

            EmployeeDataGridView.DataSource = dataSet.Tables[0];

            EmployeeDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            EmployeeDataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            EmployeeDataGridView.Columns["EmployeeCode"].Visible = false;
        }

        private void DermatologistAppointmentButton_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT EmployeeCode, CONCAT(Surname, ' ', Name, ' ', MiddleName) AS [Врач-дерматолог] FROM Employees WHERE PositionCode = 3", sqlConnection);

            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet);

            EmployeeDataGridView.DataSource = dataSet.Tables[0];

            EmployeeDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            EmployeeDataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            EmployeeDataGridView.Columns["EmployeeCode"].Visible = false;
        }

        private void NeurologistAppointmentButton_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT EmployeeCode, CONCAT(Surname, ' ', Name, ' ', MiddleName) AS [Врач-невролог] FROM Employees WHERE PositionCode = 5", sqlConnection);

            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet);

            EmployeeDataGridView.DataSource = dataSet.Tables[0];

            EmployeeDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            EmployeeDataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            EmployeeDataGridView.Columns["EmployeeCode"].Visible = false;
        }

        private void OtorhinolaryngologistAppointmentButton_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT EmployeeCode, CONCAT(Surname, ' ', Name, ' ', MiddleName) AS [Врач-оториноларинголог] FROM Employees WHERE PositionCode = 6", sqlConnection);

            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet);

            EmployeeDataGridView.DataSource = dataSet.Tables[0];

            EmployeeDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            EmployeeDataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            EmployeeDataGridView.Columns["EmployeeCode"].Visible = false;
        }

        private void UrologistAppointmentButton_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT EmployeeCode, CONCAT(Surname, ' ', Name, ' ', MiddleName) AS [Врач-уролог] FROM Employees WHERE PositionCode = 7", sqlConnection);

            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet);

            EmployeeDataGridView.DataSource = dataSet.Tables[0];

            EmployeeDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            EmployeeDataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            EmployeeDataGridView.Columns["EmployeeCode"].Visible = false;
        }

        private void OphthalmologistAppointmentButton_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT EmployeeCode, CONCAT(Surname, ' ', Name, ' ', MiddleName) AS [Врач-офтальмолог] FROM Employees WHERE PositionCode = 8", sqlConnection);

            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet);

            EmployeeDataGridView.DataSource = dataSet.Tables[0];

            EmployeeDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            EmployeeDataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            EmployeeDataGridView.Columns["EmployeeCode"].Visible = false;
        }

        private void InfectionistAppointmentButton_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT EmployeeCode, CONCAT(Surname, ' ', Name, ' ', MiddleName) AS [Врач-инфекционист] FROM Employees WHERE PositionCode = 9", sqlConnection);

            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet);

            EmployeeDataGridView.DataSource = dataSet.Tables[0];

            EmployeeDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            EmployeeDataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            EmployeeDataGridView.Columns["EmployeeCode"].Visible = false;
        }

        private void EndocrinologistAppointmentButton_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT EmployeeCode, CONCAT(Surname, ' ', Name, ' ', MiddleName) AS [Врач-эндокринолог] FROM Employees WHERE PositionCode = 10", sqlConnection);

            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet);

            EmployeeDataGridView.DataSource = dataSet.Tables[0];

            EmployeeDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            EmployeeDataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            EmployeeDataGridView.Columns["EmployeeCode"].Visible = false;
        }

        private void AllergistAppointmentButton_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT EmployeeCode, CONCAT(Surname, ' ', Name, ' ', MiddleName) AS [Врач-аллерголог] FROM Employees WHERE PositionCode = 11", sqlConnection);

            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet);

            EmployeeDataGridView.DataSource = dataSet.Tables[0];

            EmployeeDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            EmployeeDataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            EmployeeDataGridView.Columns["EmployeeCode"].Visible = false;
        }

        private void СardiologistAppointmentButton_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT EmployeeCode, CONCAT(Surname, ' ', Name, ' ', MiddleName) AS [Врач-кардиолог] FROM Employees WHERE PositionCode = 12", sqlConnection);

            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet);

            EmployeeDataGridView.DataSource = dataSet.Tables[0];

            EmployeeDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            EmployeeDataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            EmployeeDataGridView.Columns["EmployeeCode"].Visible = false;
        }

        private void MonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT Tickets.TicketCode, Tickets.Time AS Время, CONCAT(Patients.Surname, ' ', Patients.Name, ' ', Patients.MiddleName) AS Пациент FROM Patients RIGHT JOIN Tickets ON Patients.PatientCode = Tickets.PatientCode WHERE Date = '{MonthCalendar.SelectionRange.Start.ToShortDateString()}' AND EmployeeCode = '{EmployeeDataGridView.CurrentRow.Cells[0].Value.ToString()}'", sqlConnection);

            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet);

            ChooseTimeDataGridView.DataSource = dataSet.Tables[0];

            ChooseTimeDataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ChooseTimeDataGridView.Columns[1].Width = 70;
            ChooseTimeDataGridView.Columns[2].Width = 250;
            this.ChooseTimeDataGridView.Columns["TicketCode"].Visible = false;
        }

        private void MonthCalendar_DateChanged()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT Tickets.TicketCode, Tickets.Time AS Время, CONCAT(Patients.Surname, ' ', Patients.Name, ' ', Patients.MiddleName) AS Пациент FROM Patients RIGHT JOIN Tickets ON Patients.PatientCode = Tickets.PatientCode WHERE Date = '{MonthCalendar.SelectionRange.Start.ToShortDateString()}' AND EmployeeCode = '{EmployeeDataGridView.CurrentRow.Cells[0].Value.ToString()}'", sqlConnection);

            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet);

            ChooseTimeDataGridView.DataSource = dataSet.Tables[0];

            ChooseTimeDataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ChooseTimeDataGridView.Columns[1].Width = 70;
            ChooseTimeDataGridView.Columns[2].Width = 250;
            ChooseTimeDataGridView.Columns["TicketCode"].Visible = false;
        }

        private void CreateOfTicketsButton_Click(object sender, EventArgs e)
        {
            CreationOfTicketsForm creationOfTicketsForm;
            
            if (EmployeeDataGridView.Rows.Count == 0)
            {
                creationOfTicketsForm = new CreationOfTicketsForm();
                creationOfTicketsForm.ShowDialog();
                return;
            }

            var rows = EmployeeDataGridView.Rows;

            if (EmployeeDataGridView.Rows.Count > 0)
            {
                for (int i = 0; i < rows.Count; i++)
                {
                    if (rows[i].Selected == true)
                    {
                        creationOfTicketsForm = new CreationOfTicketsForm();
                        creationOfTicketsForm.ShowDialog();
                        MonthCalendar_DateChanged();
                        return;
                    }
                }
            }
            creationOfTicketsForm = new CreationOfTicketsForm();
            creationOfTicketsForm.ShowDialog();
        }
    }
}
