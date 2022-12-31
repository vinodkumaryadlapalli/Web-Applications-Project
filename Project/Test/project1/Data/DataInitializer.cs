using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Test3.Models;

namespace Test3.Data
{
    // Q: Why do ducks have webbed feet?
    public class DataInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {
        //Create the data initializer to create a department called either "PokemonCards", "ClassicVideoGames", or "ChristmasDecorations", 3 products that are in that department
        //and a test user with the admin role (login: testUser, password: testUser)
        protected override void Seed(ApplicationDbContext context)
        {
            ApplicationUser testuser = new ApplicationUser
            {
                UserName = "testUser",
                Email = "test@test.ca"

            };

            UserStore<ApplicationUser> userStore = new UserStore<ApplicationUser>(context);
            UserManager<ApplicationUser> userManager = new UserManager<ApplicationUser>(userStore);

            IdentityRole role1 = new IdentityRole { Name = "Admin" };
            RoleStore<IdentityRole> roleStore = new RoleStore<IdentityRole>(context);
            RoleManager<IdentityRole> roleManager = new RoleManager<IdentityRole>(roleStore);

            roleManager.Create(role1);
            userManager.Create(testuser, "testUser");
            userManager.AddToRole(testuser.Id, "Admin");

            Department ClassicVideoGames = new Department
            {
                ID = 1,
                Name = "VideoGames",
            };

            Product p1 = new Product
            {
                ID = 1,
                Name = "Super Mario Bros",
                Cost = 15.99,
                Department = ClassicVideoGames
            };

            context.Products.Add(p1);


            context.Products.Add(new Product
            {
                ID = 2,
                Name = "Street Fighter",
                Cost = 11.50,
                Department = ClassicVideoGames
            });

            context.Products.Add(new Product
            {
                ID = 3,
                Name = "The Legend of Zelda",
                Cost = 12.00,
                Department = ClassicVideoGames
            });
            base.Seed(context);
        }
    }
}

    