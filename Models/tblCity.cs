using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

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