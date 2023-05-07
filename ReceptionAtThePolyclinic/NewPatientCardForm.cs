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
    public partial class NewPatientCardForm : Form
    {
        private SqlConnection sqlConnection = null;
        string imgLoc = null;

        public NewPatientCardForm()
        {
            InitializeComponent();
        }

        private void NewPatientCardForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);

            sqlConnection.Open();

            if (sqlConnection.State != ConnectionState.Open)
            {
                MessageBox.Show("Подключение к базе данных не установлено! Обратитесь к системному администратору!");
            }
        }

        private void SaveCardButton_Click(object sender, EventArgs e)
        {
            string Gender;

            if (MaleRadioButton.Checked)
            {
                Gender = "Male";
            }
            else
            {
                Gender = "Female";
            }

            DateTime DateOfBirth = DateTime.Parse(DateOfBirthDateTimePicker.Text);

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
            }


            SqlCommand sqlCommand;

            if (imgLoc != null)
            {
                sqlCommand = new SqlCommand("INSERT INTO [Patients] (Surname, Name, MiddleName, DateOfBirth, Gender, Adress, SocialStatus, PlaceOfWork, PassportSeries, PassportNumber, PassportDateOfIssue, PassportIssuedBy, PassportDepartmentCode, MedicalPolicyNumber, Snills, PhoneNumber, Email, Photo) VALUES (@Surname, @Name, @MiddleName, @DateOfBirth, @Gender, @Adress, @SocialStatus, @PlaceOfWork, @PassportSeries, @PassportNumber, @PassportDateOfIssue, @PassportIssuedBy, @PassportDepartmentCode, @MedicalPolicyNumber, @Snills, @PhoneNumber, @Email, @Photo)", sqlConnection);
            }
            else
            {
                sqlCommand = new SqlCommand("INSERT INTO [Patients] (Surname, Name, MiddleName, DateOfBirth, Gender, Adress, SocialStatus, PlaceOfWork, PassportSeries, PassportNumber, PassportDateOfIssue, PassportIssuedBy, PassportDepartmentCode, MedicalPolicyNumber, Snills, PhoneNumber, Email) VALUES (@Surname, @Name, @MiddleName, @DateOfBirth, @Gender, @Adress, @SocialStatus, @PlaceOfWork, @PassportSeries, @PassportNumber, @PassportDateOfIssue, @PassportIssuedBy, @PassportDepartmentCode, @MedicalPolicyNumber, @Snills, @PhoneNumber, @Email)", sqlConnection);
            }
            
            sqlCommand.Parameters.AddWithValue("@Surname", SurnameTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@Name", NameTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@MiddleName", MiddleNameTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@DateOfBirth", $"{DateOfBirth.Month}/{DateOfBirth.Day}/{DateOfBirth.Year}");
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
            if (imgLoc != null)
            {
                sqlCommand.Parameters.AddWithValue("@Photo", img);
            }
            

            if (sqlCommand.ExecuteNonQuery().ToString() == "1")
            {
                MessageBox.Show("Карта создана");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ошибка создания");
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
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
