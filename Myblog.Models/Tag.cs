using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myblog.Models
{
    class Tag
    {
        public int TagId { get; set; }
        public string TagName;
        public string TagDescription;
        public DateTime CreatedOn;
        public DateTime ModifiedOn;
        public string CreatedBy;
        public string ModifiedBy;
    }
}
