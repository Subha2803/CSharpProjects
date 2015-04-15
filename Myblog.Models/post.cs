using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myblog.Models
{
    class Post
    {
        public int PostId { get; set; }
        public int BlogId { get; set; }
        public string Title;
        public string Body;
        public DateTime CreatedOn;
        public DateTime ModifiedOn;
        public string CreatedBy;
        public string ModifiedBy;
    }
    
}
