using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaTecnica.Data
{
    public class AppDBContext : DbContext
    {        
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {            

        }
    }
}
