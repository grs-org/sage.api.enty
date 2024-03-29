﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Uni.Sage.Api.Enty.Controllers
{
    public class AuthenticateController : BaseController
    {
        #region Property
        /// <summary>
        /// Property Declaration
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private readonly IConfiguration _config;

        #endregion

        #region Contructor Injector
        /// <summary>
        /// Constructor Injection to access all methods or simply DI(Dependency Injection)
        /// </summary>
        public AuthenticateController(IConfiguration config)
        {
            _config = config;
        }
        #endregion

        #region GenerateJWT
        /// <summary>
        /// Generate Json Web Token Method
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        private string GenerateJSONWebToken(LoginModel userInfo)
        {
            if (userInfo is null)
            {
                throw new ArgumentNullException(nameof(userInfo));
            }

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
              _config["Jwt:Issuer"],
              null,
              expires: DateTime.Now.AddDays(15),
              signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        #endregion

        #region AuthenticateUser
        /// <summary>
        /// Hardcoded the User authentication
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        private async Task<LoginModel> AuthenticateUser(LoginModel login)
        {
            LoginModel user = null;
            await Task.Delay(1);
            //Validate the User Credentials    
            //Demo Purpose, I have Passed HardCoded User Information    
            if (login.UserName.ToLower() == "sage")
            {
                user = new LoginModel { UserName = "sage", Password = "sage2022" };
            }
            return user;
        }
        #endregion

        #region Login Validation
        
        [AllowAnonymous]
        [HttpGet(nameof(Login))]
        public async Task<IActionResult> Login(string user,string password)
        {
            LoginModel data = new LoginModel { UserName = user, Password = password };
            IActionResult response = Unauthorized();

            var model = await AuthenticateUser(data);
            if (model != null)
            {
                var tokenString = GenerateJSONWebToken(model);
                response = Ok(new { Token = tokenString, Message = "Success" });
            }
             
            return response;
        }
        #endregion

        #region Get
        /// <summary>
        /// Authorize the Method
        /// </summary>
        /// <returns></returns>
        [HttpGet(nameof(Get))]
        public async Task<IActionResult> Get()
        {
            var accessToken = await HttpContext.GetTokenAsync("access_token");
            return Ok(new { Token = accessToken, Message = "Success" });
        }


        #endregion

    }

    #region JsonProperties
    /// <summary>
    /// Json Properties
    /// </summary>
    public class LoginModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
    #endregion
}
