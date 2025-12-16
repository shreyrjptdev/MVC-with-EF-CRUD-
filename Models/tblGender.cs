using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_with_EF__CRUD_.Models
{
    public class tblGender
    {
        [Key]
        public int gid { get; set; }
        public string gname { get; set; }
    }
}