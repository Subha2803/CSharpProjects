using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myblog.Models
{
    class Comment
    {
        public int CommentId { get; set; }
        public string UserName;
        public string UserEmail;
        public string Content;
        public int PostId;
        public DateTime CreatedOn;
        public DateTime ModifiedOn;
        public string CreatedBy;
        public string ModifiedBy;
    }
}
