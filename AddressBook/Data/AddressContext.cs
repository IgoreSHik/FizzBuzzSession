using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AddressBook.Models;
using Microsoft.EntityFrameworkCore;

namespace AddressBook.Data
{
    public class AddressContext : DbContext
    {
            public DbSet<Address> Address { get; set; }
    }
}
