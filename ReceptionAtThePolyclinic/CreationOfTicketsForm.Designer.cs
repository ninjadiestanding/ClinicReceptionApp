
namespace ReceptionAtThePolyclinic
{
    partial class CreationOfTicketsForm
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
            this.PositionComboBox = new System.Windows.Forms.ComboBox();
            this.EmployeeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.FirstShiftRadioButton = new System.Windows.Forms.RadioButton();
            this.SecondShiftRadioButton = new System.Windows.Forms.RadioButton();
            this.CreateTicketsButton = new System.Windows.Forms.Button();
            this.CabinetComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PositionComboBox
            // 
            this.PositionComboBox.FormattingEnabled = true;
            this.PositionComboBox.Location = new System.Drawing.Point(127, 23);
            this.PositionComboBox.Name = "PositionComboBox";
            this.PositionComboBox.Size = new System.Drawing.Size(195, 21);
            this.PositionComboBox.TabIndex = 0;
            this.PositionComboBox.SelectedValueChanged += new System.EventHandler(this.PositionComboBox_SelectedValueChanged);
            // 
            // EmployeeComboBox
            // 
            this.EmployeeComboBox.FormattingEnabled = true;
            this.EmployeeComboBox.Location = new System.Drawing.Point(127, 55);
            this.EmployeeComboBox.Name = "EmployeeComboBox";
            this.EmployeeComboBox.Size = new System.Drawing.Size(195, 21);
            this.EmployeeComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Специальность";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(42, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Сотрудник";
            // 
            // MonthCalendar
            // 
            this.MonthCalendar.Location = new System.Drawing.Point(15, 119);
            this.MonthCalendar.Name = "MonthCalendar";
            this.MonthCalendar.TabIndex = 4;
            // 
            // FirstShiftRadioButton
            // 
            this.FirstShiftRadioButton.AutoSize = true;
            this.FirstShiftRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstShiftRadioButton.Location = new System.Drawing.Point(264, 183);
            this.FirstShiftRadioButton.Name = "FirstShiftRadioButton";
            this.FirstShiftRadioButton.Size = new System.Drawing.Size(76, 20);
            this.FirstShiftRadioButton.TabIndex = 5;
            this.FirstShiftRadioButton.TabStop = true;
            this.FirstShiftRadioButton.Text = "1 смена";
            this.FirstShiftRadioButton.UseVisualStyleBackColor = true;
            // 
            // SecondShiftRadioButton
            // 
            this.SecondShiftRadioButton.AutoSize = true;
            this.SecondShiftRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondShiftRadioButton.Location = new System.Drawing.Point(264, 209);
            this.SecondShiftRadioButton.Name = "SecondShiftRadioButton";
            this.SecondShiftRadioButton.Size = new System.Drawing.Size(76, 20);
            this.SecondShiftRadioButton.TabIndex = 6;
            this.SecondShiftRadioButton.TabStop = true;
            this.SecondShiftRadioButton.Text = "2 смена";
            this.SecondShiftRadioButton.UseVisualStyleBackColor = true;
            // 
            // CreateTicketsButton
            // 
            this.CreateTicketsButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CreateTicketsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTicketsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateTicketsButton.Location = new System.Drawing.Point(136, 293);
            this.CreateTicketsButton.Name = "CreateTicketsButton";
            this.CreateTicketsButton.Size = new System.Drawing.Size(86, 33);
            this.CreateTicketsButton.TabIndex = 7;
            this.CreateTicketsButton.Text = "Создать";
            this.CreateTicketsButton.UseVisualStyleBackColor = false;
            this.CreateTicketsButton.Click += new System.EventHandler(this.CreateTicketsButton_Click);
            // 
            // CabinetComboBox
            // 
            this.CabinetComboBox.FormattingEnabled = true;
            this.CabinetComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.CabinetComboBox.Location = new System.Drawing.Point(127, 86);
            this.CabinetComboBox.Name = "CabinetComboBox";
            this.CabinetComboBox.Size = new System.Drawing.Size(46, 21);
            this.CabinetComboBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(58, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Кабинет";
            // 
            // CreationOfTicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(354, 337);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CabinetComboBox);
            this.Controls.Add(this.CreateTicketsButton);
            this.Controls.Add(this.SecondShiftRadioButton);
            this.Controls.Add(this.FirstShiftRadioButton);
            this.Controls.Add(this.MonthCalendar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmployeeComboBox);
            this.Controls.Add(this.PositionComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CreationOfTicketsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание талонов";
            this.Load += new System.EventHandler(this.СreationOfTicketsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PositionComboBox;
        private System.Windows.Forms.ComboBox EmployeeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar MonthCalendar;
        private System.Windows.Forms.RadioButton FirstShiftRadioButton;
        private System.Windows.Forms.RadioButton SecondShiftRadioButton;
        private System.Windows.Forms.Button CreateTicketsButton;
        private System.Windows.Forms.ComboBox CabinetComboBox;
        private System.Windows.Forms.Label label3;
    }
}