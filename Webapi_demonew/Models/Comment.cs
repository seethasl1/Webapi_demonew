using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Webapi_demonew.Models
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public String UserComment { get; set; }
        public DateTime? Commentdate{ get; set; }
    }
}