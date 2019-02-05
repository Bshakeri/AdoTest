using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class DatabaseContext : System.Data.Entity.DbContext
    {
        public DatabaseContext() //constuctor
        {
               
        }

        public System.Data.Entity.DbSet<Person> People { get; set; }
    }
}
