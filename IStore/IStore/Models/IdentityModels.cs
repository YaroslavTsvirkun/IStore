using System;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace IStore.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    /// <summary>
    /// Класс ApplicationUser для работы с пользувателями в БД
    /// </summary>
    public class ApplicationUser : IdentityUser
    {
        /// <summary>
        /// Метод GenerateUserIdentityAsync записывает в БД
        /// </summary>
        /// <param name="manager"></param>
        /// <returns></returns>
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Обратите внимание, что authenticationType должен совпадать с типом, определенным в CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);

            // Здесь добавьте утверждения пользователя

            return userIdentity;
        }
    }

    /// <summary>
    /// Класс ApplicationDbContext инициализирует подключение к базе данных
    /// </summary>
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        /// <summary>
        /// Инициализация подключения к БД
        /// </summary>
        public ApplicationDbContext() : base("DefaultConnection", throwIfV1Schema: false) { }

        /// <summary>
        /// Метод Create создает сеанс связи с БД
        /// </summary>
        /// <returns></returns>
        public static ApplicationDbContext Create() => new ApplicationDbContext();
    }
}