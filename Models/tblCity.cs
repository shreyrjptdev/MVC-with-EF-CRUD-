using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_with_EF__CRUD_.Models
{
    public class tblCity
    {
        [Key]
        public int cid { get; set; }
        public int sid { get; set; }
        public string cname { get; set; }
    }
}