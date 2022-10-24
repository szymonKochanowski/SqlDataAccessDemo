using SqlDataAccessDemo.Models;
using Dapper;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;

namespace SqlDataAccessDemo
{
    public class DatabaseAccess
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

        public List<Person> GetPersonListByLastName(string lastName)
        {
            List<Person> personList = new List<Person>();

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                // First way to write sql query in db
                //personList = connection.Query<Person>($"SELECT * FROM [DataAccessDemoDB].[dbo].[People] WHERE last_name ='{lastName}'").ToList();
                // Second way to write sql query in db
                personList = connection.Query<Person>("dbo.People_GetByLastName @last_name", new {last_name = lastName}).ToList();
                return personList;
            }
        }

        public void InsertPerson(string firstName, string lastName, string email, string gender)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                DateTime createdNow = DateTime.Now;
                DateTime? notUpdated = null;
                Person newPerson = new Person { first_name = firstName, last_name = lastName, email = email, gender = gender, created = createdNow, updated = notUpdated };
                List<Person> personList = new List<Person>();
                personList.Add(newPerson);

                // Third way to write sql query in db
                connection.Execute("dbo.People_Insert @first_name, @last_name, @email, @gender, @created, @updated", personList);
            }
        }
    }
}
