using InstructionForServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstructionForServer.Abstract
{
   public interface IInstructionRepository
    {
       IQueryable<Instruction> Instructions { get; }
    }
}
