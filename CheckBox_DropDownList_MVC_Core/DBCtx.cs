using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheckBox_DropDownList_MVC_Core.Models;
using Microsoft.EntityFrameworkCore;

namespace CheckBox_DropDownList_MVC_Core
{
    public class DBCtx : DbContext
    {
        public DBCtx(DbContextOptions<DBCtx> options) : base(options)
        {
        }

        public DbSet<FruitModel> Fruits { get; set; }
    }
}
