#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApiCRUDSwagger.Models;

public partial class DataBaseFirstEfContext : DbContext
{
    public DataBaseFirstEfContext(DbContextOptions<DataBaseFirstEfContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Dbfirstapprtbl> Dbfirstapprtbls { get; set; }
    public DbSet<ServerList> ServerLists { get; set; }
     public DbSet<ApplicationList> ApplicationLists { get; set; }
}
