using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebHelsi.Entities;
using WebHelsi.ViewModel;

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
                foreach (var c in cities)
                {
                    var s = context.Cities.SingleOrDefault(x => x.Name == c);
                    if (s == null)
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

                #region Cliniks
                
                List<ClinicViewModels> clinics = new List<ClinicViewModels> {
                    new ClinicViewModels { Name="Міська Поліклініка №2", City = "Rivne", Street="вул.Грушевського"},
                     new ClinicViewModels { Name="Міська Поліклініка №3", City = "Rivne", Street="вул.Макарова"},
                      new ClinicViewModels { Name="Обласна Лікарня", City = "Rivne", Street="вул.Київська"},
                       new ClinicViewModels { Name="Міська Лікарня", City = "Rivne", Street="вул.Карнаухова"},
                       //---------------------------------------------------------------------------------------
                       new ClinicViewModels { Name="ДИТЯЧА КЛІНІЧНА ЛІКАРНЯ №6", City = "Kyiv", Street="вул.ТЕРЕЩЕНКІВСЬКА 23-25/10"},
                     new ClinicViewModels { Name="ДКЛ №4 Солом'янського району", City = "Kyiv", Street="вул. Стражеско Академіка 6А"},
                      new ClinicViewModels { Name="ДКЛ №7 Печерського району", City = "Kyiv", Street="вул. Підвисоцького Професора 4Б"},
                       new ClinicViewModels { Name="ДКЛ №9 Подільського району", City = "Kyiv", Street="вул. Копилівська 1/7"},
                             //---------------------------------------------------------------------------------------
                       new ClinicViewModels { Name="КНП Консультативно-діагностичний центр №20 ОМР", City = "Odessa", Street="вул. Левітана 62"},
                     new ClinicViewModels { Name="КНП Консультативно-діагностичний центр №29 ОМР", City = "Odessa", Street="вул. Заболотного Академіка 32"},
                        new ClinicViewModels { Name="Одеська міська лікарня №8", City = "Odessa", Street="вул. Фонтанська дорога 110"},
                       new ClinicViewModels { Name=" АМБУЛАТОРІЯ СІМЕЙНОГО ЛІКАРЯ", City = "Odessa", Street="вул. Ільфа та Петрова 8А"},

                };
                foreach (var h in clinics)
                {
                    //шукаємо місто по назві
                    //шукаємо клініку по назві, якщо клінікі немає, то додаємо
                    var findCity = context.Cities.SingleOrDefault(x => x.Name == h.City);
                    if (findCity != null)
                    {
                        var findClinic = context.Clinics.SingleOrDefault(x => x.Name == h.Name && x.CityId==findCity.Id);
                        {
                            if (findClinic == null)
                            {
                                context.Clinics.Add(new Clinic
                                {
                                    Name = h.Name,
                                    CityId = findCity.Id,
                                    Street = h.Street
                                });
                                context.SaveChanges();
                            }

                        }
                    }
                }
                #endregion

                #region Doctors

                List<DoctorViewModel> doctors = new List<DoctorViewModel> {
                   new DoctorViewModel{Name=" Оксана",Surname="Синюк",DateBirthday=new DateTime(1995,10,12) ,
                       Spetialization = "Педіатр",Clinic ="КНП Консультативно-діагностичний центр №20 ОМР", City = "Odessa",ImageDoctor="https://icon-library.net/images/icon-for-person/icon-for-person-1.jpg" },
                     //-----------------------------------------------------------------------------------
                };
                foreach (var h in doctors)
                {
                    //шукаємо місто по назві
                    //шукаємо клініку по назві, якщо клінікі немає, то додаємо
                    var findCity = context.Cities.SingleOrDefault(x => x.Name == h.City);
                    if (findCity != null)
                    {
                        var findClinic = context.Clinics.SingleOrDefault(x => x.Name == h.Name && x.CityId == findCity.Id);
                        {
                            if (findClinic == null)
                            {
                                context.Doctors.Add(new Doctor
                                {
                                    //Name = h.Name,
                                    //Surname = h.Surname,
                                    // = findCity.Id,
                                    //Street = h.Street
                                });
                                context.SaveChanges();
                            }

                        }
                    }
                }
                #endregion
            }
        }
    }
}
