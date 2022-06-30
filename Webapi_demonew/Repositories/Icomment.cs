using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Webapi_demonew.Models;

namespace Webapi_demonew.Repositories
{
    interface Icomment
    {
        void InsertComment(Comment Comment); //Inserting
        IEnumerable<Comment> ListofComment();//List of comment
    }
}