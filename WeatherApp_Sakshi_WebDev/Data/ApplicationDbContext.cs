using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WeatherApp_Sakshi_WebDev.Models;

namespace WeatherApp_Sakshi_WebDev.Data
{
    // This is the ApplicationDbContext class responsible for managing database context
    // Author: Sakshi
    // Student Number: A00262877
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
