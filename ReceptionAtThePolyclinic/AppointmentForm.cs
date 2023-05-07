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
using Word = Microsoft.Office.Interop.Word;

namespace ReceptionAtThePolyclinic
{
    public partial class AppointmentForm : Form
    {
        private SqlConnection sqlConnection = null;

        private readonly string TemplateFileName = @"C:\Users\Emil\source\repos\ReceptionAtThePolyclinic\ReceptionAtThePolyclinic\TicketPattern\ticket.docx";

        public AppointmentForm(string patientCode, string patientSurname, string patientName, string patientMiddleName)
        {
            InitializeComponent();
            PatientCodeTextBox.Text = patientCode;
            PatientTextBox.Text = ($"{patientSurname} {patientName} {patientMiddleName}");
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
            SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT Tickets.Cabinet, Tickets.TicketCode, Tickets.Time AS Время, CONCAT(Patients.Surname, ' ', Patients.Name, ' ', Patients.MiddleName) AS Пациент FROM Patients RIGHT JOIN Tickets ON Patients.PatientCode = Tickets.PatientCode WHERE Date = '{MonthCalendar.SelectionRange.Start.ToShortDateString()}' AND EmployeeCode = '{EmployeeDataGridView.CurrentRow.Cells[0].Value.ToString()}'", sqlConnection);

            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet);

            ChooseTimeDataGridView.DataSource = dataSet.Tables[0];

            ChooseTimeDataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ChooseTimeDataGridView.Columns[2].Width = 70;
            ChooseTimeDataGridView.Columns[3].Width = 250;
            this.ChooseTimeDataGridView.Columns["Cabinet"].Visible = false;
            this.ChooseTimeDataGridView.Columns["TicketCode"].Visible = false;
        }

        private void MonthCalendar_DateChanged()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT Tickets.Cabinet, Tickets.TicketCode, Tickets.Time AS Время, CONCAT(Patients.Surname, ' ', Patients.Name, ' ', Patients.MiddleName) AS Пациент FROM Patients RIGHT JOIN Tickets ON Patients.PatientCode = Tickets.PatientCode WHERE Date = '{MonthCalendar.SelectionRange.Start.ToShortDateString()}' AND EmployeeCode = '{EmployeeDataGridView.CurrentRow.Cells[0].Value.ToString()}'", sqlConnection);

            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet);

            ChooseTimeDataGridView.DataSource = dataSet.Tables[0];

            ChooseTimeDataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ChooseTimeDataGridView.Columns[2].Width = 70;
            ChooseTimeDataGridView.Columns[3].Width = 250;
            this.ChooseTimeDataGridView.Columns["Cabinet"].Visible = false;
            this.ChooseTimeDataGridView.Columns["TicketCode"].Visible = false;
        }

        private void MakeAnAppointmentButton_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("UPDATE Tickets SET PatientCode = @PatientCode WHERE TicketCode = @TicketCode", sqlConnection);
            int patientCodeInt = int.Parse(PatientCodeTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@PatientCode", patientCodeInt);
            sqlCommand.Parameters.AddWithValue("@TicketCode", ChooseTimeDataGridView.CurrentRow.Cells[1].Value);
            if (sqlCommand.ExecuteNonQuery().ToString() == "1")
            {
                DialogResult dr = MessageBox.Show("Пациент записан. Напечатать талон?", "Печать талона", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    var position = EmployeeDataGridView.Columns[1].HeaderText;
                    var number = ChooseTimeDataGridView.CurrentRow.Cells[1].Value.ToString();
                    var date = MonthCalendar.SelectionRange.Start.ToShortDateString();
                    var time = ChooseTimeDataGridView.CurrentRow.Cells[2].Value.ToString();
                    var name = EmployeeDataGridView.CurrentRow.Cells[1].Value.ToString();
                    var cabinet = ChooseTimeDataGridView.CurrentRow.Cells[0].Value.ToString();

                    var wordApp = new Word.Application();
                    wordApp.Visible = false;

                    try
                    {
                        var wordDocument = wordApp.Documents.Open(TemplateFileName);
                        ReplaceWordStub("{position}", position, wordDocument);
                        ReplaceWordStub("{number}", number, wordDocument);
                        ReplaceWordStub("{date}", date, wordDocument);
                        ReplaceWordStub("{time}", time, wordDocument);
                        ReplaceWordStub("{name}", name, wordDocument);
                        ReplaceWordStub("{cabinet}", cabinet, wordDocument);

                        wordDocument.SaveAs(@"C:\Users\Emil\Desktop\ticket.docx");
                        wordApp.Visible = true;
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка формирования талона");
                    }
                }
            }
            else
            {
                MessageBox.Show("Ошибка записи");
            }

            MonthCalendar_DateChanged();
        }

        private void ReplaceWordStub(string stubToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }
    }
}
