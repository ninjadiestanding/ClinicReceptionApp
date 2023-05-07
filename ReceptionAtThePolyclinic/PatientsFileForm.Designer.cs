
namespace ReceptionAtThePolyclinic
{
    partial class PatientsFileForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AddPatientButton = new System.Windows.Forms.Button();
            this.PatientsFileTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PatientsFileDataGridView = new System.Windows.Forms.DataGridView();
            this.NameSearchTextBox = new System.Windows.Forms.TextBox();
            this.SurnameSearchTextBox = new System.Windows.Forms.TextBox();
            this.MiddleNameSearchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PatientSearchButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.MedicalPolicyNumberSearchTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PatientsFileTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsFileDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddPatientButton
            // 
            this.AddPatientButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.AddPatientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddPatientButton.Location = new System.Drawing.Point(17, 105);
            this.AddPatientButton.Name = "AddPatientButton";
            this.AddPatientButton.Size = new System.Drawing.Size(95, 31);
            this.AddPatientButton.TabIndex = 0;
            this.AddPatientButton.Text = "Добавить пациента";
            this.AddPatientButton.UseVisualStyleBackColor = false;
            this.AddPatientButton.Click += new System.EventHandler(this.AddPatientButton_Click);
            // 
            // PatientsFileTableLayoutPanel
            // 
            this.PatientsFileTableLayoutPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PatientsFileTableLayoutPanel.ColumnCount = 1;
            this.PatientsFileTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PatientsFileTableLayoutPanel.Controls.Add(this.PatientsFileDataGridView, 0, 0);
            this.PatientsFileTableLayoutPanel.Location = new System.Drawing.Point(14, 143);
            this.PatientsFileTableLayoutPanel.Name = "PatientsFileTableLayoutPanel";
            this.PatientsFileTableLayoutPanel.RowCount = 1;
            this.PatientsFileTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PatientsFileTableLayoutPanel.Size = new System.Drawing.Size(887, 422);
            this.PatientsFileTableLayoutPanel.TabIndex = 1;
            // 
            // PatientsFileDataGridView
            // 
            this.PatientsFileDataGridView.AllowUserToAddRows = false;
            this.PatientsFileDataGridView.AllowUserToDeleteRows = false;
            this.PatientsFileDataGridView.AllowUserToResizeColumns = false;
            this.PatientsFileDataGridView.AllowUserToResizeRows = false;
            this.PatientsFileDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PatientsFileDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.PatientsFileDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PatientsFileDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.PatientsFileDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PatientsFileDataGridView.Location = new System.Drawing.Point(3, 3);
            this.PatientsFileDataGridView.Name = "PatientsFileDataGridView";
            this.PatientsFileDataGridView.ReadOnly = true;
            this.PatientsFileDataGridView.RowHeadersVisible = false;
            this.PatientsFileDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PatientsFileDataGridView.Size = new System.Drawing.Size(881, 416);
            this.PatientsFileDataGridView.TabIndex = 0;
            this.PatientsFileDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.PatientsFileDataGridView_DataBindingComplete);
            this.PatientsFileDataGridView.DoubleClick += new System.EventHandler(this.PatientsFileDataGridView_DoubleClick);
            // 
            // NameSearchTextBox
            // 
            this.NameSearchTextBox.Location = new System.Drawing.Point(101, 45);
            this.NameSearchTextBox.Name = "NameSearchTextBox";
            this.NameSearchTextBox.Size = new System.Drawing.Size(151, 21);
            this.NameSearchTextBox.TabIndex = 2;
            // 
            // SurnameSearchTextBox
            // 
            this.SurnameSearchTextBox.Location = new System.Drawing.Point(101, 19);
            this.SurnameSearchTextBox.Name = "SurnameSearchTextBox";
            this.SurnameSearchTextBox.Size = new System.Drawing.Size(151, 21);
            this.SurnameSearchTextBox.TabIndex = 3;
            // 
            // MiddleNameSearchTextBox
            // 
            this.MiddleNameSearchTextBox.Location = new System.Drawing.Point(101, 72);
            this.MiddleNameSearchTextBox.Name = "MiddleNameSearchTextBox";
            this.MiddleNameSearchTextBox.Size = new System.Drawing.Size(151, 21);
            this.MiddleNameSearchTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Отчество";
            // 
            // PatientSearchButton
            // 
            this.PatientSearchButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PatientSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PatientSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatientSearchButton.Location = new System.Drawing.Point(319, 75);
            this.PatientSearchButton.Name = "PatientSearchButton";
            this.PatientSearchButton.Size = new System.Drawing.Size(87, 27);
            this.PatientSearchButton.TabIndex = 10;
            this.PatientSearchButton.Text = "Найти";
            this.PatientSearchButton.UseVisualStyleBackColor = false;
            this.PatientSearchButton.Click += new System.EventHandler(this.PatientSearchButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Номер медицинского полиса";
            // 
            // MedicalPolicyNumberSearchTextBox
            // 
            this.MedicalPolicyNumberSearchTextBox.Location = new System.Drawing.Point(272, 45);
            this.MedicalPolicyNumberSearchTextBox.Name = "MedicalPolicyNumberSearchTextBox";
            this.MedicalPolicyNumberSearchTextBox.Size = new System.Drawing.Size(172, 21);
            this.MedicalPolicyNumberSearchTextBox.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.PatientSearchButton);
            this.panel1.Controls.Add(this.MedicalPolicyNumberSearchTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.NameSearchTextBox);
            this.panel1.Controls.Add(this.SurnameSearchTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.MiddleNameSearchTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(425, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 119);
            this.panel1.TabIndex = 13;
            // 
            // PatientsFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(911, 577);
            this.Controls.Add(this.PatientsFileTableLayoutPanel);
            this.Controls.Add(this.AddPatientButton);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "PatientsFileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Картотека пациентов";
            this.Load += new System.EventHandler(this.PatientsFileForm_Load);
            this.PatientsFileTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PatientsFileDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddPatientButton;
        private System.Windows.Forms.TableLayoutPanel PatientsFileTableLayoutPanel;
        private System.Windows.Forms.TextBox NameSearchTextBox;
        private System.Windows.Forms.TextBox SurnameSearchTextBox;
        private System.Windows.Forms.TextBox MiddleNameSearchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button PatientSearchButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MedicalPolicyNumberSearchTextBox;
        private System.Windows.Forms.DataGridView PatientsFileDataGridView;
        private System.Windows.Forms.Panel panel1;
    }
}