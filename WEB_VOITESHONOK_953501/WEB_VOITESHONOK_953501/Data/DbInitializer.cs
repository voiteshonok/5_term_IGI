﻿using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_VOITESHONOK_953501.Entities;

namespace WEB_VOITESHONOK_953501.Data
{
    public class DbInitializer
    {
        public static async Task Seed(ApplicationDbContext context,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            // создать БД, если она еще не создана
            context.Database.EnsureCreated();

            // проверка наличия ролей
            if (!context.Roles.Any())
            {
                var roleAdmin = new IdentityRole
                {
                    Name = "admin",
                    NormalizedName = "admin"
                };
                // создать роль админ
                await roleManager.CreateAsync(roleAdmin);
            }

            // проверка наличия пользователей
            if (!context.Users.Any())
            {
                // создать пользователя user@mail.ru
                var user = new ApplicationUser
                {
                    Email = "user@mail.ru",
                    UserName = "user@mail.ru"
                };
                await userManager.CreateAsync(user, "123456");

                // создать пользователя admin@mail.ru
                var admin = new ApplicationUser
                {
                    Email = "admin@mail.ru",
                    UserName = "admin@mail.ru"
                };
                await userManager.CreateAsync(admin, "123456");
                // назначить роль admin
                admin = await userManager.FindByEmailAsync("admin@mail.ru");
                await userManager.AddToRoleAsync(admin, "admin");
            }
            //проверка наличия групп объектов
            if (!context.DishGroups.Any())
            {
                context.DishGroups.AddRange(
                    new List<DishGroup>
                    {
                        new DishGroup {GroupName="Стартеры"},
                        new DishGroup {GroupName="Салаты"},
                        new DishGroup {GroupName="Супы"},
                        new DishGroup {GroupName="Основные блюда"},
                        new DishGroup {GroupName="Напитки"},
                        new DishGroup {GroupName="Десерты"}
                    });
                await context.SaveChangesAsync();
            }

            // проверка наличия объектов
            if (!context.Dishes.Any())
            {
                context.Dishes.AddRange(
                    new List<Dish>
                    {
                        new Dish {DishId = 1, DishName="Суп-харчо", Description="Очень острый, невкусный", Calories =200, DishGroupId=3, Image="Суп.jpg" },
                        new Dish { DishId = 2, DishName="Борщ", Description="Много сала, без сметаны", Calories =330, DishGroupId=3, Image="Борщ.jpg" },
                        new Dish { DishId = 3, DishName="Котлета пожарская", Description="Хлеб - 80%, Морковь - 20%", Calories =635, DishGroupId=4, Image="Котлеты.jpg" },
                        new Dish { DishId = 4, DishName="Макароны по-флотски", Description="С охотничьей колбаской", Calories =524, DishGroupId=4, Image="Макароны.jpg" },
                        new Dish { DishId = 5, DishName="Компот", Description="Быстро растворимый, 2 литра", Calories =180, DishGroupId=5, Image="Компот.jpg" }
                    });
                await context.SaveChangesAsync();
            }
        }
    }
}
