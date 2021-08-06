using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Tasker.Pages
{
    public class CreateTaskModel : PageModel
    {
        private ApplicationDbContext _context;

        [BindProperty]
        public Task NewTask { get; set; }
        
        public void OnGet()
        {
        }

        public CreateTaskModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            _context.Tasks.Add(NewTask);
            _context.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
