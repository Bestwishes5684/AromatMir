using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AromatMir.DbContextT
{
    public class DataBaseHelper
    {
        public static DbContextOptions<TradeContext> Option()
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            var config = builder.Build();
            string connectionString = config.GetConnectionString("DefaultConnection");
            var optionsBuilder = new DbContextOptionsBuilder<TradeContext>();
            return optionsBuilder
                    .UseSqlServer(connectionString)
                    .Options;
        }
    }
}

