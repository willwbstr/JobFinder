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
        public static List<Business> GetAll(string searchby)
        {
            List<Business> businessList = new List<Business>();
            SqlConnection connection = JobFinderDB.GetConnection();
            string selectStatement =
                "SELECT businessID, businessName, address, address2, city, state, zip, fax, businessPhone, email, website, notes " +
                "FROM Business";
            SqlCommand selectCommand = new SqlCommand(selectStatement + searchby, connection);

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
    }
}
