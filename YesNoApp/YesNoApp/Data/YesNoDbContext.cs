using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YesNoApp.Models;

namespace YesNoApp.Data
{
    public class YesNoDbContext : DbContext
    {
        public YesNoDbContext(DbContextOptions<YesNoDbContext> options) : base(options)
        {
        }


    }
}
