using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using System.Windows.Media;

namespace StudentRegistrationProject
{
    internal class ConnectToDB
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog = StudentRegSambedb; Integrated Security = True; TrustServerCertificate=True");
        SqlCommand command;
        SqlDataReader reader;
        DataRow row;
        public DataTable table;

        public void Registerstudent(int StudentId, string name, string surname, string address, string city, string cellPhone)
        {
            conn.Open();
            //command = new SqlCommand("INSERT INTO Student (StudentId, Name, Surname, Address, City, CellPhone) VALUES (@StudentId, @Name, @Surname, @Address, @City, @CellPhone)", conn);
            //command.Parameters.AddWithValue("@StudentId", StudentId);
            //command.Parameters.AddWithValue("@Name", name);
            //command.Parameters.AddWithValue("@Surname", surname);
            //command.Parameters.AddWithValue("@Address", address);
            //command.Parameters.AddWithValue("@City", city);
            //command.Parameters.AddWithValue("@CellPhone", cellPhone);
            command = new SqlCommand(string.Format("INSERT INTO StudentRegs (StudentID, Name, Surname, Address, City, CellPhone) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", StudentId, name, surname, address, city, cellPhone),conn);
            command.ExecuteNonQuery();
            conn.Close();
            command.Dispose();

        }

        public void Deletestudent(int StudentId)
        {
            conn.Open();
            command = new SqlCommand("DELETE FROM StudentRegs WHERE StudentID = @StudentId", conn);
            command.Parameters.AddWithValue("@StudentId", StudentId);
            command.ExecuteNonQuery();
            conn.Close();
            command.Dispose();
        }

        public void Updatestudent(int StudentId, string name, string surname, string address, string city, string cellPhone)
        {
            conn.Open();
            command = new SqlCommand("UPDATE StudentRegs SET Name = @Name, Surname = @Surname, Address = @Address, City = @City, CellPhone = @CellPhone WHERE StudentID = @StudentId", conn);
            command.Parameters.AddWithValue("@StudentId", StudentId);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Surname", surname);
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@City", city);
            command.Parameters.AddWithValue("@CellPhone", cellPhone);
            command.ExecuteNonQuery();
            conn.Close();
            command.Dispose();
        }

        public void DisplayStudents()
        {
            table = new DataTable();
            conn.Open();
            command = new SqlCommand("SELECT * FROM StudentRegs", conn);
            reader = command.ExecuteReader();
            for (int i = 0; i < reader.FieldCount; i++)
            {
                table.Columns.Add(reader.GetName(i));
            }
            while (reader.Read())
            {
                row = table.NewRow();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    row[i] = reader[i];
                }
                table.Rows.Add(row);
            }
            conn.Close();
            command.Dispose();
            reader.Close();
        }
    }


}
