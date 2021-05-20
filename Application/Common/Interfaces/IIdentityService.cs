using Application.Common.Dtos;

using Application.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IIdentityService
    {
        Task<string> GetUserNameAsync(int userId);

        Task<bool> IsInRoleAsync(int userId, string role);

        Task<bool> AuthorizeAsync(int userId, string policyName);

        Task<(Result Result, int UserId)> CreateUserAsync(int userId,string userName, string avatar);

        Task<Result> DeleteUserAsync(int userId);
        Task<bool> IsUserExistAsync(string userName);
        Task<IEnumerable< UserDto>> Get5lastUserRegisterOnSite();



    }
}
