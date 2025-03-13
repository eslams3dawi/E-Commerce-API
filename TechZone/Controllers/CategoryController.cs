using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechZone.Models;

namespace TechZone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        TechZoneContext _context = new TechZoneContext();

        [HttpGet]
        public ActionResult GetAll()
        {
            var categories = _context.Categories.ToList();
            return Ok(categories);
        }
        [HttpGet("id")]
        public ActionResult GetById(int id)
        {
            var category = _context.Categories.Find(id);
            if(category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }
        [HttpPost]
        public ActionResult Add(Category category)
        {
            _context.Add(category);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { CategoryId = category.CategoryId }, "Category Created Successfully");
        }
        [HttpPut("id")]
        public ActionResult Edit(int id, Category category)
        {
            if(id != category.CategoryId)
            {
                return BadRequest();
            }

            var CategoryFromDB = _context.Categories.Find(id);
            if(CategoryFromDB == null)
            {
                return NotFound();
            }

            CategoryFromDB.CategoryId = category.CategoryId;
            CategoryFromDB.Name = category.Name;
            CategoryFromDB.PatrentCategoryId = category.PatrentCategoryId;
            CategoryFromDB.CreatedAt = category.CreatedAt;
            CategoryFromDB.Products = category.Products;

            _context.SaveChanges();

            return NoContent();
        }
        [HttpDelete("id")]
        public ActionResult Delete(int id)
        {
            var category = _context.Categories.Find(id);
            if(category == null)
            {
                return NotFound();
            }
            _context.Remove(category);
            _context.SaveChanges();

            if(!_context.Categories.Any())//Reset Identity To Zero, when all rows are deleted
            {
                _context.Database.ExecuteSqlRaw("DBCC CHECKIDENT ('Categories', RESEED, 0);");
            }
            return NoContent();
        }
        [HttpDelete]
        public ActionResult DeleteAll()//Reset Identity To Zero, when all rows are deleted
        {
            var allCategories = _context.Categories.ToList();
            if(allCategories == null)
            {
                return NotFound();
            }
            _context.RemoveRange(allCategories);
            _context.SaveChanges();

            _context.Database.ExecuteSqlRaw("DBCC CHECKIDENT ('Categories', RESEED, 0);");

            return NoContent();
        }
    }
}
