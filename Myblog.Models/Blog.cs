using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myblog.Models
{
    class Blog
    {
        public int BlogId { get; set; }
        public string BlogName;
        public string OwnerName;
        public DateTime CreatedOn;
        public DateTime ModifiedOn;
        public string CreatedBy;
        public string ModifiedBy;
    }
}
