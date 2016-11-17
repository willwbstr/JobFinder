using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using JobFinderBU;

namespace JobFinderData
{
    public static class PhoneDB
    {
        public static List<Phone> GetAll(string searchby)
        {
            List<Phone> phoneList = new List<Phone>();
            SqlConnection connection = JobFinderDB.GetConnection();
            string selectStatement =
                "SELECT phoneID, , contactNumber, contactID, notes " +
                "FROM Phone";
            SqlCommand selectCommand = new SqlCommand(selectStatement + searchby, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Phone phone = new Phone();
                    phone.PhoneID = (int)reader["phoneID"];
                    phone.ContactNumber = (string)reader["contactnumber"];
                    phone.Notes = (string)reader["notes"];
                    phone.ContactID = (int)reader["ContactID"];
                 
                    phoneList.Add(phone);

                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return phoneList;
        }
    }
}
