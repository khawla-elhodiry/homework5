
namespace teacher_attendance_DB_hw5
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DTP_start_time = new System.Windows.Forms.DateTimePicker();
            this.DTP_leave_time = new System.Windows.Forms.DateTimePicker();
            this.DTP_date = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.butt_add = new System.Windows.Forms.Button();
            this.teacher_attendanceDataSet = new teacher_attendance_DB_hw5.teacher_attendanceDataSet();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherTableAdapter = new teacher_attendance_DB_hw5.teacher_attendanceDataSetTableAdapters.teacherTableAdapter();
            this.teacher_attendanceDataSet1 = new teacher_attendance_DB_hw5.teacher_attendanceDataSet1();
            this.courceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courceTableAdapter = new teacher_attendance_DB_hw5.teacher_attendanceDataSet1TableAdapters.courceTableAdapter();
            this.teacher_attendanceDataSet2 = new teacher_attendance_DB_hw5.teacher_attendanceDataSet2();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomTableAdapter = new teacher_attendance_DB_hw5.teacher_attendanceDataSet2TableAdapters.roomTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacher_attendanceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacher_attendanceDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacher_attendanceDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 275);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(937, 223);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.teacherBindingSource, "teacher_id", true));
            this.comboBox1.DataSource = this.teacherBindingSource;
            this.comboBox1.DisplayMember = "techer_name";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(212, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 33);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "teacher_id";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.courceBindingSource, "cource_id", true));
            this.comboBox2.DataSource = this.courceBindingSource;
            this.comboBox2.DisplayMember = "cource_name";
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(212, 93);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(173, 33);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.ValueMember = "cource_id";
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.roomBindingSource, "room_id", true));
            this.comboBox3.DataSource = this.roomBindingSource;
            this.comboBox3.DisplayMember = "room_name";
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(212, 139);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(173, 33);
            this.comboBox3.TabIndex = 3;
            this.comboBox3.ValueMember = "room_id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Teacher Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cource_name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "room name";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(536, 199);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(481, 30);
            this.textBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(462, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Note";
            // 
            // DTP_start_time
            // 
            this.DTP_start_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_start_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTP_start_time.Location = new System.Drawing.Point(702, 56);
            this.DTP_start_time.Name = "DTP_start_time";
            this.DTP_start_time.Size = new System.Drawing.Size(167, 30);
            this.DTP_start_time.TabIndex = 9;
            // 
            // DTP_leave_time
            // 
            this.DTP_leave_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_leave_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTP_leave_time.Location = new System.Drawing.Point(702, 96);
            this.DTP_leave_time.Name = "DTP_leave_time";
            this.DTP_leave_time.Size = new System.Drawing.Size(167, 30);
            this.DTP_leave_time.TabIndex = 10;
            // 
            // DTP_date
            // 
            this.DTP_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_date.Location = new System.Drawing.Point(702, 142);
            this.DTP_date.Name = "DTP_date";
            this.DTP_date.Size = new System.Drawing.Size(167, 30);
            this.DTP_date.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(571, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Start Time";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(571, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Leave Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(606, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Date";
            // 
            // butt_add
            // 
            this.butt_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt_add.Location = new System.Drawing.Point(197, 202);
            this.butt_add.Name = "butt_add";
            this.butt_add.Size = new System.Drawing.Size(103, 38);
            this.butt_add.TabIndex = 15;
            this.butt_add.Text = "SAVE";
            this.butt_add.UseVisualStyleBackColor = true;
            this.butt_add.Click += new System.EventHandler(this.butt_add_Click);
            // 
            // teacher_attendanceDataSet
            // 
            this.teacher_attendanceDataSet.DataSetName = "teacher_attendanceDataSet";
            this.teacher_attendanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "teacher";
            this.teacherBindingSource.DataSource = this.teacher_attendanceDataSet;
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // teacher_attendanceDataSet1
            // 
            this.teacher_attendanceDataSet1.DataSetName = "teacher_attendanceDataSet1";
            this.teacher_attendanceDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courceBindingSource
            // 
            this.courceBindingSource.DataMember = "cource";
            this.courceBindingSource.DataSource = this.teacher_attendanceDataSet1;
            // 
            // courceTableAdapter
            // 
            this.courceTableAdapter.ClearBeforeFill = true;
            // 
            // teacher_attendanceDataSet2
            // 
            this.teacher_attendanceDataSet2.DataSetName = "teacher_attendanceDataSet2";
            this.teacher_attendanceDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "room";
            this.roomBindingSource.DataSource = this.teacher_attendanceDataSet2;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 510);
            this.Controls.Add(this.butt_add);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DTP_date);
            this.Controls.Add(this.DTP_leave_time);
            this.Controls.Add(this.DTP_start_time);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacher_attendanceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacher_attendanceDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacher_attendanceDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DTP_start_time;
        private System.Windows.Forms.DateTimePicker DTP_leave_time;
        private System.Windows.Forms.DateTimePicker DTP_date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button butt_add;
        private teacher_attendanceDataSet teacher_attendanceDataSet;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private teacher_attendanceDataSetTableAdapters.teacherTableAdapter teacherTableAdapter;
        private teacher_attendanceDataSet1 teacher_attendanceDataSet1;
        private System.Windows.Forms.BindingSource courceBindingSource;
        private teacher_attendanceDataSet1TableAdapters.courceTableAdapter courceTableAdapter;
        private teacher_attendanceDataSet2 teacher_attendanceDataSet2;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private teacher_attendanceDataSet2TableAdapters.roomTableAdapter roomTableAdapter;
    }
}

