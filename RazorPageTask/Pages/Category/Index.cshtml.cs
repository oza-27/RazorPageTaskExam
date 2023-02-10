using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPageTask.Data;

namespace RazorPageTask.Pages.Category
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public IEnumerable<Model.Category> Categories { get; set; }
        public void OnGet()
        {
            Categories = _db.categories;
        }
    }
}
