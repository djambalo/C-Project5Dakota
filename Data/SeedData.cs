using CourseCatalog.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseCatalog.Data;

public class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context =
               new CourseCatalogContext(serviceProvider.GetRequiredService<DbContextOptions<CourseCatalogContext>>()))
        {
            if (context == null || context.Course == null)
            {
                throw new ArgumentNullException("null context");
            }

            if (context.Course.Any())
            {
                return;
            }

            context.Course.AddRange(
                new Course()
                {
                    Id = 121,
                    CourseName = "CIS 121",
                    CourseDescription = "Logic",
                    RoomNumber = 116,
                    StartTime = new TimeOnly(8, 0, 0)
                },
                new Course()
                {
                    Id = 412,
                    CourseName = "CIS 412",
                    CourseDescription = "Cobol II",
                    RoomNumber = 120,
                    StartTime = new TimeOnly(9, 0, 0)
                },
                new Course()
                {
                    Id = 175,
                    CourseName = "CIS 175",
                    CourseDescription = "Java II",
                    RoomNumber = 200,
                    StartTime = new TimeOnly(13, 0, 0)
                },
                new Course()
                {
                    Id = 198,
                    CourseName = "CIS 198",
                    CourseDescription = "JavaScript",
                    RoomNumber = 116,
                    StartTime = new TimeOnly(11, 0, 0)
                },
                new Course()
                {
                    Id = 618,
                    CourseName = "CIS 618",
                    CourseDescription = ".Net",
                    RoomNumber = 112,
                    StartTime = new TimeOnly(8, 30, 0)
                }
            );
            context.SaveChanges();
        }
    }
}