using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechZone.Models;

namespace TechZone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        TechZoneContext _context = new TechZoneContext();

        //Product/GetAll

        [HttpGet]
        public ActionResult GetAll()
        {
            var products = _context.Products.ToList();
            return Ok(products);
        }
        [HttpGet("id")]
        //[HttpGet]
        //[Route("id")]
        public ActionResult GetById(int id)
        {
            var product = _context.Products.Find(id);
            if(product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
        [HttpPost]
        public ActionResult Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { ProudctId = product.ProductId }, "Product Created Successfully");
        }
        [HttpPut("id")]
        public ActionResult Edit(int id, Product product)
        {
            if(id != product.ProductId)
            {
                return BadRequest();
            }

            var ProductFromDB = _context.Products.Find(id);
            if(ProductFromDB == null)
            {
                return NotFound();
            }

            ProductFromDB.ProductId = product.ProductId;
            ProductFromDB.Name = product.Name;
            ProductFromDB.Price = product.Price;
            ProductFromDB.Description = product.Description;
            ProductFromDB.StockQuantity = product.StockQuantity;
            ProductFromDB.ImageUrl = product.ImageUrl;
            ProductFromDB.CreatedAt = product.CreatedAt;
            ProductFromDB.CategoryId = product.CategoryId;
            //_context.Update(product);//not important, because EF core will track the changes

            ProductFromDB.Category = product.Category;

            _context.SaveChanges();
            return NoContent();
        }
        [HttpDelete("id")]
        public ActionResult Delete(int id)
        {
            var product = _context.Products.Find(id);
            if(product == null)
            {
                return NotFound();
            }
            _context.Remove(product);
            _context.SaveChanges();

            _context.Database.ExecuteSqlRaw("DBCC CHECKIDENT ('Products', RESEED, 0);");
            return NoContent();
        }
    }
}
