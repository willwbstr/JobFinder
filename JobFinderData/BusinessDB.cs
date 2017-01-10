using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using JobFinderBU;


namespace JobFinderData
{
    public class BusinessDB
    {
        
        public static List<Business> GetAll(string find)
        {
            List<Business> businessList = new List<Business>();
            SqlConnection connection = JobFinderDB.GetConnection();
            string selectStatement =
                "SELECT Business.businessID, businessName, address, address2, city, state, zip, fax, businessPhone, email, website, Business.notes, Contact.contactID, contactLastName, contactFirstName, methodOfContact, jobDescription, sourceOfJob, salary, status, contactNumber " +
                "FROM Business " +
                "JOIN Contact ON Business.businessID = Contact.businessID " +
                "JOIN JOB ON Contact.contactID = Job.contactID " +
                "JOIN Phone ON Job.contactID = Phone.contactID " +
                find;
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Business business = new Business();
                    business.BusinessID = (int)reader["businessID"];
                    business.BusinessName = (string)reader["businessName"];
                    business.Address = reader["address"].ToString();
                    business.Address2 = reader["address2"].ToString();
                    business.City = (string)reader["city"];
                    business.State = (string)reader["state"];
                    business.Zip = (int)reader["zip"];
                    business.Email = reader["email"].ToString();
                    business.Fax = reader["fax"].ToString();
                    business.BusinessPhone = reader["businessPhone"].ToString();
                    business.Website = reader["website"].ToString();
                    business.Notes = reader["notes"].ToString();
                    businessList.Add(business);

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
            return businessList;
        }
        public static void UpdateBusiness()
        {
            SqlConnection connection = JobFinderDB.GetConnection();
            string updateStatement =
           "UPDATE Business " + " businessID = BusinessID, businessName = BusinessName, address = Address, address2 = Address2, city = City, state = State, zip = Zip, fax = Fax, businessPhone = BusinessPhone, email = Email, website = Website, notes = Notes " +
           "Where businessID = BusinessID";

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
