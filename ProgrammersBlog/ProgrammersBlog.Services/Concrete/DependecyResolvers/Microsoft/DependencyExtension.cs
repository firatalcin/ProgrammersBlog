using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProgrammersBlog.Data.Concrete.EntityFramework.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Services.Concrete.DependecyResolvers.Microsoft
{
    public static class DependencyExtension
    {
        public static void AddDependency(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseSqlServer("server=MAKINA\\SQLEXPRESS01; database= ProgrammersBlogDb; integrated security=true;");
            });
        }
    }
}
