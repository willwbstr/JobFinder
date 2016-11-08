using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using JobFinderBU;

namespace JobFinderData
{
    public static class JobDB
    {
        public static List<Job> GetAll()
        {
            List<Job> jobList = new List<Job>();
            SqlConnection connection = JobFinderDB.GetConnection();
            string selectStatement =
                "SELECT jobID, jobs, sourceOfJob, salary, status, notes, contactID" +
                "FROM Job";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Job job = new Job();
                    job.JobID = (int)reader["jobID"];
                    job.Jobs = (string)reader["jobs"];
                    job.SourceOfJob = (string)reader["sourceOfJob"];
                    job.Salary = (decimal)reader["salary"];
                    job.Status = (string)reader["status"];
                    job.ContactID = (int)reader["contactID"];
                    job.Notes = (string)reader["notes"];
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
    }
}
