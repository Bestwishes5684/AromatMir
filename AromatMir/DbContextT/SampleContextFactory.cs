using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AromatMir.DbContextT
{
    internal class SampleContextFactory : IDesignTimeDbContextFactory<TradeContext>
    {
        public TradeContext CreateDbContext(string[] args)
     => new TradeContext(DataBaseHelper.Option());
    }
}
