using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BugTracker.Data;
using BugTracker.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

namespace BugTracker.Areas.Dashboard.Pages.Projects
{
    public class CreateModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly BugTracker.Data.ApplicationDbContext _context;
        private readonly ILogger<CreateModel> _logger;

        public CreateModel(BugTracker.Data.ApplicationDbContext context, UserManager<IdentityUser> userManager, ILogger<CreateModel> logger)
        {
            _context = context;
            _userManager = userManager;
            _logger = logger;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ProjectModel ProjectModel { get; set; }
        public ProjectUsers ProjectUsers = new ProjectUsers();

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
   
            _logger.LogInformation("This is happening");

            // TODO - Make this be globally viable
            DateTime localDate = DateTime.Now;
            IdentityUser identityUser = await _userManager.GetUserAsync(User);
            //int projectID = Project.ID;
                
            ProjectModel.Project.UserID = identityUser?.Id;
            ProjectUsers.UserID = identityUser?.Id;

            ProjectModel.Project.CreateDate = localDate;

            ProjectUsers.ProjectID = ProjectModel.Project.ID;
            ProjectUsers.CreateDate = localDate;
            
            _logger.LogInformation("I am about to submit Project to the database");

            _context.Project.Add(ProjectModel.Project);
            _context.ProjectUsers.Add(ProjectUsers);
            await _context.SaveChangesAsync();
 
            _logger.LogInformation("I have succeeded ?");

            return RedirectToPage("./Index");
        }
    }
}
