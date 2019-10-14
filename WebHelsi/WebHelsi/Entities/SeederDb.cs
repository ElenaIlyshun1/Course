using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebHelsi.Entities;

namespace WebHelsi.Entities
{
    public class SeederDB
    {
        //public static void SeedUsers(UserManager<DbUser> userManager,
        //    RoleManager<DbRole> roleManager)
        //{
        //    string roleName = "Admin";
        //    var role = roleManager.FindByNameAsync(roleName).Result;
        //    if (role == null)
        //    {
        //        role = new DbRole
        //        {
        //            Name = roleName
        //        };
        //        var addRoleResult = roleManager.CreateAsync(role).Result;
        //    }
        //    var userEmail = "bomba@gmail.com";
        //    var user = userManager.FindByEmailAsync(userEmail).Result;
        //    if (user == null)
        //    {
        //        user = new DbUser
        //        {
        //            Email = userEmail,
        //            UserName = userEmail
        //        };
        //        var result = userManager.CreateAsync(user, "Qwerty1-").Result;
        //        if (result.Succeeded)
        //        {
        //            result = userManager.AddToRoleAsync(user, roleName).Result;
        //        }

        //    }
        //}

        //public static void Seed(EFDbContext context, DbProduct model)
        //{
        //    var prod = context.Products.SingleOrDefault(p => p.Name == model.Name);
        //    if (prod == null)
        //    {
        //        prod = new DbProduct
        //        {
        //            Name = model.Name,
        //            Price = model.Price,
        //            DateCreate = DateTime.Now
        //        };
        //       context.Products.Add(prod);
        //       context.SaveChanges();
        //    }
        //}
        public static void SeedData(IServiceProvider services, IHostingEnvironment env,
            IConfiguration config)
        {
            using (var scope = services.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<EFDbContext>();
                var managerUser = scope.ServiceProvider.GetRequiredService<UserManager<DbUser>>();
                var managerRole = scope.ServiceProvider.GetRequiredService<RoleManager<DbRole>>();
                //Seed(managerUser, managerRole);
                //string name = "i7-7700K";
                //var prod = context.Products.SingleOrDefault(p => p.Name == name);
                //if (prod == null)
                //{
                //    prod = new DbProduct
                //    {
                //        Name = name,
                //        Price = 10000,
                //        DateCreate = DateTime.Now
                //    };
                //    context.Products.Add(prod);
                //    context.SaveChanges();
                //}
                //var context = scope.ServiceProvider.GetRequiredService<EFDbContext>();
                #region City
                string[] cities = {
                    "Rivne", "Kyiv","Kharkiv","Odessa", "Dnipro","Zaporizhia","Lviv","Kryvyi Rih","Mykolaiv","Mariupol",
                    "Vinnytsia","Kherson","Poltava","Chernihiv","Cherkasy","Khmelnytskyi"
                };
                foreach(var c in cities)
                {
                    var s = context.Cities.SingleOrDefault(x=> x.Name== c);
                    if(s==null)
                    {
                        context.Cities.Add(new City
                        {
                            Name = c
                        });
                        context.SaveChanges();
                    }
                }
                #endregion
                #region Specialization
                string[] specializations = {
                    "Dermatologist", "Family Physician","Pediatrician","Obstetrician", "Surgeon","Psychiatrist","Cardiologist","Endocrinologist",
                    "Gastroenterologist","Nephrologist","Ophthalmologist","Otolaryngologist","Pulmonologist","Neurologist","Radiologist","Anesthesiologist","Oncologist"
                };
                foreach (var h in specializations)
                {
                    var a = context.Specializations.SingleOrDefault(x => x.Name == h);
                    if (a == null)
                    {
                        context.Specializations.Add(new Specialization
                        {
                            Name = h
                        });
                        context.SaveChanges();
                    }
                }          
                #endregion

            }
        }
    }
}
