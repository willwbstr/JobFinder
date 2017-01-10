using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using JobFinderBU;

namespace JobFinderData
{
    public class JobDB
    {
        public static List<Job> GetAll(string find)
        {
            List<Job> jobList = new List<Job>();
            SqlConnection connection = JobFinderDB.GetConnection();
            string selectStatement =
                "SELECT jobID, jobDescription, sourceOfJob, salary, status, notes, contactID " +
                "FROM Job ";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Job job = new Job();
                    job.JobID = (int)reader["jobID"];
                    job.JobDescription = (string)reader["jobDescription"];
                    job.SourceOfJob = (string)reader["sourceOfJob"];
                    try { job.Salary = decimal.Parse(reader["salary"].ToString()); }
                    catch { job.Salary = 0M; }
                    job.Status = (string)reader["status"];
                    job.ContactID = (int)reader["contactID"];
                    try { job.Notes = (string) reader["notes"].ToString(); }
                    catch { job.Notes = "Notes Are Blank"; }
                    jobList.Add(job);

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
            return jobList;
        }
        public static void UpdateJob()
        {
            SqlConnection connection = JobFinderDB.GetConnection();
            string updateStatement =
           "UPDATE Job "+ " SET jobDescription = JobDescription, sourceOfJob = SourceOfJob, salary = Salary, status = Status, notes = Notes, contactId = ContactID" +
           "Where jobID = JobID";

            try
            {
                connection.Open();
                SqlCommand selectCommand = new SqlCommand(updateStatement, connection);
            }
            catch(SqlException ex)
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
