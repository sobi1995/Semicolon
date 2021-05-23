using Application.Common.Dtos;
using Application.Common.Interfaces;
using Application.Common.Models;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Identity
{
    public class IdentityService : IIdentityService
    {
        private readonly UserManager<User> _userManager;
        private readonly IUserClaimsPrincipalFactory<User> _userClaimsPrincipalFactory;
        private readonly IAuthorizationService _authorizationService;
        private readonly SignInManager<User> _signInManager;
      
        public IdentityService(
            UserManager<User> userManager,
            IUserClaimsPrincipalFactory<User> userClaimsPrincipalFactory,
            IAuthorizationService authorizationService,
             SignInManager<User>  signInManager
              )
        {
            _userManager = userManager;
            _userClaimsPrincipalFactory = userClaimsPrincipalFactory;
            _authorizationService = authorizationService;
            _signInManager = signInManager;
           
        }

        public async Task<string> GetUserNameAsync(int userId)
        {
            var user = await _userManager.Users.FirstAsync(u => u.Id == userId);

            return user.UserName;
        }

        public async Task<(Result Result, int UserId)> CreateUserAsync(CreateAccountWithGitHubDto createUser)
        {
            var user = new User
            {
                Id= createUser.Id,
                UserName =createUser.UserName,
                Email = createUser.Email,
                Created=DateTime.Now,
                Avatar=createUser.Avatar_url,
                Bio=createUser.Bio
                
            };

            var result = await _userManager.CreateAsync(user);

            return (result.ToApplicationResult(), user.Id);
        }

        public async Task<bool> IsInRoleAsync(int userId, string role)
        {
            var user = _userManager.Users.SingleOrDefault(u => u.Id == userId);

            return await _userManager.IsInRoleAsync(user, role);
        }

        public async Task<bool> AuthorizeAsync(int userId, string policyName)
        {
            var user = _userManager.Users.SingleOrDefault(u => u.Id == userId);

            var principal = await _userClaimsPrincipalFactory.CreateAsync(user);

            var result = await _authorizationService.AuthorizeAsync(principal, policyName);

            return result.Succeeded;
        }

        public async Task<Result> DeleteUserAsync(int userId)
        {
            var user = _userManager.Users.SingleOrDefault(u => u.Id == userId);

            if (user != null)
            {
                return await DeleteUserAsync(user);
            }

            return Result.Success();
        }

        public async Task<Result> DeleteUserAsync(User user)
        {
            var result = await _userManager.DeleteAsync(user);

            return result.ToApplicationResult();
        }

        public async Task<bool> IsUserExistAsync(string userName)
        {
           
            return await _userManager.FindByNameAsync(userName) != null ? true : false;
        }

        public async Task<IEnumerable< UserDto>> Get5lastUserRegisterOnSite()
        {
            return await _userManager.Users.OrderByDescending(x => x.Created).Take(5).Select(x => new UserDto() { 
            
            Created=x.Created,
            
            UserName   =x.UserName
            
            }).ToListAsync();
        }

        public async Task< UserDto> GetUser(int userId)
        {
            return await _userManager.Users.Where(x=> x.Id==userId).Select(x=> new UserDto() {    
            Id=x.Id,
            Avatar=x.Avatar,
            Created=x.Created,
            UserName=x.UserName,
            Bio=x.Bio
            }).FirstAsync();
        }

        public async Task<UserDto> GetUser(string userName)
        {
            return await _userManager.Users.Where(x => x.UserName == userName).Select(x => new UserDto()
            {
                Id = x.Id,
                Avatar = x.Avatar,
                Created = x.Created,
                UserName = x.UserName,
                Bio = x.Bio
            }).FirstOrDefaultAsync();
        }
    }
}
