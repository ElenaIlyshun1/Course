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

                #region City
                string[] cities = {
                    "Рівне", "Київ","Харків","Одеса", "Дніпро","Запоріжжя","Львів","Кривий Ріг","Миколаїв","Маріуполь",
                    "Вінниця","Херсон","Полтава","Чернігів","Черкаси","Хмельницький"
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
                    "Дерматолог", "Сімейний терапевт","Педіатр","Хірург", "Отоларинголог","Кардіолог","Стоматолог","Ендокринолог",
                    "Гастроентеролог","Окуліст","Невропатолог","Травматолог","Пульмонолог","Онколог"
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

                List<ClinicVM> clinics = new List<ClinicVM> {
                    new ClinicVM { Name="Міська Поліклініка №2", City = "Рівне", Street="вул.Грушевського"},
                     new ClinicVM { Name="Міська Поліклініка №3", City = "Рівне", Street="вул.Макарова"},
                      new ClinicVM { Name="Обласна Лікарня", City = "Рівне", Street="вул.Київська"},
                       new ClinicVM { Name="Міська Лікарня", City = "Рівне", Street="вул.Карнаухова"},
                       //---------------------------------------------------------------------------------------
                       new ClinicVM { Name="ДИТЯЧА КЛІНІЧНА ЛІКАРНЯ №6", City = "Київ", Street="вул.ТЕРЕЩЕНКІВСЬКА 23-25/10"},
                     new ClinicVM { Name="ДКЛ №4 Солом'янського району", City = "Київ", Street="вул. Стражеско Академіка 6А"},
                      new ClinicVM { Name="ДКЛ №7 Печерського району", City = "Київ", Street="вул. Підвисоцького Професора 4Б"},
                       new ClinicVM { Name="ДКЛ №9 Подільського району", City = "Київ", Street="вул. Копилівська 1/7"},
                             //---------------------------------------------------------------------------------------
                       new ClinicVM { Name="КНП Консультативно-діагностичний центр №20 ОМР", City = "Одеса", Street="вул. Левітана 62"},
                     new ClinicVM { Name="КНП Консультативно-діагностичний центр №29 ОМР", City = "Одеса", Street="вул. Заболотного Академіка 32"},
                        new ClinicVM { Name="Одеська міська лікарня №8", City = "Одеса", Street="вул. Фонтанська дорога 110"},
                       new ClinicVM { Name=" АМБУЛАТОРІЯ СІМЕЙНОГО ЛІКАРЯ", City = "Одеса", Street="вул. Ільфа та Петрова 8А"},

                };
                foreach (var h in clinics)
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
                                context.Clinics.Add(new Clinic
                                {
                                    Name = h.Name,
                                    Street = h.Street,
                                    //City = h.City,
                                    CityId = findCity.Id
                                });
                                context.SaveChanges();
                            }

                        }
                    }
                }
                #endregion

                #region Doctors

                List<DoctorVM> doctors = new List<DoctorVM> {
                   new DoctorVM{Name=" Оксана",Surname="Синюк",DateBirthday=new DateTime(1965,10,12) , Email = "www@gmail.com",
                       Spetialization = "Педіатр",Clinic ="Міська Поліклініка №2", City = "Рівне",ImageDoctor="https://icon-library.net/images/icon-for-person/icon-for-person-1.jpg" },

                    new DoctorVM{Name=" Василь",Surname="Васинюк",DateBirthday=new DateTime(1975,10,11) , Email = "rrr@gmail.com",
                       Spetialization = "Дерматолог",Clinic ="КНП Консультативно-діагностичний центр №20 ОМР", City = "Одеса",ImageDoctor="https://icon-library.net/images/icon-for-person/icon-for-person-1.jpg" },

                    new DoctorVM{Name=" Тамара",Surname="Олексюк",DateBirthday=new DateTime(1987,08,07) , Email = "sss@gmail.com",
                       Spetialization = "Отоларинголог",Clinic ="Обласна Лікарня", City = "Рівне",ImageDoctor="https://icon-library.net/images/icon-for-person/icon-for-person-1.jpg" },

                    new DoctorVM{Name=" Володимир",Surname="Іванов",DateBirthday=new DateTime(1972,02,05) , Email = "dd@gmail.com",
                       Spetialization = "Кардіолог",Clinic ="Міська Лікарня", City = "Рівне",ImageDoctor="https://icon-library.net/images/icon-for-person/icon-for-person-1.jpg" },

                    new DoctorVM{Name=" Петро",Surname="Симончук",DateBirthday=new DateTime(1978,01,01) , Email = "ff@gmail.com",
                       Spetialization = "Невропатолог",Clinic ="ДКЛ №4 Солом'янського району", City = "Київ",ImageDoctor="https://icon-library.net/images/icon-for-person/icon-for-person-1.jpg" },

                    new DoctorVM{Name=" Степан",Surname="Миколюк",DateBirthday=new DateTime(1968,11,12) , Email = "gg@gmail.com",
                       Spetialization = "Хірург",Clinic ="ДИТЯЧА КЛІНІЧНА ЛІКАРНЯ №6", City = "Київ",ImageDoctor="https://icon-library.net/images/icon-for-person/icon-for-person-1.jpg" },

                    new DoctorVM{Name=" Олена",Surname="Кірчук",DateBirthday=new DateTime(1955,08,02) , Email = "hh@gmail.com",
                       Spetialization = "Сімейний терапевт",Clinic ="КНП Консультативно-діагностичний центр №20 ОМР", City = "Київ",ImageDoctor="https://icon-library.net/images/icon-for-person/icon-for-person-1.jpg" },

                    new DoctorVM{Name=" Тетяна",Surname="Горпинчук",DateBirthday=new DateTime(1959,11,22) , Email = "jj@gmail.com",
                       Spetialization = "Окуліст",Clinic ="КНП Консультативно-діагностичний центр №20 ОМР", City = "Одеса",ImageDoctor="https://icon-library.net/images/icon-for-person/icon-for-person-1.jpg" },

                    new DoctorVM{Name="Сергій",Surname="Петрушевський",DateBirthday=new DateTime(1978,09,10) , Email = "kkk@gmail.com",
                       Spetialization = "Дерматолог",Clinic ="Одеська міська лікарня №8", City = "Одеса",ImageDoctor="https://icon-library.net/images/icon-for-person/icon-for-person-1.jpg" },

                    new DoctorVM{Name=" Світлана",Surname="Романюк",DateBirthday=new DateTime(1990,10,12) , Email = "bbb@gmail.com",
                       Spetialization = "Ендокринолог",Clinic ="КНП Консультативно-діагностичний центр №29 ОМР", City = "Одеса",ImageDoctor="https://icon-library.net/images/icon-for-person/icon-for-person-1.jpg" },
                     //-----------------------------------------------------------------------------------
                };
                foreach (var h in doctors)
                {

                    var findCity = context.Cities.SingleOrDefault(x => x.Name == h.City);
                    if (findCity != null)
                    {
                        var findClinic = context.Clinics.SingleOrDefault(x => x.Name == h.Clinic && x.CityId == findCity.Id);
                        {
                            if (findClinic != null)
                            {
                                var findSpetialization = context.Specializations.SingleOrDefault(x => x.Name == h.Spetialization);
                                {
                                    if (findSpetialization != null)
                                    {
                                        var findDoctor = context.Doctors.SingleOrDefault(x => x.Name == h.Name && x.Surname == h.Surname && x.ClinicId == findClinic.Id);
                                        {
                                            if (findDoctor == null)
                                            {
                                                var findEmail = managerUser.FindByNameAsync(h.Email).Result;
                                                if (findEmail == null)
                                                {
                                                    var user = new DbUser
                                                    {
                                                        UserName = h.Email,
                                                        Email = h.Email
                                                    };


                                                    var result = managerUser.CreateAsync(user, "Qwerty1-").Result;
                                                    if (result.Succeeded)
                                                    {
                                                        context.Doctors.Add(new Doctor
                                                        {
                                                            Id = user.Id,
                                                            Name = h.Name,
                                                            Surname = h.Surname,
                                                            DateBirthday = h.DateBirthday,
                                                            ImageDoctor = h.ImageDoctor,
                                                            ClinicId = findClinic.Id,
                                                            SpecializationId = findSpetialization.Id
                                                        });
                                                        context.SaveChanges();
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                        }
                    }
                }
                #endregion

                //#region Clients

                //List<ClientVM> clients = new List<ClientVM> {
                //   new ClientVM{Name=" Оксана",Surname="Матвійчук",DateBirthday=new DateTime(1965,10,12) , Email = "oksana1423@gmail.com",Password="qwerty3456" },
                //    new ClientVM{Name=" Антон",Surname="Петровський",DateBirthday=new DateTime(1965,10,12) , Email = "retro4235@gmail.com",Password="anton1413"},
                //    new ClientVM{Name=" Вова",Surname="Михальчук",DateBirthday=new DateTime(1998,10,12) , Email = "bigl@gmail.com",Password="123456789"},
                //    new ClientVM{Name=" Гена",Surname="Петров",DateBirthday=new DateTime(1987,10,12) , Email = "gena@gmail.com",Password="gean12"},
                //    new ClientVM{Name=" Оля",Surname="Павліна",DateBirthday=new DateTime(2000,10,12) , Email = "olya@gmail.com",Password="olyag4oiu"},

                //};
                //foreach (var h in clients)
                //{
                //    var findClient = context.Clients.SingleOrDefault(x => x.Email == h.Email );
                //    if (findClient == null)
                //    {

                //        context.Clients.Add(new Client
                //        {
                //            Name = h.Name,
                //            Surname = h.Surname,
                //            Email = h.Email,
                //            DateBirthday = h.DateBirthday,
                //            Password = h.Password

                //        });
                //        context.SaveChanges();
                //    }
                //}
                //#endregion
            }
        }
    }
}
