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
                "SELECT phoneID, contactNumber, contactID, notes " +
                "FROM Phone ";
            SqlCommand selectCommand = new SqlCommand(selectStatement + searchby, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Phone phone = new Phone();
                    phone.PhoneID = (int)reader["phoneID"];
                    try { phone.ContactNumber = reader["contactNumber"].ToString(); }
                    catch { phone.ContactNumber = "No Number"; }
                    try { phone.Notes = (string)reader["notes"].ToString(); }
                    catch { phone.Notes = "Notes Are Blank"; }
                    phone.ContactID = (int)reader["contactID"];
                 
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
