using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Dtos 
{
  public  class CreateAccountWithGitHubDto
    {
        public int Id { get; set; }
        public  string  UserName { get; set; }
        public string Avatar_url { get; set; }
        public string Email { get; set; }
        public string Bio { get; set; }
    }
}
