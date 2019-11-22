using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCore.Dominio.Models;
using ApiCore.Dominio.Servicios;
using ApiCore.Extensions;
using ApiCore.Resources;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCore.Controllers
{
    [Route("api/[controller]")]
    public class CategoriesController : Controller
    {
        private readonly ITodoRucContribuyente _categoryService;
        private readonly IMapper _mapper;

        public CategoriesController(ITodoRucContribuyente categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        //[HttpGet]
        //public async Task <IEnumerable<RucEmbajadorDto>> GetAllAsync()

        // {
        //     var ListAsyncRucEmbajador = await  _categoryService.ListAsyncRucEmbajador();
        //     var ListAsyncRucEmbajadordto = _mapper.Map<IEnumerable<RucEmbajador>, IEnumerable<RucEmbajadorDto>> (ListAsyncRucEmbajador);
        //     return ListAsyncRucEmbajadordto;
        // }

        // [HttpPost]
        // public async Task<IActionResult> PostAsync([FromBody] RucDto resource)
        // {
        //     if (!ModelState.IsValid)
        //         return BadRequest(ModelState.GetErrorMessages());
        //     var category = _mapper.Map<RucDto, Ruc>(resource);

        //     var result = await _categoryService.(category);

        //     if (!result.Success)
        //         return BadRequest(result.Message);

        //     var categoryResource = _mapper.Map<Category, CategoryResource>(result.Category);
        //     return Ok(categoryResource);


        // }

        // [HttpPut("{id}")]
        // public async Task<IActionResult> PutAsync(int id, [FromBody] SaveCategoryResource resource)
        // {
        //     if (!ModelState.IsValid)
        //         return BadRequest(ModelState.GetErrorMessages());

        //     var category = _mapper.Map<SaveCategoryResource, Category>(resource);
        //     var result = await _categoryService.UpdateAsync(id, category);

        //     if (!result.Success)
        //         return BadRequest(result.Message);

        //     var categoryResource = _mapper.Map<Category, CategoryResource>(result.Category);
        //     return Ok(categoryResource);
        // }

        // [HttpDelete("{id}")]
        // public async Task<IActionResult> DeleteAsync(int id)
        // {
        //     var result = await _categoryService.DeleteAsync(id);

        //     if (!result.Success)
        //         return BadRequest(result.Message);

        //     var categoryResource = _mapper.Map<Category, CategoryResource>(result.Category);
        //     return Ok(categoryResource);
        // }
    
    }
}