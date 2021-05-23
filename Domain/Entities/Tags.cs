using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
 public   class Tags : AuditableEntity
    {
        public string Tag { get; set; }
        public Post Post { get; set; }
        public int   PostId { get; set; }

    }
}
