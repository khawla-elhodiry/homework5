using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using teacher_attendance_DB_hw5.libraries;

namespace teacher_attendance_DB_hw5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teacher_attendanceDataSet2.room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.teacher_attendanceDataSet2.room);
            // TODO: This line of code loads data into the 'teacher_attendanceDataSet1.cource' table. You can move, or remove it, as needed.
            this.courceTableAdapter.Fill(this.teacher_attendanceDataSet1.cource);
            // TODO: This line of code loads data into the 'teacher_attendanceDataSet.teacher' table. You can move, or remove it, as needed.
            this.teacherTableAdapter.Fill(this.teacher_attendanceDataSet.teacher);
            dataGridView1.DataSource= DbOperations.Getattendance();
        }

        private void butt_add_Click(object sender, EventArgs e)
        {
            int tea_id = Convert.ToInt32(comboBox1.SelectedValue);
            int cource_id = Convert.ToInt32(comboBox2.SelectedValue);
            int room_id = Convert.ToInt32(comboBox3.SelectedValue);
            DbOperations.insert(tea_id, cource_id, room_id,
                this.DTP_start_time.Value.TimeOfDay, this.DTP_leave_time.Value.TimeOfDay
                ,textBox1.Text,this.DTP_date.Value);
            dataGridView1.DataSource = DbOperations.Getattendance();

        }
    }
}
