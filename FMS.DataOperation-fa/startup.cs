using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

[assembly: FunctionsStartup(typeof(FMS.DataOperation_fa.startup))]
namespace FMS.DataOperation_fa
{
    class startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            string SqlConnection = Environment.GetEnvironmentVariable("SqlConnectionString");
            builder.Services.AddDbContext<FMS.DataOperation_fa.Models.FMSDataOperation_faContext>(
                options => options.UseSqlServer(SqlConnection));
        }
    }
}
