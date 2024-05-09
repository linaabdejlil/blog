using Blog.Data;
using Blog.Models.Domain;
using Blog.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class AdminTagsController : Controller
    {
        private readonly BlogDbContext _blogDbContext;
        public AdminTagsController(BlogDbContext blogDbContext)
        {
            this._blogDbContext = blogDbContext;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Add")]
        public IActionResult Add (AddTagResquest addTagResquest)
        {
            //maping Addtagreauest to Tag domain model
            var tag = new Tag
            {
                Name = addTagResquest.Name,
                DispalyName = addTagResquest.DisplayName
            };


            _blogDbContext.Tags.Add(tag);
            _blogDbContext.SaveChanges();
            return View("Add");  
        }
    }
}
