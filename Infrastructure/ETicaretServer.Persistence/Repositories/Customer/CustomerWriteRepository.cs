﻿using ETicaretServer.Application.Repositories;
using ETicaretServer.Domain.Entities;
using ETicaretServer.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretServer.Persistence.Repositories
{
    public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(ETicaretServerDbContext context) : base(context)
        {
        }
    }
}
