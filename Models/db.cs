using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_with_EF__CRUD_.Models
{
    public class db : DbContext
    {
        public db() : base("abc")
        {
        }
        public DbSet<tblStudent> tblStudents { get; set; }
        public DbSet<tblState> tblStates { get; set; }
        public DbSet<tblGender> tblGenders { get; set; }
    }
}