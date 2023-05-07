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
    public partial class PatientsFileForm : Form
    {
        private SqlConnection sqlConnection = null;

        public PatientsFileForm()
        {
            InitializeComponent();
        }

        private void PatientsFileForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
            sqlConnection.Open();

            if (sqlConnection.State != ConnectionState.Open)
            {
                MessageBox.Show("Подключение к базе данных не установлено! Обратитесь к системному администратору!");
            }

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT PatientCode, Surname AS Фамилия, Name AS Имя, MiddleName AS Отчество, DateOfBirth AS [Дата рождения], MedicalPolicyNumber AS [Медицинский полис], Snills AS СНИЛС FROM Patients", sqlConnection);

            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet);

            PatientsFileDataGridView.DataSource = dataSet.Tables[0];
            PatientsFileDataGridView.Columns["PatientCode"].Visible = false;

            PatientsFileDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            PatientsFileDataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void PatientsFileDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            PatientsFileDataGridView.ClearSelection();
        }

        private void AddPatientButton_Click(object sender, EventArgs e)
        {
            NewPatientCardForm newPatientCardForm = new NewPatientCardForm();
            newPatientCardForm.ShowDialog();

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT PatientCode, Surname AS Фамилия, Name AS Имя, MiddleName AS Отчество, DateOfBirth AS [Дата рождения], MedicalPolicyNumber AS [Медицинский полис], Snills AS СНИЛС FROM Patients", sqlConnection);

            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet);

            PatientsFileDataGridView.DataSource = dataSet.Tables[0];
            PatientsFileDataGridView.Columns["PatientCode"].Visible = false;

            PatientsFileDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            PatientsFileDataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void PatientSearchButton_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT PatientCode, Surname AS Фамилия, Name AS Имя, MiddleName AS Отчество, DateOfBirth AS [Дата рождения], MedicalPolicyNumber AS [Медицинский полис], Snills AS СНИЛС FROM Patients WHERE Surname LIKE N'%{SurnameSearchTextBox.Text}%' AND Name LIKE N'%{NameSearchTextBox.Text}%' AND MiddleName LIKE N'%{MiddleNameSearchTextBox.Text}%' AND MedicalPolicyNumber LIKE N'%{MedicalPolicyNumberSearchTextBox.Text}%'", sqlConnection);

            DataSet dataSet = new DataSet();
            
            dataAdapter.Fill(dataSet);

            PatientsFileDataGridView.DataSource = dataSet.Tables[0];

            PatientsFileDataGridView.Columns["PatientCode"].Visible = false;

            PatientsFileDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            PatientsFileDataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void PatientsFileDataGridView_DoubleClick(object sender, EventArgs e)
        {
            PatientCardForm patientCard = new PatientCardForm(PatientsFileDataGridView.CurrentRow.Cells[0].Value.ToString());
            patientCard.ShowDialog();

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT PatientCode, Surname AS Фамилия, Name AS Имя, MiddleName AS Отчество, DateOfBirth AS [Дата рождения], MedicalPolicyNumber AS [Медицинский полис], Snills AS СНИЛС FROM Patients", sqlConnection);

            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet);

            PatientsFileDataGridView.DataSource = dataSet.Tables[0];
            PatientsFileDataGridView.Columns["PatientCode"].Visible = false;

            PatientsFileDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            PatientsFileDataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
