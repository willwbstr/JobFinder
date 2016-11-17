using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using JobFinderBU;

namespace JobFinderData
{
    public static class ContactDB
    {
        public static List<Contact> GetAll(string searchby)
        {
            List<Contact> contactList = new List<Contact>();
            SqlConnection connection = JobFinderDB.GetConnection();
            string selectStatement =
                "SELECT contactID, contactLastName, contactFirstName, businessID, contactEmail, methodOfContact, notes " +
                "FROM Contact";
            SqlCommand selectCommand = new SqlCommand(selectStatement + searchby, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Contact contact = new Contact();
                    contact.ContactID = reader["contactID"].ToString();
                    contact.ContactLastName = (string)reader["contactLastName"];
                    contact.ContactFirstName = (string)reader["contactFirstName"];
                    contact.BusinessID = (int)reader["businessID"];
                    contact.ContactEmail = reader["contactEmail"].ToString();
                    contact.MethodOfContact = reader["methodofContact"].ToString();
                    contact.Notes = reader["notes"].ToString();
                    contactList.Add(contact);

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
            return contactList;
        }
    }
}
