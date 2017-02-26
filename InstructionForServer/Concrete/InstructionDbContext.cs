using InstructionForServer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace InstructionForServer.Concrete
{
    public class InstructionDbContext : DbContext
    {
        public DbSet<Instruction> Instructions { get; set; }
    }
}