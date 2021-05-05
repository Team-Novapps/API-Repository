using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Teoguide.Domain.Entity;

namespace Teoguide.Infrastructure.Context
{
    public class TeoguideDbContext : IdentityDbContext
    {
        public TeoguideDbContext(DbContextOptions<TeoguideDbContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
