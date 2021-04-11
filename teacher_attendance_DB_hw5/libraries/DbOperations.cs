using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using teacher_attendance_DB_hw5.libraries;

namespace teacher_attendance_DB_hw5.libraries
{
    class DbOperations
    {
      
        public static DataTable Getattendance()
        {
            DbCommand comm = teacher_attendance_DB_hw5.libraries.DatabaseConnection.getConnection();
            comm.CommandText = "SELECT teacher.techer_name, cource.cource_name, room.room_name, attendance.start_time, attendance.leave_time, attendance.note, attendance.date FROM attendance INNER JOIN cource ON attendance.cource_id = cource.cource_id INNER JOIN room ON attendance.room_id = room.room_id INNER JOIN teacher ON attendance.teacher_id = teacher.teacher_id ";
            DataTable table;
            try
            {
                comm.Connection.Open();
                DbDataReader reader = comm.ExecuteReader();
                table = new DataTable();
                table.Load(reader);
                reader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                comm.Connection.Close();
            }
            return table;



        }
        public static void insert(int teacher_id , int cource_id , int room_id , TimeSpan start_time, TimeSpan leave_time, string note , DateTime date)
        {
            DbCommand comm = DatabaseConnection.getConnection();
            comm.CommandText = "INSERT INTO [attendance] ([teacher_id], [cource_id], [room_id], [start_time], [leave_time], [note], [date]) VALUES (@techer_id, @cource_id, @room_id, @start_time, @leave_time, @note, @date)";
            comm.Parameters.Add(new SqlParameter("@techer_id", teacher_id));

            comm.Parameters.Add(new SqlParameter("@cource_id", cource_id));

            comm.Parameters.Add(new SqlParameter("@room_id", room_id));

            comm.Parameters.Add(new SqlParameter("@start_time", start_time));

            comm.Parameters.Add(new SqlParameter("@leave_time", leave_time));

            comm.Parameters.Add(new SqlParameter("@note", note));

             comm.Parameters.Add(new SqlParameter("@date", date));
            int affectedRows = -1;
            try
            {
                // Open the connection of the command
                comm.Connection.Open();
                // Execute the command and get the number of affected rows
                affectedRows = comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Log eventual errors and rethrow them
                //Utilities.LogError(ex);
                throw;
            }
            finally
            {
                // Close the connection
                comm.Connection.Close();
            }
        }
    }
}
