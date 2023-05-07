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
using System.IO;

namespace ReceptionAtThePolyclinic
{
    public partial class PatientCardForm : Form
    {
        private SqlConnection sqlConnection = null;
        string PatientCode;
        string imgLoc = null;

        public PatientCardForm(string patientCode)
        {
            InitializeComponent();
            this.PatientCode = patientCode;
        }

        private void PatientCard_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);

            sqlConnection.Open();

            if (sqlConnection.State != ConnectionState.Open)
            {
                MessageBox.Show("Подключение к базе данных не установлено! Обратитесь к системному администратору!");
            }

            try
            {
                string sql = $"SELECT Photo From Patients WHERE PatientCode = {PatientCode}";
                if (sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();
                }
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    byte[] img = (byte[])(reader[0]);
                    if (img == null)
                    {
                        PhotoPictureBox.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        PhotoPictureBox.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    PhotoPictureBox.Image = null;
                    MessageBox.Show("Это не существует");
                }
                sqlConnection.Close();
            }
            catch
            {
                sqlConnection.Close();
                //MessageBox.Show(ex.Message);
            }

            SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT * FROM Patients WHERE PatientCode = {PatientCode}", sqlConnection);

            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet);

            CodeTextBox.Text = dataSet.Tables[0].Rows[0].ItemArray[0].ToString();
            SurnameTextBox.Text = dataSet.Tables[0].Rows[0].ItemArray[1].ToString();
            NameTextBox.Text = dataSet.Tables[0].Rows[0].ItemArray[2].ToString();
            MiddleNameTextBox.Text = dataSet.Tables[0].Rows[0].ItemArray[3].ToString();
            DateOfBirthDateTimePicker.Value = DateTime.Parse(dataSet.Tables[0].Rows[0].ItemArray[4].ToString());

            if (dataSet.Tables[0].Rows[0].ItemArray[5].ToString() == "Male")
            {
                MaleRadioButton.Checked = true;
            }
            else
            {
                FemaleRadioButton.Checked = true;
            }

            AdressTextBox.Text = dataSet.Tables[0].Rows[0].ItemArray[6].ToString();
            SocialStatusComboBox.Text = dataSet.Tables[0].Rows[0].ItemArray[7].ToString();
            PlaceOfWorkTextBox.Text = dataSet.Tables[0].Rows[0].ItemArray[8].ToString();

            PassportSeriesTextBox.Text = dataSet.Tables[0].Rows[0].ItemArray[9].ToString();
            PassportNumberTextBox.Text = dataSet.Tables[0].Rows[0].ItemArray[10].ToString();
            PassportDateOfIssueTextBox.Text = dataSet.Tables[0].Rows[0].ItemArray[11].ToString();
            PassportIssuedByTextBox.Text = dataSet.Tables[0].Rows[0].ItemArray[12].ToString();
            PassportDepartmentCodeTextBox.Text = dataSet.Tables[0].Rows[0].ItemArray[13].ToString();

            MedicalPolicyNumberTextBox.Text = dataSet.Tables[0].Rows[0].ItemArray[14].ToString();
            SnillsTextBox.Text = dataSet.Tables[0].Rows[0].ItemArray[15].ToString();
            PhoneNumberTextBox.Text = dataSet.Tables[0].Rows[0].ItemArray[16].ToString();
            EmailTextBox.Text = dataSet.Tables[0].Rows[0].ItemArray[17].ToString();

            SqlDataAdapter dataAdapter2 = new SqlDataAdapter($"SELECT Tickets.TicketCode AS [Номер талона], Tickets.Date AS Дата, Tickets.Time AS Время, Positions.Position AS [Врач-специалист], Cabinet AS Кабинет FROM Tickets JOIN Employees ON Tickets.EmployeeCode = Employees.EmployeeCode JOIN Positions ON Employees.PositionCode = Positions.PositionCode WHERE Tickets.PatientCode = {PatientCode}", sqlConnection);

            DataSet dataSet2 = new DataSet();

            dataAdapter2.Fill(dataSet2);

            PatientAppointmentsDataGridView.DataSource = dataSet2.Tables[0];

            PatientAppointmentsDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            PatientAppointmentsDataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void PatientCard_Load()
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);

            sqlConnection.Open();

            if (sqlConnection.State != ConnectionState.Open)
            {
                MessageBox.Show("Подключение к базе данных не установлено! Обратитесь к системному администратору!");
            }

            SqlDataAdapter dataAdapter1 = new SqlDataAdapter($"SELECT Tickets.TicketCode AS [Номер талона], Tickets.Date AS Дата, Tickets.Time AS Время, Positions.Position AS [Врач-специалист], Cabinet AS Кабинет FROM Tickets JOIN Employees ON Tickets.EmployeeCode = Employees.EmployeeCode JOIN Positions ON Employees.PositionCode = Positions.PositionCode WHERE Tickets.PatientCode = {PatientCode}", sqlConnection);

            DataSet dataSet1 = new DataSet();

            dataAdapter1.Fill(dataSet1);

            PatientAppointmentsDataGridView.DataSource = dataSet1.Tables[0];

            PatientAppointmentsDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            PatientAppointmentsDataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void PatientAppointmentsDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            PatientAppointmentsDataGridView.ClearSelection();
        }

        private void MakeAnAppointmentButton_Click(object sender, EventArgs e)
        {
            AppointmentForm appointmentForm = new AppointmentForm(CodeTextBox.Text, SurnameTextBox.Text, NameTextBox.Text, MiddleNameTextBox.Text);
            appointmentForm.ShowDialog();

            SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT Tickets.TicketCode AS [Номер талона], Tickets.Date AS Дата, Tickets.Time AS Время, Positions.Position AS [Врач-специалист], Tickets.Cabinet AS Кабинет FROM Tickets JOIN Employees ON Tickets.EmployeeCode = Employees.EmployeeCode JOIN Positions ON Employees.PositionCode = Positions.PositionCode WHERE Tickets.PatientCode = {PatientCode}", sqlConnection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            PatientAppointmentsDataGridView.DataSource = dataSet.Tables[0];

            PatientAppointmentsDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            PatientAppointmentsDataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void DeleteAppointmentButton_Click(object sender, EventArgs e)
        {
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
            SqlCommand sqlCommand = new SqlCommand("UPDATE Tickets SET Tickets.PatientCode = @PatientCode WHERE TicketCode = @TicketCode", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@PatientCode", DBNull.Value);
            sqlCommand.Parameters.AddWithValue("@TicketCode", PatientAppointmentsDataGridView.CurrentRow.Cells[0].Value);
            if (sqlCommand.ExecuteNonQuery().ToString() == "1")
            {
                MessageBox.Show("Запись удалена");
            }
            else
            {
                MessageBox.Show("Ошибка удаления записи");
            }

            PatientCard_Load();
        }

        private void EditCardButton_Click(object sender, EventArgs e)
        {
            EditCardButton.Visible = false;
            SaveCardButton.Visible = true;

            SurnameTextBox.ReadOnly = false;
            NameTextBox.ReadOnly = false;
            MiddleNameTextBox.ReadOnly = false;
            DateOfBirthDateTimePicker.Enabled = true;
            MaleRadioButton.Enabled = true;
            FemaleRadioButton.Enabled = true;
            AdressTextBox.ReadOnly = false;
            SocialStatusComboBox.Enabled = true;
            PlaceOfWorkTextBox.ReadOnly = false;

            PassportSeriesTextBox.ReadOnly = false;
            PassportNumberTextBox.ReadOnly = false;
            PassportDateOfIssueTextBox.ReadOnly = false;
            PassportIssuedByTextBox.ReadOnly = false;
            PassportDepartmentCodeTextBox.ReadOnly = false;

            MedicalPolicyNumberTextBox.ReadOnly = false;
            SnillsTextBox.ReadOnly = false;
            PhoneNumberTextBox.ReadOnly = false;
            EmailTextBox.ReadOnly = false;
            LoadPhotoButton.Enabled = true;
        }

        private void SaveCardButton_Click(object sender, EventArgs e)
        {
            EditCardButton.Visible = true;
            SaveCardButton.Visible = false;

            SurnameTextBox.ReadOnly = true;
            NameTextBox.ReadOnly = true;
            MiddleNameTextBox.ReadOnly = true;
            DateOfBirthDateTimePicker.Enabled = false;
            MaleRadioButton.Enabled = false;
            FemaleRadioButton.Enabled = false;
            AdressTextBox.ReadOnly = true;
            SocialStatusComboBox.Enabled = false;
            PlaceOfWorkTextBox.ReadOnly = true;

            PassportSeriesTextBox.ReadOnly = true;
            PassportNumberTextBox.ReadOnly = true;
            PassportDateOfIssueTextBox.ReadOnly = true;
            PassportIssuedByTextBox.ReadOnly = true;
            PassportDepartmentCodeTextBox.ReadOnly = true;

            MedicalPolicyNumberTextBox.ReadOnly = true;
            SnillsTextBox.ReadOnly = true;
            PhoneNumberTextBox.ReadOnly = true;
            EmailTextBox.ReadOnly = true;
            LoadPhotoButton.Enabled = false;

            string Gender;

            if (MaleRadioButton.Checked)
            {
                Gender = "Male";
            }
            else
            {
                Gender = "Female";
            }

            SqlCommand sqlCommand;
            byte[] img = null;
            if (imgLoc != null)
            {
                FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                if (sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();
                }
                sqlCommand = new SqlCommand($"UPDATE Patients SET Photo = @Photo WHERE PatientCode = @PatientCode", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@PatientCode", CodeTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@Photo", img);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }

            sqlCommand = new SqlCommand("UPDATE Patients SET Surname = @Surname, Name = @Name, MiddleName = @MiddleName, DateOfBirth = @DateOfBirth, Gender = @Gender, Adress = @Adress, SocialStatus = @SocialStatus, PlaceOfWork = @PlaceOfWork, PassportSeries = @PassportSeries, PassportNumber = @PassportNumber, PassportDateOfIssue = @PassportDateOfIssue, PassportIssuedBy = @PassportIssuedBy, PassportDepartmentCode = @PassportDepartmentCode, MedicalPolicyNumber = @MedicalPolicyNumber, Snills = @Snills, PhoneNumber = @PhoneNumber, Email = @Email WHERE PatientCode = @PatientCode", sqlConnection);
            sqlConnection.Open();
            sqlCommand.Parameters.AddWithValue("@PatientCode", CodeTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@Surname", SurnameTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@Name", NameTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@MiddleName", MiddleNameTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@DateOfBirth", DateOfBirthDateTimePicker.Value);
            sqlCommand.Parameters.AddWithValue("@Gender", Gender);
            sqlCommand.Parameters.AddWithValue("@Adress", AdressTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@SocialStatus", SocialStatusComboBox.Text);
            sqlCommand.Parameters.AddWithValue("@PlaceOfWork", PlaceOfWorkTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@PassportSeries", PassportSeriesTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@PassportNumber", PassportNumberTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@PassportDateOfIssue", PassportDateOfIssueTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@PassportIssuedBy", PassportIssuedByTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@PassportDepartmentCode", PassportDepartmentCodeTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@MedicalPolicyNumber", MedicalPolicyNumberTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@Snills", SnillsTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@PhoneNumber", PhoneNumberTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@Email", EmailTextBox.Text);

            if (sqlCommand.ExecuteNonQuery().ToString() == "1")
            {
                MessageBox.Show("Данные сохранены");
            }
            else
            {
                MessageBox.Show("Ошибка сохранения");
            }
        }

        private void LoadPhotoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    imgLoc = openFileDialog.FileName.ToString();
                    PhotoPictureBox.ImageLocation = imgLoc;
                    PhotoPictureBox.Tag = imgLoc;
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
