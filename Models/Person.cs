using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDataAccessDemo.Models
{
    public class Person
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public DateTime created { get; set; }
        public DateTime? updated { get; set; }

        public string fullInfo 
        {
            get 
            { 
                return  $"{first_name} {last_name} {email} {gender} {created} {updated}"; 
            }
        }

        public Person()
        {
        }

        public Person(int id, string first_name, string last_name, string email, string gender, DateTime created, DateTime updated)
        {
            this.id = id;
            this.first_name = first_name;
            this.last_name = last_name;
            this.email = email;
            this.gender = gender;
            this.created = created;
            this.updated = updated;
        }
    }
}
