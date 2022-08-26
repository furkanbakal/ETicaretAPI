﻿using ETicaretServer.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretServer.Persistence.Contexts
{
    public class ETicaretServerDbContext : DbContext
    {
        public ETicaretServerDbContext(DbContextOptions options) : base(options)
        {}
        public DbSet<Product>  Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
