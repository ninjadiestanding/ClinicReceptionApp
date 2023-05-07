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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = pictureBox1;
        }

        private void PatientsFileButton_Click(object sender, EventArgs e)
        {
            PatientsFileForm patientsFileForm = new PatientsFileForm();
            patientsFileForm.Show();
        }

        private void TimetableManagementButton_Click(object sender, EventArgs e)
        {
            TimetableManagementForm timetableManagementForm = new TimetableManagementForm();
            timetableManagementForm.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
