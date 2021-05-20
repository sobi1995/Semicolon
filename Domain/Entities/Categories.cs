using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
  public  class Categories : AuditableEntity
    {
        public string Name { get; set; }
        public Categories Categorie { get; set; }
        public int? CategoriesId { get; set; }
        public IList<Categories> CategoriesParent { get; set; }
        public string Icon { get; set; }

        public ICollection<Post> Post { get; set; }

    }
}
