using System.Collections.Generic;
using Domain;

namespace Persistence
{
  public class Seed
  {
    public static async Task SeedData(DataContext context)
    {
      if (context.Activities.Any()) return;

      var activities = new List<Activity>() {
        new Activity()
        {
          Title = "Past Activity 1",
          Date = DateTime.Now.AddMonths(-2),
          Description = "Activity 2 months ago",
          Category = "drinks",
          City = "London",
          venue = "Pub"
        },
        new Activity()
        {
          Title = "Past Activity 2",
          Date = DateTime.Now.AddMonths(-1),
          Description = "Activity 1 month ago",
          Category = "culture",
          City = "Paris",
          venue = "Louvre"
        },
        new Activity()
        {
          Title = "Future Activity 1",
          Date = DateTime.Now.AddMonths(1),
          Description = "Activity 1 month in the future",
          Category = "culture",
          City = "London",
          venue = "Natural History Museum"
        },
        new Activity()
        {
          Title = "Future Activity 2",
          Date = DateTime.Now.AddMonths(2),
          Description = "Activity 2 months in the future",
          Category = "music",
          City = "London",
          venue = "Another pub"
        },
        new Activity()
        {
          Title = "Future Activity 3",
          Date = DateTime.Now.AddMonths(3),
          Description = "Activity 3 months in the future",
          Category = "drinks",
          City = "London",
          venue = "Another pub"
        },
        new Activity()
        {
          Title = "Future Activity 4",
          Date = DateTime.Now.AddMonths(4),
          Description = "Activity 4 months in the future",
          Category = "drinks",
          City = "London",
          venue = "Yet another pub"
        },
        new Activity()
        {
          Title = "Future Activity 5",
          Date = DateTime.Now.AddMonths(5),
          Description = "Activity 5 months in the future",
          Category = "drinks",
          City = "London",
          venue = "Just another pub"
        },
        new Activity()
        {
          Title = "Future Activity 6",
          Date = DateTime.Now.AddMonths(6),
          Description = "Activity 6 months in the future",
          Category = "music",
          City = "London",
          venue = "Roundhouse Camden"
        },
        new Activity()
        {
          Title = "Future Activity 7",
          Date = DateTime.Now.AddMonths(7),
          Description = "Activity 7 months in the future",
          Category = "travel",
          City = "London",
          venue = "Somwhere in the Thames"
        },
        new Activity()
        {
          Title = "Future Activity 8",
          Date = DateTime.Now.AddMonths(8),
          Description = "Activity 8 months in the future",
          Category = "film",
          City = "London",
          venue = "Cinema"
        },
      };

      await context.Activities.AddRangeAsync(activities);
      await context.SaveChangesAsync();
    }
  }
}