using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuestbookAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GuestbookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationUserController : ControllerBase
    {
        private UserManager<ApplicationUser> _userMenager;
        private SignInManager<ApplicationUser> _signInMengager;

        public ApplicationUserController(UserManager<ApplicationUser> userMenager, SignInManager<ApplicationUser> signInManager)
        {
            _userMenager = userMenager;
            _signInMengager = signInManager;
        }
        [HttpPost]
        [Route("Register")]
        public async Task<Object> PostApplicationUser(ApplicationUserModel model)
        {
            var applicationUser = new ApplicationUser()
            {
                UserName = model.UserName,
                Email = model.Email,
                FullName = model.FullName,
            };
            try
            {
                IdentityResult result =  await _userMenager.CreateAsync(applicationUser, model.Password);
                return Ok(result);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}