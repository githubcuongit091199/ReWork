using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Infrastructures
{
    internal class ConfiguationEntities
    {
        public static void ConfigDB(ModelBuilder builder)
        {
            builder.Entity<Product>().Property(x => x.Active).HasDefaultValue(true);
        }
    }
}
