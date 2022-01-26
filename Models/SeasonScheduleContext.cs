using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HW4_Ynfante.Models
{
    public class SeasonScheduleContext : DbContext
    {
        public SeasonScheduleContext(DbContextOptions<SeasonScheduleContext> options)
            : base(options)
        { }

        public DbSet<SeasonSchedule> Schedules { get; set; }

        protected override void OnModelCreating(
            ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SeasonSchedule>().HasData(
                new SeasonSchedule
                {
                    WeekId = 1,
                    Date = "Sun, Sep 12",
                    Vs = "@",
                    TeamLogo = "Indianapolis.png",
                    Opponent = "Indianapolis",
                    Time = "12:00 PM",
                    Tv = "FOX"
                },
                new SeasonSchedule
                {
                    WeekId = 2,
                    Date = "Sun, Sep 19",
                    Vs = "vs",
                    TeamLogo = "Tennessee.png",
                    Opponent = "Tennessee",
                    Time = "3:25 PM",
                    Tv = "CBS"
                },
                new SeasonSchedule
                {
                    WeekId = 3,
                    Date = "Sun, Sep 26",
                    Vs = "@",
                    TeamLogo = "Minnesota.png",
                    Opponent = "Minnesota",
                    Time = "3:25 PM",
                    Tv = "FOX"
                },
                new SeasonSchedule
                {
                    WeekId = 4,
                    Date = "Sun, Oct 3",
                    Vs = "@",
                    TeamLogo = "San Francisco.png",
                    Opponent = "San Francisco",
                    Time = "3:05 PM",
                    Tv = "FOX"
                },
                new SeasonSchedule
                {
                    WeekId = 5,
                    Date = "Thu, Oct 7",
                    Vs = "vs",
                    TeamLogo = "Los Angeles.png",
                    Opponent = "Los Angeles",
                    Time = "7:20 PM",
                    Tv = "FOX, NFL"
                },
                new SeasonSchedule
                {
                    WeekId = 6,
                    Date = "Sun, Oct 17",
                    Vs = "@",
                    TeamLogo = "Pittsburgh.png",
                    Opponent = "Pittsburgh",
                    Time = "7:20 PM",
                    Tv = "NBC"
                },
                new SeasonSchedule
                {
                    WeekId = 7,
                    Date = "Mon, Oct 25",
                    Vs = "vs",
                    TeamLogo = "New Orleans.png",
                    Opponent = "New Orleans",
                    Time = "7:15 PM",
                    Tv = "ESPN"
                },
                new SeasonSchedule
                {
                    WeekId = 8,
                    Date = "Sun, Oct 31",
                    Vs = "vs",
                    TeamLogo = "Jacksonville.png",
                    Opponent = "Jacksonville",
                    Time = "3:05 PM",
                    Tv = "CBS"
                },
                new SeasonSchedule
                {
                    WeekId = 9,
                    Date = "BYE WEEK",
                    Vs = "",
                    TeamLogo = "blank.png",
                    Opponent = "",
                    Time = "",
                    Tv = ""
                },
                new SeasonSchedule
                {
                    WeekId = 10,
                    Date = "Sun, Nov 14",
                    Vs = "@",
                    TeamLogo = "Green Bay.png",
                    Opponent = "Green Bay",
                    Time = "3:25 PM",
                    Tv = "CBS"
                },
                new SeasonSchedule
                {
                    WeekId = 11,
                    Date = "Sun, Nov 21",
                    Vs = "vs",
                    TeamLogo = "Arizona.png",
                    Opponent = "Arizona",
                    Time = "3:25 PM",
                    Tv = "FOX"
                },
                new SeasonSchedule
                {
                    WeekId = 12,
                    Date = "Mon, Nov 29",
                    Vs = "@",
                    TeamLogo = "Washington.png",
                    Opponent = "Washington",
                    Time = "7:15 PM",
                    Tv = "ESPN"
                },
                new SeasonSchedule
                {
                    WeekId = 13,
                    Date = "Sun, Dec 5",
                    Vs = "vs",
                    TeamLogo = "San Francisco.png",
                    Opponent = "San Francisco",
                    Time = "7:20 PM",
                    Tv = "NBC"
                },
                new SeasonSchedule
                {
                    WeekId = 14,
                    Date = "Sun, Dec 12",
                    Vs = "@",
                    TeamLogo = "Houston.png",
                    Opponent = "Houston",
                    Time = "12:00 PM",
                    Tv = "FOX"
                },
                new SeasonSchedule
                {
                    WeekId = 15,
                    Date = "Sun, Dec 19",
                    Vs = "@",
                    TeamLogo = "Los Angeles.png",
                    Opponent = "Los Angeles",
                    Time = "3:25 PM",
                    Tv = "FOX"
                },
                new SeasonSchedule
                {
                    WeekId = 16,
                    Date = "Sun, Dec 26",
                    Vs = "vs",
                    TeamLogo = "Chicago.png",
                    Opponent = "Chicago",
                    Time = "3:05 PM",
                    Tv = "FOX"
                },
                new SeasonSchedule
                {
                    WeekId = 17,
                    Date = "Sun, Jan 2",
                    Vs = "vs",
                    TeamLogo = "Detroit.png",
                    Opponent = "Detroit",
                    Time = "3:25 PM",
                    Tv = "FOX"
                },
                new SeasonSchedule
                {
                    WeekId = 18,
                    Date = "Sun, Jan 9",
                    Vs = "@",
                    TeamLogo = "Arizona.png",
                    Opponent = "Arizona",
                    Time = "3:25 PM",
                    Tv = "FOX"
                }
            );
         }
    }
}
