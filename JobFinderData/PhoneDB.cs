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
        public static List<Phone> GetAll(string find)
        {
            List<Phone> phoneList = new List<Phone>();
            SqlConnection connection = JobFinderDB.GetConnection();
            string selectStatement =
                "SELECT phoneID, contactNumber, contactID, notes " +
                "FROM Phone " + find;
            SqlCommand selectCommand = new SqlCommand(selectStatement + find, connection);
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
        public static void UpdatePhone()
        {
            SqlConnection connection = JobFinderDB.GetConnection();
            string updateStatement =
           "UPDATE Phone " + " SET  phoneID = PhoneID, contactNumber = ContactNumber, contactID = ContactID, notes = Notes "+
           "Where phoneID = PhoneID";

            try
            {
                connection.Open();
                SqlCommand selectCommand = new SqlCommand(updateStatement, connection);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
