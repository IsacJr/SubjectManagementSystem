using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SubjectManagementSystem.Domain;
using SubjectManagementSystem.Repository;
using SubjectManagementSystem.Service;

namespace SubjectManagementSystem.API
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;

        public AuthController(IUserService userService)
        {
            this._userService = userService;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Auth([FromBody]User user)
        {
            try
            {
                //uma boa prática seria usar DI (Injeção de dependência)
                //mas não é o foco do artigo

                var userExists = await _userService.GetOne(user.Id);

                if (userExists == null)
                    return BadRequest(new { Message = "Email e/ou senha está(ão) inválido(s)." });

                
                if(userExists.Password != user.Password)
                    return BadRequest(new { Message = "Email e/ou senha está(ão) inválido(s)." });


                var token = JwtAuth.GenerateToken(userExists);

                return Ok(new
                {
                    Token = token,
                    Usuario = userExists
                });

            }
            catch (Exception)
            {
                return BadRequest(new { Message = "Ocorreu algum erro interno na aplicação, por favor tente novamente." });
            }
        }
    }
}