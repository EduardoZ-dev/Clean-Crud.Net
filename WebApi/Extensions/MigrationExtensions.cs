using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Extensions
{
    public static class MigrationExtensions
    {
        public static void ApplyMigrations(this WebApplication app)
        {
            using var score = app.Services.CreateScope();

            var dbContext = score.ServiceProvider.GetRequiredService<ApplicationDbContext>();

            dbContext.Database.Migrate();
        }
    }
}
