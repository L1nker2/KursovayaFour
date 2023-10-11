using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.VisualBasic.ApplicationServices;

namespace Sushkov
{
    public class Driver
    {
        [Key]
        public int Driver_Id { get; set; }
        public string Driver_Fio { get; set; }
        public string Driver_Phone { get; set; }
    }
    public class Route
    {
        [Key]
        public int Route_Id { get; set; }
        public string Route_Start { get; set; }
        public string Route_End { get; set; }
        public string Route_Length { get; set; }
    }
    public class Schedule
    {
        [Key]
        public int Schedule_Id { get; set; }
        public string Schedule_Day { get; set; }
        public string Schedule_Start_Time { get; set; }
        public string Schedule_End_Time { get; set; }
        public int Route_Id { get; set; }
        public int Driver_Id { get; set; }
    }
    public class DriverDbContext : DbContext
    {
        //public string sqlstr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Roman\\Desktop\\Курсовая\\DataBase4.mdf;Integrated Security=True;Connect Timeout=30";
        public string sqlstr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\USER\\Documents\\DataBase4.mdf;Integrated Security=True;Connect Timeout=30";
        public DbSet<Driver> Drivers { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(sqlstr);
        }
        public void AddDriver(string DriverFio, string DriverPhone)
        {
            using (DriverDbContext context = new DriverDbContext())
            {
                Driver driver = new Driver
                {
                    Driver_Fio = DriverFio,
                    Driver_Phone = DriverPhone
                };
                context.Drivers.Add(driver);
                context.SaveChanges();
            }
        }
        public void RemoveDriver(int DriverId)
        {
            using (DriverDbContext context = new DriverDbContext())
            {
                var driver = context.Drivers.FirstOrDefault(el => el.Driver_Id == DriverId);
                if(driver != null)
                {
                    context.Remove(driver);
                    context.SaveChanges();
                }
            }
        }
        public void EditDriver(int DriverId, string DriverFio, string DriverPhone)
        {
            using (DriverDbContext context = new DriverDbContext())
            {
                var driver = context.Drivers.FirstOrDefault(el => el.Driver_Id == DriverId);
                if(driver != null)
                {
                    driver.Driver_Fio = DriverFio;
                    driver.Driver_Phone = DriverPhone;
                    context.SaveChanges();
                }
            }
        }
    }
    public class RouteDbContext : DbContext
    {
        //public string sqlstr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Roman\\Desktop\\Курсовая\\DataBase4.mdf;Integrated Security=True;Connect Timeout=30";
        public string sqlstr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\USER\\Documents\\DataBase4.mdf;Integrated Security=True;Connect Timeout=30";
        public DbSet<Route> Routes { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(sqlstr);
        }
        public void AddRoute(string RouteStart, string RouteEnd, string RouteLength)
        {
            using(RouteDbContext context = new RouteDbContext())
            {
                Route route = new Route
                {
                    Route_Start = RouteStart,
                    Route_End = RouteEnd,
                    Route_Length = RouteLength
                };
                context.Routes.Add(route);
                context.SaveChanges();
            }
        }
        public void RemoveRoute(int RouteId)
        {
            using(RouteDbContext context = new RouteDbContext())
            {
                var route = context.Routes.FirstOrDefault(el => el.Route_Id == RouteId);
                if(route != null)
                {
                    context.Routes.Remove(route);
                    context.SaveChanges();
                }
            }
        }
        public void EditRoute(int RouteId, string RouteStart, string RouteEnd, string RouteLength)
        {
            using(RouteDbContext context = new RouteDbContext())
            {
                var route = context.Routes.FirstOrDefault(el => el.Route_Id == RouteId);
                if(route != null)
                {
                    route.Route_Start = RouteStart;
                    route.Route_End = RouteEnd;
                    route.Route_Length = RouteLength;
                    context.SaveChanges();
                }
            }
        }
    }
    public class ScheduleDbContext : DbContext
    {
        //public string sqlstr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Roman\\Desktop\\Курсовая\\DataBase4.mdf;Integrated Security=True;Connect Timeout=30";
        public string sqlstr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\USER\\Documents\\DataBase4.mdf;Integrated Security=True;Connect Timeout=30";
        public DbSet<Schedule> Schedules { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(sqlstr);
        }
        public void AddSchedule(string ScheduleDay, string ScheduleStartTime, string ScheduleEndTime, int RouteId, int DriverId)
        {
            using(ScheduleDbContext context = new ScheduleDbContext())
            {
                Schedule schedule = new Schedule
                {
                    Schedule_Day = ScheduleDay,
                    Schedule_Start_Time = ScheduleStartTime,
                    Schedule_End_Time = ScheduleEndTime,
                    Route_Id = RouteId,
                    Driver_Id = DriverId
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
            }
        }
        public void RemoveSchedule(int ScheduleId)
        {
            using(ScheduleDbContext context = new ScheduleDbContext())
            {
                var schedule = context.Schedules.FirstOrDefault(el => el.Schedule_Id == ScheduleId);
                if(schedule != null)
                {
                    context.Schedules.Remove(schedule);
                    context.SaveChanges();
                }
            }
        }
        public void EditSchedule(int ScheduleId, string ScheduleDay, string ScheduleStartTime, string ScheduleEndTime, int RouteId, int DriverId)
        {
            using(ScheduleDbContext context = new ScheduleDbContext())
            {
                var schedule = context.Schedules.FirstOrDefault(el => el.Schedule_Id == ScheduleId);
                if (schedule != null)
                {
                    schedule.Schedule_Day = ScheduleDay;
                    schedule.Schedule_Start_Time = ScheduleStartTime;
                    schedule.Schedule_End_Time = ScheduleEndTime;
                    schedule.Route_Id = RouteId;
                    schedule.Driver_Id = DriverId;
                    context.SaveChanges();
                }
            }
        }
    }
}