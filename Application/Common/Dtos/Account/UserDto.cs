using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Dtos
{
 public   class UserDto
    {
        public int Id { get; set; }
        public string Avatar { get; set; }
        public DateTime Created { get; set; }
        public string  UserName { get; set; }
        public string Bio { get; set; }
    }
}
