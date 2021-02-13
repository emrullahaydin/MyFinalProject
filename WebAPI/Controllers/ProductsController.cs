using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //Loose coupled - Gevşek bağlılık
        //naming convention
        //IOC container = Inversion of control  - Değişimin Kontrolü
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
           _productService = productService;
        }


        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            //Dependency chain -- Bağımlılık          
            //IProductService productService = new ProductManager(new EfProductDal());

            var result = _productService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getById")]  //alias mantığı ile yapılabilir postmanda kontrol ediliyor.
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //[HttpPost("upp")]
        //public IActionResult upp(Product product)
        //{
        //    var result = _productService.Add(product);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}
    }
}
