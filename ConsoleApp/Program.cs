using Autofac;
using PS.Domain;
using PS.Manager;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS.Service;
using System.Globalization;

namespace ConsoleApp
{
    class Program
    {
        private static IContainer container { get; set; }
        static void Main(string[] args)
        {
            container = ConfigureContainer();
            var revinueService = container.Resolve<IRevenueService>();

            DateTime reference = DateTime.Now;
            Calendar calendar = CultureInfo.CurrentCulture.Calendar;

            IEnumerable<int> daysInMonth = Enumerable.Range(1, DateTime.Now.Day);

            var a = daysInMonth.Select(day => new DateTime(reference.Year, reference.Month, day));
            var b = a.GroupBy(d => calendar.GetWeekOfYear(d, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday));
            //var hd = b.Where(x => x.DayOfWeek == DayOfWeek.Sunday);
            //var c = b.Except();
            /*List<Tuple<DateTime, DateTime>> weeks = daysInMonth.Select(day => new DateTime(reference.Year, reference.Month, day))
                .GroupBy(d => calendar.GetWeekOfYear(d, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday))
                .Select(g => new Tuple<DateTime, DateTime>(g.First(), g.Last()))
                .ToList();*/

            var weeks = daysInMonth.Select(day => new DateTime(reference.Year, reference.Month, day))
                .GroupBy(d => calendar.GetWeekOfYear(d, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday))
                .Select(g => new
                {
                    g.First()
                })
                .ToList();

            //weeks.ForEach(x => Console.WriteLine("{0:MM/dd/yyyy} - {1:MM/dd/yyyy}", x.Item1, x.Item2));

            //var allUser = revinueService.GetRevinueBetween(DateTime.Now, DateTime.Now.AddDays(5));

            Console.ReadKey();
        }

        private static IContainer ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<UserRepository>().As<IUserRepository>();
            builder.RegisterType<PetRepository>().As<IPetRepository>();
            builder.RegisterType<TransRepository>().As<ITransRepository>();

            builder.RegisterType<UserManager>().As<IUserManager>();
            builder.RegisterType<PetManager>().As<IPetManager>();
            builder.RegisterType<TransManager>().As<ITransManager>();

            builder.RegisterType<RevenueService>().As<IRevenueService>();
            // Register all dependencies (and dependencies of those dependencies, etc)

            return builder.Build();
        }
    }
}
