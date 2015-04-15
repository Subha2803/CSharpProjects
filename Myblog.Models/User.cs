using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myblog.Models
{
    class User
    {
        public int UserID { get; set; }
        public string Username;
        public string UserEmail;
        public DateTime CreatedOn;
        public DateTime ModifiedOn;
        public string CreatedBy;
        public string ModifiedBy;

    }
}
