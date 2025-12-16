using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_with_EF__CRUD_.Models
{
    public class tblStudent
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public int state { get; set; }
        public int city { get; set; }
    }
}