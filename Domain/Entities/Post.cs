using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
  public  class Post : AuditableEntity
    {
        //public Categories Categories { get; set; }
        //public int CategoriesId { get; set; }
        public ICollection<Tags> Tags { get; set; }
      
        public string Title { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
    }
}
