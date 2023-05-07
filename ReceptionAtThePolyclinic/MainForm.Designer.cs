
namespace ReceptionAtThePolyclinic
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PatientsFileButton = new System.Windows.Forms.Button();
            this.TimetableManagementButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PatientsFileButton
            // 
            this.PatientsFileButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PatientsFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PatientsFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatientsFileButton.Location = new System.Drawing.Point(45, 256);
            this.PatientsFileButton.Name = "PatientsFileButton";
            this.PatientsFileButton.Size = new System.Drawing.Size(221, 33);
            this.PatientsFileButton.TabIndex = 0;
            this.PatientsFileButton.Text = "Картотека пациентов";
            this.PatientsFileButton.UseVisualStyleBackColor = false;
            this.PatientsFileButton.Click += new System.EventHandler(this.PatientsFileButton_Click);
            // 
            // TimetableManagementButton
            // 
            this.TimetableManagementButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TimetableManagementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimetableManagementButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimetableManagementButton.Location = new System.Drawing.Point(45, 295);
            this.TimetableManagementButton.Name = "TimetableManagementButton";
            this.TimetableManagementButton.Size = new System.Drawing.Size(221, 35);
            this.TimetableManagementButton.TabIndex = 1;
            this.TimetableManagementButton.Text = "Управление расписанием";
            this.TimetableManagementButton.UseVisualStyleBackColor = false;
            this.TimetableManagementButton.Click += new System.EventHandler(this.TimetableManagementButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(45, 336);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(221, 33);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ReceptionAtThePolyclinic.Properties.Resources.nurse;
            this.pictureBox1.Location = new System.Drawing.Point(45, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(311, 390);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.TimetableManagementButton);
            this.Controls.Add(this.PatientsFileButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ИС Регистратура";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PatientsFileButton;
        private System.Windows.Forms.Button TimetableManagementButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

