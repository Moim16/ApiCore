using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using ApiCore.Dominio.Models;
using ApiCore.Dominio.Repositorio;
using ApiCore.Dominio.Servicios;
using ApiCore.Resources;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace ApiCore.Controllers
{
    [Authorize]
    [Route("api/[controller]")]   
    public class ProductsController : ControllerBase
    {
       // private readonly IProductService _productService;
        private readonly IMapper _mapper;
        private readonly ITodoRucContribuyente _todoRucRepository;
        private readonly IUserService _userService;
        //private readonly IConfiguration _configuration;
        public ProductsController(/*IProductService productService,*/ IMapper mapper, ITodoRucContribuyente todoRucRepository/*,IConfiguration configuration*/,IUserService userService)
        {
            //_productService = productService;
            _mapper = mapper;
            _todoRucRepository = todoRucRepository;
            _userService = userService;
            //_configuration = configuration;
        }

        [AllowAnonymous]
       // [HttpPost("login")]
        public IActionResult Authenticate([FromBody]User userParam)
        {
            var user = _userService.Authenticate(userParam.Entidad, userParam.Contrasenia);

            if (user == null)
                return BadRequest(new { message = "Entidad o contraseña incorrecta",tipo=1 });

            return Ok(user);
        }
         

            

        //[HttpGet]
        //public async Task<IEnumerable<ProductResource>> ListAsync()
        //{
        //    var products = await _productService.ListAsync();
        //    var resources = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductResource>>(products);
        //    return resources;
        //}
        [HttpGet("{id}")]
        public async Task<IActionResult> ListAsyncRuc(int id)
        {
            //var tokenalfa=GenerarTokenJWT();
            

          var products = await _todoRucRepository.FindByIdAsyncRuc(id);
                
           
           return Ok(products);
        }


        //private string GenerarTokenJWT()
        //{
        //    // CREAMOS EL HEADER //
        //    var _symmetricSecurityKey = new SymmetricSecurityKey(
        //            Encoding.UTF8.GetBytes(_configuration["JWT:ClaveSecreta"])
        //        );
        //    var _signingCredentials = new SigningCredentials(
        //            _symmetricSecurityKey, SecurityAlgorithms.HmacSha256
        //        );
        //    var _Header = new JwtHeader(_signingCredentials);

        //    // CREAMOS LOS CLAIMS //
        //    var _Claims = new[] {
        //        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
        //        new Claim(JwtRegisteredClaimNames.NameId, ""),
        //        new Claim("entidad", "ENTIDADDGI"),
        //        new Claim("identidad", "IDENTIDADALFA"),
        //        new Claim(ClaimTypes.Actor, "DGI")
        //    };

        //    // CREAMOS EL PAYLOAD //
        //    var _Payload = new JwtPayload(
        //            issuer: _configuration["JWT:Issuer"],
        //            audience: _configuration["JWT:Audience"],
        //            claims: _Claims,
        //            notBefore: DateTime.Now,
        //            // Exipra a la 24 horas.
        //            expires: DateTime.Now.AddHours(24)
        //        );

        //    // GENERAMOS EL TOKEN //
        //    var _Token = new JwtSecurityToken(
        //            _Header,
        //            _Payload
        //        );

        //    return new JwtSecurityTokenHandler().WriteToken(_Token);
        //}


        //[HttpGet]
        //public async Task<IEnumerable<RucDto>> ListAsyncRuc()
        //{
        //    var products = await _todoRucRepository.ListAsyncRuc();
        //    var resources = _mapper.Map<IEnumerable<Ruc>, IEnumerable<RucDto>>(products);
        //    return resources;
        //}
    }
}