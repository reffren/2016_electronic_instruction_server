using InstructionForServer.Abstract;
using InstructionForServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InstructionForServer.Concrete
{
    public class EFInstructionRepository : IInstructionRepository
    {
        private InstructionDbContext context = new InstructionDbContext();
        public IQueryable<Instruction> Instructions
        {
            get { return context.Instructions; }
        }
    }
}