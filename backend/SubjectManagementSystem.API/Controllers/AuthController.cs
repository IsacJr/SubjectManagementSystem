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
        private readonly IAuthenticationService _authService;

        public AuthController(IAuthenticationService authService)
        {
            this._authService = authService;
        }

        [HttpPost("Auth")]
        [AllowAnonymous]
        public async Task<IActionResult> Auth([FromBody]AuthDto user)
        {
            try
            {
                //uma boa prática seria usar DI (Injeção de dependência)
                //mas não é o foco do artigo

                var userExists = await _authService.getByEmail(user.Email);

                if (userExists == null)
                    return BadRequest(new { Message = "Email e/ou senha está(ão) inválido(s)." });

                
                if(userExists.Password != user.Password)
                    return BadRequest(new { Message = "Email e/ou senha está(ão) inválido(s)." });


                var token = JwtAuth.GenerateToken(userExists);

                return Ok(new
                {
                    Jwt = token
                });

            }
            catch (Exception)
            {
                return BadRequest(new { Message = "Ocorreu algum erro interno na aplicação, por favor tente novamente." });
            }
        }
    }
}