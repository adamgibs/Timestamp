using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timestamp.Models;

namespace Timestamp.Data
{
    public class TimestampContext : DbContext
    {
        public TimestampContext(DbContextOptions<TimestampContext> options) : base(options)
        {

        }

        public DbSet<Models.Timestamp> Timestamps { get; set; }
    }
}
