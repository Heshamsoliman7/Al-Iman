using Al_Iman.Models;
using Al_Iman.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Al_Iman.Utilities
{
    // This class is responsible for initializing the database with default values
    public class DbInitializer : IDbInitializer
    {
        private UserManager<IdentityUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;
        private ApplicationDbContext _context;

        // Constructor: here we inject the necessary services for this class
        public DbInitializer(UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager,
            ApplicationDbContext context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;
        }

        // This method initializes the database
        public void Initialize()
        {
            try
            {
                // Check if there are any pending migrations, and apply them if they exist
                if (_context.Database.GetPendingMigrations().Count() > 0)
                {
                    _context.Database.Migrate();
                }
            }
            catch (Exception)
            {
                // If there is any error during migration, it will be thrown to be handled by the caller
                throw;
            }

            // Check if the "WebSite_Admin" role exists; if not, create the necessary roles and a default admin user
            if (!_roleManager.RoleExistsAsync(WebSiteRoles.WebSite_Admin).GetAwaiter().GetResult())
            {
                // Creating roles in the system
                _roleManager.CreateAsync(new IdentityRole(WebSiteRoles.WebSite_Admin)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(WebSiteRoles.WebSite_Patient)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(WebSiteRoles.WebSite_Doctor)).GetAwaiter().GetResult();

                // Creating a default admin user
                _userManager.CreateAsync(new ApplicationUser
                {
                    UserName = "Hesham",
                    Email = "heshamsoliman@gmail.com"
                }, "Hesham@123").GetAwaiter().GetResult();

                // Fetching the newly created user from the database
                var Appuser = _context.ApplicationUsers.FirstOrDefault(x => x.Email == "heshamsoliman@gmail.com");

                // Assigning the "WebSite_Admin" role to the new user
                if (Appuser != null)
                {
                    _userManager.AddToRoleAsync(Appuser, WebSiteRoles.WebSite_Admin).GetAwaiter().GetResult();
                }
            }
        }
    }
}
