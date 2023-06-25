using AutoMapper;
using JobPortalAPI.Model;
using JobPortalAPI.Model.DTO;
using JobPortalAPI.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JobPortalAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthenticationController : Controller
    {
        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        public AuthenticationController(IAccountService accountService,IMapper mapper,IConfiguration configuration)
        {
            _accountService = accountService;
            _mapper = mapper;
            _configuration = configuration;
        }

        [HttpPost]
        [Route("register")]
        public bool Registration([FromBody]RegAccountDto regAccount)
        {
            return _accountService.Registration(_mapper.Map<RegAccount>(regAccount));
        }
        [HttpPost]
        [Route("login")]
        public JwtToken Login([FromBody]AuthAccount login) 
        { 
       
            
            RegAccount regAccount= _accountService.Login(login);

            if(regAccount == null)
            {
                return null;
            }
            return new JwtToken
            {
                Token = GenerateToken(regAccount),
                Role = regAccount.Role,
            };

        }
        [NonAction]
        public string GenerateToken([FromBody] RegAccount regAccount)
        {
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            var tkey = new SymmetricSecurityKey( Encoding.UTF8.GetBytes(_configuration["JWTToken:Key"]));
            var TokenDescp = new SecurityTokenDescriptor
            {
                Subject = new System.Security.Claims.ClaimsIdentity(
                    
                    new Claim[]
                    {
                        new Claim(ClaimTypes.Email,regAccount.UserEmail),
                        new Claim(ClaimTypes.Role, regAccount.Role),
                        new Claim(ClaimTypes.Name,regAccount.UserEmail)
                    }
                    ),
                Expires = DateTime.UtcNow.AddDays(1),
                Issuer= _configuration["JWTToken:Issuer"],
                Audience= _configuration["JWTToken:Audience"],    
                SigningCredentials = new SigningCredentials(tkey, SecurityAlgorithms.HmacSha256)
            };
            var JwtToken= tokenHandler.CreateJwtSecurityToken(TokenDescp);
            var encodeJWT =tokenHandler.WriteToken(JwtToken);
            return encodeJWT;

        }



        [HttpPost]
        [Route("forgotpassword")]
        public bool ForgetPassword([FromBody] ForgetPasswordDto Account) 
        {
            return _accountService.ForgetPassword(Account);
        }
        
    }
}
